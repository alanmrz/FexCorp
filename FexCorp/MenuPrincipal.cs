using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FexCorp
{
    public partial class MenuPrincipal : Form
    {
             
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            MenuEnvios frm = new MenuEnvios();
            frm.MdiParent = this.ParentForm;           
            this.Close();
            frm.Show();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            MenuSucursal mSucu = new MenuSucursal();
            mSucu.MdiParent = this.ParentForm;            
            this.Close();
            mSucu.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MenuClientes mClientes = new MenuClientes();
            mClientes.MdiParent = this.ParentForm;
            this.Close();
            mClientes.Show();
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            MenuSeguimiento mSeguimiento = new MenuSeguimiento();
            mSeguimiento.MdiParent = this.ParentForm;
            this.Close();
            mSeguimiento.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MenuReportes mReportes = new MenuReportes();
            mReportes.MdiParent = this.ParentForm;
            this.Close();
            mReportes.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            MenuConfiguracion mConfig = new MenuConfiguracion();
            mConfig.MdiParent = this.ParentForm;
            this.Close();
            mConfig.Show();
        }
    }
}
