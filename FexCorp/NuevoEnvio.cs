﻿using System;
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
    public partial class NuevoEnvio : Form
    {
        public NuevoEnvio()
        {
            InitializeComponent();
        }

        private void NuevoEnvio_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(768, 398);

            SetearToolTips();
        }

        public void SetearToolTips()
        {

        }

        //////////////////////////////////////////////////////////////CONFIGURACION BONTONES
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            NuevoEnvio2 frm = new NuevoEnvio2();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuEnvios frm = new MenuEnvios();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MenuEnvios frm = new MenuEnvios();
            frm.MdiParent = this.ParentForm;
            frm.Show();
            this.Close();
        }
        ///////////////////////////////////////////////////////////////////////////////////
    }
}
