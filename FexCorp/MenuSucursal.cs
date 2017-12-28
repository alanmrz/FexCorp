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
    public partial class MenuSucursal : Form
    {
        public MenuSucursal()
        {
            InitializeComponent();
        }

        private void MenuSucursal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);

            SetearToolTIps();
        }

        public void SetearToolTIps()
        {
            TTHome.SetToolTip(btnHome, "Menú Principal");
            TTEnvios.SetToolTip(btnEnvios, "Envios");
            TTClientes.SetToolTip(btnClientes, "Clientes");
            TTReportes.SetToolTip(btnReportes, "Reportes");
            TTSeguimiento.SetToolTip(btnSeguimiento, "Seguimiento");
            TTConfig.SetToolTip(btnConfig, "Configuración");
        }

        ////////////////////////////////////////////////////////////Configuracion de lo botones
        private void btnHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal frm = new MenuPrincipal();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            EliminarSucursal frm = new EliminarSucursal();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnListaTodos_Click(object sender, EventArgs e)
        {
            ListarSucursales frm = new ListarSucursales();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnAgreSucursal_Click(object sender, EventArgs e)
        {
            NuevaSucursal frm = new NuevaSucursal();
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
        ///////////////////////////////////////////////////////////////////////
    }
}
