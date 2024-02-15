using System.ComponentModel.Design;

namespace Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User("ivanov", "ivanov"));
            users.Add(new User("petrov", "petrov"));
            users.Add(new User("sidorov", "sidorov"));

            Console.WriteLine("введите логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("введите пароль: ");
            string pass = Console.ReadLine();
            User u = new User(login, pass);

            bool isRegistered = false;
            foreach (User user in users)
            {
                if (user == u)
                    isRegistered = true;
            }
            string res = isRegistered  ? "авторизация успешна" : "не авторизован";

            Console.WriteLine(res);
        }
    }
}