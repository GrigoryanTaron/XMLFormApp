namespace XMLFormApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.XMLView = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CrateBtn = new System.Windows.Forms.Button();
            this.GetBtn = new System.Windows.Forms.Button();
            this.GetAllBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.XMLView)).BeginInit();
            this.SuspendLayout();
            // 
            // XMLView
            // 
            this.XMLView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XMLView.Location = new System.Drawing.Point(0, 0);
            this.XMLView.Name = "XMLView";
            this.XMLView.RowTemplate.Height = 25;
            this.XMLView.Size = new System.Drawing.Size(779, 438);
            this.XMLView.TabIndex = 0;
            this.XMLView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XMLView_CellContentClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(828, 12);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CrateBtn
            // 
            this.CrateBtn.Location = new System.Drawing.Point(828, 41);
            this.CrateBtn.Name = "CrateBtn";
            this.CrateBtn.Size = new System.Drawing.Size(75, 23);
            this.CrateBtn.TabIndex = 2;
            this.CrateBtn.Text = "Create";
            this.CrateBtn.UseVisualStyleBackColor = true;
            this.CrateBtn.Click += new System.EventHandler(this.CrateBtn_Click);
            // 
            // GetBtn
            // 
            this.GetBtn.Location = new System.Drawing.Point(828, 70);
            this.GetBtn.Name = "GetBtn";
            this.GetBtn.Size = new System.Drawing.Size(75, 23);
            this.GetBtn.TabIndex = 3;
            this.GetBtn.Text = "Get";
            this.GetBtn.UseVisualStyleBackColor = true;
            this.GetBtn.Click += new System.EventHandler(this.GetBtn_Click);
            // 
            // GetAllBtn
            // 
            this.GetAllBtn.Location = new System.Drawing.Point(828, 99);
            this.GetAllBtn.Name = "GetAllBtn";
            this.GetAllBtn.Size = new System.Drawing.Size(75, 23);
            this.GetAllBtn.TabIndex = 4;
            this.GetAllBtn.Text = "GetAll";
            this.GetAllBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(828, 128);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 450);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.GetAllBtn);
            this.Controls.Add(this.GetBtn);
            this.Controls.Add(this.CrateBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.XMLView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XMLView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView XMLView;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button CrateBtn;
        private System.Windows.Forms.Button GetBtn;
        private System.Windows.Forms.Button GetAllBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
