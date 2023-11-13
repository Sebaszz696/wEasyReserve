namespace EasyReserve
{
    partial class frmReservarEspacio
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
            this.cboEscenario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoDeEspacio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTuCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            this.cboHora = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDespacio = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboEscenario
            // 
            this.cboEscenario.CausesValidation = false;
            this.cboEscenario.FormattingEnabled = true;
            this.cboEscenario.Location = new System.Drawing.Point(556, 390);
            this.cboEscenario.Name = "cboEscenario";
            this.cboEscenario.Size = new System.Drawing.Size(184, 24);
            this.cboEscenario.TabIndex = 62;
            this.cboEscenario.SelectedIndexChanged += new System.EventHandler(this.cboEscenario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(564, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 33);
            this.label4.TabIndex = 61;
            this.label4.Text = "Escenario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboTipoDeEspacio
            // 
            this.cboTipoDeEspacio.CausesValidation = false;
            this.cboTipoDeEspacio.FormattingEnabled = true;
            this.cboTipoDeEspacio.Items.AddRange(new object[] {
            "Cancha de futbol",
            "Cancha de baloncesto",
            "Gimnasio",
            "Salas de conferencia",
            "Aulas"});
            this.cboTipoDeEspacio.Location = new System.Drawing.Point(556, 274);
            this.cboTipoDeEspacio.Name = "cboTipoDeEspacio";
            this.cboTipoDeEspacio.Size = new System.Drawing.Size(184, 24);
            this.cboTipoDeEspacio.TabIndex = 57;
            this.cboTipoDeEspacio.SelectedIndexChanged += new System.EventHandler(this.cboTipoDeEspacio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(476, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 40);
            this.label3.TabIndex = 56;
            this.label3.Text = "Reserva tu Espacio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(564, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 33);
            this.label5.TabIndex = 55;
            this.label5.Text = "Tipo de espacio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(963, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 33);
            this.label2.TabIndex = 54;
            this.label2.Text = "Hora";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(278, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 33);
            this.label6.TabIndex = 53;
            this.label6.Text = "Fecha";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTuCedula
            // 
            this.txtTuCedula.Location = new System.Drawing.Point(911, 390);
            this.txtTuCedula.Name = "txtTuCedula";
            this.txtTuCedula.Size = new System.Drawing.Size(189, 22);
            this.txtTuCedula.TabIndex = 69;
            this.txtTuCedula.TextChanged += new System.EventHandler(this.txtTuCedula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(927, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 68;
            this.label1.Text = "Tu Cedula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mcFecha
            // 
            this.mcFecha.Location = new System.Drawing.Point(172, 274);
            this.mcFecha.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.mcFecha.MaxSelectionCount = 1;
            this.mcFecha.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 70;
            this.mcFecha.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcFecha_DateChanged);
            // 
            // cboHora
            // 
            this.cboHora.FormattingEnabled = true;
            this.cboHora.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "10:00",
            "11:00",
            "12:00",
            "14:00",
            "15:00"});
            this.cboHora.Location = new System.Drawing.Point(933, 274);
            this.cboHora.Name = "cboHora";
            this.cboHora.Size = new System.Drawing.Size(184, 24);
            this.cboHora.TabIndex = 71;
            this.cboHora.SelectedIndexChanged += new System.EventHandler(this.cboHora_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(753, 708);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 23);
            this.label7.TabIndex = 85;
            this.label7.Text = "Escriba en este campo el Id a modificar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtIDespacio
            // 
            this.txtIDespacio.Location = new System.Drawing.Point(846, 683);
            this.txtIDespacio.Name = "txtIDespacio";
            this.txtIDespacio.Size = new System.Drawing.Size(188, 22);
            this.txtIDespacio.TabIndex = 84;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.LightGray;
            this.btnModificar.Location = new System.Drawing.Point(76, 673);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(544, 49);
            this.btnModificar.TabIndex = 83;
            this.btnModificar.Text = "MODIFICAR ESPACIO";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsultar.Location = new System.Drawing.Point(731, 596);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(544, 49);
            this.btnConsultar.TabIndex = 82;
            this.btnConsultar.Text = "CONSULTAR ESPACIO";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReservar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.ForeColor = System.Drawing.Color.LightGray;
            this.btnReservar.Location = new System.Drawing.Point(76, 596);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReservar.Size = new System.Drawing.Size(544, 49);
            this.btnReservar.TabIndex = 81;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // frmReservarEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 753);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIDespacio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.cboHora);
            this.Controls.Add(this.mcFecha);
            this.Controls.Add(this.txtTuCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEscenario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTipoDeEspacio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservarEspacio";
            this.Text = "Ubicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ComboBox cboEscenario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoDeEspacio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTuCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcFecha;
        private System.Windows.Forms.ComboBox cboHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDespacio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnReservar;
    }
}
