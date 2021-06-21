using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PR_STORE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "SP_READ_Department";
            SqlConnection cnn = new SqlConnection("Data Source=localhost;Database=Tienda_JYM;Trusted_Connection=True;MultipleActiveResultSets=true");
            SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);
            cnn.Open();

            // Tabla auxiliar
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtDeparrtamento.Text = dt.Rows[0]["Name"].ToString();
            }
            else
            {
                MessageBox.Show("Codigo no existe");
                txtDeparrtamento.Clear();
                txtId.Clear();
            }
        }
    }
}
