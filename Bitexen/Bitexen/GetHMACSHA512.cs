using System;
using System.Security.Cryptography;
using System.Text;

namespace Bitexen
{
    class GetHMACSHA512
    {
        public static Object hash_hmac(string signatureString, string secretKey, bool raw_output = false)
        {
            var enc = Encoding.UTF8;
            HMACSHA512 hmac = new HMACSHA512(enc.GetBytes(secretKey));
            hmac.Initialize();

            byte[] buffer = enc.GetBytes(signatureString);
            if (raw_output)
            {
                return hmac.ComputeHash(buffer);
            }
            else
            {
                return BitConverter.ToString(hmac.ComputeHash(buffer)).Replace("-", "").ToLower();
            }
        }
    }
}
