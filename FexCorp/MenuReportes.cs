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
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void MenuReportes_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);

            SetearToolTips();
        }

        public void SetearToolTips()
        {
            this.TTSucursales.SetToolTip(btnSucursal, "Sucursal");
            this.TTHome.SetToolTip(btnHome, "Menú Principal");
            this.TTClientes.SetToolTip(btnClientes, "Clientes");
            this.TTEnvios.SetToolTip(btnEnvios, "Envios");
            this.TTSeguimiento.SetToolTip(btnSeguimiento, "Seguimiento");
            this.TTConfig.SetToolTip(btnConfig, "Configuración");

        }

        ////////////////////////////////////////////////////////////////////Configuracion botones
        private void btnHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal frm = new MenuPrincipal();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnRep1_Click(object sender, EventArgs e)
        {
            Reporte_1 frm = new Reporte_1();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnRep2_Click(object sender, EventArgs e)
        {
            Reporte_2 frm = new Reporte_2();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnRep3_Click(object sender, EventArgs e)
        {
            Reporte_3 frm = new Reporte_3();
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

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            MenuSeguimiento frm = new MenuSeguimiento();
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
        ///////////////////////////////////////////////////////////////////////////////////
    }
}
