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
    }
}
