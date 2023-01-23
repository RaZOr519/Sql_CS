SqlConnection connection = new SqlConnection("@");
connection.Open();
SqlCommand cmd = connection.CreateCommand();

cmd.CommandType = CommandType.Text;
cmd.CommandText = "INSERT INTO [TABLE] (eid, name, age, pno) VALUES ('" +id.Text+"', '"+name.Text+"', @Gender)";
cmd.Parameters.AddWithValue("@Gender", Gender);

cmd.ExcuteNonQuery();

connection.Close();

//2

connection.Open();
            //SqlCommand cmd = new SqlCommand(@"SELECT * FROM [Table] WHERE CID='" + id.Text + "'", connection);
            //SqlDataReader reader = cmd.ExecuteReader();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = (@"SELECT * FROM [Table] WHERE cid='" + textBox1.Text + "'");
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                textBox2.Text = reader[2].ToString();
                textBox3.Text = reader[3].ToString();
            }
            else
            {
                MessageBox.Show("Not Found");
            }
            connection.Close();
        }

//3
