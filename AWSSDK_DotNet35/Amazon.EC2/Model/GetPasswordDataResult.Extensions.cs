/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2;
using Amazon.Runtime;
using System.Security.Cryptography;
using ThirdParty.BouncyCastle.OpenSsl;
using System.IO;


namespace Amazon.EC2.Model
{
    public partial class GetPasswordDataResult : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets the decrypted password using the RSA private key which can be found in the
        /// PEM file for the key pair.
        /// </summary>
        /// <param name="rsaPrivateKey">The RSA private key from the PEM file</param>
        /// <returns>The decrypted password</returns>
        public string GetDecryptedPassword(string rsaPrivateKey)
        {
            RSAParameters rsaParams;
            try
            {
                rsaParams = new PemReader(new StringReader(rsaPrivateKey.Trim())).ReadPrivatekey();
            }
            catch (Exception e)
            {
                throw new AmazonEC2Exception("Invalid RSA Private Key", e);
            }

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(rsaParams);

            byte[] encryptedBytes = Convert.FromBase64String(this.PasswordData);
            var decryptedBytes = rsa.Decrypt(encryptedBytes, false);

            string decrypted = Encoding.UTF8.GetString(decryptedBytes);
            return decrypted;
        }
    }
}
