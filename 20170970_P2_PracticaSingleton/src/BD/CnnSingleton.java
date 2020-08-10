package BD;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import javax.swing.JOptionPane;

public class CnnSingleton {

    private static Connection Cnn = null;
    private String driver;
    private String URL;
    private String USUARIO;
    private String PASSWORD;

    private CnnSingleton() {
        driver = "com.mysql.jdbc.Driver";
        URL = "jdbc:mysql://localhost:3306/dbAlumnos?autoReconnect=true&useSSL=false";
        USUARIO = "root";
        PASSWORD = "";

        try {
            Class.forName(driver);
            Cnn = DriverManager.getConnection(URL, USUARIO, PASSWORD);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, e);
        }
    }

    public static Connection getConnection() {
        if (Cnn == null) {
            new CnnSingleton();
        }
        return Cnn;
    }

    public static void LogOut() throws SQLException {
        Cnn.close();
    }
}
