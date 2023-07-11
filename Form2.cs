using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace TugasAkhir_C4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDepart_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Departement VALUES(" + textboxNameDepart.Text + ",'" + textboxIdDepart.Text + "','" + textboxSumDepart.Text + "','" + textboxAddressDepart.Text + "')";
                //SqlCommand command = new
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
