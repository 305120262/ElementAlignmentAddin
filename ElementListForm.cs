using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementAlignmentAddin
{
    internal delegate void AlignElementDelegate(string name, string h, string v,string hDirection,string vDirection); 

    public partial class ElementListForm : Form
    {
        internal AlignElementDelegate AlignHandler;

        public ElementListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlignHandler(listElement.Text,tbxH.Text,tbxV.Text,cbxHDirection.Text,cbxVDirection.Text);
        }

        public void AddItem(string i)
        {
             listElement.Items.Add(i);
        }
    }
}
