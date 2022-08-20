using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifier;

namespace ParallelConstr
{
    
    class PlatformData
    {
        private int service_ID;
        private string provider_Name;
        private double total_Users;
        protected bool service_TypeIsMobile;

        public PlatformData(string provider_Name, double total_Users, bool service_TypeIsMobile)
        {

            this.provider_Name = provider_Name;
            this.total_Users = total_Users;
            this.service_TypeIsMobile = service_TypeIsMobile;

        }
        public PlatformData(string provider_Name, double total_Users, bool service_TypeIsMobile, int service_ID)
        {

            SvcProviderName = provider_Name;
            TotalUsers = total_Users;
            SvcTypeIsMobile = service_TypeIsMobile;
            SvcProviderID = service_ID;

        }

        public string SvcProviderName
        {
            get { return provider_Name; }
            set { provider_Name = value; }
        }

        public double TotalUsers
        {
            get { return total_Users; }
            set { total_Users = value; }
        }

        public bool SvcTypeIsMobile
        {
            get { return service_TypeIsMobile; }
            set { service_TypeIsMobile = value; }
        }

        public int SvcProviderID
        {
            get { return service_ID; }
            set { service_ID = value; }
        }
        public class SvcCollection : ObservableCollection<PlatformData>
        {
            public SvcCollection() { }

            public SvcCollection(List<PlatformData> listData)
            {
                foreach (var item in listData)
                {
                    this.Add(item);
                }

            }

            public SvcCollection(IEnumerable<PlatformData> listData)
            {
                foreach (var item in listData)
                {
                    this.Add(item);
                }
            }

            public SvcCollection(PlatformData listData)
            {
                if (listData != null)
                {
                    this.Add(listData);
                }
            }

            /*public bool IsMobile(PlatformData a, PlatformData b)
            {
                return a.SvcTypeIsMobile == b.SvcTypeIsMobile;
            }*/

            public class CompareMobile : IEqualityComparer<PlatformData>
            {
                public bool Equals(PlatformData a, PlatformData b)
                {
                    return a.SvcProviderName == b.SvcProviderName;
                } 

                public int GetHashCode(PlatformData obj)
                {
                    return 1;
                }
            }
        }
    }

    public static class IntegerExtension
    {
        public static int PW_StrLength(this string password)
        {
            //Console.WriteLine("Password(Length): " + password.Length);
            return password.Length;
        }

        public static object Top_Platform(this double total)
        {
            return total;
        }

        public static double AVG_Interaction(this int views, int comments)
        {
            if(views != 0)
            {
                double quotient = comments / (views + 0.0001); //Avoid - "Divide by Zero"  w/ Exception Handling.
                return quotient;
            } 
            else
            {
                double quotient = 0;
                return quotient;
            }
            
        }
    }
    interface iUser
    {
        void Profile();
    }
    class UserData : iUser
    {
        private string username;
        private string password;
        protected int views;
        protected int comments;

        public UserData(string username, string password, int views, int comments)
        {
            this.username = username;
            this.password = password;
            this.views = views;
            this.comments = comments;
        }

        public UserData(string username, string password, int views, int comments, List<string> topics, int serviceID)
        {
            Username = username;
            Password = password;
            Views = views;
            Comments = comments;
            Topics = topics;
            SvcProviderID = serviceID;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Views
        {
            get { return views; }
            set { views = value; }
        }

        public int Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        private List<string> _topics;
        public List<string> Topics
        {
            get { return _topics; }
            set { _topics = value; }
        }

        private int _serviceID;
        public int SvcProviderID
        {
            get { return _serviceID; }
            set { _serviceID = value; }
        }
        void iUser.Profile()
        {
            //UserData null_Compiler = new UserData("", "", 0, 0);

            Console.WriteLine(this.Username);
            Console.WriteLine(this.Password);
            Console.WriteLine(this.Views);
            Console.WriteLine(this.Comments);
        }


        public class UserCollection : ObservableCollection<UserData>
        {
            public UserCollection() { }

            public UserCollection(List<UserData> listData)
            {
                foreach (var item in listData)
                {
                    this.Add(item);
                }

            }

            public UserCollection(IEnumerable<UserData> listData)
            {
                foreach (var item in listData)
                {
                    this.Add(item);
                }
            }

            public UserCollection(UserData listData)
            {
                if (listData != null)
                {
                    this.Add(listData);
                }
            }
        }
    }

    /*public static class Numbers
    {
        public static void Page_Assm(List<int> obj, int start, int end, int target)
        {
            List<int> acc_Take = obj.TakeWhile(x => x > start).Where(x => x <= end).ToList();
            List<int> acc_Skip = obj.TakeWhile(x => x > end).Where(x => x <= target).ToList();
            
    foreach (int page in acc_Take)
            {
                Console.Write("[" + page.ToString() + "]");
                
            }

            Console.WriteLine("\n");

            foreach (int page in acc_Skip)
            {
                Console.Write("[" + page.ToString() + "]");
            }

            Console.WriteLine("\n");
        }
    }*/
}
