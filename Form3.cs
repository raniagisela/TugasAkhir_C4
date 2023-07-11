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
    public partial class Form3 : Form
    {
        DBConnect dBCon = new DBConnect();
        public Form3()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuery = "SELECT * FROM Pegawai";
            //SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //dataGridViewDepart.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Pegawai VALUES(" + textboxNameEmploy.Text + ",'" + textboxIdEmploy.Text + "','" + textboxPosition.Text + "','" + textboxAddressEmploy.Text + "','" + textboxTelpEmploy.Text + "')";
                //SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                //dBCon.OpenCon();
                //command.ExecuteNonQuery();
                MessageBox.Show("Departement Added Successfully!", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dBCon.CloseCon();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (textboxIdEmploy.Text == "" || textboxNameEmploy.Text == "" || textboxPosition.Text == "" || textboxAddressEmploy.Text == "" || textboxTelpEmploy.Text == "")
                {
                    MessageBox.Show("Missing Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string updateQuery = "UPDATE Pegawai SET nama_pegawai='" + textboxNameEmploy.Text + "'id_pegawai='" + textboxIdEmploy + "'jabatan_pegawai='" + textboxPosition + "'alamat_pegawai='" + textboxAddressEmploy + "'no_telp='" + textboxTelpEmploy + " ";
                //SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                //dBCon.OpenCon();
                //command.ExecuteNonQuery();
                MessageBox.Show("Employee Updated Successfully!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewEmploy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEmploy_Click(object sender, EventArgs e)
        {
            textboxNameEmploy.Text = dataGridViewEmploy.SelectedRows[0].Cells[0].Value.ToString();
            textboxIdEmploy.Text = dataGridViewEmploy.SelectedRows[0].Cells[1].Value.ToString();
            textboxPosition.Text = dataGridViewEmploy.SelectedRows[0].Cells[2].Value.ToString();
            textboxAddressEmploy.Text = dataGridViewEmploy.SelectedRows[0].Cells[3].Value.ToString();
            textboxTelpEmploy.Text = dataGridViewEmploy.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void clear()
        {
            textboxNameEmploy.Clear();
            textboxIdEmploy.Clear();
            textboxPosition.Clear();
            textboxAddressEmploy.Clear();
            textboxTelpEmploy.Clear();
        }

        private void btnClearEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Departement WHERE nama_pegawai='" + textboxNameEmploy.Text + "'id_pegawai='" + textboxIdEmploy + "'jabatan_pegawai='" + textboxPosition + "'alamat_pegawai='" + textboxAddressEmploy + "'no_telp='" + textboxTelpEmploy + " ";
                //SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                //dBCon.OpenCon();
                //command.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Successfully!", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
