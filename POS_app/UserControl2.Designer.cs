namespace POS_app
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userControl1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nametxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantitytxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pricetxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userControl2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(323, 394);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Size = new System.Drawing.Size(125, 27);
            this.totalPrice.TabIndex = 1;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(259, 393);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(58, 28);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "CART";
            // 
            // userControl2BindingSource
            // 
            this.userControl2BindingSource.DataSource = typeof(POS_app.UserControl2);
            // 
            // userControl1BindingSource
            // 
            this.userControl1BindingSource.DataSource = typeof(POS_app.UserControl1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nametxt,
            this.Quantitytxt,
            this.Pricetxt});
            this.dataGridView1.Location = new System.Drawing.Point(52, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(428, 292);
            this.dataGridView1.TabIndex = 4;
            // 
            // Nametxt
            // 
            this.Nametxt.HeaderText = "Column1";
            this.Nametxt.MinimumWidth = 6;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Width = 125;
            // 
            // Quantitytxt
            // 
            this.Quantitytxt.HeaderText = "Column1";
            this.Quantitytxt.MinimumWidth = 6;
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.Width = 125;
            // 
            // Pricetxt
            // 
            this.Pricetxt.HeaderText = "Column1";
            this.Pricetxt.MinimumWidth = 6;
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(52, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "IMPORT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(52, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "New Customer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.totalPrice);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(525, 473);
            ((System.ComponentModel.ISupportInitialize)(this.userControl2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox totalPrice;
        private Label Total;
        private Label label1;
        private BindingSource userControl2BindingSource;
        private BindingSource userControl1BindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nametxt;
        private DataGridViewTextBoxColumn Quantitytxt;
        private DataGridViewTextBoxColumn Pricetxt;
        private Button button1;
        private Button button2;
    }
}
