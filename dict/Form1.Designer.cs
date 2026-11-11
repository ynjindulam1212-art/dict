namespace dict
{
    partial class Form1
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
            txtSearch = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            cmbLanguage = new ComboBox();
            lblSearch = new Label();
            txtEnglish = new TextBox();
            textMongolian = new TextBox();
            textRussian = new TextBox();
            lblLanguage = new Label();
            lblEnglish = new Label();
            lblMongolian = new Label();
            lblRussian = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            brnClear = new Button();
            btnSave = new Button();
            statusStrip1 = new StatusStrip();
            dgvWords = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            lblStatus = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(63, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(460, 27);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Хоосон";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbLanguage
            // 
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Location = new Point(591, 8);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(151, 28);
            cmbLanguage.TabIndex = 1;
            cmbLanguage.Text = "Бүгд";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 11);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 20);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Хайх:";
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(79, 339);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(174, 27);
            txtEnglish.TabIndex = 4;
            txtEnglish.Text = "Хоосон";
            // 
            // textMongolian
            // 
            textMongolian.Location = new Point(348, 339);
            textMongolian.Name = "textMongolian";
            textMongolian.Size = new Size(174, 27);
            textMongolian.TabIndex = 5;
            textMongolian.Text = "Хоосон";
            // 
            // textRussian
            // 
            textRussian.Location = new Point(618, 339);
            textRussian.Name = "textRussian";
            textRussian.Size = new Size(170, 27);
            textRussian.TabIndex = 6;
            textRussian.Text = "Хоосон";
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(549, 12);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(36, 20);
            lblLanguage.TabIndex = 7;
            lblLanguage.Text = "Хэл:";
            // 
            // lblEnglish
            // 
            lblEnglish.AutoSize = true;
            lblEnglish.Location = new Point(4, 339);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new Size(51, 20);
            lblEnglish.TabIndex = 8;
            lblEnglish.Text = "Англи";
            // 
            // lblMongolian
            // 
            lblMongolian.AutoSize = true;
            lblMongolian.Location = new Point(275, 339);
            lblMongolian.Name = "lblMongolian";
            lblMongolian.Size = new Size(63, 20);
            lblMongolian.TabIndex = 9;
            lblMongolian.Text = "Монгол";
            // 
            // lblRussian
            // 
            lblRussian.AutoSize = true;
            lblRussian.Location = new Point(549, 339);
            lblRussian.Name = "lblRussian";
            lblRussian.Size = new Size(45, 20);
            lblRussian.TabIndex = 10;
            lblRussian.Text = "Орос";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 378);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 31);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(119, 378);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 31);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Засах";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(228, 378);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 31);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // brnClear
            // 
            brnClear.Location = new Point(337, 378);
            brnClear.Name = "brnClear";
            brnClear.Size = new Size(103, 31);
            brnClear.TabIndex = 14;
            brnClear.Text = "Цэвэрлэх";
            brnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(446, 378);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 31);
            btnSave.TabIndex = 15;
            btnSave.Text = "Санах";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            // 
            // dgvWords
            // 
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWords.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvWords.Location = new Point(32, 69);
            dgvWords.Name = "dgvWords";
            dgvWords.RowHeadersWidth = 51;
            dgvWords.Size = new Size(427, 239);
            dgvWords.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "№";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Англи";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Монгол";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Орос";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5 });
            dataGridView2.Location = new Point(532, 69);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(256, 188);
            dataGridView2.TabIndex = 18;
            // 
            // Column5
            // 
            Column5.HeaderText = "Үгийн жагсаалт";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 500;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(177, 20);
            lblStatus.Text = "Нийт: 0 үг ; Санасан үг: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(dgvWords);
            Controls.Add(statusStrip1);
            Controls.Add(btnSave);
            Controls.Add(brnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lblRussian);
            Controls.Add(lblMongolian);
            Controls.Add(lblEnglish);
            Controls.Add(lblLanguage);
            Controls.Add(textRussian);
            Controls.Add(textMongolian);
            Controls.Add(txtEnglish);
            Controls.Add(lblSearch);
            Controls.Add(cmbLanguage);
            Controls.Add(txtSearch);
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private OpenFileDialog openFileDialog1;
        private ComboBox cmbLanguage;
        private Label lblSearch;
        private TextBox txtEnglish;
        private TextBox textMongolian;
        private TextBox textRussian;
        private Label lblLanguage;
        private Label lblEnglish;
        private Label lblMongolian;
        private Label lblRussian;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button brnClear;
        private Button btnSave;
        private StatusStrip statusStrip1;
        private DataGridView dgvWords;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column5;
        private ToolStripStatusLabel lblStatus;
    }
}
