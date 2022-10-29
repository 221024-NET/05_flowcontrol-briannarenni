using System;

namespace FlowControl {
    public class Program {
        //create global variables to hold users login data.
        public static string username;
        public static string password;

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            //Challenge 1. Temperature Advice
            int temp = GetValidTemperature();
            GiveActivityAdvice(temp);

            //Challenge 2. Login system.
            Register();
            if (Login()) {
                Console.WriteLine("Congratulations, You successfully logged in.");
            }

            //Challenge 3. Ternary Operators
            temp = GetValidTemperature();
            GetTemperatureTernary(temp);
        }

        // Challenge 1
        public static int GetValidTemperature() {
            Console.WriteLine("Enter temperature: ");
            string userTemp = Console.ReadLine();
            int temp;
            bool validTemp = int.TryParse(userTemp, out temp);
            return temp;
        }

        public static void GiveActivityAdvice(int temp) {
            Console.WriteLine($"Current temperature: {temp} degrees");


            // 20 <= n < 40 = thawed out
            // 40 <= n < 60 = feels like Autumn
            // 60 <= n < 80 = perfect outdoor workout temperature
            // 80 <= n < 90 = niiice
            // 90 <= n < 100 = hella hot
            // 100 <= n < 135 = hottest

            if (temp < -20) {
                Console.WriteLine("hella cold");
            } else if (temp >= -20 && temp < 0) {
                Console.WriteLine("pretty cold");
            } else if (temp >= 0 && temp < 20) {
                Console.WriteLine("cold");
            } else if (temp >= 20 && temp < 40) {
                Console.WriteLine("thawed out");
            } else if (temp >= 40 && temp < 60) {
                Console.WriteLine("feels like Autumn");
            } else if (temp >= 60 && temp < 80) {
                Console.WriteLine("perfect outdoor workout temperature");
            } else if (temp >= 80 && temp < 90) {
                Console.WriteLine("niiice");
            } else if (temp >= 90 && temp < 100) {
                Console.WriteLine("hella hot");
            } else if (temp >= 90 && temp < 135) {
                Console.WriteLine("hottest");
            }
        }

        // Challenge 2
        public static void Register() {
            Console.WriteLine("Enter username: ");
            Program.username = Console.ReadLine();
            Console.WriteLine("Username saved.");

            Console.WriteLine("Enter password: ");
            Program.password = Console.ReadLine();
            Console.WriteLine("Password saved.");

        }

        public static bool Login() {
            bool repeatPrompts = true;
            bool validLogin = false;
            while (repeatPrompts) {
                Console.WriteLine("Enter saved username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter saved password: ");
                string password = Console.ReadLine();

                if (username == Program.username && password == Program.password) {
                    validLogin = true;
                    repeatPrompts = false;
                    break;
                } else {
                    Console.WriteLine("Incorrect username or password. Please enter again.");
                    continue;
                }
            }

            return validLogin;
        }

        // Challenge 3
        // This method as one int parameter.
        // It checks is the int is
        // <=42, between 43 and 78 inclusive, or > 78.
        // For each temperature range, a different advice is given.
        public static void GetTemperatureTernary(int temp) {
            if (temp <= 42) {
                Console.WriteLine($"{temp} is too cold!");
            } else if (temp >= 43 && temp <= 78) {
                Console.WriteLine($"{temp} is an ok temperature.");
            } else if (temp > 78) {
                Console.WriteLine($"{temp} is too hot!");
            }

        }
    } // end of Program()
}
