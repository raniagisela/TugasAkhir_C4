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
        DBConnect dBCon = new DBConnect();
        public Form2()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuery = "SELECT * FROM Departement";
            //SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //dataGridViewDepart.DataSource = table;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void btnAddDepart_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Departement VALUES(" + textboxNameDepart.Text + ",'" + textboxIdDepart.Text + "','" + textboxSumDepart.Text + "','" + textboxAddressDepart.Text + "')";
                //SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                //dBCon.OpenCon();
                //command.ExecuteNonQuery();
                MessageBox.Show("Departement Added Successfully!","Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dBCon.CloseCon();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveDepart_Click(object sender, EventArgs e)
        {
            try
            {
                if(textboxIdDepart.Text=="" || textboxNameDepart.Text=="" || textboxSumDepart.Text=="" || textboxAddressDepart.Text=="")
                {
                    MessageBox.Show("Missing Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string updateQuery = "UPDATE Departement SET nama_departement='" +textboxNameDepart.Text+ "'id_departement='" +textboxIdDepart+ "'jumlah_pegawai='" +textboxSumDepart+ "'alamat_departement='" +textboxAddressDepart+" ";
                //SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                //dBCon.OpenCon();
                //command.ExecuteNonQuery();
                MessageBox.Show("Departement Updated Successfully!","Update Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewDepart_Click(object sender, EventArgs e)
        {
            textboxNameDepart.Text = dataGridViewDepart.SelectedRows[0].Cells[0].Value.ToString();
            textboxIdDepart.Text = dataGridViewDepart.SelectedRows[0].Cells[1].Value.ToString();
            textboxSumDepart.Text = dataGridViewDepart.SelectedRows[0].Cells[2].Value.ToString();
            textboxAddressDepart.Text = dataGridViewDepart.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void clear()
        {
            textboxNameDepart.Clear();
            textboxIdDepart.Clear();
            textboxSumDepart.Clear();
            textboxAddressDepart.Clear();
        }

        private void btnClearDepart_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Departement WHERE nama_departement='" + textboxNameDepart.Text + "'id_departement='" + textboxIdDepart + "'jumlah_pegawai='" + textboxSumDepart + "'alamat_departement='" + textboxAddressDepart + " ";
                //SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                //dBCon.OpenCon();
                //command.ExecuteNonQuery();
                MessageBox.Show("Departement Deleted Successfully!", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            Form3 employee = new Form3();
            employee.Show();
            this.Hide();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            Form2 departement = new Form2();
            departement.Show();
            this.Hide();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Form4 cust = new Form4();
            cust.Show();
            this.Hide();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            Form5 prod = new Form5();
            prod.Show();
            this.Hide();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            Form6 supp = new Form6();
            supp.Show();
            this.Hide();
        }
    }
}
