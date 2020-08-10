package Alumnos;

import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;

public class FrmAlumnos extends javax.swing.JFrame {

    ClsAlumnos Alumnos = new ClsAlumnos();

    public FrmAlumnos() {
        initComponents();
        Alumnos.LlenaGridAlumno(this.tblAlumnos);//Se carga el Grid
        Alumnos.CmbGrupo(this.cmbGrupos);//Se carga el combo con los grupos desde otra table de la bd
        LimitarCaracteres(txtName, 19);
        LimitarCaracteres(txtAP, 19);
        LimitarCaracteres(txtAM, 19);
        LimitarCaracteres(txtMatricula, 8);

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        tblAlumnos = new javax.swing.JTable();
        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        btnInsert = new javax.swing.JButton();
        btnDel = new javax.swing.JButton();
        btnUpd = new javax.swing.JButton();
        txtAM = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        txtMatricula = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        txtAP = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        txtName = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        cmbGrupos = new javax.swing.JComboBox<>();
        lblID = new javax.swing.JLabel();
        btnVoid = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        tblAlumnos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null, null, null},
                {null, null, null, null, null, null},
                {null, null, null, null, null, null},
                {null, null, null, null, null, null}
            },
            new String [] {
                "ID", "Nombre", "Apellido P.", "Apellido M.", "Matrícula", "Grupo"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, false, false, false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        tblAlumnos.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblAlumnosMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(tblAlumnos);
        if (tblAlumnos.getColumnModel().getColumnCount() > 0) {
            tblAlumnos.getColumnModel().getColumn(2).setResizable(false);
            tblAlumnos.getColumnModel().getColumn(4).setResizable(false);
        }

        jPanel1.setLayout(null);

        jLabel1.setFont(new java.awt.Font("Dialog", 3, 18)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 255, 255));
        jLabel1.setText("Grupo:");
        jPanel1.add(jLabel1);
        jLabel1.setBounds(10, 350, 60, 24);

        btnInsert.setBackground(new java.awt.Color(255, 255, 255));
        btnInsert.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        btnInsert.setForeground(new java.awt.Color(51, 51, 51));
        btnInsert.setText("Insertar");
        btnInsert.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnInsertActionPerformed(evt);
            }
        });
        jPanel1.add(btnInsert);
        btnInsert.setBounds(10, 430, 96, 40);

        btnDel.setBackground(new java.awt.Color(255, 255, 255));
        btnDel.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        btnDel.setForeground(new java.awt.Color(51, 51, 51));
        btnDel.setText("Eliminar");
        btnDel.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDelActionPerformed(evt);
            }
        });
        jPanel1.add(btnDel);
        btnDel.setBounds(120, 430, 101, 40);

        btnUpd.setBackground(new java.awt.Color(255, 255, 255));
        btnUpd.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        btnUpd.setForeground(new java.awt.Color(51, 51, 51));
        btnUpd.setText("Actualizar");
        btnUpd.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnUpdActionPerformed(evt);
            }
        });
        jPanel1.add(btnUpd);
        btnUpd.setBounds(240, 430, 116, 40);

        txtAM.setBackground(new java.awt.Color(255, 255, 255));
        txtAM.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        txtAM.setForeground(new java.awt.Color(0, 0, 0));
        jPanel1.add(txtAM);
        txtAM.setBounds(200, 200, 150, 40);

        jLabel2.setFont(new java.awt.Font("Dialog", 3, 24)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(255, 255, 255));
        jLabel2.setText("ALUMNOS");
        jPanel1.add(jLabel2);
        jLabel2.setBounds(110, 20, 121, 32);

        jLabel3.setFont(new java.awt.Font("Dialog", 3, 18)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(255, 255, 255));
        jLabel3.setText("Nombre:");
        jPanel1.add(jLabel3);
        jLabel3.setBounds(10, 80, 74, 24);

        txtMatricula.setBackground(new java.awt.Color(255, 255, 255));
        txtMatricula.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        txtMatricula.setForeground(new java.awt.Color(0, 0, 0));
        jPanel1.add(txtMatricula);
        txtMatricula.setBounds(90, 290, 190, 40);

        jLabel4.setFont(new java.awt.Font("Dialog", 3, 18)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(255, 255, 255));
        jLabel4.setText("Apellido Materno:");
        jPanel1.add(jLabel4);
        jLabel4.setBounds(190, 170, 152, 24);

        txtAP.setBackground(new java.awt.Color(255, 255, 255));
        txtAP.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        txtAP.setForeground(new java.awt.Color(0, 0, 0));
        jPanel1.add(txtAP);
        txtAP.setBounds(20, 200, 150, 40);

        jLabel5.setFont(new java.awt.Font("Dialog", 3, 18)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(255, 255, 255));
        jLabel5.setText("Apellido Paterno:");
        jPanel1.add(jLabel5);
        jLabel5.setBounds(10, 170, 149, 24);

        txtName.setBackground(new java.awt.Color(255, 255, 255));
        txtName.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        txtName.setForeground(new java.awt.Color(0, 0, 0));
        jPanel1.add(txtName);
        txtName.setBounds(90, 100, 190, 40);

        jLabel6.setFont(new java.awt.Font("Dialog", 3, 18)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(255, 255, 255));
        jLabel6.setText("Matrícula:");
        jPanel1.add(jLabel6);
        jLabel6.setBounds(10, 260, 85, 24);

        cmbGrupos.setBackground(new java.awt.Color(255, 255, 255));
        cmbGrupos.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        cmbGrupos.setForeground(new java.awt.Color(0, 0, 0));
        jPanel1.add(cmbGrupos);
        cmbGrupos.setBounds(110, 370, 90, 40);
        jPanel1.add(lblID);
        lblID.setBounds(150, 60, 0, 0);

        btnVoid.setBackground(new java.awt.Color(255, 255, 255));
        btnVoid.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        btnVoid.setForeground(new java.awt.Color(51, 51, 51));
        btnVoid.setText("Limpiar Cajas");
        btnVoid.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnVoidActionPerformed(evt);
            }
        });
        jPanel1.add(btnVoid);
        btnVoid.setBounds(20, 500, 330, 40);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, 360, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 847, javax.swing.GroupLayout.PREFERRED_SIZE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 701, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    public void LimitarCaracteres(JTextField campo, int cantidad) {
        campo.addKeyListener(new KeyAdapter() {
            public void keyTyped(KeyEvent e) {
                char c = e.getKeyChar();
                int cant = campo.getText().length();
                if (cant >= cantidad) {
                    e.consume();
                }
            }
        });
    }

    //Evento para insertar
    private void btnInsertActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnInsertActionPerformed
        if ("".equals(this.txtName.getText())
                || "".equals(this.txtAP.getText())
                || "".equals(this.txtAM.getText())
                || "".equals(this.txtMatricula.getText())) {
            JOptionPane.showMessageDialog(null, "Introduzca Datos");
        } else {
            int ID = 0;
            Alumnos.InsertarAlumno(ID, txtName.getText(), txtAP.getText(), txtAM.getText(), Integer.parseInt(txtMatricula.getText()), cmbGrupos.getSelectedIndex() + 1);
            Alumnos.LlenaGridAlumno(this.tblAlumnos);
            JOptionPane.showMessageDialog(null, "Se Insertó Correctamente");
            CleanBoxes();
        }
    }//GEN-LAST:event_btnInsertActionPerformed

    //Evento para eliminar
    private void btnDelActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDelActionPerformed
        int Fila = this.tblAlumnos.getSelectedRow();
        if (Fila == -1) {
            JOptionPane.showMessageDialog(null, "Seleccione Una Fila");
        } else {
            DefaultTableModel tblMode = (DefaultTableModel) this.tblAlumnos.getModel();
            String Clave = tblMode.getValueAt(Fila, 0).toString();
            int Del;
            int Confirmacion = JOptionPane.showConfirmDialog(null, "¿Desea eliminar los datos seleccionados?", "Confirmar salida", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
            if (Confirmacion == 0) {
                Del = Alumnos.EliminarAlumno(Clave);
                if (Del != 0) {
                    JOptionPane.showMessageDialog(null, "El Registro se eliminó correctamente");
                    Alumnos.LlenaGridAlumno(tblAlumnos);
                    CleanBoxes();
                } else {
                    JOptionPane.showMessageDialog(null, "Error al Eliminar el Registro");
                }
            }

        }
    }//GEN-LAST:event_btnDelActionPerformed

    //Evento para actualizar
    private void btnUpdActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnUpdActionPerformed
        int Fila = this.tblAlumnos.getSelectedRow();
        if (Fila == -1) {
            JOptionPane.showMessageDialog(null, "Seleccione Una Fila");
        } else {
            if ("".equals(this.txtName.getText())
                    || "".equals(this.txtAP.getText())
                    || "".equals(this.txtAM.getText())
                    || "".equals(this.txtMatricula.getText())) {
                JOptionPane.showMessageDialog(null, "Introduzca Datos");
            } else {
                Alumnos.EditarAlumno(Integer.parseInt(lblID.getText()), txtName.getText(), txtAP.getText(), txtAM.getText(), Integer.parseInt(txtMatricula.getText()), cmbGrupos.getSelectedIndex() + 1);
                Alumnos.LlenaGridAlumno(this.tblAlumnos);
                JOptionPane.showMessageDialog(null, "Se Actualizó Correctamente");
                CleanBoxes();
            }
        }
    }//GEN-LAST:event_btnUpdActionPerformed

    //Envia los datos a las cajas de texto de acuerdo a la fila seleccionada
    private void tblAlumnosMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblAlumnosMouseClicked
        int Fila = this.tblAlumnos.getSelectedRow();
        lblID.setText(this.tblAlumnos.getValueAt(Fila, 0).toString());
        txtName.setText(this.tblAlumnos.getValueAt(Fila, 1).toString());
        txtAP.setText(this.tblAlumnos.getValueAt(Fila, 2).toString());
        txtAM.setText(this.tblAlumnos.getValueAt(Fila, 3).toString());
        txtMatricula.setText(this.tblAlumnos.getValueAt(Fila, 4).toString());
    }//GEN-LAST:event_tblAlumnosMouseClicked

    private void btnVoidActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnVoidActionPerformed
        CleanBoxes();
    }//GEN-LAST:event_btnVoidActionPerformed

    //Limpia las cajas de texto
    private void CleanBoxes() {
        this.lblID.setText("");
        this.txtName.setText("");
        this.txtAP.setText("");
        this.txtAM.setText("");
        this.txtMatricula.setText("");
    }

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(FrmAlumnos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FrmAlumnos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FrmAlumnos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FrmAlumnos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrmAlumnos().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnDel;
    private javax.swing.JButton btnInsert;
    private javax.swing.JButton btnUpd;
    private javax.swing.JButton btnVoid;
    private javax.swing.JComboBox<String> cmbGrupos;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblID;
    private javax.swing.JTable tblAlumnos;
    private javax.swing.JTextField txtAM;
    private javax.swing.JTextField txtAP;
    private javax.swing.JTextField txtMatricula;
    private javax.swing.JTextField txtName;
    // End of variables declaration//GEN-END:variables
}
