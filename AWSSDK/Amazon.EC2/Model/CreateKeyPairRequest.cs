/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Creates a new 2048-bit RSA key pair with the specified name. The public
    /// key is stored by Amazon EC2 and the private key is displayed on the console.
    /// The private key is returned as an unencrypted PEM encoded PKCS#8 private key.
    /// If a key with the specified name already exists, Amazon EC2 returns an error.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateKeyPairRequest
    {    
        private string keyNameField;

        /// <summary>
        /// Gets and sets the KeyName property.
        /// A unique name for the key pair.
        ///
        /// Constraints:
        /// Accepts alphanumeric characters, spaces, dashes, and underscores.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyName")]
        public string KeyName
        {
            get { return this.keyNameField; }
            set { this.keyNameField = value; }
        }

        /// <summary>
        /// Sets the KeyName property
        /// </summary>
        /// <param name="keyName">A unique name for the key pair.
        ///
        /// Constraints:
        /// Accepts alphanumeric characters, spaces, dashes, and underscores.</param>
        /// <returns>this instance</returns>
        public CreateKeyPairRequest WithKeyName(string keyName)
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

    }
}
