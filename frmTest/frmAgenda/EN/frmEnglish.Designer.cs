namespace frmTest
{
    partial class frmEnglish
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
            this.txtVal = new System.Windows.Forms.TextBox();
            this.lbCaja = new System.Windows.Forms.ListBox();
            this.btnAñadir2 = new System.Windows.Forms.Button();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosFinancierosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosFinancierosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciaFinancieraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganaciasFinancierasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAlirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVal
            // 
            this.txtVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVal.Location = new System.Drawing.Point(16, 74);
            this.txtVal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(437, 20);
            this.txtVal.TabIndex = 0;
            // 
            // lbCaja
            // 
            this.lbCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCaja.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbCaja.FormattingEnabled = true;
            this.lbCaja.ItemHeight = 19;
            this.lbCaja.Location = new System.Drawing.Point(16, 113);
            this.lbCaja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbCaja.Name = "lbCaja";
            this.lbCaja.Size = new System.Drawing.Size(661, 156);
            this.lbCaja.TabIndex = 1;
            this.lbCaja.SelectedIndexChanged += new System.EventHandler(this.lbCaja_SelectedIndexChanged);
            // 
            // btnAñadir2
            // 
            this.btnAñadir2.Font = new System.Drawing.Font("MS PMincho", 12F, System.Drawing.FontStyle.Bold);
            this.btnAñadir2.Location = new System.Drawing.Point(16, 32);
            this.btnAñadir2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAñadir2.Name = "btnAñadir2";
            this.btnAñadir2.Size = new System.Drawing.Size(161, 23);
            this.btnAñadir2.TabIndex = 2;
            this.btnAñadir2.Text = "Add Activity";
            this.btnAñadir2.UseVisualStyleBackColor = true;
            this.btnAñadir2.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Font = new System.Drawing.Font("MS PMincho", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar1.Location = new System.Drawing.Point(451, 45);
            this.btnGuardar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(100, 23);
            this.btnGuardar1.TabIndex = 2;
            this.btnGuardar1.Text = "Save";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Font = new System.Drawing.Font("MS PMincho", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar1.Location = new System.Drawing.Point(559, 45);
            this.btnEliminar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar1.TabIndex = 2;
            this.btnEliminar1.Text = "Delete";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(695, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuenoToolStripMenuItem,
            this.gastosFinancierosToolStripMenuItem,
            this.ganaciasFinancierasToolStripMenuItem,
            this.sAlirToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nuenoToolStripMenuItem
            // 
            this.nuenoToolStripMenuItem.Name = "nuenoToolStripMenuItem";
            this.nuenoToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.nuenoToolStripMenuItem.Text = "New";
            this.nuenoToolStripMenuItem.Click += new System.EventHandler(this.nuenoToolStripMenuItem_Click);
            // 
            // gastosFinancierosToolStripMenuItem
            // 
            this.gastosFinancierosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastosFinancierosToolStripMenuItem1,
            this.gananciaFinancieraToolStripMenuItem});
            this.gastosFinancierosToolStripMenuItem.Name = "gastosFinancierosToolStripMenuItem";
            this.gastosFinancierosToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.gastosFinancierosToolStripMenuItem.Text = "Resource Finacial";
            // 
            // gastosFinancierosToolStripMenuItem1
            // 
            this.gastosFinancierosToolStripMenuItem1.Name = "gastosFinancierosToolStripMenuItem1";
            this.gastosFinancierosToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.gastosFinancierosToolStripMenuItem1.Text = "Expenditure Financial";
            this.gastosFinancierosToolStripMenuItem1.Click += new System.EventHandler(this.gastosFinancierosToolStripMenuItem1_Click);
            // 
            // gananciaFinancieraToolStripMenuItem
            // 
            this.gananciaFinancieraToolStripMenuItem.Name = "gananciaFinancieraToolStripMenuItem";
            this.gananciaFinancieraToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.gananciaFinancieraToolStripMenuItem.Text = "Gains Financial";
            this.gananciaFinancieraToolStripMenuItem.Click += new System.EventHandler(this.gananciaFinancieraToolStripMenuItem_Click);
            // 
            // ganaciasFinancierasToolStripMenuItem
            // 
            this.ganaciasFinancierasToolStripMenuItem.Name = "ganaciasFinancierasToolStripMenuItem";
            this.ganaciasFinancierasToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.ganaciasFinancierasToolStripMenuItem.Text = "Save";
            this.ganaciasFinancierasToolStripMenuItem.Click += new System.EventHandler(this.ganaciasFinancierasToolStripMenuItem_Click);
            // 
            // sAlirToolStripMenuItem
            // 
            this.sAlirToolStripMenuItem.Name = "sAlirToolStripMenuItem";
            this.sAlirToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.sAlirToolStripMenuItem.Text = "Exit";
            this.sAlirToolStripMenuItem.Click += new System.EventHandler(this.sAlirToolStripMenuItem_Click);
            // 
            // frmEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 299);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnGuardar1);
            this.Controls.Add(this.btnAñadir2);
            this.Controls.Add(this.lbCaja);
            this.Controls.Add(this.txtVal);
            this.Font = new System.Drawing.Font("MS PMincho", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEnglish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEnglish_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.ListBox lbCaja;
        private System.Windows.Forms.Button btnAñadir2;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosFinancierosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosFinancierosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gananciaFinancieraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganaciasFinancierasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAlirToolStripMenuItem;
    }
}

