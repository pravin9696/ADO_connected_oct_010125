using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_connected_oct_010125
{
    class DBOperations
    {
         public void deleteEmployee_By_Vishal()
 {
     //this method created by Vishal 
 }
        public void deleteEmployee_Pravin()
        {
           //thi is my code 
        }
        public void updateEmployee()
        {
            string name;
            string address;
            Int64 contact;
            int id;
            Console.WriteLine("enter id to update Employee records");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("enter New information like name, address and contact of employee");
            name = Console.ReadLine();
            address = Console.ReadLine();
            contact=Int64.Parse(Console.ReadLine());


            //step1   create connection between project and Database  AND open connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;TrustServerCertificate=True";
            con.Open();


            //step2  create object of SqlCommand class and provide sqlcommand( ie. query) and execute it

            SqlCommand cmd = new SqlCommand();
            //*******
            cmd.CommandText = $"update tblEmployee set name='{name}',Address='{address}',contact={contact} where empid={id}";
            cmd.Connection = con;

            int n= cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("record updated successfully....");
            }
            else
            {
                Console.WriteLine("Not updated yet!!!");
            }
            //step3 close connection

            con.Close();
        }
        public void insertEmployee()
        {
            //step1  create connection between project and Database  AND open connection

            // SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;TrustServerCertificate=True");

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;TrustServerCertificate=True";
            con.Open();


            //step2  create object of SqlCommand class and provide sqlcommand( query) and execute it

            string name;
            string add;
            Int64 contact;
            Console.WriteLine("Enter name , address and contact of employee");
            name = Console.ReadLine();
            add = Console.ReadLine();
            contact=Int64.Parse(Console.ReadLine());    

            SqlCommand cmd = new SqlCommand();//2 parameters   1->sql query    2-> Sqlconnection object
            cmd.CommandText = $"insert into tblEmployee values('{name}','{add}',{contact})";
            cmd.Connection = con;
            
            int n=cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("record inserted successfully....");
            }
            else {
                Console.WriteLine("Not inserted yet!!!");
            }



            //step3  close connection after using sqlconnection object
            con.Close();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DBOperations dbObj=new DBOperations();
            //dbObj.insertEmployee();
            dbObj.updateEmployee();
            Console.ReadKey();
        }
    }
}
