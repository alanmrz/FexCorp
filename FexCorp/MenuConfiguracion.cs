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
    public partial class MenuConfiguracion : Form
    {
        public MenuConfiguracion()
        {
            InitializeComponent();
        }

        private void MenuConfiguracion_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);

            SetearToolTips();
        }

        public void SetearToolTips()
        {
            this.TTSucursal.SetToolTip(btnSucursal, "Sucursal");
            this.TTHome.SetToolTip(btnHome, "Menú Principal");
            this.TTClientes.SetToolTip(btnClientes, "Clientes");
            this.TTSeguimiento.SetToolTip(btnSeguimiento, "Seguimiento");
            this.TTReportes.SetToolTip(btnReportes, "Reportes");
            this.TTEnvios.SetToolTip(btnEnvios, "Envios");
        }

        ////////////////////////////////////////////////////////////////CONFIGURACION BONTONES
        private void btnHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal frm = new MenuPrincipal();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnBk_Click(object sender, EventArgs e)
        {
            BackUp frm = new BackUp();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Restaurar frm = new Restaurar();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar frm = new Eliminar();
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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MenuReportes frm = new MenuReportes();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }
        /////////////////////////////////////////////////////////////////////////////////
    }
}
