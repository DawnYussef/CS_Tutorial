using System;

namespace AccessModifier
{
    interface iData
    {
        void RetreiveData();
    }

    class AccessMod : iData
    {
        public string publicStr = "username";
        private string privateStr = "Password123!";
        protected string protectedStr = "Example of 'Protected String' available in Class," +
            " or through Inheritance.\n";
        //internal - available only in assembly;
        public void RetreiveData(string data)
        {
            AccessMod dataString = new AccessMod();
            dataString.publicStr = data;
            Console.Write(data.ToString() + "\n");
        }

        public void RetreiveData()
        {
            //throw new NotImplementedException();
        }
    }

    class AccessMod_Protected : AccessMod
    {

        
        public void RetreiveData(int data)
        {
            
            
            AccessMod_Protected modData = new AccessMod_Protected();
            modData.protectedStr = data.ToString();
            Console.Write(data.ToString() + "\n");
            
        }
    }

    /*class UserData_Mod : AccessMod_Protected
    {
        public string username;
        private string password; 
        protected int views;
        protected int comments;

        public void UserData_Print(string username, string password, int views, int comments)
        {
            this.username = username;
            this.password = password;
            this.views = views;
            this.comments = comments;
            
            Console.WriteLine("Username: " + username);

            UserData_Mod dataPassword = new UserData_Mod();
            UserData_Mod dataViews = new UserData_Mod();

            UserData_Mod dataComments = new UserData_Mod();
            Console.WriteLine("Password: ");
            dataPassword.RetreiveData(password);
            Console.WriteLine("View(s): ");
            dataViews.RetreiveData(views);
            Console.WriteLine("Comment(s): ");
            dataComments.RetreiveData(comments);

        }
    }*/
}
