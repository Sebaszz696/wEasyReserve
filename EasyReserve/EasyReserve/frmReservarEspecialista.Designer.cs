namespace EasyReserve
{
    partial class frmReservarEspecialista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservarEspecialista));
            this.cboEspecialista = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHora = new System.Windows.Forms.ComboBox();
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            this.cboTipoDeCita = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTuCedula = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIDcita = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboEspecialista
            // 
            this.cboEspecialista.CausesValidation = false;
            this.cboEspecialista.FormattingEnabled = true;
            this.cboEspecialista.Location = new System.Drawing.Point(572, 396);
            this.cboEspecialista.Name = "cboEspecialista";
            this.cboEspecialista.Size = new System.Drawing.Size(184, 24);
            this.cboEspecialista.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(580, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 33);
            this.label4.TabIndex = 51;
            this.label4.Text = "Especialista";
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
            this.cboHora.Location = new System.Drawing.Point(924, 280);
            this.cboHora.Name = "cboHora";
            this.cboHora.Size = new System.Drawing.Size(184, 24);
            this.cboHora.TabIndex = 50;
            // 
            // mcFecha
            // 
            this.mcFecha.Location = new System.Drawing.Point(170, 280);
            this.mcFecha.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.mcFecha.MaxSelectionCount = 1;
            this.mcFecha.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 49;
            // 
            // cboTipoDeCita
            // 
            this.cboTipoDeCita.CausesValidation = false;
            this.cboTipoDeCita.FormattingEnabled = true;
            this.cboTipoDeCita.Items.AddRange(new object[] {
            "Psicología",
            "Dermatología",
            "Odontología",
            "Pediatría",
            "Cirugia Estetica",
            "Ginecología"});
            this.cboTipoDeCita.Location = new System.Drawing.Point(572, 280);
            this.cboTipoDeCita.Name = "cboTipoDeCita";
            this.cboTipoDeCita.Size = new System.Drawing.Size(184, 24);
            this.cboTipoDeCita.TabIndex = 47;
            this.cboTipoDeCita.SelectedIndexChanged += new System.EventHandler(this.cboTipoDeCita_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(522, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 40);
            this.label3.TabIndex = 46;
            this.label3.Text = "Reserva tu cita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(580, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 33);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tipo de cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(979, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 33);
            this.label2.TabIndex = 44;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "Fecha";
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReservar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.ForeColor = System.Drawing.Color.LightGray;
            this.btnReservar.Location = new System.Drawing.Point(13, 568);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReservar.Size = new System.Drawing.Size(544, 49);
            this.btnReservar.TabIndex = 65;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(940, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 33);
            this.label6.TabIndex = 66;
            this.label6.Text = "Tu Cedula";
            // 
            // txtTuCedula
            // 
            this.txtTuCedula.Location = new System.Drawing.Point(924, 396);
            this.txtTuCedula.Name = "txtTuCedula";
            this.txtTuCedula.Size = new System.Drawing.Size(189, 22);
            this.txtTuCedula.TabIndex = 67;
            this.txtTuCedula.TextChanged += new System.EventHandler(this.txtTuCedula_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsultar.Location = new System.Drawing.Point(668, 568);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(544, 49);
            this.btnConsultar.TabIndex = 70;
            this.btnConsultar.Text = "CONSULTAR CITA";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.LightGray;
            this.btnModificar.Location = new System.Drawing.Point(13, 645);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(544, 49);
            this.btnModificar.TabIndex = 71;
            this.btnModificar.Text = "MODIFICAR CITA";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIDcita
            // 
            this.txtIDcita.Location = new System.Drawing.Point(783, 655);
            this.txtIDcita.Name = "txtIDcita";
            this.txtIDcita.Size = new System.Drawing.Size(188, 22);
            this.txtIDcita.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(690, 680);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 23);
            this.label7.TabIndex = 80;
            this.label7.Text = "Escriba en este campo el Id a modificar";
            // 
            // frmReservarEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1440, 753);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIDcita);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtTuCedula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.cboEspecialista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboHora);
            this.Controls.Add(this.mcFecha);
            this.Controls.Add(this.cboTipoDeCita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservarEspecialista";
            this.Text = "Ubicacion";
            this.Load += new System.EventHandler(this.frmReservarEspacio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEspecialista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHora;
        private System.Windows.Forms.MonthCalendar mcFecha;
        private System.Windows.Forms.ComboBox cboTipoDeCita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTuCedula;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtIDcita;
        private System.Windows.Forms.Label label7;
    }
}