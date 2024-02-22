using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_25
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            var student = Manage.GetById(Form1.Id);
            txb_Name.Text = student.Name;
            txb_TeacherId.Text = student.TeacherId.ToString();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var result = Manage.Update(new Models.StudentUpdateModel()
            {
                Id = Form1.Id,
                Name= txb_Name.Text, 
                TeacherId = int.Parse(txb_TeacherId.Text)
            });

            if (result)
            {
                MessageBox.Show("Düzəliş edildi.");
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
    }
}
