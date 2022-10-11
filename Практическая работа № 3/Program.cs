namespace Практическая_работа___3
{
    internal class Program
    {
        static void Main()
        {
            ChangeOfOctaves();
        }
        static void ChangeOfOctaves()
        {
            Console.WriteLine("Переключение между октавами - от F2 и до F7");
            ConsoleKeyInfo OctaveButton = Console.ReadKey();
            if (OctaveButton.Key == ConsoleKey.F2) SecondOctave();
            if (OctaveButton.Key == ConsoleKey.F3) ThirdOctave();
            if (OctaveButton.Key == ConsoleKey.F4) FourthOctave();
            if (OctaveButton.Key == ConsoleKey.F5) FifthOctave();
            if (OctaveButton.Key == ConsoleKey.F6) SixthOctave();
            if (OctaveButton.Key == ConsoleKey.F7) SeventhOctave();
        }
        static void SecondOctave()
        {
            int[] SecondOctave = new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            Console.WriteLine("2 октава");
            ConsoleKeyInfo Button = Console.ReadKey();
            while (Button.Key != ConsoleKey.Escape)
            {
                if (Button.Key == ConsoleKey.A) Console.Beep(SecondOctave[0], 400);
                if (Button.Key == ConsoleKey.W) Console.Beep(SecondOctave[1], 400);
                if (Button.Key == ConsoleKey.S) Console.Beep(SecondOctave[2], 400);
                if (Button.Key == ConsoleKey.D) Console.Beep(SecondOctave[3], 400);
                if (Button.Key == ConsoleKey.R) Console.Beep(SecondOctave[4], 400);
                if (Button.Key == ConsoleKey.F) Console.Beep(SecondOctave[5], 400);
                if (Button.Key == ConsoleKey.G) Console.Beep(SecondOctave[6], 400);
                if (Button.Key == ConsoleKey.Y) Console.Beep(SecondOctave[7], 400);
                if (Button.Key == ConsoleKey.H) Console.Beep(SecondOctave[8], 400);
                if (Button.Key == ConsoleKey.J) Console.Beep(SecondOctave[9], 400);
                if (Button.Key == ConsoleKey.I) Console.Beep(SecondOctave[10], 400);
                if (Button.Key == ConsoleKey.K) Console.Beep(SecondOctave[11], 400);
                if (Button.Key == ConsoleKey.F3) Entrance3();
                if (Button.Key == ConsoleKey.F4) Entrance4();
                if (Button.Key == ConsoleKey.F5) Entrance5();
                if (Button.Key == ConsoleKey.F6) Entrance6();
                if (Button.Key == ConsoleKey.F7) Entrance7();
                Console.Clear();
                Button = Console.ReadKey();
            }
        }
        static void ThirdOctave()
        {
            int[] ThirdOctave = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            Console.WriteLine("3 октава");
            ConsoleKeyInfo Button = Console.ReadKey();
            while (Button.Key != ConsoleKey.Escape)
            {
                if (Button.Key == ConsoleKey.A) Console.Beep(ThirdOctave[0], 400);
                if (Button.Key == ConsoleKey.W) Console.Beep(ThirdOctave[1], 400);
                if (Button.Key == ConsoleKey.S) Console.Beep(ThirdOctave[2], 400);
                if (Button.Key == ConsoleKey.D) Console.Beep(ThirdOctave[3], 400);
                if (Button.Key == ConsoleKey.R) Console.Beep(ThirdOctave[4], 400);
                if (Button.Key == ConsoleKey.F) Console.Beep(ThirdOctave[5], 400);
                if (Button.Key == ConsoleKey.G) Console.Beep(ThirdOctave[6], 400);
                if (Button.Key == ConsoleKey.Y) Console.Beep(ThirdOctave[7], 400);
                if (Button.Key == ConsoleKey.H) Console.Beep(ThirdOctave[8], 400);
                if (Button.Key == ConsoleKey.J) Console.Beep(ThirdOctave[9], 400);
                if (Button.Key == ConsoleKey.I) Console.Beep(ThirdOctave[10], 400);
                if (Button.Key == ConsoleKey.K) Console.Beep(ThirdOctave[11], 400);
                if (Button.Key == ConsoleKey.F2) Entrance2();
                if (Button.Key == ConsoleKey.F4) Entrance4();
                if (Button.Key == ConsoleKey.F5) Entrance5();
                if (Button.Key == ConsoleKey.F6) Entrance6();
                if (Button.Key == ConsoleKey.F7) Entrance7();
                Console.Clear();
                Button = Console.ReadKey();
            }
        }
        static void FourthOctave()
        {
            int[] FourthOctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            Console.WriteLine("4 октава");
            ConsoleKeyInfo Button = Console.ReadKey();
            while (Button.Key != ConsoleKey.Escape)
            {
                if (Button.Key == ConsoleKey.A) Console.Beep(FourthOctave[0], 400);
                if (Button.Key == ConsoleKey.W) Console.Beep(FourthOctave[1], 400);
                if (Button.Key == ConsoleKey.S) Console.Beep(FourthOctave[2], 400);
                if (Button.Key == ConsoleKey.D) Console.Beep(FourthOctave[3], 400);
                if (Button.Key == ConsoleKey.R) Console.Beep(FourthOctave[4], 400);
                if (Button.Key == ConsoleKey.F) Console.Beep(FourthOctave[5], 400);
                if (Button.Key == ConsoleKey.G) Console.Beep(FourthOctave[6], 400);
                if (Button.Key == ConsoleKey.Y) Console.Beep(FourthOctave[7], 400);
                if (Button.Key == ConsoleKey.H) Console.Beep(FourthOctave[8], 400);
                if (Button.Key == ConsoleKey.J) Console.Beep(FourthOctave[9], 400);
                if (Button.Key == ConsoleKey.I) Console.Beep(FourthOctave[10], 400);
                if (Button.Key == ConsoleKey.K) Console.Beep(FourthOctave[11], 400);
                if (Button.Key == ConsoleKey.F2) Entrance2();
                if (Button.Key == ConsoleKey.F3) Entrance3();
                if (Button.Key == ConsoleKey.F5) Entrance5();
                if (Button.Key == ConsoleKey.F6) Entrance6();
                if (Button.Key == ConsoleKey.F7) Entrance7();
                Console.Clear();
                Button = Console.ReadKey();
            }
        }
        static void FifthOctave()
        {
            int[] FifthOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            Console.WriteLine("5 октава");
            ConsoleKeyInfo Button = Console.ReadKey();
            while (Button.Key != ConsoleKey.Escape)
            {
                if (Button.Key == ConsoleKey.A) Console.Beep(FifthOctave[0], 400);
                if (Button.Key == ConsoleKey.W) Console.Beep(FifthOctave[1], 400);
                if (Button.Key == ConsoleKey.S) Console.Beep(FifthOctave[2], 400);
                if (Button.Key == ConsoleKey.D) Console.Beep(FifthOctave[3], 400);
                if (Button.Key == ConsoleKey.R) Console.Beep(FifthOctave[4], 400);
                if (Button.Key == ConsoleKey.F) Console.Beep(FifthOctave[5], 400);
                if (Button.Key == ConsoleKey.G) Console.Beep(FifthOctave[6], 400);
                if (Button.Key == ConsoleKey.Y) Console.Beep(FifthOctave[7], 400);
                if (Button.Key == ConsoleKey.H) Console.Beep(FifthOctave[8], 400);
                if (Button.Key == ConsoleKey.J) Console.Beep(FifthOctave[9], 400);
                if (Button.Key == ConsoleKey.I) Console.Beep(FifthOctave[10], 400);
                if (Button.Key == ConsoleKey.K) Console.Beep(FifthOctave[11], 400);
                if (Button.Key == ConsoleKey.F2) Entrance2();
                if (Button.Key == ConsoleKey.F3) Entrance3();
                if (Button.Key == ConsoleKey.F4) Entrance4();
                if (Button.Key == ConsoleKey.F6) Entrance6();
                if (Button.Key == ConsoleKey.F7) Entrance7();
                Console.Clear();
                Button = Console.ReadKey();
            }
        }
        static void SixthOctave()
        {
            int[] SixthOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            Console.WriteLine("6 октава");
            ConsoleKeyInfo Button = Console.ReadKey();
            while (Button.Key != ConsoleKey.Escape)
            {
                if (Button.Key == ConsoleKey.A) Console.Beep(SixthOctave[0], 400);
                if (Button.Key == ConsoleKey.W) Console.Beep(SixthOctave[1], 400);
                if (Button.Key == ConsoleKey.S) Console.Beep(SixthOctave[2], 400);
                if (Button.Key == ConsoleKey.D) Console.Beep(SixthOctave[3], 400);
                if (Button.Key == ConsoleKey.R) Console.Beep(SixthOctave[4], 400);
                if (Button.Key == ConsoleKey.F) Console.Beep(SixthOctave[5], 400);
                if (Button.Key == ConsoleKey.G) Console.Beep(SixthOctave[6], 400);
                if (Button.Key == ConsoleKey.Y) Console.Beep(SixthOctave[7], 400);
                if (Button.Key == ConsoleKey.H) Console.Beep(SixthOctave[8], 400);
                if (Button.Key == ConsoleKey.J) Console.Beep(SixthOctave[9], 400);
                if (Button.Key == ConsoleKey.I) Console.Beep(SixthOctave[10], 400);
                if (Button.Key == ConsoleKey.K) Console.Beep(SixthOctave[11], 400);
                if (Button.Key == ConsoleKey.F2) Entrance2();
                if (Button.Key == ConsoleKey.F3) Entrance3();
                if (Button.Key == ConsoleKey.F4) Entrance4();
                if (Button.Key == ConsoleKey.F5) Entrance5();
                if (Button.Key == ConsoleKey.F7) Entrance7();
                Console.Clear();
                Button = Console.ReadKey();
            }
        }
        static void SeventhOctave()
        {
            int[] SeventhOctave = new int[] { 2093, 327, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            Console.WriteLine("7 октава");
            ConsoleKeyInfo Button = Console.ReadKey();
            while (Button.Key != ConsoleKey.Escape)
            {
                if (Button.Key == ConsoleKey.A) Console.Beep(SeventhOctave[0], 400);
                if (Button.Key == ConsoleKey.W) Console.Beep(SeventhOctave[1], 400);
                if (Button.Key == ConsoleKey.S) Console.Beep(SeventhOctave[2], 400);
                if (Button.Key == ConsoleKey.D) Console.Beep(SeventhOctave[3], 400);
                if (Button.Key == ConsoleKey.R) Console.Beep(SeventhOctave[4], 400);
                if (Button.Key == ConsoleKey.F) Console.Beep(SeventhOctave[5], 400);
                if (Button.Key == ConsoleKey.G) Console.Beep(SeventhOctave[6], 400);
                if (Button.Key == ConsoleKey.Y) Console.Beep(SeventhOctave[7], 400);
                if (Button.Key == ConsoleKey.H) Console.Beep(SeventhOctave[8], 400);
                if (Button.Key == ConsoleKey.J) Console.Beep(SeventhOctave[9], 400);
                if (Button.Key == ConsoleKey.I) Console.Beep(SeventhOctave[10], 400);
                if (Button.Key == ConsoleKey.K) Console.Beep(SeventhOctave[11], 400);
                if (Button.Key == ConsoleKey.F2) Entrance2();
                if (Button.Key == ConsoleKey.F3) Entrance3();
                if (Button.Key == ConsoleKey.F4) Entrance4();
                if (Button.Key == ConsoleKey.F5) Entrance5();
                if (Button.Key == ConsoleKey.F6) Entrance6();
                Console.Clear();
                Button = Console.ReadKey();
            }
        }
        static void Entrance2()
        {
            SecondOctave();
        }
        static void Entrance3()
        {
            ThirdOctave();
        }
        static void Entrance4()
        {
            FourthOctave();
        }
        static void Entrance5()
        {
            FifthOctave();
        }
        static void Entrance6()
        {
            SixthOctave();
        }
        static void Entrance7()
        {
            SeventhOctave();
        }
    }
}