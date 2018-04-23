using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;

namespace PasteData {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();

            gridControl1.DataSource = DataHelper.GetData(10);
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Append;
        }
        private void OnButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e) {
            if (e.Button.Properties.Caption == "Copy") {
                gridView1.CopyToClipboard();
            }
            if (e.Button.Properties.Caption == "Paste") {
                gridView1.PasteFromClipboard();
            }
        }
    }
}
