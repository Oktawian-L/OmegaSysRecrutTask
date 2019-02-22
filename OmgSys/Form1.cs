using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmgSys
{
    public partial class Form1 : Form
    {
   
        private BindingSource bindingSource1 = new BindingSource();


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

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
           // this.output.Text = "Odpytywanie webserwisu...";
            OmgSys.ServiceReference1.CalculatorSoapClient soap = new OmgSys.ServiceReference1.CalculatorSoapClient();
            //credientale
            soap.ClientCredentials.UserName.UserName = "admin";
            soap.ClientCredentials.UserName.Password = "admin";

            //int userVal = int.Parse(numer1.Text);
           
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
           
          
            try
            {
                //dataGridView1.Rows.Add(cop);
                string[] row0 = { userVal.ToString(), userVal2.ToString(), oper.Text, wynik.ToString() };

                dataGridView1.Rows.Add(row0);

            }
            catch { MessageBox.Show("Błąd dodania obiektu"); }


            //int wynik = Int32.Parse(numer1.Text) + Int32.Parse(numer2.Text);
            //int wynik = soap.Add(userVal, userVal2);
            //int wynik = 1 + 2;
            responseBox.Text = wynik.ToString();

            //example insrt
            /*
             * odpwoiedz przechwytywana do short descrption
             */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void oblicz_buton_Click(object sender, EventArgs e)
        {

        }

        private void handle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
           {
                //Serializacja
                System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(OmgSys.COper));
                COper cop2 = new COper(1, 2, "+", 3);
                TextWriter writer = new StreamWriter(@".\" + DateTime.Now.ToString() + "_.xml");
                serializer.Serialize(writer, cop2);

                //zamykam  i wysylam plik xml
                writer.Close();
            }
            catch
            { MessageBox.Show("Błąd generowania pliku"); }
        }
    }
}
