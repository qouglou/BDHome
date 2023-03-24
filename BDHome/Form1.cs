using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDHome
{
    //EXEC [dbo].[wrong_procedure] @Name = Kek, @Lname = Wait, @phone = 123
    public partial class Form1 : Form
    {
        static string ConnectString = @"Server=(local)\SQLEXPRESS;Persist Security Info=False;Integrated Security=true;Initial Catalog=GlobinAuthors;";
        SqlConnection myConnection = new SqlConnection(ConnectString);

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonCodeProcedure_Click(object sender, EventArgs e)
        {
            tableBD.DataSource = null;
            tableBD.Rows.Clear();
            DataSet ds = new DataSet();
            string commandtext = "SELECT * FROM authors WHERE au_lname = ISNULL(@Name, au_lname) " +
                "AND au_fname = ISNULL(@Lname, au_fname)";
            SqlCommand commandwithparam = new SqlCommand(commandtext, myConnection);
            commandwithparam.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox1.Text;
            commandwithparam.Parameters.Add("@Lname", SqlDbType.VarChar).Value = textBox2.Text;
            StringBuilder errorMessages = new StringBuilder();
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {
                SqlCommand command = new SqlCommand(commandtext, connection);
                try
                {
                    command.Connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(commandwithparam);
                    adapter.Fill(ds);
                    tableBD.DataSource = ds.Tables[0];
                    myConnection.Close();
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    textBoxError.Text = errorMessages.ToString();
                    MessageBox.Show(errorMessages.ToString(), "Exceptions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBoxError.Text = "Ошибок нет";
            }
        }

        private void buttonSavedProcedure_Click(object sender, EventArgs e)
        {
            tableBD.DataSource = null;
            tableBD.Rows.Clear();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("[dbo].[selectdata]", myConnection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = textBox2.Text;

            myConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            tableBD.DataSource = ds.Tables[0];
            myConnection.Close();
            textBoxError.Text = "Ошибок нет";
        }

        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
            tableBD.DataSource = null;
            tableBD.Rows.Clear();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("[dbo].[selectdata]", myConnection);
            myConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            tableBD.DataSource = ds.Tables[0];
            myConnection.Close();
            textBoxError.Text = "Ошибок нет";
        }

        private void buttonWrongSavedProcedure_Click(object sender, EventArgs e)
        {
            tableBD.DataSource = null;
            tableBD.Rows.Clear();
            DataSet ds = new DataSet();
            string commandtext = "INSERT INTO authors values (1)";
            SqlCommand commandwithparam = new SqlCommand(commandtext, myConnection);
            StringBuilder errorMessages = new StringBuilder();
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {
                SqlCommand command = new SqlCommand(commandtext, connection);
                try
                {
                    command.Connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(commandwithparam);
                    adapter.Fill(ds);
                    tableBD.DataSource = ds.Tables[0];
                    myConnection.Close();

                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    textBoxError.Text = errorMessages.ToString();
                    MessageBox.Show(errorMessages.ToString(), "Exceptions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void buttonWrongCodeProcedure_Click(object sender, EventArgs e)
        {
            tableBD.DataSource = null;
            tableBD.Rows.Clear();
            DataSet ds = new DataSet();
            StringBuilder errorMessages = new StringBuilder();
            using (SqlConnection connection = new SqlConnection(ConnectString))
            {
                SqlCommand command = new SqlCommand("[dbo].[wrong_procedure]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@phone", SqlDbType.Char).Value = "123";
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = "KEK";
                command.Parameters.Add("@Lname", SqlDbType.VarChar).Value = "Wait";
                try
                {
                    command.Connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    tableBD.DataSource = ds.Tables[0];
                    myConnection.Close();

                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    textBoxError.Text = errorMessages.ToString();
                    MessageBox.Show(errorMessages.ToString(), "Exceptions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            tableBD.DataSource = null;
            tableBD.Rows.Clear();
            DataSet ds = new DataSet();
            string commandtext = textBoxQuery.Text;
            SqlCommand commandwithparam = new SqlCommand(commandtext, myConnection);
            StringBuilder errorMessages = new StringBuilder();
            using (SqlConnection connection = new SqlConnection(ConnectString))
                if (textBoxQuery.Text != "" || textBoxQuery.Text != "")
                {
                    SqlCommand command = new SqlCommand(commandtext, connection);
                    try
                    {
                        command.Connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(commandwithparam);
                        adapter.Fill(ds);
                        tableBD.DataSource = ds.Tables[0];
                        myConnection.Close();

                    }
                    catch (SqlException ex)
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)
                        {
                            errorMessages.Append("Index #" + i + "\n" +
                                "Message: " + ex.Errors[i].Message + "\n" +
                                "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                "Source: " + ex.Errors[i].Source + "\n" +
                                "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        textBoxError.Text = errorMessages.ToString();
                        MessageBox.Show(errorMessages.ToString(), "Exceptions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    textBoxError.Text = errorMessages.ToString();
                    MessageBox.Show("Введите запрос", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
    }
}