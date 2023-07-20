using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace SmartBooks
{
    public partial class CodigoPostal : Form
    {
        Thread th;
        public CodigoPostal()
        {
            InitializeComponent();
        }
        public void openMenu(object obj)
        {
            Application.Run(new SmartBooks());
        }

        private void CodigoPostal_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("insert into CodigoPostal(CodigoPostal, Localidade) values (@CodigoPostal, @Localidade)", conn);

            conn.Open();

           
            cmd.Parameters.AddWithValue("@Localidade",txt_loc.Text);
            cmd.Parameters.AddWithValue("@CodigoPostal", int.Parse(txt_cp.Text));



            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            con.Open();

            SqlCommand cmd = new SqlCommand("Update CodigoPostal set CodigoPostal=@CodigoPostal, Localidade = @Localidade where CodigoPostal = @CodigoPostal", con);

         
            cmd.Parameters.AddWithValue("@CodigoPostal", int.Parse(txt_cp.Text));
            cmd.Parameters.AddWithValue("@Localidade", txt_loc.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete CodigoPostal where CodigoPostal = @CodigoPostal", con);
            cmd.Parameters.AddWithValue("@CodigoPostal", int.Parse(txt_cp.Text));
            cmd.ExecuteNonQuery();



            con.Close();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from CodigoPostal", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
