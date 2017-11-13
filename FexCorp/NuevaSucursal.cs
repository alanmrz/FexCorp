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
    public partial class NuevaSucursal : Form
    {
        public NuevaSucursal()
        {
            InitializeComponent();
        }

        private void NuevaSucursal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal frm = new MenuPrincipal();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }
    }
}
