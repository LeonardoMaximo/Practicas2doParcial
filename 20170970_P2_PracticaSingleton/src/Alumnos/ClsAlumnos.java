package Alumnos;

import BD.CnnSingleton;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.JComboBox;
import javax.swing.JOptionPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

public class ClsAlumnos {

    private Connection Cnn;

    public ClsAlumnos() {
        Cnn = CnnSingleton.getConnection();
    }

    //Consulta a la tabla Alumnos
    public ResultSet getSelectAlumno() {
        ResultSet rs = null;
        try {
            Statement stm = Cnn.createStatement();
            rs = stm.executeQuery("SELECT intIDAlumno,vchName,vchAP,vchAM,intMatricula,vchGrupo FROM tblalumnos JOIN tblgrupo ON tblalumnos.intIDGrupo=tblgrupo.intIDGrupo");
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error En Consulta", "Error De Servidor", JOptionPane.ERROR_MESSAGE);
        }
        return rs;
    }

    //Consulta a la tabla Alumnos
    public ResultSet getSelectGrupo(int intIDGrupo) {
        ResultSet rs = null;
        try {
            Statement stm = Cnn.createStatement();
            rs = stm.executeQuery("SELECT vchGrupo FROM tblGrupo WHERE intIDGrupo = intIDGrupo");
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error En Consulta", "Error De Servidor", JOptionPane.ERROR_MESSAGE);
        }
        return rs;
    }

    //Inserta en la tabla Alumnos 
    public int InsertarAlumno(int intIDAlumno, String vchName, String vchAP, String vchAM, int intMatricula, int intIDGrupo) {
        int r = 0;
        String Ins = "INSERT INTO tblAlumnos values (" + intIDAlumno + ",'" + vchName + "','" + vchAP + "','" + vchAM + "','" + intMatricula + "','" + intIDGrupo + "')";
        try {
            Statement stm = (Statement) Cnn.createStatement();
            r = stm.executeUpdate(Ins);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "No agregado", "Error De Servidor", JOptionPane.ERROR_MESSAGE);
        } finally {
            return r;
        }
    }

    //Eliminar en la tabla Alumnos
    public int EliminarAlumno(String intIDAlumno) {
        int r = 0;
        String Del = "DELETE FROM tblAlumnos where intIDAlumno = " + intIDAlumno;
        try {
            Statement stm = (Statement) Cnn.createStatement();
            r = stm.executeUpdate(Del);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "No Eliminado", "Error De Servidor", JOptionPane.ERROR_MESSAGE);
        } finally {
            return r;
        }
    }

    //Edita datos de la tabla Alumnos
    public int EditarAlumno(int intIDAlumno, String vchName, String vchAP, String vchAM, int intMatricula, int intIDGrupo) {
        int r = 0;
        String Upd = "UPDATE tblAlumnos SET intIDAlumno= '" + intIDAlumno + "', vchName='" + vchName
                + "', vchAP='" + vchAP + "', vchAM='" + vchAM + "', intMatricula='" + intMatricula + "', intIDGrupo='" + intIDGrupo
                + "' WHERE intIDAlumno = " + intIDAlumno;
        try {
            Statement stm = Cnn.createStatement();
            r = stm.executeUpdate(Upd);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "No Modificado", "Error De Servidor", JOptionPane.ERROR_MESSAGE);
        } finally {
            return r;
        }
    }

    public void LlenaGridAlumno(JTable Tabla) {
        try {
            DefaultTableModel modelo = (DefaultTableModel) Tabla.getModel();
            while (modelo.getRowCount() > 0) {
                modelo.removeRow(0);
            }
            ResultSet rs = getSelectAlumno();
            while (rs.next()) {
                String intIDAlumno = rs.getString("intIDAlumno");
                String vchName = rs.getString("vchName");
                String vchAP = rs.getString("vchAP");
                String vchAM = rs.getString("vchAM");
                String intMatricula = rs.getString("intMatricula");
                String vchGrupo = rs.getString("vchGrupo");
                modelo.addRow(new Object[]{intIDAlumno, vchName, vchAP, vchAM, intMatricula, vchGrupo});
            }
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Imposible Cargar Datos", "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    public void CmbGrupo(JComboBox combo) {
        ResultSet rs = null;
        String ConsultaGrupo = "SELECT * FROM tblGrupo";

        try {
            Statement stm;
            stm = (Statement) Cnn.createStatement();
            rs = stm.executeQuery(ConsultaGrupo);
            while (rs.next()) {
                String vchGrupo = rs.getString("vchGrupo");
                combo.addItem(vchGrupo);
            }
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Imposible Cargar Datos", "Error", JOptionPane.ERROR_MESSAGE);
        }
    }
}
