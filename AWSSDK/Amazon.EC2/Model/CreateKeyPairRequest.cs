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
    /// Creates a new 2048-bit RSA key pair with the specified name. The public
    /// key is stored by Amazon EC2 and the private key is returned to you.
    /// </summary>
    /// <remarks>
    /// The private key is returned as an unencrypted PEM encoded PKCS#8 private key.
    /// If a key with the specified name already exists, Amazon EC2 returns an error.
    /// The key pair returned to you works only in the Region you're using when you
    /// create the key pair. To create a key pair that works in all Regions, use ImportKeyPair.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateKeyPairRequest : EC2Request
    {    
        private string keyNameField;

        /// <summary>
        /// A unique name for the key pair.
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
        /// <param name="keyName">A unique name for the key pair.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
