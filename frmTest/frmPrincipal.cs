using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmTest
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void Accept() 
        {
            if(cbSelect.Text == "Español")
            {
                frmEspañol esp = new frmEspañol();
                esp.Visible = true;
                this.Visible = false;
            }
            else if (cbSelect.Text == "English")
            {
                frmEnglish eng = new frmEnglish();
                eng.Visible = true;
                this.Visible = false;
            }
            else if (cbSelect.Text == "日本語")
            {
                frmJapanese eng = new frmJapanese();
                eng.Visible = true;
                this.Visible = false;
            }
            else if (cbSelect.Text != "English" || cbSelect.Text != "Español")
            {
                MessageBox.Show("El idioma selecionado no es admitido, Intentelo nuevamente. "+" The language selectioned is no valid, try again.");
            }
        }
        private void Select()
        {
            if( "Español" == (string) cbSelect.Items[cbSelect.SelectedIndex] )
            {
                this.Text = "Selecciòn de idioma";
                button1.Text = "Seleccionar";
            }
            else if ("English" == (string) cbSelect.Items[cbSelect.SelectedIndex])
            {
                this.Text = "Selection of language";
                button1.Text = "Selection";
            }
            else if ("日本語" == (string)cbSelect.Items[cbSelect.SelectedIndex])
            {
                this.Text = "言語の選択";
                button1.Text = "選択";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accept();
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select();
        }
    }
}
