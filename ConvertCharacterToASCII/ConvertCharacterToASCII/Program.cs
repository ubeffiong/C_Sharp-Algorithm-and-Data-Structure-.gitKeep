using System;

namespace ConvertCharacterToASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte val = 36;
            //method 1
            int unicode = 65;
            char character = (char)unicode;
            string text = character.ToString();
            Console.WriteLine(text);

            //method 2
            string asciichar = (Convert.ToChar(65)).ToString();
            Console.WriteLine(asciichar);
            Console.WriteLine(asciichar.ToString());

        }
        //method 3
        static char asciiSymbol(byte val)
        {
            if (val < 32) return '.';  // Non-printable ASCII
            if (val < 127) return (char)val;   // Normal ASCII
                                               // Workaround the hole in Latin-1 code page
            if (val == 127) return '.';
            if (val < 0x90) return "€.‚ƒ„…†‡ˆ‰Š‹Œ.Ž."[val & 0xF];
            if (val < 0xA0) return ".‘’“”•–—˜™š›œ.žŸ"[val & 0xF];
            if (val == 0xAD) return '.';   // Soft hyphen: this symbol is zero-width even in monospace fonts
            return (char)val;   // Normal Latin-1
        }
    }
}
