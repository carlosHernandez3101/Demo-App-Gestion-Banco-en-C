﻿namespace CHernandez_JBonilla
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcGestionBanco = new System.Windows.Forms.TabControl();
            this.tpRegBanco = new System.Windows.Forms.TabPage();
            this.dtFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.tbxNitBan = new System.Windows.Forms.TextBox();
            this.tbxNomBan = new System.Windows.Forms.TextBox();
            this.btnAgregarBanco = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.tpRegSuc = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConsSuc = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tcGestionBanco.SuspendLayout();
            this.tpRegBanco.SuspendLayout();
            this.tpRegSuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcGestionBanco
            // 
            this.tcGestionBanco.Controls.Add(this.tpRegBanco);
            this.tcGestionBanco.Controls.Add(this.tpRegSuc);
            this.tcGestionBanco.Controls.Add(this.tpConsSuc);
            this.tcGestionBanco.Location = new System.Drawing.Point(37, 29);
            this.tcGestionBanco.Name = "tcGestionBanco";
            this.tcGestionBanco.SelectedIndex = 0;
            this.tcGestionBanco.Size = new System.Drawing.Size(661, 379);
            this.tcGestionBanco.TabIndex = 0;
            // 
            // tpRegBanco
            // 
            this.tpRegBanco.Controls.Add(this.label9);
            this.tpRegBanco.Controls.Add(this.dtFechaCreacion);
            this.tpRegBanco.Controls.Add(this.tbxNitBan);
            this.tpRegBanco.Controls.Add(this.tbxNomBan);
            this.tpRegBanco.Controls.Add(this.btnAgregarBanco);
            this.tpRegBanco.Controls.Add(this.label3);
            this.tpRegBanco.Controls.Add(this.label2);
            this.tpRegBanco.Controls.Add(this.lbl);
            this.tpRegBanco.Location = new System.Drawing.Point(4, 22);
            this.tpRegBanco.Name = "tpRegBanco";
            this.tpRegBanco.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegBanco.Size = new System.Drawing.Size(653, 353);
            this.tpRegBanco.TabIndex = 0;
            this.tpRegBanco.Text = "REGISTRAR BANCO";
            this.tpRegBanco.UseVisualStyleBackColor = true;
            // 
            // dtFechaCreacion
            // 
            this.dtFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaCreacion.Location = new System.Drawing.Point(254, 196);
            this.dtFechaCreacion.Name = "dtFechaCreacion";
            this.dtFechaCreacion.Size = new System.Drawing.Size(200, 21);
            this.dtFechaCreacion.TabIndex = 6;
            // 
            // tbxNitBan
            // 
            this.tbxNitBan.Location = new System.Drawing.Point(254, 141);
            this.tbxNitBan.Name = "tbxNitBan";
            this.tbxNitBan.Size = new System.Drawing.Size(100, 20);
            this.tbxNitBan.TabIndex = 5;
            // 
            // tbxNomBan
            // 
            this.tbxNomBan.Location = new System.Drawing.Point(254, 91);
            this.tbxNomBan.Name = "tbxNomBan";
            this.tbxNomBan.Size = new System.Drawing.Size(100, 20);
            this.tbxNomBan.TabIndex = 4;
            // 
            // btnAgregarBanco
            // 
            this.btnAgregarBanco.Location = new System.Drawing.Point(227, 266);
            this.btnAgregarBanco.Name = "btnAgregarBanco";
            this.btnAgregarBanco.Size = new System.Drawing.Size(195, 55);
            this.btnAgregarBanco.TabIndex = 3;
            this.btnAgregarBanco.Text = "REGISTRAR BANCO";
            this.btnAgregarBanco.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE CREACIÓN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIT BANCO:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(93, 91);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(97, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "NOMBRE BANCO:";
            // 
            // tpRegSuc
            // 
            this.tpRegSuc.Controls.Add(this.label8);
            this.tpRegSuc.Controls.Add(this.button1);
            this.tpRegSuc.Controls.Add(this.comboBox1);
            this.tpRegSuc.Controls.Add(this.textBox4);
            this.tpRegSuc.Controls.Add(this.textBox3);
            this.tpRegSuc.Controls.Add(this.textBox2);
            this.tpRegSuc.Controls.Add(this.textBox1);
            this.tpRegSuc.Controls.Add(this.label7);
            this.tpRegSuc.Controls.Add(this.label6);
            this.tpRegSuc.Controls.Add(this.label5);
            this.tpRegSuc.Controls.Add(this.label4);
            this.tpRegSuc.Controls.Add(this.label1);
            this.tpRegSuc.Location = new System.Drawing.Point(4, 22);
            this.tpRegSuc.Name = "tpRegSuc";
            this.tpRegSuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegSuc.Size = new System.Drawing.Size(653, 353);
            this.tpRegSuc.TabIndex = 1;
            this.tpRegSuc.Text = "REGISTRAR SUCURSAL";
            this.tpRegSuc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "REGISTRAR SUCURSAL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "norte",
            "sur",
            "centro"});
            this.comboBox1.Location = new System.Drawing.Point(178, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(351, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "ANTIGUEDAD EN AÑOS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "NUMERO DE EMPLEADOS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "UBICACIÓN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "NOMBRE SUCURSAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO SUCURSAL:";
            // 
            // tpConsSuc
            // 
            this.tpConsSuc.Location = new System.Drawing.Point(4, 22);
            this.tpConsSuc.Name = "tpConsSuc";
            this.tpConsSuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsSuc.Size = new System.Drawing.Size(653, 353);
            this.tpConsSuc.TabIndex = 2;
            this.tpConsSuc.Text = "CONSULTAR SUCURSAL";
            this.tpConsSuc.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "DATOS DE LA SUCURSAL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "DATOS DEL BANCO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcGestionBanco);
            this.Name = "Form1";
            this.Text = "GESTION ADMINISTRATIVA DEL BANCO";
            this.tcGestionBanco.ResumeLayout(false);
            this.tpRegBanco.ResumeLayout(false);
            this.tpRegBanco.PerformLayout();
            this.tpRegSuc.ResumeLayout(false);
            this.tpRegSuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcGestionBanco;
        private System.Windows.Forms.TabPage tpRegBanco;
        private System.Windows.Forms.TabPage tpRegSuc;
        private System.Windows.Forms.TabPage tpConsSuc;
        private System.Windows.Forms.DateTimePicker dtFechaCreacion;
        private System.Windows.Forms.TextBox tbxNitBan;
        private System.Windows.Forms.TextBox tbxNomBan;
        private System.Windows.Forms.Button btnAgregarBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

