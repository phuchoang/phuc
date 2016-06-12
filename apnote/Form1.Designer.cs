namespace apnote
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listview = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listview)).BeginInit();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.BackgroundColor = System.Drawing.Color.Yellow;
            this.listview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listview.Location = new System.Drawing.Point(-1, 33);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(284, 227);
            this.listview.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(13, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btndele
            // 
            this.btndele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndele.BackgroundImage")));
            this.btndele.Location = new System.Drawing.Point(191, 3);
            this.btndele.Name = "btndele";
            this.btndele.Size = new System.Drawing.Size(75, 23);
            this.btndele.TabIndex = 2;
            this.btndele.Text = "Delete";
            this.btndele.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btndele);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.listview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listview;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndele;
    }
}

