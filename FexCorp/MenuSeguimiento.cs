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
        }

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
    }
}
