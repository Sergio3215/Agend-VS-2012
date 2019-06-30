using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace frmTest
{
    public partial class frmFinanciasGanaciaEnglish: Form
    {
        public frmFinanciasGanaciaEnglish()
        {
            InitializeComponent();

            Loaded();
            Reset();
        }

        //Comienzan los Metodos-------------------------------------------------------------------------------------------------------------------------------------

        //Carga un Save si existe---------------------
        private void Loaded()
        {
            // corrobora que haya save----------
            if (System.IO.File.Exists("01_SaveFinancias_Ganancia") && System.IO.File.Exists("02_SaveFinancias_Ganancia"))
            {
                OpenFileDialog load = new OpenFileDialog();
                OpenFileDialog load1 = new OpenFileDialog();

                load.AddExtension.Equals(".sav1");
                load.FileName = "01_SaveFinancias_Ganancia";

                load1.AddExtension.Equals(".sav1");
                load1.FileName = "02_SaveFinancias_Ganancia";

                StreamReader open = new StreamReader(load.FileName);
                StreamReader open1 = new StreamReader(load1.FileName);

                string[] obj = File.ReadAllLines(load.FileName);
                string[] obj1 = File.ReadAllLines(load1.FileName);

                ltbNombre.Items.AddRange(obj);
                ltbValor.Items.AddRange(obj1);

                open.Close();
                open1.Close();
            }
            //si no hay crea uno
            else
            {
                Create_Save();
            }
        }

        //metodo que crea save archivo------------------------------------------------------------------------------------------------------------------------
        private void Create_Save()
        {
            SaveFileDialog save = new SaveFileDialog();
            SaveFileDialog save1 = new SaveFileDialog();

            save.AddExtension.Equals(".sav1");
            save.Filter.Equals(".sav1");
            save.FileName = "01_SaveFinancias_Ganancia";

            save1.AddExtension.Equals(".sav1");
            save1.Filter.Equals(".sav1");
            save1.FileName = "02_SaveFinancias_Ganancia";


            StreamWriter stw = new StreamWriter(save.FileName);
            StreamWriter stw1 = new StreamWriter(save1.FileName);

            foreach (object file in ltbNombre.Items)
            {
                stw.WriteLine(file.ToString());
            }

            foreach (object file1 in ltbValor.Items)
            {
                stw1.WriteLine(file1.ToString());
            }


            stw.Close();
            stw1.Close();
        }

        //resetea los  textbox---------------------------------------------------------------------------------------------------------------------
        private void Reset()
        {
            txtNombre.Text = "";
            txtValor.Text = "";
            ltbNombre.SelectedIndex = -1;
            ltbValor.SelectedIndex = -1;
            txtNombre.Focus();

            double z = 0;
            if(ltbValor.Items.Count -1 != -1)
            {
                for (int i=0; i < ltbValor.Items.Count; i++)
                {
                    double x = Convert.ToDouble(ltbValor.Items[i].ToString());
                    z = z + x;
                }
                txtSubtotalGasto.Text = z.ToString();
            }

            SaveFileDialog save2 = new SaveFileDialog();
            save2.AddExtension.Equals(".sav1");
            save2.Filter.Equals(".sav1");
            save2.FileName = "File2"; // subtotal gasto
            StreamWriter stw2 = new StreamWriter(save2.FileName);
            stw2.Write(z);
            stw2.Close();
            Total();
        }


        private void Total()
        {
            if (System.IO.File.Exists("File1") && System.IO.File.Exists("File2"))
            {
                OpenFileDialog load = new OpenFileDialog();
                OpenFileDialog load1 = new OpenFileDialog();

                load.AddExtension.Equals(".sav1");
                load.FileName = "File1";

                load1.AddExtension.Equals(".sav1");
                load1.FileName = "File2";

                StreamReader open = new StreamReader(load.FileName);
                StreamReader open1 = new StreamReader(load1.FileName);

                string obj = File.ReadAllText(load.FileName);
                string obj1 = File.ReadAllText(load1.FileName);

                double x = Double.Parse(obj);
                double y = Double.Parse(obj1);
                double result = y - x;
                txtTotalGasto.Text = result.ToString();
                

                open.Close();
                open1.Close();
            }
        }

        //*limpia los campos text box-------------------------------------------------------------------------------------------------------------
        private void Clean()
        {
            if (txtValor.TextLength > 0 && txtNombre.TextLength > 0)
            {
                txtNombre.Text = "";
                txtValor.Text = "";
                ltbNombre.SelectedIndex = -1;
                ltbValor.SelectedIndex = -1;
                txtNombre.Focus();
            }
            else
            {
                Reset();
            }
        }

        //Guarda el texto en el textbox a la listview y guarda todo en el save------------------------------------------------------------------
        private void Save()
        {
            int Nombre, Valor;
            Nombre = ltbNombre.SelectedIndex;
            Valor = ltbNombre.SelectedIndex;
            if (txtNombre.TextLength > 0 && txtValor.TextLength > 0)
            {
                if (ltbNombre.SelectedIndex == -1)
                {
                    ltbNombre.Items.Add(txtNombre.Text);
                    ltbValor.Items.Add(txtValor.Text);
                }
                if (Nombre >= 0 && Nombre < ltbNombre.Items.Count && Valor == Nombre)
                {
                    ltbValor.Items[Valor] = txtValor.Text;
                    ltbNombre.Items[Nombre] = txtNombre.Text;

                    double result = 0, x = 0, z = 0;
                    z = Convert.ToDouble(txtValor.Text);
                    x = Convert.ToDouble(ltbValor.Items[Nombre].ToString());
                    result = Convert.ToDouble(txtSubtotalGasto.Text);
                    if (x > z)
                    {
                        result = result - (x - z);
                        txtSubtotalGasto.Text = result.ToString();
                    }
                }
            }
            Create_Save();
            Reset();
        }

        //borra la lista seleccionada--------------------------------------------------------------------------------------
        private void Delete()
        {
            int Nombre, Valor;
            Nombre = ltbNombre.SelectedIndex;
            Valor = ltbValor.SelectedIndex;

            if (Nombre >= 0 && Nombre < ltbNombre.Items.Count)
            {
                Valor = Nombre;
                if (Nombre >= 0 && Nombre < ltbNombre.Items.Count)
                {
                    double result = 0, x = 0, z = 0;

                    ltbNombre.Items.RemoveAt(ltbNombre.SelectedIndex);
                    z = Convert.ToDouble(txtSubtotalGasto.Text);
                    x = Convert.ToDouble(ltbValor.Items[Nombre].ToString());
                    result = x - z;
                    txtSubtotalGasto.Text = result.ToString();
                    ltbValor.Items.RemoveAt(Nombre);
                }
            }
            Create_Save();
            Reset();
        }

        //Exporta a otro archivo save, 01_SaveFinancias + fecha-----------------------------------------------------------
        private void Export()
        {
            DateTime date = DateTime.Now;
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension.Equals(".sav1");
            save.FileName = "01_SaveFinancias_gastos" +  date.ToString("yyyy-MM--dd");
            StreamWriter stw = new StreamWriter(save.FileName);
                    stw.WriteLine("||=============================================================================================================||");
                    stw.WriteLine("||===============================================Resumen de Ganancia==============================================||");
                    stw.WriteLine("||                                                                                                             \t\t\t\t\t\t\t\t\t||");
                    stw.WriteLine("||                                                                                                             \t\t\t\t\t\t\t\t\t||");
                    stw.WriteLine("||=============================================================================================================||");
                    stw.WriteLine("||                                                ||\tNombre\t\t\t||\t\t\tValor de la Duda\t\t\t||");
                    stw.WriteLine("||=============================================================================================================||");
                for (int i = 0; i <= ltbNombre.Items.Count-1; i++)
                {
                    if (ltbNombre.Items[i].ToString().Length <= 4 && ltbNombre.Items[i].ToString().Length >= 1)
                    {
                        if (ltbNombre.Items[i].ToString().Length == 3 || ltbNombre.Items[i].ToString().Length == 4)
                        {
                            stw.WriteLine("||                                                ||" + ltbNombre.Items[i].ToString() + "\t\t\t\t\t\t" + ltbValor.Items[i].ToString() + "    ");
                        }
                        else if (ltbNombre.Items[i].ToString().Length == 1 || ltbNombre.Items[i].ToString().Length == 2)
                        {
                            stw.WriteLine("||                                                ||" + ltbNombre.Items[i].ToString() + "\t\t\t\t\t\t\t" + ltbValor.Items[i].ToString() + "    ");
                        }
                    }
                    else if (ltbNombre.Items[i].ToString().Length <= 7 && ltbNombre.Items[i].ToString().Length > 4)
                    {
                        stw.WriteLine("||                                                ||" + ltbNombre.Items[i].ToString() + "\t\t\t\t\t\t" + ltbValor.Items[i].ToString() + "    ");
                    }
                    else if (ltbNombre.Items[i].ToString().Length <= 10 && ltbNombre.Items[i].ToString().Length > 7)
                    {
                        stw.WriteLine("||                                                ||" + ltbNombre.Items[i].ToString() + "\t\t\t\t\t\t" + ltbValor.Items[i].ToString() + "    ");
                    }
                    else if (ltbNombre.Items[i].ToString().Length > 10 && ltbNombre.Items[i].ToString().Length < 16)
                    {

                        stw.WriteLine("||                                                ||" + ltbNombre.Items[i].ToString() + "\t\t\t\t\t" + ltbValor.Items[i].ToString() + "    ");
                    }
                }
                    stw.WriteLine("||=============================================================================================================||");
                    stw.WriteLine("||=============================================================================================================||");
                    stw.WriteLine("||                  SubTotal:\t\t\t\t\t\t" + txtSubtotalGasto.Text + "  ");
                    stw.WriteLine("||=============================================================================================================||");
                    stw.WriteLine("||=============================================================================================================||");
                    stw.WriteLine("||                  Total:\t\t\t\t\t\t" + txtTotalGasto.Text + "  ");
                    stw.WriteLine("||=============================================================================================================||");
                    stw.WriteLine("||=============================================================================================================||");
            stw.Close();

            /*DateTime date = DateTime.Now;

            SaveFileDialog save = new SaveFileDialog();
            SaveFileDialog save1 = new SaveFileDialog();

            save.AddExtension.Equals(".sav1");
            save.FileName = "01_SaveFinancias" +  date.ToString("yyyy-MM--dd");

            save1.AddExtension.Equals(".sav1");
            save1.FileName = "02_SaveFinancias" + date.ToString("yyyy-MM--dd");

            StreamWriter stw = new StreamWriter(save.FileName);
            StreamWriter stw1 = new StreamWriter(save1.FileName);


            foreach (object file in ltbNombre.Items)
            {
                stw.WriteLine(file.ToString());
            }
            foreach (object file1 in ltbValor.Items)
            {
                stw1.WriteLine(file1.ToString());
            }
            stw.Close();
            stw1.Close();*/
            for (int i = ltbNombre.Items.Count - 1; i != -1; i--)
            {
                ltbNombre.Items.RemoveAt(i);
                ltbValor.Items.RemoveAt(i);
            }
            txtSubtotalGasto.Text = "0";
            txtTotalGasto.Text = "0";
            txtValor.Text = "";
            txtNombre.Text = "";
            Create_Save();
        }

        //Selecciona dos campos sincronizados, es decir a la vez, ltbNombre en conjunto a ltbValor----------------
        private void Selection()
        {
            int Nombre, Valor;
            Nombre = ltbNombre.SelectedIndex;
            Valor = ltbValor.SelectedIndex;
            if (Nombre >= 0 && Nombre < ltbNombre.Items.Count)
            {
                txtNombre.Text = ltbNombre.Items[Nombre].ToString();
                Valor = Nombre;
            }
            if (Valor >= 0 && Valor < ltbValor.Items.Count)
            {
               txtValor.Text = ltbValor.Items[Valor].ToString();
            }
        }


        //evita el click al ltbValor----------------------------------------------------------------------------
        private void No_Click()
        {
            if (ltbValor.SelectedIndex > -1)
            {
                ltbValor.SelectedIndex = -1;
            }
        }

        private void Close()
        {
            Application.Exit();
        }



        //aca empieza los eventos de botones----------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void ltbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selection();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void ltbValor_Click(object sender, EventArgs e)
        {
            No_Click();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                e.Handled = false;

            else
                e.Handled = true; 
        }

        private void frmFinanciasGanacia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void agendaDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinanciasGastosEnglish fm = new frmFinanciasGastosEnglish();
            fm.Visible = true;
            this.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = ltbNombre.Items.Count - 1; i != -1; i--)
            {
                ltbNombre.Items.RemoveAt(i);
                ltbValor.Items.RemoveAt(i);
            }
            double res = Double.Parse(txtSubtotalGasto.Text) + Double.Parse(txtTotalGasto.Text);
            txtTotalGasto.Text = res.ToString();
            txtSubtotalGasto.Text = "0";
            Create_Save();
            Reset();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnglish fm = new frmEnglish();
            fm.Visible = true;
            this.Visible = false;
        }

    }
}
