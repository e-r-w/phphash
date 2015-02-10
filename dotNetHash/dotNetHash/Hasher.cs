using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dotNetHash
{
    public static class Hasher
    {
        private const string Key = "secret";

        public static string Hash(string id, string timeStamp)
        {
            var keyAsBarray = GetBytes(Key);
            using (var hmac = new HMACSHA256(keyAsBarray))
            {
                var data = id + timeStamp;
                var dataAsBarray = GetBytes(data);
                
                hmac.ComputeHash(dataAsBarray);
                var hashString = GetString(hmac.Hash);
                return hashString;
            }
        }

        private static byte[] GetBytes(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        private static string GetString(byte[] ba)
        {
            var hex = BitConverter.ToString(ba);
            return hex.Replace("-", "").ToLower();
        }
    }
}
