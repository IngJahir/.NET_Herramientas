using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            CRUD_Deparment oCRUD_Deparment = new CRUD_Deparment();
            dataGridView1.DataSource = oCRUD_Deparment.READ_Department();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNuevo frmNuevo = new FrmNuevo();
            frmNuevo.ShowDialog();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                FrmNuevo frmEdit = new FrmNuevo(Id);
                frmEdit.ShowDialog();
                Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            try
            {
                if (Id != null)
                {
                    CRUD_Deparment oCRUD_Deparment = new CRUD_Deparment();
                    oCRUD_Deparment.DELETE_Department((int)Id);
                    Refresh();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrio un error al eliminar: "+ ex.Message);
            }
            
        }

        #region HELPER
        private int? GetId() 
        {
            try
            {
                return int.Parse(
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                );
            }
            catch (Exception)
            {
                return null;
            }
            
            
        }

        
        #endregion







        //private void button1_Click(object sender, EventArgs e)
        //{
        //    CRUD_Deparment deparment = new CRUD_Deparment();

        //    if (deparment.Confirmar_conexion())
        //        MessageBox.Show("Coneccion exitosa !!!");
        //    else
        //        MessageBox.Show("Sin coneccion");
        //}
    }
}
