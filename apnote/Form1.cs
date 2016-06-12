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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.load();
            this.btnadd.Click += btnadd_Click;
            this.btndele.Click += btndele_Click;
            this.listview.DoubleClick += listview_DoubleClick;
        }

        void listview_DoubleClick(object sender, EventArgs e)
        {
            if (listview.SelectedRows.Count == 1)
            {
                dataEntities db = new dataEntities();
                not noe = new not();
                var row = listview.SelectedRows[0];
                string cell = (string)row.Cells["note"].Value;
                Form3 a = new Form3(cell);
                a.ShowDialog();
                if(noe.note!=cell)
                {
                delete();
                }
                this.load();
            }

        }
  
       
         void delete()
        {
            if (listview.SelectedRows.Count == 1)
            {
                var row = listview.SelectedRows[0];
                string cell = (string)row.Cells["note"].Value;
                dataEntities db = new dataEntities();
                not noe = db.nots.Single(st => st.note == cell);
                db.nots.Remove(noe);
                db.SaveChanges();
                this.load();
            }
        }
        
        void btndele_Click(object sender, EventArgs e)
        {
            delete();
        }

        void btnadd_Click(object sender, EventArgs e)
        {
            Form2 b = new Form2();
            b.ShowDialog();
            this.load();
        }
        public void load()
        {
            dataEntities db = new dataEntities();
            this.listview.DataSource = db.nots.ToList();
        }
    }
}
