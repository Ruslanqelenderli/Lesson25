using Lesson_25.Entities;
using Lesson_25.Models;
using System.Data;
using System.Data.SqlClient;

namespace Lesson_25
{
    public partial class Form1 : Form
    {
        public static int Id { get; set; }
        public Form1()
        {
            InitializeComponent();
            btn_Delete.Visible = false;
            btn_Update.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_Students.DataSource = Manage.GetStudents();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var model = new StudentAddModel()
            {
                Name = txb_Name.Text,
                TeacherId = int.Parse(txb_TeacherId.Text)
            };

            var result = Manage.Add(model);
            if (result)
            {
                MessageBox.Show("Əlavə olundu.");
                dgv_Students.DataSource = Manage.GetStudents();
                txb_Name.Clear();
                txb_TeacherId.Clear();

            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dgv_Students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Delete.Visible = true;
            btn_Update.Visible = true;
            Form1.Id = (int)dgv_Students.SelectedCells[0].Value;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var result = Manage.Delete(Form1.Id);
            if (result)
            {
                MessageBox.Show("Silindi.");
                dgv_Students.DataSource = Manage.GetStudents();
                btn_Delete.Visible = false;

            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            dgv_Students.DataSource = Manage.GetStudents();
        }
    }
}
