using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFxCopRules
{
    public class MD5User
    {
        System.Security.Cryptography.MD5 md5Prop { get; set; }
        System.Security.Cryptography.MD5 md5Field;
        private static string md5Something = typeof(System.Security.Cryptography.MD5).Name;
        private static string md5SomethingElse = System.Security.Cryptography.HashAlgorithm.Create().GetType().FullName;
        private static string md5AnotherThing = System.Security.Cryptography.HashAlgorithm.Create(md5Something).GetType().FullName;

        public MD5User()
        {
            var hashedBytes = System.Security.Cryptography.MD5
                .Create()
                .ComputeHash(System.Text.Encoding.UTF8.GetBytes("foo"));
            var base64 = Convert.ToBase64String(hashedBytes);
            Console.WriteLine(base64);
        }
    }
}
