using System;
using System.Security.Cryptography;
using System.Text;
using Xunit;

using Amazon.EC2.Model;

namespace AWSSDK_DotNet.UnitTests.EC2
{
    public class PasswordTest
    {
        private const int KeySizeInBits = 2048;

        // Around one key in forty qualifies, so the cap only exists to fail loudly instead of
        // spinning forever if key generation ever stops behaving randomly.
        private const int MaxKeyGenerationAttempts = 2000;

        // Test an issue with certain combination of private key and encrypted passwords that were causing a encoding issue while decrypting the password.
        [Fact]
        [Trait("UnitTest", "EC2")]
        public void TestMissingLeadingZeroIssue()
        {
            const string expectedPassword = "test-p@ssw0rd";

            using (var rsa = CreateKeyWithShortCrtParameter())
            {
                var encryptedPassword = Convert.ToBase64String(
                    rsa.Encrypt(Encoding.UTF8.GetBytes(expectedPassword), RSAEncryptionPadding.Pkcs1));

                var response = new GetPasswordDataResponse { PasswordData = encryptedPassword };

                Assert.Equal(expectedPassword, response.GetDecryptedPassword(ExportPkcs1Pem(rsa)));
            }
        }

        /// <summary>
        /// Generates a key holding the condition this test exists for: a CRT parameter whose value is
        /// shorter than its field width. Such a parameter is DER-encoded without its leading zero byte,
        /// which is what used to break key parsing and leave the decrypted password mangled.
        /// </summary>
        private static RSA CreateKeyWithShortCrtParameter()
        {
            for (var attempt = 0; attempt < MaxKeyGenerationAttempts; attempt++)
            {
                var rsa = RSA.Create(KeySizeInBits);

                if (HasShortParameter(rsa.ExportParameters(includePrivateParameters: true)))
                {
                    return rsa;
                }

                rsa.Dispose();
            }

            throw new InvalidOperationException(
                $"Could not generate an RSA key with a short CRT parameter in {MaxKeyGenerationAttempts} attempts.");
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

        private static string ExportPkcs1Pem(RSA rsa)
        {
            // Frameworks without RSA.ImportFromPem parse the key with BouncyCastle's PemReader, so the
            // base64 is wrapped at the conventional 64 characters rather than emitted as one long line.
            var base64 = Convert.ToBase64String(rsa.ExportRSAPrivateKey());
            var pem = new StringBuilder("-----BEGIN RSA PRIVATE KEY-----\n");

            for (var offset = 0; offset < base64.Length; offset += 64)
            {
                pem.Append(base64, offset, Math.Min(64, base64.Length - offset)).Append('\n');
            }

            return pem.Append("-----END RSA PRIVATE KEY-----").ToString();
        }
    }
}
