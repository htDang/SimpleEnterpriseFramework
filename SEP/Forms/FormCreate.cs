﻿using SEP.Data.Common;
using SEP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEP.Forms
{
    public partial class FormCreate : FormBase
    {
        public FormCreate(ISEPDataRow row) :base(row)
        {
            this.InitializeFormContent("Add New Row", "Add");
        }

        public override string InitTextBoxContent(object value) => "";
    }
}
