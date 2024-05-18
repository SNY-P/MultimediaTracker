import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class dbConnection {
    // public static final String url = "jdbc:sqlite:D:/Main/Projects/cmdMediaTracker/MediaTracker/src/mediaTracker.db";

    public static Connection connect() throws SQLException {
        String url = "jdbc:sqlite:D:/Main/Projects/cmdMediaTracker/MediaTracker/src/mediaTracker.db";
        Connection conn = null;
        try {
            conn = DriverManager.getConnection(url);
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
        return conn;
    }

    public static void close(Connection connection) {
        if (connection != null) {
            try {
                connection.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }

    public void loginAdd(String username, String password) {
        String statement = "INSERT INTO UserInfo (Username, Password) VALUES (?,?)";

        try (Connection conn = connect();
             PreparedStatement pstmt = conn.prepareStatement(statement)) {
            pstmt.setString(1, username);
            pstmt.setString(2, password);
            pstmt.executeUpdate();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

    public boolean checkUsername(String username) {
        boolean usernameExists = false;

        String query = "SELECT * FROM UserInfo WHERE Username = ?";

        try (Connection conn = connect();
            PreparedStatement pstmt = conn.prepareStatement(query)) {
            pstmt.setString(1, username);
            try (ResultSet rs = pstmt.executeQuery()) {
                if (rs.next()) {
                    usernameExists = true;
                }
            }
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }

        return usernameExists;
    }

    public boolean checkPassword(String password) {
        boolean passwordExists = false;

        String query = "SELECT * FROM UserInfo WHERE Password = ?";

        try (Connection conn = connect();
            PreparedStatement pstmt = conn.prepareStatement(query)) {
            pstmt.setString(1, password);
            try (ResultSet rs = pstmt.executeQuery()) {
                if (rs.next()) {
                    passwordExists = true;
                }
            }
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
        
        return passwordExists;
    }

    public boolean checkDetails(String username, String password) {
        boolean correctDetails = false;

        String query = "SELECT * FROM UserInfo Where Username = ? AND Password = ?";

        try (Connection conn = connect();
            PreparedStatement pstmt = conn.prepareStatement(query)) {
            pstmt.setString(1, username);
            pstmt.setString(2, password);
            try (ResultSet rs = pstmt.executeQuery()) {
                if (rs.next()) {
                    correctDetails = true;
                }
            }
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }

        return correctDetails;
    }
    
    public static int getUserID(String username) {
        String query = "SELECT userID FROM UserInfo WHERE Username = ?";
        int uID = 0;

        try (Connection conn = connect();
                PreparedStatement pstmt = conn.prepareStatement(query);) {
            pstmt.setString(1, username);
            try (ResultSet rs = pstmt.executeQuery()) {
                if (rs.next()) {
                    uID = rs.getInt(1);
                }
            }
        }
        catch (SQLException e) {
            e.printStackTrace();
        }

        return uID;
    }
}
