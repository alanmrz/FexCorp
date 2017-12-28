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
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void MenuClientes_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);

            SetearToolTips();
        }

        public void SetearToolTips()
        {
            TTHome.SetToolTip(btnHome, "Menú Principal");
            TTEnvios.SetToolTip(btnEnvios, "Envios");
            TTSucusales.SetToolTip(btnSucursal, "Sucursales");
            TTReportes.SetToolTip(btnReportes, "Reportes");
            TTConfig.SetToolTip(btnConfig, "Configuración");
            TTSeguimiento.SetToolTip(btnSeguimiento, "Seguimiento");
        }

        //////////////////////////////////////////////////////////////////Configuracion de los botones
        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente frm = new EliminarCliente();
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

        private void btnListaTodos_Click(object sender, EventArgs e)
        {
            ListarClientes frm = new ListarClientes();
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
        //////////////////////////////////////////////////////////////////////////////////
    }
}
