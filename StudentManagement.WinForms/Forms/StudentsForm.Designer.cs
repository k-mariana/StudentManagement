namespace StudentManagement.WinForms.Forms
{
    partial class StudentsForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label3 = new Label();
            lblPage = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            label4 = new Label();
            txtSearch = new TextBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(837, 232);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 391);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 437);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(149, 388);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(149, 434);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 255, 192);
            btnAdd.Location = new Point(48, 489);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 255, 255);
            btnUpdate.Location = new Point(176, 489);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Location = new Point(310, 489);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(376, 9);
            label3.Name = "label3";
            label3.Size = new Size(185, 38);
            label3.TabIndex = 8;
            label3.Text = "Students List";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(163, 343);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(59, 25);
            lblPage.TabIndex = 9;
            lblPage.Text = "label4";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Azure;
            btnPrevious.Location = new Point(48, 338);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(70, 34);
            btnPrevious.TabIndex = 10;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Azure;
            btnNext.Location = new Point(300, 338);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 34);
            btnNext.TabIndex = 11;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 62);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 12;
            label4.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(125, 59);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 31);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(361, 57);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(37, 35);
            btnClear.TabIndex = 14;
            btnClear.Text = "🗙";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(944, 553);
            Controls.Add(btnClear);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(lblPage);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "StudentsForm";
            Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label3;
        private Label lblPage;
        private Button btnPrevious;
        private Button btnNext;
        private Label label4;
        private TextBox txtSearch;
        private Button btnClear;
    }
}