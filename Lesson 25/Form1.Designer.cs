namespace Lesson_25
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
            dgv_Students = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txb_Name = new TextBox();
            txb_TeacherId = new TextBox();
            btn_Add = new Button();
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_Reload = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).BeginInit();
            SuspendLayout();
            // 
            // dgv_Students
            // 
            dgv_Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Students.Location = new Point(467, 29);
            dgv_Students.Name = "dgv_Students";
            dgv_Students.RowHeadersWidth = 51;
            dgv_Students.Size = new Size(639, 376);
            dgv_Students.TabIndex = 0;
            dgv_Students.CellClick += dgv_Students_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 53);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 132);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Müəllim id";
            // 
            // txb_Name
            // 
            txb_Name.Location = new Point(38, 82);
            txb_Name.Name = "txb_Name";
            txb_Name.Size = new Size(125, 27);
            txb_Name.TabIndex = 3;
            // 
            // txb_TeacherId
            // 
            txb_TeacherId.Location = new Point(38, 170);
            txb_TeacherId.Name = "txb_TeacherId";
            txb_TeacherId.Size = new Size(125, 27);
            txb_TeacherId.TabIndex = 4;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(49, 225);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 5;
            btn_Add.Text = "Əlavə et";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(467, 411);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(113, 29);
            btn_Delete.TabIndex = 11;
            btn_Delete.Text = "Sil";
            btn_Delete.TextAlign = ContentAlignment.BottomCenter;
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(993, 411);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(113, 29);
            btn_Update.TabIndex = 12;
            btn_Update.Text = "Düzəliş";
            btn_Update.TextAlign = ContentAlignment.BottomCenter;
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Reload
            // 
            btn_Reload.Location = new Point(713, 411);
            btn_Reload.Name = "btn_Reload";
            btn_Reload.Size = new Size(113, 29);
            btn_Reload.TabIndex = 13;
            btn_Reload.Text = "Yenilə";
            btn_Reload.TextAlign = ContentAlignment.BottomCenter;
            btn_Reload.UseVisualStyleBackColor = true;
            btn_Reload.Click += btn_Reload_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 626);
            Controls.Add(btn_Reload);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Add);
            Controls.Add(txb_TeacherId);
            Controls.Add(txb_Name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_Students);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Students;
        private Label label1;
        private Label label2;
        private TextBox txb_Name;
        private TextBox txb_TeacherId;
        private Button btn_Add;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Reload;
    }
}
