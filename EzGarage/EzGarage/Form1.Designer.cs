
namespace EzGarage
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.mecanicos_Btn = new FontAwesome.Sharp.IconButton();
            this.detallesServicio_Btn = new FontAwesome.Sharp.IconButton();
            this.servicios_Btn = new FontAwesome.Sharp.IconButton();
            this.vehiculos_Btn = new FontAwesome.Sharp.IconButton();
            this.clientes_Btn = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.panelMenu.Controls.Add(this.mecanicos_Btn);
            this.panelMenu.Controls.Add(this.detallesServicio_Btn);
            this.panelMenu.Controls.Add(this.servicios_Btn);
            this.panelMenu.Controls.Add(this.vehiculos_Btn);
            this.panelMenu.Controls.Add(this.clientes_Btn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 690);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1029, 120);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(57, 55);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnExit.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(1010, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnExit.Size = new System.Drawing.Size(19, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(998, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnMaximize.Size = new System.Drawing.Size(19, 23);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(985, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnMinimize.Size = new System.Drawing.Size(19, 23);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(19, 45);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // mecanicos_Btn
            // 
            this.mecanicos_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mecanicos_Btn.FlatAppearance.BorderSize = 0;
            this.mecanicos_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mecanicos_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.mecanicos_Btn.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.mecanicos_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.mecanicos_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mecanicos_Btn.IconSize = 32;
            this.mecanicos_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mecanicos_Btn.Location = new System.Drawing.Point(0, 380);
            this.mecanicos_Btn.Name = "mecanicos_Btn";
            this.mecanicos_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.mecanicos_Btn.Size = new System.Drawing.Size(220, 60);
            this.mecanicos_Btn.TabIndex = 4;
            this.mecanicos_Btn.Text = "Mecanicos";
            this.mecanicos_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mecanicos_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mecanicos_Btn.UseVisualStyleBackColor = true;
            this.mecanicos_Btn.Click += new System.EventHandler(this.mecanicos_Btn_Click);
            // 
            // detallesServicio_Btn
            // 
            this.detallesServicio_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.detallesServicio_Btn.FlatAppearance.BorderSize = 0;
            this.detallesServicio_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detallesServicio_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.detallesServicio_Btn.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            this.detallesServicio_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.detallesServicio_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detallesServicio_Btn.IconSize = 32;
            this.detallesServicio_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detallesServicio_Btn.Location = new System.Drawing.Point(0, 320);
            this.detallesServicio_Btn.Name = "detallesServicio_Btn";
            this.detallesServicio_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.detallesServicio_Btn.Size = new System.Drawing.Size(220, 60);
            this.detallesServicio_Btn.TabIndex = 3;
            this.detallesServicio_Btn.Text = "Buscar";
            this.detallesServicio_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detallesServicio_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.detallesServicio_Btn.UseVisualStyleBackColor = true;
            this.detallesServicio_Btn.Click += new System.EventHandler(this.detallesServicio_Btn_Click);
            // 
            // servicios_Btn
            // 
            this.servicios_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.servicios_Btn.FlatAppearance.BorderSize = 0;
            this.servicios_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicios_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.servicios_Btn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.servicios_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.servicios_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.servicios_Btn.IconSize = 32;
            this.servicios_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicios_Btn.Location = new System.Drawing.Point(0, 260);
            this.servicios_Btn.Name = "servicios_Btn";
            this.servicios_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.servicios_Btn.Size = new System.Drawing.Size(220, 60);
            this.servicios_Btn.TabIndex = 2;
            this.servicios_Btn.Text = "Servicios";
            this.servicios_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicios_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.servicios_Btn.UseVisualStyleBackColor = true;
            this.servicios_Btn.Click += new System.EventHandler(this.servicios_Btn_Click);
            // 
            // vehiculos_Btn
            // 
            this.vehiculos_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vehiculos_Btn.FlatAppearance.BorderSize = 0;
            this.vehiculos_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiculos_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.vehiculos_Btn.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.vehiculos_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.vehiculos_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vehiculos_Btn.IconSize = 32;
            this.vehiculos_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehiculos_Btn.Location = new System.Drawing.Point(0, 200);
            this.vehiculos_Btn.Name = "vehiculos_Btn";
            this.vehiculos_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.vehiculos_Btn.Size = new System.Drawing.Size(220, 60);
            this.vehiculos_Btn.TabIndex = 1;
            this.vehiculos_Btn.Text = "Vehiculos";
            this.vehiculos_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehiculos_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehiculos_Btn.UseVisualStyleBackColor = true;
            this.vehiculos_Btn.Click += new System.EventHandler(this.vehiculos_Btn_Click);
            // 
            // clientes_Btn
            // 
            this.clientes_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientes_Btn.FlatAppearance.BorderSize = 0;
            this.clientes_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientes_Btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.clientes_Btn.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.clientes_Btn.IconColor = System.Drawing.Color.Gainsboro;
            this.clientes_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clientes_Btn.IconSize = 32;
            this.clientes_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientes_Btn.Location = new System.Drawing.Point(0, 140);
            this.clientes_Btn.Name = "clientes_Btn";
            this.clientes_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.clientes_Btn.Size = new System.Drawing.Size(220, 60);
            this.clientes_Btn.TabIndex = 0;
            this.clientes_Btn.Text = "Clientes";
            this.clientes_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientes_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clientes_Btn.UseVisualStyleBackColor = true;
            this.clientes_Btn.Click += new System.EventHandler(this.clientes_Btn_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnHome.Image = global::EzGarage.Properties.Resources.refaccionaria_azteca_logo;
            this.btnHome.Location = new System.Drawing.Point(-14, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(247, 120);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EzGarage.Properties.Resources.mecanica;
            this.pictureBox1.Location = new System.Drawing.Point(419, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titulo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.titulo.Location = new System.Drawing.Point(454, 377);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(124, 21);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "EZ GARAGE V.0";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.titulo);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 120);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1029, 570);
            this.panelDesktop.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 690);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "EzGarage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton mecanicos_Btn;
        private FontAwesome.Sharp.IconButton detallesServicio_Btn;
        private FontAwesome.Sharp.IconButton servicios_Btn;
        private FontAwesome.Sharp.IconButton vehiculos_Btn;
        private FontAwesome.Sharp.IconButton clientes_Btn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

