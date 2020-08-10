namespace MVC.Vista
{
    partial class V_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOperacion = new System.Windows.Forms.ComboBox();
            this.cbxFigura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(104, 293);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 17);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "Resultado";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(86, 156);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(46, 17);
            this.lblAltura.TabIndex = 12;
            this.lblAltura.Text = "Altura";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(86, 115);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(37, 17);
            this.lblBase.TabIndex = 11;
            this.lblBase.Text = "Base";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(164, 249);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(105, 23);
            this.btnResultado.TabIndex = 10;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(183, 291);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(134, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(155, 154);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(134, 20);
            this.txtAltura.TabIndex = 8;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(155, 114);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(134, 20);
            this.txtBase.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(49, 363);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(358, 20);
            this.maskedTextBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Seleccionar operación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Seleccionar figura:";
            // 
            // cbxOperacion
            // 
            this.cbxOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperacion.FormattingEnabled = true;
            this.cbxOperacion.Items.AddRange(new object[] {
            "Área",
            "Perímetro"});
            this.cbxOperacion.Location = new System.Drawing.Point(242, 59);
            this.cbxOperacion.Name = "cbxOperacion";
            this.cbxOperacion.Size = new System.Drawing.Size(138, 21);
            this.cbxOperacion.TabIndex = 24;
            // 
            // cbxFigura
            // 
            this.cbxFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFigura.Items.AddRange(new object[] {
            "Triángulo",
            "Cuadrado",
            "Rectángulo"});
            this.cbxFigura.Location = new System.Drawing.Point(35, 59);
            this.cbxFigura.Name = "cbxFigura";
            this.cbxFigura.Size = new System.Drawing.Size(121, 21);
            this.cbxFigura.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Descripción:";
            // 
            // V_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 435);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxOperacion);
            this.Controls.Add(this.cbxFigura);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Name = "V_Menu";
            this.Text = "V_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblResultado;
        public System.Windows.Forms.Label lblAltura;
        public System.Windows.Forms.Label lblBase;
        public System.Windows.Forms.Button btnResultado;
        public System.Windows.Forms.TextBox txtResultado;
        public System.Windows.Forms.TextBox txtAltura;
        public System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxOperacion;
        public System.Windows.Forms.ComboBox cbxFigura;
        private System.Windows.Forms.Label label5;
    }
}