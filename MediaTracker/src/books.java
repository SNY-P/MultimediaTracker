import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

public class books {
    dbConnection dbc = new dbConnection();
    // view the table
    public void booksSelect(int uID) throws SQLException {
        Scanner scanner = new Scanner(System.in);

        while(true) {
            System.out.println("1. Non-Translated Novels | 2. Translated Novels");
            System.out.print("Choice: ");
            int choice = scanner.nextInt();
            scanner.nextLine();

            if (choice == 1) {
                // select db for non translated novels
                // To Select: id, name, status, format, country, source, chapters
    
                String query = "SELECT b.booksID, b.Name, b.Status, b.Format, b.Source, b.Chapters, c.Name as Country " + 
                               "FROM Books b LEFT JOIN Country c ON b.countryID = c.countryID WHERE userID = ?";
    
                try (Connection conn = dbConnection.connect();
                     PreparedStatement ps = conn.prepareStatement(query)) {
                    ps.setInt(1, uID);
    
                    try (ResultSet rs = ps.executeQuery()) {
                        int[] lengths = bEntryLength(uID, conn);
                        System.out.printf("%-" + lengths[0] + "s%-" + lengths[1] + "s%-" + lengths[2] + "s%-" + lengths[3] + "s%-" + lengths[7] + "s%-" + lengths[5] + "s\n",
                                  "Books ID", "Name", "Status", "Format", "Country", "Source", "Chapters Read");
    
                        while (rs.next()) {
                            int id = rs.getInt("booksID");
                            String name = rs.getString("Name");
                            String status = rs.getString("Status");
                            String format = rs.getString("Format");
                            int chaptersRead = rs.getInt("Chapters");
                            String country = rs.getString("Country");
                            String source = rs.getString("Source");
                            System.out.printf("%-" + lengths[0] + "s%-" + lengths[1] + "s%-" + lengths[2] + "s%-" + lengths[3] + "s%-" + lengths[7] + "s%-" + lengths[5] + "s\n",
                                              id, name, status, format, country, source, chaptersRead);
                        }
                    } 
                }
                catch (SQLException e) {
                    System.out.println(e.getMessage());
                }
                scanner.close();
                return;
            }
            else {
                // select db for translated novels
                // To Select: id, name, status, format, country, originalname, source, chapters
                String query = "SELECT b.booksID, b.Name, b.Status, b.Format, b.OriginalName, b.Source, b.Chapters, c.Name as Country " + 
                               "FROM Books b LEFT JOIN Country c ON b.countryID = c.countryID WHERE userID = ?";
    
                try (Connection conn = dbConnection.connect();
                PreparedStatement ps = conn.prepareStatement(query)) {
                ps.setInt(1, uID);
    
                    try (ResultSet rs = ps.executeQuery()) {
                        int[] lengths = bEntryLength(uID, conn);
                        System.out.printf("%-" + lengths[0] + "s%-" + lengths[1] + "s%-" + lengths[2] + "s%-" + lengths[3] + "s%-" + lengths[7] + "s%-" + lengths[4] + "s%-" + lengths[5] + "s\n",
                                  "Books ID", "Name", "Status", "Format", "Country", "COO Name", "Source", "Chapters Read");
    
                        while (rs.next()) {
                            int id = rs.getInt("booksID");
                            String name = rs.getString("Name");
                            String status = rs.getString("Status");
                            String format = rs.getString("Format");
                            String cooName = rs.getString("OriginalName");
                            int chaptersRead = rs.getInt("Chapters");
                            String country = rs.getString("Country");
                            String source = rs.getString("Source");
                            System.out.printf("%-" + lengths[0] + "s%-" + lengths[1] + "s%-" + lengths[2] + "s%-" + lengths[3] + "s%-" + lengths[7] + "s%-" +  lengths[4] + "s%-" + lengths[5] + "s\n",
                                              id, name, status, format, country, cooName, source, chaptersRead);
                        }
                    } 
                }
                catch (SQLException e) {
                    System.out.println(e.getMessage());
                }
                scanner.close();
                return;
            }
        }
    }
    // used to evenly space out the table
    private int[] bEntryLength(int uID, Connection conn) throws SQLException {
        String query = "SELECT b.booksID, b.Name, b.Status, b.Format, b.OriginalName, b.Source, b.Chapters, c.Name as Country " +
                       "FROM Books b " + 
                       "LEFT JOIN Country c ON b.countryID = c.countryID " +
                       "WHERE userID = ?";

        int[] columnLengths = new int[8];

        try (PreparedStatement pstmt = conn.prepareStatement(query)) {
            pstmt.setInt(1, uID);
            try (ResultSet rst = pstmt.executeQuery()) {
                int maxBooksIdLength = 0;
                int maxNameLength = 0;
                int maxStatusLength = 0;
                int maxFormatLength = 0;
                int maxOriginalNameLength = 0;
                int maxSourceLength = 0;
                int maxChaptersReadLength = 0;
                int maxCountryLength = 0;

                while (rst.next()) {
                    maxBooksIdLength = Math.max(maxBooksIdLength, String.valueOf(rst.getInt("booksID")).length());
                    maxNameLength = Math.max(maxNameLength, rst.getString("Name").length());
                    maxStatusLength = Math.max(maxStatusLength, rst.getString("Status").length());
                    maxFormatLength = Math.max(maxFormatLength, rst.getString("Format").length());
                    maxOriginalNameLength = Math.max(maxOriginalNameLength, rst.getString("OriginalName").length());
                    maxSourceLength = Math.max(maxSourceLength, rst.getString("Source").length());
                    maxChaptersReadLength = Math.max(maxChaptersReadLength, String.valueOf(rst.getInt("Chapters")).length());
                    maxCountryLength = Math.max(maxCountryLength, String.valueOf(rst.getInt("Country")).length());
                }

                columnLengths[0] = maxBooksIdLength + 10;
                columnLengths[1] = maxNameLength + 10;
                columnLengths[2] = maxStatusLength + 10;
                columnLengths[3] = maxFormatLength + 10;
                columnLengths[4] = maxOriginalNameLength + 10;
                columnLengths[5] = maxSourceLength + 10;
                columnLengths[6] = maxChaptersReadLength + 10;
                columnLengths[7] = maxCountryLength + 10;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return columnLengths;
    }
    // add entry to table
    public void bookAdd(String name, String status, String format, int ch, int uID) {
        String statement = "INSERT INTO Books (Name, Status, Format, Chapters, userID) VALUES (?,?,?,?,?)";

        try (Connection conn = dbConnection.connect();
                PreparedStatement pstmt = conn.prepareStatement(statement)) {
            pstmt.setString(1, name);
            pstmt.setString(2, status);
            pstmt.setString(3, format);
            pstmt.setInt(4, ch);
            pstmt.setInt(5, uID);
            pstmt.executeUpdate();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }
    // edit and existing entry [String]
    public void bookEdit(int id, String newData, int choice) {
        String statement = "";
        // decides what needs to be edited
        if (choice == 1) {
            statement = "UPDATE Books SET Name = ? WHERE booksID = ?";
        }
        else if (choice == 2) {
            statement = "UPDATE Books SET Status = ? WHERE booksID = ?";
        }
        else if (choice == 3) {
            statement = "UPDATE Books SET Format = ? WHERE booksID = ?";
        }

        try (Connection conn = dbConnection.connect();
                PreparedStatement pstmt = conn.prepareStatement(statement)) {
            pstmt.setString(1, newData);
            pstmt.setInt(2, id);
            pstmt.executeUpdate();
        } catch (SQLException e) {
            System.err.println(e.getMessage());
        }
    }
    // edit and existing entry [int]
    public void bookEdit(int id, int newData) {
        String statement = "UPDATE Books SET Chapters = ? WHERE booksID = ?";

        try (Connection conn = dbConnection.connect();
                PreparedStatement pstmt = conn.prepareStatement(statement)) {
            pstmt.setInt(1, newData);
            pstmt.setInt(2, id);
            pstmt.executeUpdate();
        } catch (SQLException e) {
            System.err.println(e.getMessage());
        }
    }
    // delete and entry from table
    public void bookDelete(int id) {
        String statement = "DELETE FROM Books WHERE booksID = ?";

        try (Connection conn = dbConnection.connect();
                PreparedStatement pstmt = conn.prepareStatement(statement);) {
            pstmt.setInt(1, id);
            pstmt.executeUpdate();
        } catch (SQLException e) {
            System.err.println(e.getMessage());
        }
    }

    public boolean checkEntry (int id) {
        boolean entryExists = false;

        String statement = "SELECT * FROM Books WHERE booksID = ?";

        try (Connection conn = dbConnection.connect();
                PreparedStatement pstmt = conn.prepareStatement(statement);) {
            pstmt.setInt(1, id);
            pstmt.executeUpdate();
            entryExists = true;
            return entryExists;
        } catch (SQLException e) {
            System.err.println(e.getMessage());
            return entryExists;
        }        
    }

    public int selectCountryId(String name) {
        int cID = 0;

        String query = "SELECT countryID FROM Country WHERE Name = ?";

        try (Connection conn = dbConnection.connect();
                PreparedStatement pstmt = conn.prepareStatement(query);) {
            pstmt.setString(1, name);
            try (ResultSet rs = pstmt.executeQuery()) {
                if (rs.next()) {
                    cID = rs.getInt("countryID");
                }
            }
        } catch (SQLException e) {
            System.err.println(e.getMessage());
        }

        return cID;
    }
}
