using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmgSys
{
    public partial class Form1 : Form
    {
   
        private BindingSource bindingSource1 = new BindingSource();
        List<COper> lista_grida = new List<COper>();


        public Form1()
        {
         
            InitializeComponent();
         
            //operacje combobox
            string[] installs = new string[] { "+", "-", "*","/" };
            oper.Items.AddRange(installs);
            //kolumny grida
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Liczba1";
            dataGridView1.Columns[1].Name = "Liczba2";
            dataGridView1.Columns[2].Name = "Operacja";
            dataGridView1.Columns[3].Name = "Wynik";
            //lista
            

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
           
            OmgSys.ServiceReference1.CalculatorSoapClient soap = new OmgSys.ServiceReference1.CalculatorSoapClient();
            //credientale
            soap.ClientCredentials.UserName.UserName = "admin";
            soap.ClientCredentials.UserName.Password = "admin";

            
           
            int userVal = 0;
            int userVal2 = 0;
            int wynik = 0;
            try {
                int.TryParse(numer1.Text, out userVal);
                int.TryParse(numer2.Text, out userVal2);
            }
            catch { MessageBox.Show("Nie rozpoznano liczb"); }

            if (oper.Text == "+")
                wynik = soap.Add(userVal, userVal2);
            else if (oper.Text == "-" || oper.Text == "_")
                wynik = soap.Subtract(userVal, userVal2);
            else if (oper.Text == "*")
                wynik = soap.Multiply(userVal, userVal2);
            else if (oper.Text == "/")
                wynik = soap.Divide(userVal, userVal2);
            else
                MessageBox.Show("Nienzana operacja");

            //Dodanie do grida
            COper cop = new COper(userVal, userVal2, oper.Text,wynik);
            lista_grida.Add(cop);



            try
            {
                //dataGridView1.Rows.Add(cop);
                string[] row0 = { userVal.ToString(), userVal2.ToString(), oper.Text, wynik.ToString() };

                dataGridView1.Rows.Add(row0);


            }
            catch { MessageBox.Show("Błąd dodania obiektu"); }


            responseBox.Text = wynik.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var directory = Environment.CurrentDirectory;
            string strDate = DateTime.Now.ToString("MM_dd_yyyy");

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "XML(*.xml)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    try
                    {
                        //Serializacja
                        System.Xml.Serialization.XmlSerializer serializer =
                        new System.Xml.Serialization.XmlSerializer(typeof(List<COper>));

                        TextWriter writer = new StreamWriter(directory + "/Dane" + strDate + ".xml");
                        serializer.Serialize(writer, lista_grida);

                        //zamykam  i wysylam plik xml
                        writer.Close();
                    }
                    catch
                    { MessageBox.Show("Błąd generowania pliku"); }
                    myStream.Close();
                }
            }

        
        }
    }
}
