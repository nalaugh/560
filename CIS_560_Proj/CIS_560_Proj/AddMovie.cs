﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_560_Proj
{
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
            this.listBoxOptoins.Items.Add("Actor");
            this.listBoxOptoins.Items.Add("Director");
        }

   
    }
}
