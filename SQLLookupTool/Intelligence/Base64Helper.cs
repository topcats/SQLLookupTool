using System;
using System.Text;

namespace SQLLookupTool.Intelligence
{
    /// <summary>
    /// Provides helper methods for encoding and decoding strings using Base64 encoding.
    /// </summary>
    /// <remarks>This class is intended for internal use and offers static methods to convert between plain
    /// text and Base64-encoded strings using UTF-8 encoding. All methods throw exceptions for invalid input to ensure
    /// correct usage.</remarks>
    internal static class Base64Helper
    {

        /// <summary>
        /// Convert a plain string to Base64
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string StringToBase64(string plainText)
        {
            if (plainText == null)
                throw new ArgumentNullException(nameof(plainText), "Input string cannot be null.");

            // Convert the string into bytes using UTF-8 encoding
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            // Convert the byte array to a Base64 string
            return Convert.ToBase64String(plainBytes);
        }


        /// <summary>
        /// Convert a Base64 string back to plain text
        /// </summary>
        /// <param name="base64Text"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        public static string Base64ToString(string base64Text)
        {
            if (base64Text == null)
                throw new ArgumentNullException(nameof(base64Text), "Input Base64 string cannot be null.");

            try
            {
                // Convert Base64 string to byte array
                byte[] base64Bytes = Convert.FromBase64String(base64Text);

                // Convert bytes back to UTF-8 string
                return Encoding.UTF8.GetString(base64Bytes);
            }
            catch (FormatException)
            {
                throw new FormatException("The provided string is not a valid Base64 encoded string.");
            }
        }
    }
}
