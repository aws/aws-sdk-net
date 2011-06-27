/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Key Pair
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class KeyPair
    {    
        private string keyNameField;
        private string keyFingerprintField;
        private string keyMaterialField;

        /// <summary>
        /// Gets and sets the KeyName property.
        /// The key pair name provided in the original
        /// request.
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
        /// <param name="keyName">The key pair name provided in the original
        /// request.</param>
        /// <returns>this instance</returns>
        public KeyPair WithKeyName(string keyName)
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
        /// Gets and sets the KeyFingerprint property.
        /// A SHA-1 digest of the DER encoded private key.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyFingerprint")]
        public string KeyFingerprint
        {
            get { return this.keyFingerprintField; }
            set { this.keyFingerprintField = value; }
        }

        /// <summary>
        /// Sets the KeyFingerprint property
        /// </summary>
        /// <param name="keyFingerprint">A SHA-1 digest of the DER encoded private key.</param>
        /// <returns>this instance</returns>
        public KeyPair WithKeyFingerprint(string keyFingerprint)
        {
            this.keyFingerprintField = keyFingerprint;
            return this;
        }

        /// <summary>
        /// Checks if KeyFingerprint property is set
        /// </summary>
        /// <returns>true if KeyFingerprint property is set</returns>
        public bool IsSetKeyFingerprint()
        {
            return this.keyFingerprintField != null;
        }

        /// <summary>
        /// Gets and sets the KeyMaterial property.
        /// Only returned on create
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyMaterial")]
        public string KeyMaterial
        {
            get { return this.keyMaterialField; }
            set { this.keyMaterialField = value; }
        }

        /// <summary>
        /// Sets the KeyMaterial property
        /// </summary>
        /// <param name="keyMaterial">Only returned on create</param>
        /// <returns>this instance</returns>
        public KeyPair WithKeyMaterial(string keyMaterial)
        {
            this.keyMaterialField = keyMaterial;
            return this;
        }

        /// <summary>
        /// Checks if KeyMaterial property is set
        /// </summary>
        /// <returns>true if KeyMaterial property is set</returns>
        public bool IsSetKeyMaterial()
        {
            return this.keyMaterialField != null;
        }

    }
}
