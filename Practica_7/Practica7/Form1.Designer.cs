namespace Practica7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.chkOral = new System.Windows.Forms.CheckBox();
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.chkPerrito = new System.Windows.Forms.CheckBox();
            this.chk69 = new System.Windows.Forms.CheckBox();
            this.radPorSiempre = new System.Windows.Forms.RadioButton();
            this.radClaro = new System.Windows.Forms.RadioButton();
            this.radSi = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.numHijos = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHijos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnTerminar);
            this.panel1.Controls.Add(this.Calendario);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chkOral);
            this.panel1.Controls.Add(this.chkNormal);
            this.panel1.Controls.Add(this.chkPerrito);
            this.panel1.Controls.Add(this.chk69);
            this.panel1.Controls.Add(this.radPorSiempre);
            this.panel1.Controls.Add(this.radClaro);
            this.panel1.Controls.Add(this.radSi);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numHijos);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbGrupo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 602);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(425, 514);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(190, 61);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.White;
            this.btnTerminar.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(425, 433);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(190, 61);
            this.btnTerminar.TabIndex = 23;
            this.btnTerminar.Text = "TERMINAR";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(145, 413);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(59, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "4.- ¿En qué fecha sucedio?";
            // 
            // chkOral
            // 
            this.chkOral.AutoSize = true;
            this.chkOral.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkOral.Location = new System.Drawing.Point(476, 306);
            this.chkOral.Name = "chkOral";
            this.chkOral.Size = new System.Drawing.Size(78, 28);
            this.chkOral.TabIndex = 20;
            this.chkOral.Text = "Oral";
            this.chkOral.UseVisualStyleBackColor = true;
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNormal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkNormal.Location = new System.Drawing.Point(327, 306);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.Size = new System.Drawing.Size(110, 28);
            this.chkNormal.TabIndex = 19;
            this.chkNormal.Text = "Normal";
            this.chkNormal.UseVisualStyleBackColor = true;
            // 
            // chkPerrito
            // 
            this.chkPerrito.AutoSize = true;
            this.chkPerrito.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPerrito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkPerrito.Location = new System.Drawing.Point(196, 306);
            this.chkPerrito.Name = "chkPerrito";
            this.chkPerrito.Size = new System.Drawing.Size(102, 28);
            this.chkPerrito.TabIndex = 18;
            this.chkPerrito.Text = "Perrito";
            this.chkPerrito.UseVisualStyleBackColor = true;
            // 
            // chk69
            // 
            this.chk69.AutoSize = true;
            this.chk69.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk69.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chk69.Location = new System.Drawing.Point(94, 306);
            this.chk69.Name = "chk69";
            this.chk69.Size = new System.Drawing.Size(55, 28);
            this.chk69.TabIndex = 17;
            this.chk69.Text = "69";
            this.chk69.UseVisualStyleBackColor = true;
            // 
            // radPorSiempre
            // 
            this.radPorSiempre.AutoSize = true;
            this.radPorSiempre.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPorSiempre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radPorSiempre.Location = new System.Drawing.Point(348, 131);
            this.radPorSiempre.Name = "radPorSiempre";
            this.radPorSiempre.Size = new System.Drawing.Size(153, 28);
            this.radPorSiempre.TabIndex = 16;
            this.radPorSiempre.TabStop = true;
            this.radPorSiempre.Text = "Por Siempre";
            this.radPorSiempre.UseVisualStyleBackColor = true;
            // 
            // radClaro
            // 
            this.radClaro.AutoSize = true;
            this.radClaro.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radClaro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radClaro.Location = new System.Drawing.Point(211, 131);
            this.radClaro.Name = "radClaro";
            this.radClaro.Size = new System.Drawing.Size(87, 28);
            this.radClaro.TabIndex = 15;
            this.radClaro.TabStop = true;
            this.radClaro.Text = "Claro";
            this.radClaro.UseVisualStyleBackColor = true;
            // 
            // radSi
            // 
            this.radSi.AutoSize = true;
            this.radSi.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radSi.Location = new System.Drawing.Point(116, 131);
            this.radSi.Name = "radSi";
            this.radSi.Size = new System.Drawing.Size(49, 28);
            this.radSi.TabIndex = 14;
            this.radSi.TabStop = true;
            this.radSi.Text = "SI";
            this.radSi.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(59, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "3.- ¿Cuales posiciones hicimos?";
            // 
            // numHijos
            // 
            this.numHijos.Location = new System.Drawing.Point(145, 224);
            this.numHijos.Name = "numHijos";
            this.numHijos.Size = new System.Drawing.Size(120, 20);
            this.numHijos.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(422, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Grupo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(145, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(224, 31);
            this.txtCodigo.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(145, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(470, 31);
            this.txtNombre.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(59, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "2.- ¿Cuantos Hijos vamos a tener?";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbGrupo.Location = new System.Drawing.Point(490, 54);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(73, 21);
            this.cmbGrupo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(322, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "c) ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(171, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "b) ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(89, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "a) ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(59, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "1.- ¿ Tu mamá es mi novia?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(59, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(59, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "a) ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 607);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exámen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHijos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numHijos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkOral;
        private System.Windows.Forms.CheckBox chkNormal;
        private System.Windows.Forms.CheckBox chkPerrito;
        private System.Windows.Forms.CheckBox chk69;
        private System.Windows.Forms.RadioButton radPorSiempre;
        private System.Windows.Forms.RadioButton radClaro;
        private System.Windows.Forms.RadioButton radSi;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Label label11;
    }
}

