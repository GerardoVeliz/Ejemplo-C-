namespace WindowsFormsApp1
{
    partial class FOso
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
            this.lblSalidaNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btmSaludo = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cBNombreTrabajo = new System.Windows.Forms.ComboBox();
            this.rBtnTrabajo = new System.Windows.Forms.RadioButton();
            this.rBtnArt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalidaNombre
            // 
            this.lblSalidaNombre.AutoSize = true;
            this.lblSalidaNombre.ForeColor = System.Drawing.Color.Coral;
            this.lblSalidaNombre.Location = new System.Drawing.Point(374, 221);
            this.lblSalidaNombre.Name = "lblSalidaNombre";
            this.lblSalidaNombre.Size = new System.Drawing.Size(0, 13);
            this.lblSalidaNombre.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(394, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtNombre_MaskInputRejected);
            this.txtNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNombre_MouseDown);
            this.txtNombre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtNombre_MouseUp);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(323, 136);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: ";
            // 
            // btmSaludo
            // 
            this.btmSaludo.Location = new System.Drawing.Point(394, 242);
            this.btmSaludo.Name = "btmSaludo";
            this.btmSaludo.Size = new System.Drawing.Size(121, 23);
            this.btmSaludo.TabIndex = 4;
            this.btmSaludo.Text = "Login";
            this.btmSaludo.UseVisualStyleBackColor = true;
            this.btmSaludo.Click += new System.EventHandler(this.btmSaludo_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(324, 162);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido: ";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(394, 155);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 8;
            this.txtApellido.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtApellido_MouseUp);
            // 
            // cBNombreTrabajo
            // 
            this.cBNombreTrabajo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cBNombreTrabajo.CausesValidation = false;
            this.cBNombreTrabajo.Location = new System.Drawing.Point(394, 181);
            this.cBNombreTrabajo.Name = "cBNombreTrabajo";
            this.cBNombreTrabajo.Size = new System.Drawing.Size(121, 21);
            this.cBNombreTrabajo.TabIndex = 9;
            this.cBNombreTrabajo.UseWaitCursor = true;
            this.cBNombreTrabajo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rBtnTrabajo
            // 
            this.rBtnTrabajo.AutoSize = true;
            this.rBtnTrabajo.Location = new System.Drawing.Point(394, 209);
            this.rBtnTrabajo.Name = "rBtnTrabajo";
            this.rBtnTrabajo.Size = new System.Drawing.Size(79, 17);
            this.rBtnTrabajo.TabIndex = 10;
            this.rBtnTrabajo.TabStop = true;
            this.rBtnTrabajo.Text = "Trabajando";
            this.rBtnTrabajo.UseVisualStyleBackColor = true;
            // 
            // rBtnArt
            // 
            this.rBtnArt.AutoSize = true;
            this.rBtnArt.Location = new System.Drawing.Point(485, 209);
            this.rBtnArt.Name = "rBtnArt";
            this.rBtnArt.Size = new System.Drawing.Size(47, 17);
            this.rBtnArt.TabIndex = 11;
            this.rBtnArt.TabStop = true;
            this.rBtnArt.Text = "ART";
            this.rBtnArt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trabajo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estado: ";
            // 
            // FOso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBtnArt);
            this.Controls.Add(this.rBtnTrabajo);
            this.Controls.Add(this.cBNombreTrabajo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btmSaludo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSalidaNombre);
            this.Name = "FOso";
            this.Text = "Codea!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSalidaNombre;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btmSaludo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cBNombreTrabajo;
        private System.Windows.Forms.RadioButton rBtnTrabajo;
        private System.Windows.Forms.RadioButton rBtnArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

