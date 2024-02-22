using Lesson_25.Entities;
using Lesson_25.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_25
{
    public class Manage
    {
        public static List<Student> GetStudents()
        {
            var students = new List<Student>();
            using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=LESSON21DB;Trusted_Connection=True;"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "select * from student";
                var dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    students.Add(new Student()
                    {
                        Id = dataReader.GetInt32(dataReader.GetOrdinal("Id")),
                        Name = dataReader.GetString(dataReader.GetOrdinal("STUDENT_NAME")),
                        TeacherId = dataReader.GetInt32(dataReader.GetOrdinal("TEACHER_ID")),

                    });
                }

                connection.Close();

            }
            return students;
        }

        public static Student GetById(int id)
        {
            var student = new Student();
            using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=LESSON21DB;Trusted_Connection=True;"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = $"select * from student where ID={id}";
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    student.Id = dataReader.GetInt32(dataReader.GetOrdinal("Id"));
                    student.Name = dataReader.GetString(dataReader.GetOrdinal("STUDENT_NAME"));
                    student.TeacherId = dataReader.GetInt32(dataReader.GetOrdinal("TEACHER_ID"));
                }
                connection.Close();

            }
            return student;
        }

        public static bool Add(StudentAddModel model)
        {
            try
            {
                using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=LESSON21DB;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "insert into student (STUDENT_NAME,TEACHER_ID) VALUES (@NAME,@TEACHERID)";
                    command.Parameters.Add(new SqlParameter("@NAME", model.Name));
                    command.Parameters.Add(new SqlParameter("@TEACHERID", model.TeacherId));

                    command.ExecuteNonQuery();


                    connection.Close();

                    return true;

                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool Update(StudentUpdateModel model)
        {
            try
            {
                using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=LESSON21DB;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "update  student set STUDENT_NAME = @NAME,TEACHER_ID=@TEACHERID where ID=@ID";
                    command.Parameters.Add(new SqlParameter("@ID", model.Id));
                    command.Parameters.Add(new SqlParameter("@NAME", model.Name));
                    command.Parameters.Add(new SqlParameter("@TEACHERID", model.TeacherId));

                    command.ExecuteNonQuery();


                    connection.Close();

                    return true;

                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool Delete(int id)
        {
            try
            {
                using (var connection = new SqlConnection("Server=RUSLAN\\SQLEXPRESS;Database=LESSON21DB;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = $"delete from student where ID={id}";

                    command.ExecuteNonQuery();


                    connection.Close();

                    return true;

                }
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
