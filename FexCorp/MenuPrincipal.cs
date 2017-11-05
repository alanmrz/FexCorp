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
            frm.Show();
            this.Close();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            MenuSucursal mSucu = new MenuSucursal();
            mSucu.MdiParent = this.ParentForm;            
            mSucu.Show();
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MenuClientes mClientes = new MenuClientes();
            mClientes.MdiParent = this.ParentForm;
            mClientes.Show();
            this.Close();
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            MenuSeguimiento mSeguimiento = new MenuSeguimiento();
            mSeguimiento.MdiParent = this.ParentForm;
            mSeguimiento.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MenuReportes mReportes = new MenuReportes();
            mReportes.MdiParent = this.ParentForm;
            mReportes.Show();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            MenuConfiguracion mConfig = new MenuConfiguracion();
            mConfig.MdiParent = this.ParentForm;
            mConfig.Show();
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);
        }
    }
}
