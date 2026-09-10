using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.EC2.Model;

namespace AWSSDK_DotNet35.UnitTests.EC2
{
    [TestClass]
    public class PasswordTest
    {
        private const int KeySizeInBits = 2048;

        // Around one key in forty qualifies, so the cap only exists to fail loudly instead of
        // spinning forever if key generation ever stops behaving randomly.
        private const int MaxKeyGenerationAttempts = 2000;

        // Test an issue with certain combination of private key and encrypted passwords that were causing a encoding issue while decrypting the password.
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestMissingLeadingZeroIssue()
        {
            const string expectedPassword = "test-p@ssw0rd";

            using (var rsa = CreateKeyWithShortCrtParameter())
            {
                // false selects PKCS#1 v1.5 padding, matching the padding GetDecryptedPassword decrypts with.
                var encryptedPassword = Convert.ToBase64String(
                    rsa.Encrypt(Encoding.UTF8.GetBytes(expectedPassword), false));

                var response = new GetPasswordDataResponse { PasswordData = encryptedPassword };

                Assert.AreEqual(expectedPassword, response.GetDecryptedPassword(ExportPkcs1Pem(rsa)));
            }
        }

        /// <summary>
        /// Generates a key holding the condition this test exists for: a CRT parameter whose value is
        /// shorter than its field width. Such a parameter is DER-encoded without its leading zero byte,
        /// which is what used to break key parsing and leave the decrypted password mangled.
        /// </summary>
        private static RSACryptoServiceProvider CreateKeyWithShortCrtParameter()
        {
            for (var attempt = 0; attempt < MaxKeyGenerationAttempts; attempt++)
            {
                var rsa = new RSACryptoServiceProvider(KeySizeInBits);

                // Discarded keys must not be left behind in the machine's key store.
                rsa.PersistKeyInCsp = false;

                if (HasShortParameter(rsa.ExportParameters(includePrivateParameters: true)))
                {
                    return rsa;
                }

                rsa.Dispose();
            }

            throw new InvalidOperationException(
                string.Format("Could not generate an RSA key with a short CRT parameter in {0} attempts.",
                    MaxKeyGenerationAttempts));
        }

        private static bool HasShortParameter(RSAParameters parameters)
        {
            // ExportParameters pads every value to its full field width, so a leading zero byte means
            // the value itself needs fewer bytes than the field it sits in.
            var values = new[]
            {
                parameters.D, parameters.P, parameters.Q,
                parameters.DP, parameters.DQ, parameters.InverseQ
            };

            foreach (var value in values)
            {
                if (value.Length > 0 && value[0] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static string ExportPkcs1Pem(RSACryptoServiceProvider rsa)
        {
            // .NET Framework has no PEM or PKCS#1 export, so the key is encoded by hand.
            var base64 = Convert.ToBase64String(EncodePkcs1PrivateKey(rsa.ExportParameters(includePrivateParameters: true)));
            var pem = new StringBuilder("-----BEGIN RSA PRIVATE KEY-----\n");

            for (var offset = 0; offset < base64.Length; offset += 64)
            {
                pem.Append(base64, offset, Math.Min(64, base64.Length - offset)).Append('\n');
            }

            return pem.Append("-----END RSA PRIVATE KEY-----").ToString();
        }

        /// <summary>
        /// Encodes the key as a DER RSAPrivateKey (RFC 3447 appendix A.1.2), the structure a
        /// "BEGIN RSA PRIVATE KEY" PEM body carries.
        /// </summary>
        private static byte[] EncodePkcs1PrivateKey(RSAParameters parameters)
        {
            var body = new List<byte>();
            WriteInteger(body, new byte[] { 0 }); // version
            WriteInteger(body, parameters.Modulus);
            WriteInteger(body, parameters.Exponent);
            WriteInteger(body, parameters.D);
            WriteInteger(body, parameters.P);
            WriteInteger(body, parameters.Q);
            WriteInteger(body, parameters.DP);
            WriteInteger(body, parameters.DQ);
            WriteInteger(body, parameters.InverseQ);

            var der = new List<byte> { 0x30 }; // SEQUENCE
            WriteLength(der, body.Count);
            der.AddRange(body);

            return der.ToArray();
        }

        private static void WriteInteger(List<byte> output, byte[] value)
        {
            var start = 0;
            while (start < value.Length - 1 && value[start] == 0)
            {
                start++; // DER carries the shortest form, so field padding comes off
            }

            var needsSignByte = (value[start] & 0x80) != 0; // a leading 1 bit would read as negative

            output.Add(0x02); // INTEGER
            WriteLength(output, value.Length - start + (needsSignByte ? 1 : 0));

            if (needsSignByte)
            {
                output.Add(0x00);
            }

            for (var i = start; i < value.Length; i++)
            {
                output.Add(value[i]);
            }
        }

        private static void WriteLength(List<byte> output, int length)
        {
            if (length < 0x80)
            {
                output.Add((byte)length);
                return;
            }

            var lengthBytes = new List<byte>();
            for (var remaining = length; remaining > 0; remaining >>= 8)
            {
                lengthBytes.Insert(0, (byte)remaining);
            }

            output.Add((byte)(0x80 | lengthBytes.Count));
            output.AddRange(lengthBytes);
        }
    }
}
