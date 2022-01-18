using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<int> client1 = new Bank<int>();
            client1.setAccount(1001);
            client1.setBalance(150000);
            string client1Name = "Иванов Иван Иванович";
            client1.setName(client1Name);
            client1.readClient();
            Console.WriteLine();
            Bank<string> client2 = new Bank<string>();
            client2.setAccount("ABC15633DF8S");
            client2.setBalance(90000);
            string client2Name = "Петров Петр";
            client2.setName(client2Name);
            client2.readClient();
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    class Bank<T>
    {
        private T account;
        private int balance;
        private string[] name = { "null", "null", "null" };

        T Account
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
            }
        }

        int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public void setAccount(T account)
        {
            Account = account;
        }
        public void setBalance(int balance)
        {
            Balance = balance;
        }
        public void setName(string name)
        {
            string[] nameMassiv = name.Split();
            int t = 0;
            foreach (string s in nameMassiv)
            {
                this.name[t] = nameMassiv[t];
                t++;
            }


        }

        public void readClient()
        {
            Console.WriteLine("{0} {1} {2}", name[0], name[1], name[2]);
            Console.WriteLine(Account);
            Console.WriteLine(Balance);
        }
    }
}
