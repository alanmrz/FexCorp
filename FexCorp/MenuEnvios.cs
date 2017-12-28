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
    public partial class MenuEnvios : Form
    {
        public MenuEnvios()
        {
            InitializeComponent();
        }


        private void MenuEnvios_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);

            SetearToolTip();
        }

        public void SetearToolTip()
        {
            TTHome.SetToolTip(btnHome, "Menú Principal");
            TTClientes.SetToolTip(btnClientes, "Clientes");
            TTReportes.SetToolTip(btnReportes, "Reportes");
            TTConfig.SetToolTip(btnConfig, "Configuración");
            TTSeguimiento.SetToolTip(btnSeguimiento, "Seguimiento");
            TTSucursales.SetToolTip(btnSucursal, "Sucursales");
        }

        ///////////////////////////////////////////////////////////////Configuracion de botones

        private void btnNuevoEnvio_Click(object sender, EventArgs e)
        {
            NuevoEnvio frm = new NuevoEnvio();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnListaTodos_Click(object sender, EventArgs e)
        {
            ListarEnvios frm = new ListarEnvios();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarEnvio frm = new ModificarEnvio();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal frm = new MenuPrincipal();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            MenuSucursal frm = new MenuSucursal();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MenuClientes frm = new MenuClientes();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            MenuSeguimiento frm = new MenuSeguimiento();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MenuReportes frm = new MenuReportes();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            MenuConfiguracion frm = new MenuConfiguracion();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }
        //////////////////////////////////////////////////////////////////////////////
    }
}
