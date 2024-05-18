import java.sql.SQLException;
import java.util.Scanner;
// TO DO: Movies, TV Shows, Anime, Webtoons, Comics
// Curently Working: Novels
public class App {
    public static Scanner scanner = new Scanner(System.in);
    public static dbConnection dbc = new dbConnection();
    public static books bks = new books();

    public static void main(String[] args) throws Exception {
        dbConnection.connect();
        userNavigation();
    }

    public static void userNavigation() throws SQLException {
        System.out.print("Please Choose:\n1. Login | 2. Register | 0. Exit Application\nEnter Choice: ");
        int choice = scanner.nextInt();
        scanner.nextLine();
        int uID = 0;

        if (choice == 0) {
            System.exit(0);
        }
        else if (choice == 1) { 
            uID = login();
            categoryNavigation(uID);
        } 
        else if (choice == 2) { 
            register(); 
        }   
        else { 
            System.out.println("Please choose a valid option!\n");
            userNavigation();
        }

        scanner.close();
    }

    public static int login() {
        for (int i = 1; i <= 6; i++) {
            System.out.print("Sign In\n------------------\nUsername: ");
            String username = scanner.nextLine();
            System.out.print("Password: ");
            String password = scanner.nextLine();

            if (dbc.checkDetails(username, password)) {
                System.out.println("Success\n");
                return dbConnection.getUserID(username);
            } else {
                System.out.println("Wrong Username and/or Password. Please Try Again.\n");
            }
        }
        System.out.println("Too many tries.");
        System.exit(0);
        return 0; // unreachable, but required for compilation
    }

    public static void register() {
        System.out.print("Register\n------------------\nUsername: ");
        String username = scanner.nextLine();
        System.out.print("Password: ");
        String password = scanner.nextLine();

        if (username.isEmpty() || password.isEmpty()) {
            System.out.println("Please enter a username and/or password\n");
            register();
        }
        else {
            if (dbc.checkUsername(username) == true) {
                System.out.println("Username already exists\n");
                register();
            } 
            else {
                dbc.loginAdd(username, password);
                System.out.println("Account successfully registers\n");
                login();
            }
        }
    }

    public static void categoryNavigation(int uID) throws SQLException {
        while (true) {
            System.out.println("Categories\n1. Movies | 2. TV | 3. Anime | 4. Books | 5. Comics | 0. Logout");
            System.out.print("Enter the Category Number: ");
            int categoryChoice = scanner.nextInt();
            scanner.nextLine();

            switch (categoryChoice) {
                case 0:
                    System.out.println("You have successfully logged out");
                    userNavigation();
                case 1:
                    System.out.println("Movies");
                    break;
                case 2:
                    System.out.println("TV Shows");
                    break;
                case 3:
                    System.out.println("Anime");
                    break;
                case 4:
                    booksNavigation(uID);
                    return; // exit loop
                case 5:
                    System.out.println("Comics");
                    break;
                default:
                    System.out.println("Invalid category choice. Please choose a valid category.");
            }
        }
    }
    
    public static void booksNavigation(int uID) throws SQLException {
        while (true) {
            System.out.println("Books & Novels");
            System.out.println("1. Display Table | 2. Add Entry | 3. Edit Entry | 4. Delete Entry | 5. Exit to Categories");
            System.out.print("Enter Choice: ");
            int bChoice = scanner.nextInt();
            scanner.nextLine();

            switch (bChoice) {
                case 1:
                    bks.booksSelect(uID);
                    break;
                case 2:
                    bookAdd(uID);
                    break;
                case 3:
                    bookEntryChange(uID);
                    break;
                case 4:
                    bookDeletion(uID);
                    break;
                case 5:
                    categoryNavigation(uID);
                    return; // exit loop
                default:
                    System.out.println("You did not pick a valid option. Try Again.");
            }
        }
    }

