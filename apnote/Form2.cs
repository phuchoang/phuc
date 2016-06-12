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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.btnSave.Click += btnSave_Click;

        }
      
        void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        void Save()
        {
            dataEntities db = new dataEntities();
            not noe = new not();
            noe.note = this.txtnote.Text;
            db.nots.Add(noe);
            db.SaveChanges();
            this.Close();
            MessageBox.Show("successfully!");
          
        }
    }
}
