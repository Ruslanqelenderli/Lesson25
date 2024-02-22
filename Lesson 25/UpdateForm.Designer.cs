namespace Lesson_25
{
    partial class UpdateForm
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
            btn_Add = new Button();
            txb_TeacherId = new TextBox();
            txb_Name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(91, 214);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 10;
            btn_Add.Text = "Düzəliş et";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // txb_TeacherId
            // 
            txb_TeacherId.Location = new Point(80, 159);
            txb_TeacherId.Name = "txb_TeacherId";
            txb_TeacherId.Size = new Size(125, 27);
            txb_TeacherId.TabIndex = 9;
            // 
            // txb_Name
            // 
            txb_Name.Location = new Point(80, 71);
            txb_Name.Name = "txb_Name";
            txb_Name.Size = new Size(125, 27);
            txb_Name.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 121);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "Müəllim id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 42);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 6;
            label1.Text = "Ad";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 341);
            Controls.Add(btn_Add);
            Controls.Add(txb_TeacherId);
            Controls.Add(txb_Name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Add;
        private TextBox txb_TeacherId;
        private TextBox txb_Name;
        private Label label2;
        private Label label1;
    }
}