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
    public partial class Utilizador : Form
    {
        Thread th;
        public Utilizador()
        {
            InitializeComponent();
        }
        public void openMenu(object obj)
        {
            Application.Run(new SmartBooks());
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");
            SqlCommand storeProcedureCommand = new SqlCommand("addCodigoPostal", conn);
            SqlCommand storeProcedureCommandUser = new SqlCommand("addUserType", conn);


            SqlCommand cmd = new SqlCommand("insert into [USER](USERTYPEID, Nome, Rua, CodigoPostal, Email, PassWord, ContactoID) values (@USERTYPEID, @Nome, @Rua, @CodigoPostal, @Email, @PassWord, @ContactoID)", conn);

            string usertypeID = "0";
            string Descriçao = "";


            if (usertype.Text == "Administrador")
            {
                usertypeID = "0";
                Descriçao = "Administrador da Base de Dados";
            }
            else if (usertype.Text == "Vendedor")
            {
                usertypeID = "1";
                Descriçao = "Vendedor da Livraria";
            }
            else if (usertype.Text == "Cliente")
            {
                usertypeID = "2";
                Descriçao = "Cliente da Livraria";
            }


            cmd.Parameters.AddWithValue("@USERTYPEID", usertypeID);
            cmd.Parameters.AddWithValue("@Nome", txt_nome1.Text);
            cmd.Parameters.AddWithValue("@Rua", txt_rua1.Text);
            cmd.Parameters.AddWithValue("@CodigoPostal", int.Parse(txt_CP.Text));
            cmd.Parameters.AddWithValue("@Email", txt_email1.Text);
            cmd.Parameters.AddWithValue("@PassWord", txt_pass1.Text);
            cmd.Parameters.AddWithValue("@ContactoID", txt_contacto.Text);
            conn.Open();

            storeProcedureCommandUser.CommandType = System.Data.CommandType.StoredProcedure;
            storeProcedureCommandUser.Parameters.Add(new SqlParameter("@ID", int.Parse(usertypeID)));
            storeProcedureCommandUser.Parameters.Add(new SqlParameter("@TypeName", usertype.Text));
            storeProcedureCommandUser.Parameters.Add(new SqlParameter("@Descriçao", Descriçao));
            storeProcedureCommandUser.ExecuteNonQuery();

            storeProcedureCommand.CommandType = System.Data.CommandType.StoredProcedure;
            storeProcedureCommand.Parameters.Add(new SqlParameter("@cp", int.Parse(txt_CP.Text)));
            storeProcedureCommand.Parameters.Add(new SqlParameter("@loc", txt_loc.Text));
            storeProcedureCommand.ExecuteNonQuery();

           

            

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            string usertypeID = "0";
            string Descriçao = "";


            if (usertype.Text == "Administrador")
            {
                usertypeID = "0";
                Descriçao = "Administrador da Base de Dados";
            }
            else if (usertype.Text == "Vendedor")
            {
                usertypeID = "1";
                Descriçao = "Vendedor da Livraria";
            }
            else if (usertype.Text == "Cliente")
            {
                usertypeID = "2";
                Descriçao = "Cliente da Livraria";
            }

            con.Open();

            SqlCommand cmd = new SqlCommand("Update [USER] set USERTYPEID=@USERTYPEID, Nome=@Nome,Rua=@Rua, CodigoPostal=@CodigoPostal,Email= @Email, PassWord=@PassWord, ContactoID=@ContactoID where ID = @ID", con);
            

            cmd.Parameters.AddWithValue("@ID", int.Parse(txt_id.Text));
            cmd.Parameters.AddWithValue("@USERTYPEID", usertype.Text);
            cmd.Parameters.AddWithValue("@Nome", txt_nome1.Text);
            cmd.Parameters.AddWithValue("@Rua", txt_rua1.Text);
            cmd.Parameters.AddWithValue("@CodigoPostal", int.Parse(txt_CP.Text));
            cmd.Parameters.AddWithValue("@Email", txt_email1.Text);
            cmd.Parameters.AddWithValue("@PassWord", txt_pass1.Text);
            cmd.Parameters.AddWithValue("@ContactoID", txt_contacto.Text);


            SqlCommand storeProcedureCommand = new SqlCommand("addCodigoPostal", con);
            SqlCommand storeProcedureCommandUser = new SqlCommand("addUserType", con);

            storeProcedureCommandUser.CommandType = System.Data.CommandType.StoredProcedure;
            storeProcedureCommandUser.Parameters.Add(new SqlParameter("@ID", int.Parse(usertypeID)));
            storeProcedureCommandUser.Parameters.Add(new SqlParameter("@TypeName", usertype.Text));
            storeProcedureCommandUser.Parameters.Add(new SqlParameter("@Descriçao", Descriçao));
            storeProcedureCommandUser.ExecuteNonQuery();


            storeProcedureCommand.CommandType = System.Data.CommandType.StoredProcedure;
            storeProcedureCommand.Parameters.Add(new SqlParameter("@cp", int.Parse(txt_CP.Text)));
            storeProcedureCommand.Parameters.Add(new SqlParameter("@loc", txt_loc.Text));
            storeProcedureCommand.ExecuteNonQuery();






            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete [USER] where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txt_id.Text));
            cmd.ExecuteNonQuery();



            con.Close();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K463369;Initial Catalog=SmartBooksDB;Integrated Security=True;Pooling=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [USER]", con);
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

        private void Utilizador_Load(object sender, EventArgs e)
        {

        }
    }
}
