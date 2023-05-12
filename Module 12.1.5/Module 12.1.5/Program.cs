namespace Module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User { Login = "123", Name = "Полина Павлова", IsPremium = true },
                new User { Login = "Svets", Name = "Светлана Северова", IsPremium = false },
                new User { Login = "NKVD", Name = "Борис Финкин",  IsPremium = false},
                new User { Login = "Zhozh", Name = "Олег Жлобов", IsPremium = true },
                new User { Login = "Figs", Name = "Артем Темный", IsPremium = false },
                new User { Login = "Pupa", Name = "Мария Лупина", IsPremium = true },
                new User { Login = "Brus", Name = "Данил Матвеев", IsPremium = true }
            };                  
            
                Console.WriteLine("\n Введите логин:");
                string login = Console.ReadLine();

                foreach (User user in users)
                {
                    if (user.Login == login)
                    {
                        Console.WriteLine($"Привет, {user.Name}");
                        
                        if (user.IsPremium != true)
                        {
                            User.ShowAds();
                        }
                        break;
                    }
                }
                         
            Console.ReadKey();            
        }
    }
}