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
    public partial class MenuSeguimiento : Form
    {
        public MenuSeguimiento()
        {
            InitializeComponent();
        }

        private void MenuSeguimiento_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);

            SetearTooTips();
        }

        public void SetearTooTips()
        {
            TTHome.SetToolTip(btnHome, "Menú Principal");
            TTEnvios.SetToolTip(btnEnvios, "Envios");
            TTSucursales.SetToolTip(btnSucursal, "Sucursales");
            TTClientes.SetToolTip(btnClientes, "Clientes");
            TTReportes.SetToolTip(btnReportes, "Reportes");
            TTConfig.SetToolTip(btnConfig, "Configuración");
        }

        ////////////////////////////////////////////////////////////////////////Configuraciones de botones

        private void btnHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal frm = new MenuPrincipal();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnUnEnvio_Click(object sender, EventArgs e)
        {
            SeguimientoEnvio frm = new SeguimientoEnvio();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnEstadoEnvios_Click(object sender, EventArgs e)
        {
            EstadoEnvios frm = new EstadoEnvios();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnModificarEst_Click(object sender, EventArgs e)
        {
            ModificarSeguimiento frm = new ModificarSeguimiento();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            MenuEnvios frm = new MenuEnvios();
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

        /////////////////////////////////////////////////////////////////////////////////////////////
    }
}
