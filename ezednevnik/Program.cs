namespace Eshednevnik
{
    class Program
    {
        static DateTime date = DateTime.Now;
        static void Main()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            string date1 = date.ToShortDateString();
            int pos = 2;
            Strelki(pos, date1, key);
        }
        static void Strelki(int pos, string date1, ConsoleKeyInfo key)
        {
            key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos <= 1)
                    {
                        pos = 2;
                        Console.SetCursorPosition(0, pos);
                    }

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                }
                Console.Clear();
                Console.WriteLine(date1);
                Console.WriteLine("-----------------------");
                Perecl(pos, date1, key);
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                {
                    Data(date1, pos, key);
                }
            }
            Console.Clear();
            Environment.Exit(0);
        }
        static void Data(string date1, int pos, ConsoleKeyInfo key)
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.LeftArrow)
            {
                date = date.AddDays(-1);
                date1 = date.ToShortDateString();
                Main();
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                date = date.AddDays(1);
                date1 = date.ToShortDateString();
                Main();
            }
        }
        static void thirteenoct(string date1, int pos, ConsoleKeyInfo key)
        {
            List<string> zam = new List<string>();
            zam.Add("  1.Посмотреть что-нибудь страшное");
            zam.Add("  2.Сделать тыквенный латте");
            foreach (string item in zam)
                Console.WriteLine(item);
            if (pos == 2 && key.Key == ConsoleKey.Enter)
            {
                firstopisthirteenoct(pos, date1);
            }
            else if (pos == 3 && key.Key == ConsoleKey.Enter)
            {
                secondopisthirteenoct(pos, date1);
            }
            else if (key.Key == ConsoleKey.Backspace)
            {
                Main();
            }

        }
        static void firstopisthirteenoct(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Посмотреть что-нибудь страшное");
            opis.Add("--------------------------");
            opis.Add("Описание: Ужастик какой-то посмотреть.");
            opis.Add("Дата: 13.10.2023\r\nВремя: в 18:00.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void secondopisthirteenoct(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Сделать тыквенный латте");
            opis.Add("--------------------------");
            opis.Add("Описание: сварить тыквенный лате чтоб как в старбаксе.");
            opis.Add("Дата: 13.10.2023.\r\nВремя: 16:33");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void fifteenoct(string date1, int pos, ConsoleKeyInfo key)
        {
            List<string> zam = new List<string>();
            zam.Add("  1.Помыть террариум.");
            zam.Add("  2.Покормить улиток.");
            foreach (string item in zam)
                Console.WriteLine(item);
            if (pos == 2 && key.Key == ConsoleKey.Enter)
            {
                firstopisfifteenoct(pos, date1);
            }
            else if (pos == 3 && key.Key == ConsoleKey.Enter)
            {
                secondopisfifteenoct(pos, date1);
            }
        }
        static void firstopisfifteenoct(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Помыть террариум.");
            opis.Add("--------------------------");
            opis.Add("Описание: Помыть террариум улиткам и постирать маты.");
            opis.Add("Дата: 15.10.2023.\r\nВремя: 14:30");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void secondopisfifteenoct(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Покормить улиток.");
            opis.Add("--------------------------");
            opis.Add("Описание: Покормить улиток каким-нибудь салатиком.");
            opis.Add("Дата: 15.10.2023.\r\nВремя: в 15:30.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void thirtyoneoct(string date1, int pos, ConsoleKeyInfo key)
        {
            List<string> zam = new List<string>();
            zam.Add("  1.Жоска отметить хеллоувин.");
            zam.Add("  2.Попасть в вальгаллу.");
            foreach (string item in zam)
                Console.WriteLine(item);
            if (pos == 2 && key.Key == ConsoleKey.Enter)
            {
                firstopisthirtyoneoct(pos, date1);
            }
            else if (pos == 3 && key.Key == ConsoleKey.Enter)
            {
                secondopisthirtyoneoct(pos, date1);
            }
        }
        static void firstopisthirtyoneoct(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Жоска отметить хеллоувин.");
            opis.Add("--------------------------");
            opis.Add("Описание: Потусить в честь празднования хеллоувина.");
            opis.Add("Дата: 31.10.2023.\r\nВремя: с 15 до 23.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void secondopisthirtyoneoct(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Попасть в вальгаллу.");
            opis.Add("--------------------------");
            opis.Add("Описание: Напиться и подраться с кем-нибудь, и как итог, попасть в вальгаллу.");
            opis.Add("Дата: 31.10.2023.\r\nВремя: НАВСЕГДА.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void elevennov(string date1, int pos, ConsoleKeyInfo key)
        {
            List<string> zam = new List<string>();
            zam.Add("  1.Закупиться на алике.");
            foreach (string item in zam)
                Console.WriteLine(item);
            if (pos == 2 && key.Key == ConsoleKey.Enter)
            {
                firstopiselevennov(pos, date1);
            }
        }
        static void firstopiselevennov(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Закупиться на алике.");
            opis.Add("--------------------------");
            opis.Add("Описание: Закупиться на алиэкспресс(скидки как никак).");
            opis.Add("Дата: 11.11.2023.\r\nВремя: в 12:00.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }

        static void Perecl(int pos, string date1, ConsoleKeyInfo key)
        {
            if (date1 == "13.10.2023")
            {
                thirteenoct(date1, pos, key);
            }
            else if (date1 == "15.10.2023")
            {
                fifteenoct(date1, pos, key);

            }
            else if (date1 == "31.10.2023")
            {
                thirtyoneoct(date1, pos, key);
            }
            else if (date1 == "11.11.2023")
            {
                elevennov(date1, pos, key);
            }
            Data(date1, pos, key);
        }
    }
}
