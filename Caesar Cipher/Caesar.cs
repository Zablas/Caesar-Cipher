using System;
using System.Linq;

namespace Caesar_Cipher
{
    public class Caesar
    {
        /// <summary>
        /// Encrypts a single letter
        /// </summary>
        /// <param name="c">The letter to encrypt</param>
        /// <param name="shift">Number of characters to be shifted</param>
        /// <returns>The encrypted letter</returns>
        public static char Cipher(char c, int shift)
        {
            if (!char.IsLetter(c)) return c;
            char delta = char.IsUpper(c) ? 'A' : 'a';
            return (char)(((c + shift - delta) % 26) + delta);
        }
        /// <summary>
        /// Encrypts a string
        /// </summary>
        /// <param name="toCipher">The string to encrypt</param>
        /// <param name="shift">Number of characters to be shifted</param>
        /// <returns>The encrypted string</returns>
        public static string Encipher(string toCipher, int shift) => new string(toCipher.Select(x => Cipher(x, shift)).ToArray());
        /// <summary>
        /// Decrypts a string
        /// </summary>
        /// <param name="toDecipher">The string to decrypt</param>
        /// <param name="shift">Number of characters to be shifted</param>
        /// <returns>The decrypted string</returns>
        public static string Decipher(string toDecipher, int shift) => Encipher(toDecipher, 26 - shift);
        static void Main(string[] args)
        {
            Console.Write("Enter a string to encrypt: ");
            string toEncrypt = Console.ReadLine();
            Console.Write("Enter a shift (the key): ");
            int key = int.Parse(Console.ReadLine());
            string cipherText = Encipher(toEncrypt, key);
            Console.WriteLine("Encrypted string: {0}", cipherText);
            Console.WriteLine("Decrypted string: {0}", Decipher(cipherText, key));
            Console.ReadKey();
        }
    }
}
