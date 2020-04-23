using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=IBTCOLLEGE.mssql.somee.com;Initial Catalog=IBTCOLLEGE;User ID=ibtcollege_SQLLogin_1;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO dbo.Teams (TeamId,TeamName,CoachName,DirectorName,AddressLine1,AddressLine2,PostCode,City,ContactNumber,EmailAddress,CreatedBy) " +
                "VALUES ('" + txtTeamId.Text + "','" + txtTeamName.Text + "','" + txtCoachName.Text + "','" + txtDirectorName.Text + "','" + txtAddressLine1.Text + "','" + txtAddressLine2.Text + "','" + txtPostCode.Text + "','" + txtCity.Text + "','" + txtContactNumber.Text + "','" + txtEmailAddress.Text + "','" + txtCreatedBy.Text + "',)";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESFULLY !!!!");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM dbo.Students";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE dbo.Teams SET TEAMID = '" + txtTeamId.Text + "', TeamName = '" + txtTeamName.Text + "', CoachName = '" + txtCoachName.Text + "', DirectorName = '" + txtDirectorName.Text + "', AddressLine1 = '" + txtAddressLine1.Text + "', AddressLine2 = '" + txtAddressLine2.Text + "', PostCode = '" + txtPostCode.Text + "', City = '" + txtCity.Text + "', ContactNumber = '" + txtContactNumber.Text + "', EmailAddress = '" + txtEmailAddress.Text + "', CreatedBy = '" + txtCreatedBy.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            con.Close();
            MessageBox.Show("UPDATION SUCCESFULLY !!!");

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTeamId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtTeamName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtCoachName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtDirectorName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtAddressLine1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtAddressLine1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtPostCode.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtCity.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtContactNumber.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtEmailAddress.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtCreatedBy.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
