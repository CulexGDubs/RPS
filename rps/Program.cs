using System;

namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string result = p.rps("scissors", "rock");
            System.Console.WriteLine(result);
        }

        public string rps(string a, string b)
        {
            if(a == b)
            {
                return "TIE";
            }
            
            switch (a)
            {
                case "rock": if(b == "paper"){
                    return "Player 2 wins";
                }
                else{
                    return "Player 1 wins";
                }

                case "paper": if(b == "scissors"){
                    return "Player 2 wins";
                }
                else{
                    return "Player 1 wins";
                }

                case "scissors": if(b == "rock"){
                    return "Player 2 wins";
                }
                else{
                    return "Player 1 wins";
                }

                default: return "invalid input";
            }
        }
    }
}
