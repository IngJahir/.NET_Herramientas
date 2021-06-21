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
    public partial class FrmNuevo : Form
    {
        private int? Id;

        public FrmNuevo(int? Id=null)
        {
            InitializeComponent();
            this.Id = Id;

            if (this.Id != null)
                LoadData();
        }

        private void LoadData() 
        {
            CRUD_Deparment oCRUD_Deparment = new CRUD_Deparment();
            Department oDepartment = oCRUD_Deparment.READ_Department((int)Id);
            tb_Depertamento.Text = oDepartment.Name;
            tb_Id_Depertamento.Text = oDepartment.Id_Depertment.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD_Deparment oCRUD_Deparment = new CRUD_Deparment();
            try
            {
                if (Id == null)
                    oCRUD_Deparment.CREATE_Deparment(tb_Depertamento.Text);
                else
                    oCRUD_Deparment.UPDATE_Deperment(tb_Depertamento.Text,(int)Id);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar"+ex.Message);
                
            }
        }
    }
}
