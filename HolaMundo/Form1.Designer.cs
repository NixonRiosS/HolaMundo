namespace HolaMundo
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_saludar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.Navy;
            this.lbl_nombre.Location = new System.Drawing.Point(240, 36);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(316, 44);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Mi Primer Programa";
            this.lbl_nombre.UseCompatibleTextRendering = true;
            // 
            // btn_saludar
            // 
            this.btn_saludar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_saludar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saludar.ForeColor = System.Drawing.Color.Black;
            this.btn_saludar.Location = new System.Drawing.Point(338, 193);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(121, 60);
            this.btn_saludar.TabIndex = 1;
            this.btn_saludar.Text = "Saludar !";
            this.btn_saludar.UseVisualStyleBackColor = false;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(273, 120);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(232, 34);
            this.txt_nombre.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_saludar);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Form1";
            this.Text = "Hola Mundo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}

