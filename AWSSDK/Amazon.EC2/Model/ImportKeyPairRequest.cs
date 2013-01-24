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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Imports the public key from an RSA key pair created with a third-party tool.
    /// </summary>
    /// <remarks>
    /// This operation differs from CreateKeyPair as the private key is never
    /// transferred between the caller and AWS servers.
    ///
    /// RSA key pairs are easily created on Microsoft Windows and Linux OS systems using
    /// the ssh-keygen command line tool provided with the standard OpenSSH
    /// installation. Standard library support for RSA key pair creation is also available
    /// for Java, Ruby, Python, and many other programming languages.
    ///
    /// The following formats are supported:
    /// - OpenSSH public key format,
    /// - Base64 encoded DER format.
    /// - SSH public key file format as specified in RFC4716.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class ImportKeyPairRequest
    {    
        private string keyNameField;
        private string publicKeyMaterialField;

        /// <summary>
        /// The unique name for the key pair.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyName")]
        public string KeyName
        {
            get { return this.keyNameField; }
            set { this.keyNameField = value; }
        }

        /// <summary>
        /// Sets the unique name for the key pair.
        /// </summary>
        /// <param name="keyName">The unique name for the key pair.</param>
        /// <returns>this instance</returns>
        public ImportKeyPairRequest WithKeyName(string keyName)
        {
            this.keyNameField = keyName;
            return this;
        }

        /// <summary>
        /// Checks if KeyName property is set
        /// </summary>
        /// <returns>true if KeyName property is set</returns>
        public bool IsSetKeyName()
        {
            return this.keyNameField != null;
        }

        /// <summary>
        /// The public key.
        /// The key must be base64 encoded.
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicKeyMaterial")]
        public string PublicKeyMaterial
        {
            get { return this.publicKeyMaterialField; }
            set { this.publicKeyMaterialField = value; }
        }

        /// <summary>
        /// Sets the public key.
        /// </summary>
        /// <param name="publicKeyMaterial">The public key. This key must be base64 encoded before calling
        /// this operation.</param>
        /// <returns>this instance</returns>
        public ImportKeyPairRequest WithPublicKeyMaterial(string publicKeyMaterial)
        {
            this.publicKeyMaterialField = publicKeyMaterial;
            return this;
        }

        /// <summary>
        /// Checks if PublicKeyMaterial property is set
        /// </summary>
        /// <returns>true if PublicKeyMaterial property is set</returns>
        public bool IsSetPublicKeyMaterial()
        {
            return this.publicKeyMaterialField != null;
        }

    }
}
