using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Person
    {
        static SqlConnection connection;

        static Person()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Sum { get; set; }
        public static IEnumerable<Person> GetAllPerson()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            var SQLstr = "SELECT Id, Name, Sum FROM Person";
            SqlCommand cmd = new SqlCommand(SQLstr, connection);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var sum = reader.GetDecimal(2);
                    yield return new Person { Id = id, Name = name, Sum = sum };
                }
            }
            connection.Close();
        }
        public void Insert()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            var SQLstr = "INSERT INTO Person (Name, Sum) VALUES (@name, @sum)";
            SqlCommand cmd = new SqlCommand(SQLstr, connection);
            cmd.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter("name", Name),
                new SqlParameter("sum", Sum)
            });
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public static void Delete(int id)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            var SQLstr = "DELETE FROM Person WHERE(Id=@id)";
            SqlCommand cmd = new SqlCommand(SQLstr, connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Update()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            var SQLstr = "UPDATE Person SET Name=@name, Sum=@sum WHERE(Id=@id)";
            SqlCommand cmd = new SqlCommand(SQLstr, connection);
            cmd.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter("name", Name),
                new SqlParameter("sum", Sum),
                new SqlParameter("id", Id)
            });
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static Person Find(string name)
        {
            foreach (var p in GetAllPerson())
            {
                if (p.Name == name)
                    return p;
            }
            return null;
        }
        public override string ToString()
        {
            return $"№ {Id} Имя: {Name}, Сумма: {Sum:0.000}";
        }
    }
}
