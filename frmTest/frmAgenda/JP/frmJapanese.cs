using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmTest
{
    public partial class frmJapanese : Form
    {
        SaveFileDialog sav = new SaveFileDialog();
        OpenFileDialog sav1 = new OpenFileDialog();
        public frmJapanese()
        {
           
            InitializeComponent();
            this.Text = "議題/リスト";
            sav.FileName = "01_Save";
            Loaded();
            Reset();
        }
        private bool NewText = false;

        private void Creation_Save()
        {
            sav.FileName = "01_Save";
            sav.AddExtension.Equals(".sav1");
            StreamWriter swf = new StreamWriter(sav.FileName);
            foreach (object inset in lbCaja.Items)
            {
                swf.WriteLine(inset.ToString());
            }
            swf.Close();
        }

        private void Loaded()
        {
            if (System.IO.File.Exists("01_Save"))
            {
                sav1.FileName = "01_Save";
                sav1.AddExtension.Equals(".sav1");
                StreamReader read = new StreamReader(sav1.FileName);
                string[] obj = File.ReadAllLines(sav1.FileName);
                lbCaja.Items.AddRange(obj);
                read.Close();
            }
            else
            {
                Creation_Save();
            }

        }

        private  void Reset()
        {
            this.btnAñadir2.Enabled = true;
            this.btnGuardar1.Enabled = false;
            this.btnEliminar1.Enabled = false;
            this.txtVal.Enabled = false;
            this.txtVal.Text = "";
            NewText = false;
            lbCaja.SelectedIndex = -1;
        }

        private void Añadir()
        {
            if (txtVal.TextLength > 0)
            {
                if (MessageBox.Show("このフィールド選択がクレーンに行きます、あなたは続けたいですか？", "アラート", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    this.btnAñadir2.Enabled = false;
                    this.btnGuardar1.Enabled = true;
                    this.txtVal.Enabled = true;
                    txtVal.Focus();
                    txtVal.Text = "";
                    NewText = false;
                    lbCaja.SelectedIndex = -1;
                }
            }
            else
            {
                this.btnAñadir2.Enabled = false;
                this.btnGuardar1.Enabled = true;
                this.txtVal.Enabled = true;
                txtVal.Focus();
                txtVal.Text = "";
                NewText = false;
            }
        }

        private void Save() 
        {
            if (txtVal.TextLength > 0)
            {
                if (NewText != true)
                {
                    lbCaja.Items.Add(txtVal.Text);
                
                }
                if (lbCaja.SelectedIndex >= 0 && lbCaja.SelectedIndex < lbCaja.Items.Count)
                {
                    if (MessageBox.Show("このフィールド選択が上書きに行きます、あなたは続けたいですか？", "メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        lbCaja.Items[lbCaja.SelectedIndex] = txtVal.Text;
                        MessageBox.Show("正しくセーブ");
                    }
                }
            }
            Creation_Save();
            Reset();
        }

        private void Delete()
        {
            if (lbCaja.SelectedIndex >= 0 && lbCaja.SelectedIndex < lbCaja.Items.Count)
            {
                if (MessageBox.Show("このフィールド選択消したいですか？", "メッセージ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    lbCaja.Items.RemoveAt(lbCaja.SelectedIndex);
                }
            }
            Reset();
        }

        private void Selected_()
        {
            if (lbCaja.SelectedIndex >= 0 && lbCaja.SelectedIndex < lbCaja.Items.Count)
            {
                this.btnAñadir2.Enabled = false;
                this.btnGuardar1.Enabled = true;
                this.txtVal.Enabled = true;
                txtVal.Focus();
                txtVal.Text = "";
                NewText=true;
                btnAñadir2.Enabled = true;
                txtVal.Text = lbCaja.Items[lbCaja.SelectedIndex].ToString();
                btnEliminar1.Enabled = true;
            }
        }

        private void Close()
        {
            Application.Exit();
        }

        private void Nueva_pagina()
        {
            for (int i = lbCaja.Items.Count - 1; i != -1; i--)
            {
                lbCaja.Items.RemoveAt(i);
            }
            Creation_Save();
            Reset();
        }




        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Añadir();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void lbCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected_();
        }

        private void frmEnglish_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void nuenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //boton menu nuevo
            Nueva_pagina();

        }

        private void gastosFinancierosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFinanciasGastosJapanese fg = new frmFinanciasGastosJapanese();
            fg.Visible = true;
            this.Visible = false;
        }

        private void gananciaFinancieraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFinanciasGanaciaJapanese fg = new frmFinanciasGanaciaJapanese();
            fg.Visible = true;
            this.Visible = false;
        }

        private void ganaciasFinancierasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creation_Save();
        }

        private void sAlirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
