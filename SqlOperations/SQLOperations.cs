using Microsoft.Data.SqlClient;
using System.Data;
namespace SqlOperations
{
    public partial class SQLOperations : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=KD\SQLEXPRESS;Initial Catalog=Demo_database;User ID=LogDemo;Password=root;Encrypt=False");
        public SQLOperations()
        {
            InitializeComponent();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "Select * from staff";
                SqlCommand cmd = new SqlCommand(query, conn);
                
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0) {
                    table1.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Table is empty or You dont have " +
                        "Permissionn to access the data!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }

        }

        private void buttonview_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "Select * from demo_view_student";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    table1.DataSource = dt;
                    
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            finally { conn.Close(); }

        }

        private void buttonprocedure_Click(Object sender, EventArgs s)
        {
            try
            {
                conn.Open();
                String query = "exec demo_teacher ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    table1.DataSource = dt;

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally { conn.Close(); }

        }
    }
}
