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
namespace Question1_ModelPaper
{
    class Laptop
    {
        private String BrandName;
        private float Price;
        private String Processor;
        private int RAM;
        private String HardDrive;

        public void UpdateDet(String bn, float price, String pro, int ram, String hdd)
        {
            this.BrandName = bn;
            this.Price = price;
            this.Processor = pro;
            this.RAM = ram;
            this.HardDrive = hdd;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Brand Name : " + BrandName);
            Console.WriteLine("Price : Rs " + Price);
            Console.WriteLine("Processor : " + Processor);
            Console.WriteLine("RAM : {0}GB ", RAM);
            Console.WriteLine("HDD : " + HardDrive + "\n");
        }
    }
    class Program { 
        static void Main(string[] args)
        {
            Laptop l1 = new Laptop();
            l1.UpdateDet("Lenovo", 60000, "i5", 2, "500GB");
            l1.PrintDetails();
            Console.ReadKey();
        }


    }
}
//4
