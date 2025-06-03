/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Security.Cryptography;
using System.Text;
#if !NET
using Amazon.Runtime;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
#endif

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Extension methods for decrypting the EC2 windows password with the instance keypair.
    /// </summary>
    public static class GetPasswordDataResponseExtensions
    {
        /// <summary>
        /// Gets the decrypted password using the RSA private key which can be found in the
        /// PEM file for the key pair.
        /// </summary>
        /// <param name="getPasswordDataResponse">Instance to add the extension method to</param>
        /// <param name="rsaPrivateKey">The RSA private key from the PEM file</param>
        /// <returns>The decrypted password</returns>
        public static string GetDecryptedPassword(this GetPasswordDataResponse getPasswordDataResponse, string rsaPrivateKey)
        {
            RSA rsa = RSA.Create();
#if NET
            rsa.ImportFromPem(rsaPrivateKey.AsSpan().Trim());
#else
            RSAParameters rsaParams;
            try
            {
                using (var pemReader = new PemReader(new StringReader(rsaPrivateKey.Trim())))
                {
                    var keyPair = pemReader.ReadObject();
                    if (keyPair is RsaPrivateCrtKeyParameters)
                    {
                        rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)keyPair);
                    }
                    else if (keyPair is AsymmetricCipherKeyPair)
                    {
                        var asymmetricKeyPair = keyPair as AsymmetricCipherKeyPair;
                        var privateKey = asymmetricKeyPair.Private as RsaPrivateCrtKeyParameters;
                        rsaParams = DotNetUtilities.ToRSAParameters(privateKey);
                    }
                    else
                    {
                        throw new AmazonClientException("Unknown key type");
                    }
                }
            }
            catch (Exception e)
            {
                throw new AmazonEC2Exception("Invalid RSA Private Key", e);
            }
            rsa.ImportParameters(rsaParams);
#endif

            byte[] encryptedBytes = Convert.FromBase64String(getPasswordDataResponse.PasswordData);
            var decryptedBytes = rsa.Decrypt(encryptedBytes, RSAEncryptionPadding.Pkcs1);

            string decrypted = Encoding.UTF8.GetString(decryptedBytes);
            return decrypted;
        }
    }
}
