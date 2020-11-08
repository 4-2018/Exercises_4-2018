using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Exercises_4_2018
{
    public partial class Form1 : Form
    {

        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ExerciseResult> rezultati = new List<ExerciseResult>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "SELECT * FROM ExerciseResults";

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ExerciseResult rezultat = new ExerciseResult(reader.GetInt32(0),
                    reader.GetString(1), reader.GetString(2), reader.GetInt32(3));

                rezultati.Add(rezultat);
            }

            connection.Close();

            foreach (ExerciseResult i in rezultati)
            {
                listBoxExerciseResults.Items.Add(i.ToString());
            }
        }
    }
}
