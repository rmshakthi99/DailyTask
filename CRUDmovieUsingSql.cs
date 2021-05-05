using System;
using System.Data;
using System.Data.SqlClient;

namespace NUGet.ADOExampleProject
{
    class Program
    {
        string conString;
        SqlConnection con;
        SqlCommand cmd;
        public Program()
        {
            conString = @"server=SHAKTHI-RM\SQLEXPRESS;Integrated Security=true;Initial catalog=pubs";
            con = new SqlConnection(conString);
        }

        void FetchOneMovieFromDatabase()
        {
            string strCmd = "select * from tblMovies where id=@mid";
            cmd = new SqlCommand(strCmd, con);
            try
            {
                con.Open();
                Console.WriteLine("please enter the id");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.Add("@mid", SqlDbType.Int);
                cmd.Parameters[0].Value=id;
                SqlDataReader drMovies = cmd.ExecuteReader();
                while (drMovies.Read())
                {
                    Console.WriteLine("Movie Id :" + drMovies[0].ToString());
                    Console.WriteLine("Movie Name:" + drMovies[1]);
                    Console.WriteLine("Movie Duration:" + drMovies[2].ToString());

                    Console.WriteLine("-------------------------------------");
                }
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void UpdateMovieDuration()
        {
            Console.WriteLine("please enter the id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the movie duration");
            float mDuration = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
            string strCmd = "update tblMovies set duration =@mduration where id=@mid";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mid", id);
            cmd.Parameters.AddWithValue("@mduration", mDuration);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("movie duration updated");
                else
                    Console.WriteLine("not done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void DelMovie()
        {
            Console.WriteLine("please enter the id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the movie to be deleted");
            string mName = Console.ReadLine();
            string strCmd = "delete from  tblMovies  where id=@mid";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mid", id);
            
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("movie deleted");
                else
                    Console.WriteLine("not done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void AddMovie()
        {
            Console.WriteLine("enter movie name");
            string mName = Console.ReadLine();
            Console.WriteLine("please enter movie duration");
            float mDuration = (float)Math.Round(float.Parse(Console.ReadLine()), 2);
            string strCmd = "insert into tblMovies(name,duration)values(@mName,@mdur)";
            cmd = new SqlCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@mName", mName);
            cmd.Parameters.AddWithValue("@mdur", mDuration);
            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("movie inserted");
                else
                    Console.WriteLine("not done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void ReadAll()
        {
            string strCmd = "Select * from tblMovies";
            cmd = new SqlCommand(strCmd, con);
            try
            {
                con.Open();
                Console.WriteLine("please enter the id");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.Add("@mid", SqlDbType.Int);
                cmd.Parameters[0].Value = id;
                SqlDataReader drMovies = cmd.ExecuteReader();
                while (drMovies.Read())
                {
                    Console.WriteLine("Movie Id :" + drMovies[0].ToString());
                    Console.WriteLine("Movie Name:" + drMovies[1]);
                    Console.WriteLine("Movie Duration:" + drMovies[2].ToString());

                    Console.WriteLine("-------------------------------------");
                }
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException.Message);
            }
            finally
            {
                con.Close();
            }
        }

    
        public void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("menu");
                Console.WriteLine("1.add a movie");
                Console.WriteLine("2.update  movie duration");
                Console.WriteLine("3.delete a movie");
                Console.WriteLine("4.read all movies");
                Console.WriteLine("5.exit");
                Console.WriteLine("enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
               
                switch (choice)
                {
                    case 1:
                        AddMovie(); 
                        break;
                    case 2:
                        UpdateMovieDuration(); 
                        break;
                    case 3:
                        DelMovie();
                        break;
                    case 4:
                        ReadAll();
                        break;

                    case 5:
                        break;
                    
                    default:
                        Console.WriteLine("please enter the val choice");
                        break;
                }
            } while (choice != 5);
        }


        static void Main(String[] args)
        {
            //new Program().FetchOneMovieFromDatabase();
            //new Program().DelMovie();
            // new Program().AddMovie();
            // new Program().UpdateMovieDuration();
            new Program().PrintMenu();
            Console.ReadKey();
        }
    }
}

    
    
    



        
        
    
                
            

        
    

