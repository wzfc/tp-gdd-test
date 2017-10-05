using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil
{
    class Cryptography
    {
        public static String getSHA256String(String s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            byte[] hashBytes = SHA256.Create().ComputeHash(bytes);

            String hexString =  BitConverter.ToString(hashBytes);
            return hexString.Replace("-", "").ToLower();
        }
    }
}