    public static void bookAdd(int uID) throws SQLException{
        while (true) {
            System.out.print("Name of Book: ");
            String name = scanner.nextLine();
            System.out.print("Reading Status: ");
            String status = scanner.nextLine();
            System.out.print("Reading Format: ");
            String format = scanner.nextLine();

            if (format.equalsIgnoreCase("Online")) {
                System.out.print("Online Source: ");
                String source = scanner.nextLine();
            }

            System.out.print("Translated? Y/N: ");
            String translated = scanner.nextLine();

            if (translated.equalsIgnoreCase("Y") || translated.equalsIgnoreCase("Yes")) {
                System.out.print("Country of Origin: ");
                String country = scanner.nextLine();
            }

            System.out.print("Chapters Read: ");
            int chapters = scanner.nextInt();
            scanner.nextLine();
            
            if (name.isEmpty() || status.isEmpty() || format.isEmpty()) {
                System.out.println("One or more entries is missing. Try Again");
            } else {
                bks.bookAdd(name, status, format, chapters, uID);
                System.out.println("Book Added\n");
                bks.booksSelect(uID);
            }

            System.out.print("Do you wish to add another entry? Y/N:  ");
            String entryCho = scanner.nextLine();
            if (!entryCho.equalsIgnoreCase("Y") && !entryCho.equalsIgnoreCase("Yes")) {
                booksNavigation(uID);
                return; // exit loop
            }
        }
    }

    public static void bookEntryChange(int uID) throws SQLException {
        bks.booksSelect(uID);
        System.out.print("Choose the Books ID for the entry you wish to change: ");
        int bID = scanner.nextInt();
        scanner.nextLine();
        if (!bks.checkEntry(uID)) {
            System.out.println("Entry doesn't exist.");
            return;
        }

        bookNewDetails(bID);
        bks.booksSelect(uID);

        System.out.print("Do you wish to change another entry? Y/N:  ");
        String entryCho = scanner.nextLine();
        if (entryCho.equalsIgnoreCase("Y") || entryCho.equalsIgnoreCase("Yes")) {
            bookEntryChange(uID);
        } else {
            booksNavigation(uID);
        }
    }

    public static void bookNewDetails(int bID) throws SQLException {
        String[][] prompts = {
            {"Edit Name? Y/N: ", "New Name: "},
            {"Edit Status? Y/N: ", "New Status: "},
            {"Edit Format? Y/N: ", "New Format: "},
            {"Edit Chapters? Y/N: ", "Chapter Read: "}
        };

        for (int i = 0; i < prompts.length; i++) {
            System.out.print(prompts[i][0]);
            String choice = scanner.nextLine();
            if (choice.equalsIgnoreCase("Y") || choice.equalsIgnoreCase("Yes")) {
                System.out.print(prompts[i][1]);
                if (i < 3) {
                    String value = scanner.nextLine();
                    bks.bookEdit(bID, value, i + 1);
                } else {
                    int chapters = scanner.nextInt();
                    scanner.nextLine();
                    bks.bookEdit(bID, chapters);
                }
            }
        }
    }

    public static void bookDeletion(int uID) throws SQLException {
        bks.booksSelect(uID);
        System.out.print("Select Books ID for row deletion: ");
        int delID = scanner.nextInt();
        scanner.nextLine();
        if (bks.checkEntry(uID) == true) { 
            bks.bookDelete(delID); 
        }
        else {
            System.out.println("Entry doesn't exist. Try Again.");
            bookDeletion(uID);
        }

        System.out.print("Do you wish to delete another entry? Y/N: ");
        String delChoice = scanner.nextLine();
        if (delChoice.equalsIgnoreCase("Y") || delChoice.equalsIgnoreCase("Yes")) {
            bookDeletion(uID);
        }
        else if (delChoice.equalsIgnoreCase("N") || delChoice.equalsIgnoreCase("No")) {
            booksNavigation(uID);
        }
    }
}
