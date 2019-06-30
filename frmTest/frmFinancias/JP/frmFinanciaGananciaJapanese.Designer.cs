namespace frmTest
{
    partial class frmFinanciasGanaciaJapanese
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ltbNombre = new System.Windows.Forms.ListBox();
            this.txtSubtotalGasto = new System.Windows.Forms.TextBox();
            this.txtTotalGasto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.ltbValor = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaDeGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaDeGananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(32, 53);
            this.txtNombre.MaxLength = 16;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(416, 53);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(175, 26);
            this.txtValor.TabIndex = 1;
            this.txtValor.Text = "0";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "給付の名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(454, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "給付の価値";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("MS PMincho", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(416, 101);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(186, 31);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "エクスポルト/新しい";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS PMincho", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(190, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "セーブ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("MS PMincho", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(303, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "消す";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ltbNombre
            // 
            this.ltbNombre.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbNombre.FormattingEnabled = true;
            this.ltbNombre.ItemHeight = 19;
            this.ltbNombre.Location = new System.Drawing.Point(22, 154);
            this.ltbNombre.Name = "ltbNombre";
            this.ltbNombre.Size = new System.Drawing.Size(454, 232);
            this.ltbNombre.TabIndex = 6;
            this.ltbNombre.SelectedIndexChanged += new System.EventHandler(this.ltbNombre_SelectedIndexChanged);
            // 
            // txtSubtotalGasto
            // 
            this.txtSubtotalGasto.Enabled = false;
            this.txtSubtotalGasto.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSubtotalGasto.Location = new System.Drawing.Point(501, 404);
            this.txtSubtotalGasto.Name = "txtSubtotalGasto";
            this.txtSubtotalGasto.Size = new System.Drawing.Size(100, 26);
            this.txtSubtotalGasto.TabIndex = 5;
            this.txtSubtotalGasto.Text = "0";
            this.txtSubtotalGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalGasto
            // 
            this.txtTotalGasto.Enabled = false;
            this.txtTotalGasto.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalGasto.Location = new System.Drawing.Point(501, 444);
            this.txtTotalGasto.Name = "txtTotalGasto";
            this.txtTotalGasto.Size = new System.Drawing.Size(100, 26);
            this.txtTotalGasto.TabIndex = 5;
            this.txtTotalGasto.Text = "0";
            this.txtTotalGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(386, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "SubTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(412, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("MS PMincho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(12, 101);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(172, 31);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "フィルードのクリーン";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // ltbValor
            // 
            this.ltbValor.Font = new System.Drawing.Font("MS PMincho", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbValor.FormattingEnabled = true;
            this.ltbValor.ItemHeight = 19;
            this.ltbValor.Location = new System.Drawing.Point(501, 154);
            this.ltbValor.Name = "ltbValor";
            this.ltbValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ltbValor.Size = new System.Drawing.Size(101, 232);
            this.ltbValor.TabIndex = 7;
            this.ltbValor.Click += new System.EventHandler(this.ltbValor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 29);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.cambiarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // cambiarToolStripMenuItem
            // 
            this.cambiarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaDeGastosToolStripMenuItem,
            this.agendaDeGananciasToolStripMenuItem,
            this.agendaToolStripMenuItem});
            this.cambiarToolStripMenuItem.Name = "cambiarToolStripMenuItem";
            this.cambiarToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.cambiarToolStripMenuItem.Text = "Change";
            // 
            // agendaDeGastosToolStripMenuItem
            // 
            this.agendaDeGastosToolStripMenuItem.Name = "agendaDeGastosToolStripMenuItem";
            this.agendaDeGastosToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.agendaDeGastosToolStripMenuItem.Text = "Agend of Expenditure";
            this.agendaDeGastosToolStripMenuItem.Click += new System.EventHandler(this.agendaDeGastosToolStripMenuItem_Click);
            // 
            // agendaDeGananciasToolStripMenuItem
            // 
            this.agendaDeGananciasToolStripMenuItem.Enabled = false;
            this.agendaDeGananciasToolStripMenuItem.Name = "agendaDeGananciasToolStripMenuItem";
            this.agendaDeGananciasToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.agendaDeGananciasToolStripMenuItem.Text = "Agend of Gain";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.agendaToolStripMenuItem.Text = "Agend";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.salirToolStripMenuItem.Text = "Exit";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmFinanciasGanaciaJapanese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 482);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalGasto);
            this.Controls.Add(this.txtSubtotalGasto);
            this.Controls.Add(this.ltbValor);
            this.Controls.Add(this.ltbNombre);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFinanciasGanaciaJapanese";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "金銭的の議題（利益）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFinanciasGanacia_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox ltbNombre;
        private System.Windows.Forms.TextBox txtSubtotalGasto;
        private System.Windows.Forms.TextBox txtTotalGasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ListBox ltbValor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaDeGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaDeGananciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
    }
}