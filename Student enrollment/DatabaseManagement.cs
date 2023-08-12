using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_enrollment
{
    class DatabaseManagement
    {
        public SqlConnection OpenConnection()
        {
            string connetionString = null;
            SqlConnection con;
            connetionString = "Data Source = (LocalDB)\\v11.0;AttachDbFilename= F:\\MAY-Student enrollment\\Student enrollment\\studentenrollmentdb.mdf; Integrated Security = True";
            //connetionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\APIIT-MAC-0018-PC\\Desktop\\CsharpDB\\CsharpDB\\Phone.mdf; Integrated Security = True";
            //hOW TO KEEP THE CONNECTIONSTRING UPDATES WITHOUT HAVE TO CHECK IT EVERYTIME?
            //Data Source=(LocalDB)\v11.0;AttachDbFilename="F:\MAY-Student enrollment\Student enrollment\studentenrollmentdb.mdf";Integrated Security=True
            con = new SqlConnection(connetionString);
            try
            {
                con.Open();
                Console.WriteLine("\nConnection Open ! ");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection !:\n " + ex.ToString());
            }
            return con;
        }
        public void InsertRecord(Student s)
        {
            SqlCommand command;
            SqlConnection con;
            string InsertQuery = "Insert into tblStudent (studentID, studentName, studentIC, studentContact, studentAddress) values(@id,@name,@ic,@contact,@address)";
            try
            {
                con = OpenConnection();
                command = new SqlCommand(InsertQuery, con);
                command.Parameters.AddWithValue("@id", s.StudentID);
                command.Parameters.AddWithValue("@name", s.Name);
                command.Parameters.AddWithValue("@ic", s.Ic);
                command.Parameters.AddWithValue("@contact", s.Contact);
                command.Parameters.AddWithValue("@address", s.Address);
                int effectedRow = command.ExecuteNonQuery();
                if (effectedRow > 0)
                    Console.WriteLine("Inserted: " + effectedRow);
                else
                    Console.WriteLine("Data Not Saved");
                command.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! \n" + ex.ToString());
            }

        }

        public List<Student> ViewAll() //return the student as a list
        {
            List<Student> listofstudent = new List<Student>();
            SqlCommand command;
            string sql = null;
            SqlConnection con;
            sql = "Select * from tblStudent";

            try
            {
                con = OpenConnection();
                command = new SqlCommand(sql, con);
                SqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    Student newStudent = new Student(sqlReader.GetString(0), sqlReader.GetString(1), sqlReader.GetString(2), long.Parse(sqlReader.GetValue(3).ToString()), sqlReader.GetString(4));
                    //Console.WriteLine(sqlReader.GetValue(0) + " \t " + sqlReader.GetValue(1) + " \t " + sqlReader.GetValue(2) + " \t " + sqlReader.GetValue(3) + " \t " + sqlReader.GetValue(4));
                    Console.WriteLine(newStudent.toString());
                    listofstudent.Add(newStudent);
                }
                
                sqlReader.Close();
                command.Dispose();
                con.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! \n" + ex.ToString());
            }
            return listofstudent;
        }
        public Student ViewRecord(string searchkey) {
            SqlCommand command;
            SqlConnection con;
            Student newStudent = new Student();
            string sql ="Select* from tblstudent where studentID='"+searchkey+"'";
            try
            {
con = OpenConnection();
                command = new SqlCommand(sql, con);
                SqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    newStudent = new Student(sqlReader.GetString(0), sqlReader.GetString(1), sqlReader.GetString(2), long.Parse(sqlReader.GetValue(3).ToString()), sqlReader.GetString(4));
                    Console.WriteLine(sqlReader.GetValue(0) + " \t " + sqlReader.GetValue(1) + " \t " + sqlReader.GetValue(2));
                }
                sqlReader.Close();
                command.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! \n" + ex.ToString());
            }
            return newStudent;
        }
        public void DeleteRecord(string searchKey)
        {
            SqlCommand command;
            SqlConnection con;
            string sql="Delete from tblStudent where studentID ='"+searchKey+"'";
            try
            {
                con= OpenConnection();
                command = new SqlCommand(sql, con);
               int effectedRow = command.ExecuteNonQuery();
                if (effectedRow > 0)
                    Console.WriteLine("Deleted Rows: " + effectedRow);
                else
                    Console.WriteLine("Row Not Deleted");
                command.Dispose();
                command.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! \n" + ex.ToString());
            }
        }


        internal void UpdateRecord(Student objs)
        {
        }
    }

}
