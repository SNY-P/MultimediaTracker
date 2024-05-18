import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class books {
    dbConnection dbc = new dbConnection();
    // view the table
    public void booksSelect(int uID) throws SQLException {
        String query = "SELECT booksID, Name, Status, Format, Chapters FROM Books WHERE userID = ?";
        
        try (Connection conn = dbConnection.connect();
             PreparedStatement pstmt = conn.prepareStatement(query)) {
             
            pstmt.setInt(1, uID);
            try (ResultSet rst = pstmt.executeQuery()) {
                int[] lengths = bEntryLength(uID, conn);
                System.out.printf("%-" + lengths[0] + "s%-" + lengths[1] + "s%-" + lengths[2] + "s%-" + lengths[3] + "s%-" + lengths[4] + "s\n",
                                  "Books ID", "Name", "Status", "Format", "Chapters Read");

                while (rst.next()) {
                    int id = rst.getInt("booksID");
                    String name = rst.getString("Name");
                    String status = rst.getString("Status");
                    String format = rst.getString("Format");
                    int chaptersRead = rst.getInt("Chapters");
                    System.out.printf("%-" + lengths[0] + "d%-" + lengths[1] + "s%-" + lengths[2] + "s%-" + lengths[3] + "s%-" + lengths[4] + "d\n",
                                      id, name, status, format, chaptersRead);
                }
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
    // used to evenly space out the table
    private int[] bEntryLength(int uID, Connection conn) throws SQLException {
        String query = "SELECT booksID, Name, Status, Format, Chapters FROM Books WHERE userID = ?";
        int[] columnLengths = new int[5];

        try (PreparedStatement pstmt = conn.prepareStatement(query)) {
            pstmt.setInt(1, uID);
            try (ResultSet rst = pstmt.executeQuery()) {
                int maxBooksIdLength = 0;
                int maxNameLength = 0;
                int maxStatusLength = 0;
                int maxFormatLength = 0;
                int maxChaptersReadLength = 0;

                while (rst.next()) {
                    maxBooksIdLength = Math.max(maxBooksIdLength, String.valueOf(rst.getInt("booksID")).length());
                    maxNameLength = Math.max(maxNameLength, rst.getString("Name").length());
                    maxStatusLength = Math.max(maxStatusLength, rst.getString("Status").length());
                    maxFormatLength = Math.max(maxFormatLength, rst.getString("Format").length());
                    maxChaptersReadLength = Math.max(maxChaptersReadLength, String.valueOf(rst.getInt("Chapters")).length());
                }

                columnLengths[0] = maxBooksIdLength + 10;
                columnLengths[1] = maxNameLength + 10;
                columnLengths[2] = maxStatusLength + 10;
                columnLengths[3] = maxFormatLength + 10;
                columnLengths[4] = maxChaptersReadLength + 10;
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
}
