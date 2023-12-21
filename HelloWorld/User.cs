using System;

namespace HelloWorld
{
    public class User : IUser
    {
        public string GetName()
        {
            return Environment.UserName;
        }
    }
}