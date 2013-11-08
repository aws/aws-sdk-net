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
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Describes an Amazon EC2 key pair, including the private key material. </para> <para> The public key portion is stored by Amazon EC2
    /// and the private key is returned only once, in this type, when the key is initially created. </para>
    /// </summary>
    public class KeyPair
    {
        
        private string keyName;
        private string keyFingerprint;
        private string keyMaterial;


        /// <summary>
        /// The name of the key pair.
        ///  
        /// </summary>
        public string KeyName
        {
            get { return this.keyName; }
            set { this.keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this.keyName != null;
        }

        /// <summary>
        /// The SHA-1 digest of the DER encoded private key.
        ///  
        /// </summary>
        public string KeyFingerprint
        {
            get { return this.keyFingerprint; }
            set { this.keyFingerprint = value; }
        }

        // Check to see if KeyFingerprint property is set
        internal bool IsSetKeyFingerprint()
        {
            return this.keyFingerprint != null;
        }

        /// <summary>
        /// The unencrypted PEM encoded RSA private key.
        ///  
        /// </summary>
        public string KeyMaterial
        {
            get { return this.keyMaterial; }
            set { this.keyMaterial = value; }
        }

        // Check to see if KeyMaterial property is set
        internal bool IsSetKeyMaterial()
        {
            return this.keyMaterial != null;
        }
    }
}
