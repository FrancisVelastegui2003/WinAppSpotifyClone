namespace WinAppSpotifyClone
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.canciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // canciónToolStripMenuItem
            // 
            this.canciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCanciónToolStripMenuItem,
            this.crearCanciónToolStripMenuItem,
            this.actualizarCanciónToolStripMenuItem,
            this.eliminarCanciónToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.canciónToolStripMenuItem.Name = "canciónToolStripMenuItem";
            this.canciónToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.canciónToolStripMenuItem.Text = "&Canción";
            // 
            // consultarCanciónToolStripMenuItem
            // 
            this.consultarCanciónToolStripMenuItem.Name = "consultarCanciónToolStripMenuItem";
            this.consultarCanciónToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.consultarCanciónToolStripMenuItem.Text = "&Consultar Canción";
            this.consultarCanciónToolStripMenuItem.Click += new System.EventHandler(this.consultarCanciónToolStripMenuItem_Click);
            // 
            // crearCanciónToolStripMenuItem
            // 
            this.crearCanciónToolStripMenuItem.Name = "crearCanciónToolStripMenuItem";
            this.crearCanciónToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.crearCanciónToolStripMenuItem.Text = "C&rear Canción";
            // 
            // actualizarCanciónToolStripMenuItem
            // 
            this.actualizarCanciónToolStripMenuItem.Name = "actualizarCanciónToolStripMenuItem";
            this.actualizarCanciónToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.actualizarCanciónToolStripMenuItem.Text = "&Actualizar Canción";
            // 
            // eliminarCanciónToolStripMenuItem
            // 
            this.eliminarCanciónToolStripMenuItem.Name = "eliminarCanciónToolStripMenuItem";
            this.eliminarCanciónToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarCanciónToolStripMenuItem.Text = "&Eliminar Canción";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de ...";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 552);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Song";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem canciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCanciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCanciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarCanciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCanciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}