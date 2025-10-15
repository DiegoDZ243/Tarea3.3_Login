namespace ProyectoTallerBaseDatos.Frontend
{
    partial class frmMenu
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pcbMenu = new System.Windows.Forms.PictureBox();
            this.pcbVerUsuarios = new System.Windows.Forms.PictureBox();
            this.pcbRegistrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(83, 318);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(225, 59);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar Usuarios";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuarios.Location = new System.Drawing.Point(67, 318);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.Size = new System.Drawing.Size(225, 59);
            this.btnVerUsuarios.TabIndex = 3;
            this.btnVerUsuarios.Text = "Ver Usuarios";
            this.btnVerUsuarios.UseVisualStyleBackColor = true;
            this.btnVerUsuarios.Click += new System.EventHandler(this.btnVerUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.pcbRegistrar);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Location = new System.Drawing.Point(30, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 406);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(147)))));
            this.panel2.Controls.Add(this.btnVerUsuarios);
            this.panel2.Controls.Add(this.pcbVerUsuarios);
            this.panel2.Location = new System.Drawing.Point(459, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 405);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(163)))), ((int)(((byte)(209)))));
            this.panel3.Controls.Add(this.pnlTitulo);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(28, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 500);
            this.panel3.TabIndex = 6;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.pcbMenu);
            this.pnlTitulo.Controls.Add(this.lblMenu);
            this.pnlTitulo.Location = new System.Drawing.Point(30, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(780, 94);
            this.pnlTitulo.TabIndex = 7;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(355, 22);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(143, 48);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "Menú";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(28, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 57);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pcbMenu
            // 
            this.pcbMenu.Image = global::ProyectoTallerBaseDatos.Properties.Resources.img_menu;
            this.pcbMenu.Location = new System.Drawing.Point(247, 0);
            this.pcbMenu.Name = "pcbMenu";
            this.pcbMenu.Size = new System.Drawing.Size(93, 94);
            this.pcbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMenu.TabIndex = 7;
            this.pcbMenu.TabStop = false;
            // 
            // pcbVerUsuarios
            // 
            this.pcbVerUsuarios.Image = global::ProyectoTallerBaseDatos.Properties.Resources.img_ver_usuarios;
            this.pcbVerUsuarios.Location = new System.Drawing.Point(43, 38);
            this.pcbVerUsuarios.Name = "pcbVerUsuarios";
            this.pcbVerUsuarios.Size = new System.Drawing.Size(264, 258);
            this.pcbVerUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVerUsuarios.TabIndex = 2;
            this.pcbVerUsuarios.TabStop = false;
            // 
            // pcbRegistrar
            // 
            this.pcbRegistrar.Image = global::ProyectoTallerBaseDatos.Properties.Resources.img_registro;
            this.pcbRegistrar.Location = new System.Drawing.Point(58, 38);
            this.pcbRegistrar.Name = "pcbRegistrar";
            this.pcbRegistrar.Size = new System.Drawing.Size(264, 258);
            this.pcbRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRegistrar.TabIndex = 1;
            this.pcbRegistrar.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(897, 600);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel3);
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegistrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pcbRegistrar;
        private System.Windows.Forms.PictureBox pcbVerUsuarios;
        private System.Windows.Forms.Button btnVerUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pcbMenu;
        private System.Windows.Forms.Button btnSalir;
    }
}