using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apnote
{
    public partial class Form3 : Form
    {
        public Form3(string note)
        {
            InitializeComponent();
            ac = new dataEntities();
            noe = ac.nots.Single(st=>st.note==note);          
        }
        dataEntities ac;
        private not noe;
        void btnSave_Click(object sender, EventArgs e)
        {
            noe = new not();
            noe.note = this.txtnote.Text;
            ac.nots.Add(noe);
            ac.SaveChanges();
            this.Close();
            MessageBox.Show("successfully!");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.txtnote.Text = noe.note;
            this.btnSave.Click+=btnSave_Click;
        }
    }
}
