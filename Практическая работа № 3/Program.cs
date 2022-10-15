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
            int[] octave = SmenaOctaves(1);

            if (OctaveButton.Key == ConsoleKey.F2)
            {
                octave = SmenaOctaves(2);
                Octave(octave, "2 октава");
            }
            if (OctaveButton.Key == ConsoleKey.F3)
            {
                octave = SmenaOctaves(3);
                Octave(octave, "3 октава");
            }

            if (OctaveButton.Key == ConsoleKey.F4)
            {
                 octave = SmenaOctaves(4);
                 Octave(octave, "4 октава");
            }
            if (OctaveButton.Key == ConsoleKey.F5)
            {
                 octave = SmenaOctaves(5);
                 Octave(octave, "5 октава");
             }
            if (OctaveButton.Key == ConsoleKey.F6)
            {
                 octave = SmenaOctaves(6);
                 Octave(octave, "6 октава");
            }
            if (OctaveButton.Key == ConsoleKey.F7)
            {
                 octave = SmenaOctaves(3);
                 Octave(octave, "7 октава");
            }

           
        }
        static int[] Octave(int[] passedOctave, string textOctave)
        {
             Console.WriteLine(textOctave);
             ConsoleKeyInfo Button = Console.ReadKey();
             while (true)
             {
                 if (Button.Key == ConsoleKey.A) Console.Beep(passedOctave[0], 400);
                 if (Button.Key == ConsoleKey.W) Console.Beep(passedOctave[1], 400);
                 if (Button.Key == ConsoleKey.S) Console.Beep(passedOctave[2], 400);
                 if (Button.Key == ConsoleKey.D) Console.Beep(passedOctave[3], 400);
                 if (Button.Key == ConsoleKey.R) Console.Beep(passedOctave[4], 400);
                 if (Button.Key == ConsoleKey.F) Console.Beep(passedOctave[5], 400);
                 if (Button.Key == ConsoleKey.G) Console.Beep(passedOctave[6], 400);                  
                 if (Button.Key == ConsoleKey.Y) Console.Beep(passedOctave[7], 400);
                 if (Button.Key == ConsoleKey.H) Console.Beep(passedOctave[8], 400);
                 if (Button.Key == ConsoleKey.J) Console.Beep(passedOctave[9], 400);
                 if (Button.Key == ConsoleKey.I) Console.Beep(passedOctave[10], 400);
                 if (Button.Key == ConsoleKey.K) Console.Beep(passedOctave[11], 400);
                 if (Button.Key == ConsoleKey.F2 || Button.Key == ConsoleKey.F3 || Button.Key == ConsoleKey.F4 || Button.Key == ConsoleKey.F5 || Button.Key == ConsoleKey.F6 || Button.Key == ConsoleKey.F5) ChangeOfOctaves();
                 Console.Clear();
                 Button = Console.ReadKey();
             }
        }

        static int[] SmenaOctaves(int octave)
        {
             int[] SecondOctave2 = new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
             int[] ThirdOctave3 = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
             int[] FourthOctave4 = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
             int[] FifthOctave5 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
             int[] SixthOctave6 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
             int[] SeventhOctave7 = new int[] { 2093, 327, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };

             if (octave == 2) return SecondOctave2;
             else if (octave == 3) return ThirdOctave3;
             else if (octave == 4) return FourthOctave4;
             else if (octave == 5) return FifthOctave5;
             else if (octave == 6) return SixthOctave6;
             else return SeventhOctave7;
        }
    }
}