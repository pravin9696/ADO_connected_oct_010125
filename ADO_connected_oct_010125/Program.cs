﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO_connected_oct_010125
{
    public class DBOperation_para_Query
    {
        public void update()
        {
            int empid;
            string name;
            string add;
            Int64 contact;
            Console.WriteLine("Enter employee ID to update records");
            empid =int.Parse(Console.ReadLine());
            Console.WriteLine("enter name , address and contact number of employee");
            name = Console.ReadLine();
            add = Console.ReadLine();
            contact = Int64.Parse(Console.ReadLine());


            //step1
            SqlConnection con = new SqlConnection();
            try
            {                
                con.ConnectionString = "Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                con.Open();
                //step 2

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update tblEmployee set name=@nm,Address=@add,contact=@contact where empid=@empid";
                cmd.CommandType=CommandType.Text;
                cmd.Parameters.AddWithValue("@empid", empid);
                cmd.Parameters.AddWithValue("@add", add);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@nm", name);

                int n=cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine("record updated successfully...");
                }
                else
                {
                    Console.WriteLine("Record not updated!!!");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                con.Close();
            }



        }
        public void insert_using_SP()
        {
            string name;
            string add;
            Int64 contact;
            Console.WriteLine("enter name , address and contact number of employee");
            name = Console.ReadLine();
            add = Console.ReadLine();
            contact = Int64.Parse(Console.ReadLine());


            //step1
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            con.Open();

            //step 2

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spInsertEmp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nm", name);
            cmd.Parameters.AddWithValue("@ad", add);
            cmd.Parameters.AddWithValue("@cont", contact);

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("record inserted using SP successfully...");
            }
            else
            {
                Console.WriteLine("Record not inserted!!!");
            }

            con.Close();

        }
        public void insert()
        {
            string name;
            string add;
            Int64 contact;
            Console.WriteLine("enter name , address and contact number of employee");
            name = Console.ReadLine();
            add = Console.ReadLine();
            contact = Int64.Parse(Console.ReadLine());


            //step1
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            con.Open();

            //step 2

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tblEmployee values(@name,@add,@contact)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@add", add);
            cmd.Parameters.AddWithValue("@contact", contact);

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("record inserted successfully...");
            }
            else
            {
                Console.WriteLine("Record not inserted!!!");
            }

            con.Close();

        }
    }
    class DBOperations
    {
        public void deleteEmployee_Pravin()
        {
            //step1
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            con.Open();

            //step2
            SqlCommand cmd = new SqlCommand($"select * from tblEmployee where address='mumbai' ", con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("ID\tName\tAddress\tContact");
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t{rdr[1]}\t{rdr[2]}\t{rdr[3]}");
            }
        }
        public void Read_single_record()
        {
            Console.WriteLine("Enter employee ID to show record");
            int empid = int.Parse(Console.ReadLine());
            //step1
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            con.Open();

            //step2
            SqlCommand cmd = new SqlCommand($"select * from tblEmployee where empid={empid}", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rdr = cmd.ExecuteReader();
            // if (rdr.HasRows==true)
            if (rdr.Read())
            {
                // rdr.Read();
                Console.WriteLine("Emp ID=" + rdr[0] + " Name=" + rdr["name"]);
            }
            else
            {
                Console.WriteLine("record not found!!");
            }

        }
        public void deleteEmployee()
        {
            Console.WriteLine("enter employee id to delete record..");
            int eid = int.Parse(Console.ReadLine());

            //step1
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            con.Open();


            //step2 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"delete from tblEmployee where empid={eid}";
            //cmd.CommandType = CommandType.Text;

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
                Console.WriteLine("record deleted successfully");
            else
                Console.WriteLine("Record not deleted...");

            //step 3
            con.Close();

        }
        public void updateEmployee()
        {
            string name;
            string address;
            Int64 contact;
            int id;
            Console.WriteLine("enter id to update Employee records");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter New information like name, address and contact of employee");
            name = Console.ReadLine();
            address = Console.ReadLine();
            contact = Int64.Parse(Console.ReadLine());


            //step1   create connection between project and Database  AND open connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;TrustServerCertificate=True";
            con.Open();


            //step2  create object of SqlCommand class and provide sqlcommand( ie. query) and execute it

            SqlCommand cmd = new SqlCommand();
            //*******
            cmd.CommandText = $"update tblEmployee set name='{name}',Address='{address}',contact={contact} where empid={id}";
            cmd.Connection = con;

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("record updated successfully....");
                int x = 4;
            }
            else
            {
                Console.WriteLine("Not updated yet!!!");
            }

            cmd.CommandText = $"select * from tblEmployee where empid={id}";
            var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"id:{rdr[0]}\t {rdr[1]}\t {rdr[2]}\t {rdr[3]}");
            }
            ////step3 close connection

            con.Close();
        }
        public void insertEmployee()
        {
            //step1  create connection between project and Database  AND open connection

            // SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;TrustServerCertificate=True");

            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=.;Initial Catalog=DB_ADO_connected_sample;Integrated Security=True;TrustServerCertificate=True";
            con.ConnectionString = MyConnectionString.myConString;
            con.Open();


            //step2  create object of SqlCommand class and provide sqlcommand( query) and execute it

            string name;
            string add;
            Int64 contact;
            Console.WriteLine("Enter name , address and contact of employee");
            name = Console.ReadLine();
            add = Console.ReadLine();
            contact = Int64.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand();//2 parameters   1->sql query    2-> Sqlconnection object
            cmd.CommandText = $"insert into tblEmployee values('{name}','{add}',{contact})";
            cmd.Connection = con;

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("record inserted successfully....");
            }
            else
            {
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
            // DBOperations dbObj=new DBOperations();
            // dbObj.insertEmployee();
            //// dbObj.updateEmployee();
            //// //dbObj.deleteEmployee();
            ////  //dbObj.Read_single_record();
            ////// dbObj.Read_all();
            ///
            DBOperation_para_Query dpq = new DBOperation_para_Query();

            // dpq.insert();
            //dpq.insert_using_SP();
            dpq.update();


            Console.ReadKey();
        }
    }
}
