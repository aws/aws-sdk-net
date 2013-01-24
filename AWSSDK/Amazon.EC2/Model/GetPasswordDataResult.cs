/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

using ThirdParty.BouncyCastle.OpenSsl;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Get Password Data Result
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class GetPasswordDataResult
    {    
        private PasswordData passwordDataField;

        /// <summary>
        /// Gets and sets the PasswordData property.
        /// Password data
        /// </summary>
        [XmlElementAttribute(ElementName = "PasswordData")]
        public PasswordData PasswordData
        {
            get { return this.passwordDataField; }
            set { this.passwordDataField = value; }
        }

        /// <summary>
        /// Checks if PasswordData property is set
        /// </summary>
        /// <returns>true if PasswordData property is set</returns>
        public bool IsSetPasswordData()
        {
            return this.passwordDataField != null;
        }

        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        /// <summary>
        /// String Representation of this object. Overrides Object.ToString()
        /// </summary>
        /// <returns>This object as a string</returns>
        public override string ToString()
        {
            return this.ToXML();
        }

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

            byte[] encryptedBytes = Convert.FromBase64String(this.PasswordData.Data);
            var decryptedBytes = rsa.Decrypt(encryptedBytes, false);

            UTF8Encoding enc = new UTF8Encoding();
            string decrypted = enc.GetString(decryptedBytes);
            return decrypted;
        }
    }
}
