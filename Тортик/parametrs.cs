using System.Reflection.Emit;
using System.Runtime.ExceptionServices;

namespace Тортик
{
    internal class parametr
    {
        private static int izcena;
        private static List<string> spisok = new List<string> { };

        public static int Start(int x)
        {
            
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выберите параметр торта");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("----------------------------------");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("  Форма");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("  Размер");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("  Вкус коржей");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("  Количество коржей");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("  Глазурь");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("  Декор");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("  Конец заказа");
           
            
            Console.SetCursorPosition(0, x);
            Console.WriteLine("->");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine($"Итоговая цена: {izcena}");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("Ваш торт: ");
            for (int i = 0; i < spisok.Count; i++)
            {
                Console.SetCursorPosition(0, i+12);
                Console.WriteLine(spisok[i]);
            }
            return izcena;
        }
        public static void strela(int x, int a, int per)
        {
            int el = per;
            int position = x;
            ConsoleKeyInfo strelka;
            do
            {
                perecluchenie(a, position);
                strelka = Console.ReadKey();
                if (strelka.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (strelka.Key == ConsoleKey.DownArrow)
                {
                    position++;  
                }
                else if (strelka.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            } while (strelka.Key != ConsoleKey.Enter);
            vybor(position, el);
        }
   
        private static void vybor(int posit, int a)
        {
            if (a == 1)
            {
                if (posit == 2)
                {
                    strela(2, 2, 2);
                }
                if (posit == 3)
                {
                    strela(2, 3, 3);
                }
                if (posit == 4)
                {
                    strela(2, 4, 4);
                }
                if (posit == 5)
                {
                    strela(2, 5, 5);

                }
                if (posit == 6)
                {
                    strela(2, 6, 6);
                }
                if (posit == 7)
                {
                    strela(2, 7, 7);
                }
                if (posit == 8)
                {

                }
            }
            if (a == 2)
            {
                if (posit == 2)
                {
                    izcena = izcena + 500;
                    spisok.Add("Круг - 500");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 3)
                {
                    izcena = izcena + 500;
                    spisok.Add("Квадрат - 500");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 4)
                {
                    izcena = izcena + 500;
                    spisok.Add("Прямоугольник - 500");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 5)
                {
                    izcena = izcena + 700;
                    spisok.Add("Сердечко - 700");
                    strela(2, 1, 1);
                    Start(2);
                }
            }
            if (a == 3)
            {
                if (posit == 2)
                {
                    izcena = izcena + 1000;
                    spisok.Add("Маленький (Диаметр - 16 см, 8 порций) - 1000");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 3)
                {
                    izcena = izcena + 1200;
                    spisok.Add("Обычный (Диаметр - 18 см, 10 порций) - 1200");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 4)
                {
                    izcena = izcena + 2000;
                    spisok.Add("Большой (Диаметр - 28 см, 24 порций) - 2000");
                    strela(2, 1, 1);
                    Start(2);
                }
            }
            if (a == 4)
            {
                if (posit == 2)
                {
                    izcena = izcena + 100;
                    spisok.Add("Ванильный - 100");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 3)
                {
                    izcena = izcena + 100;
                    spisok.Add("Шоколадный - 100");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 4)
                {
                    izcena = izcena + 150;
                    spisok.Add("Карамельный - 150");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 5)
                {
                    izcena = izcena + 200;
                    spisok.Add("Ягодный - 200");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 6)
                {
                    izcena = izcena + 250;
                    spisok.Add("Кокосовый - 250");
                    strela(2, 1, 1);
                    Start(2);
                }
            }
            if (a == 5)
            {
                if (posit == 2)
                {
                    izcena = izcena + 200;
                    spisok.Add("1 корж - 200");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 3)
                {
                    izcena = izcena + 400;
                    spisok.Add("2 коржа - 400");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 4)
                {
                    izcena = izcena + 600;
                    spisok.Add("3 коржа - 600");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 5)
                {
                    izcena = izcena + 800;
                    spisok.Add("4 коржа - 800");
                    strela(2, 1, 1);
                    Start(2);
                }
            }
            if (a == 6)
            {
                if (posit == 2)
                {
                    izcena = izcena + 100;
                    spisok.Add("Шоколад - 100");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 3)
                {
                    izcena = izcena + 100;
                    spisok.Add("Крем - 100");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 4)
                {
                    izcena = izcena + 150;
                    spisok.Add("Бизе - 150");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 5)
                {
                    izcena = izcena + 150;
                    spisok.Add("Драже - 150");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 6)
                {
                    izcena = izcena + 200;
                    spisok.Add("Ягоды - 200");
                    strela(2, 1, 1);
                    Start(2);
                }
            }
            if (a == 7)
            {
                if (posit == 2)
                {
                    izcena = izcena + 150;
                    spisok.Add("Шоколадная - 150");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 3)
                {
                    izcena = izcena + 150;
                    spisok.Add("Ягодная - 150");
                    strela(2, 1, 1);
                    Start(2);
                }
                if (posit == 4)
                {
                    izcena = izcena + 150;
                    spisok.Add("Кремовая - 150");
                    strela(2, 1, 1);
                    Start(2);
                }
            }
        }
        private static void Start2(int pos)
        {
            Start(pos);
        }  
        public static void toch(int x, string a)
        {
            Console.Clear();
            Console.WriteLine($"{a}");
            Console.SetCursorPosition(0, x);
            Console.WriteLine("->");
        }
        
        private static void perecluchenie(int a, int pos)
        {
            if (a == 1)
            {
                Start2(pos);
            }
            if (a == 2)
            {
                string text = "Выберите пункт из меню\n" +
                    "---------------------\n" +
                    "   Круг - 500\n" +
                    "   Квадрат - 500\n" +
                    "   Прямоугольник - 500\n" +
                    "   Сердечко - 700\n";
                toch(pos, text);
            }
            if (a == 3)
            {
                string text = "Выберите пункт из меню\n" +
                    "--------------------\n" +
                    "  Маленький (Диаметр - 16 см, 8 порций) - 1000\n" +
                    "  Обычный (Диаметр - 18 см, 10 порций) - 1200\n" +
                    "  Большой (Диаметр - 28 см, 24 порций) - 2000\n";
                toch(pos, text);
            }
            if (a == 4)
            {
                string text = "Выберите пункт из меню\n" +
                    "--------------------\n" +
                    "  Ванильный - 100\n" +
                    "  Шоколадный - 100\n" +
                    "  Карамельный - 150\n" +
                    "  Ягодный - 200\n" +
                    "  Кокосовый - 250\n";
                toch(pos, text);
            }
            if (a == 5)
            {
                string text = "Выберите пункт из меню\n" +
                    "--------------------\n" +
                    "  1 корж - 200\n" +
                    "  2 коржа - 400\n" +
                    "  3 коржа - 600\n" +
                    "  4 коржа - 800\n";
                toch(pos, text);
            }
            if (a == 6)
            {
                string text = "Выберите пункт из меню\n" +
                    "--------------------\n" +
                    "  Шоколад - 100\n" +
                    "  Крем - 100\n" +
                    "  Бизе - 150\n" +
                    "  Драже - 150\n" +
                    "  Ягода - 200\n";
                toch(pos, text);
            }
            if (a == 7)
            {
                string text = "Выберите пункт из меню\n" +
                    "--------------------\n" +
                    "  Шоколадная - 150\n" +
                    "  Ягодная - 150\n" +
                    "  Кремовая - 150\n";       
                toch(pos, text);
            }       
            if (a == 8)
            {
                
            }
        }
        public static void file(int peredacha)
        {
            if (peredacha == 1)
            {
                string t = "";
                for (int i = 0; i < spisok.Count; i++)
                {
                    t = t + $"{spisok[i]}";
                }
                File.WriteAllText("C:\\Users\\mirzo\\OneDrive\\Рабочий стол\\торт.txt", $"Ваши заказы:\n\n" +
                    $"Ваш торт:\n{t}" +
                    $"\n\nИтоговая цена: {izcena}");
            }
            if (peredacha == 2)
            {
                string t = "";
                for (int i = 0; i < spisok.Count; i++)
                {
                    t = t + $"{spisok[i]}";
                }
                File.WriteAllText("C:\\Users\\mirzo\\OneDrive\\Рабочий стол\\торт.txt", $"Ваши заказы:\n\n" +
                    $"Ваш торт:\n{t}" +
                    $"\n\nИтоговая цена: {izcena}");
            }
        }
            public static void clear()
            {
                izcena = 0;
                spisok.Clear();
            }
        }
    }

    

