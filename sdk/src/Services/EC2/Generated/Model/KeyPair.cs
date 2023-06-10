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

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a key pair.
    /// </summary>
    public partial class KeyPair
    {
        private string _keyFingerprint;
        private string _keyMaterial;
        private string _keyName;
        private string _keyPairId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property KeyFingerprint. <ul> <li> 
        /// <para>
        /// For RSA key pairs, the key fingerprint is the SHA-1 digest of the DER encoded private
        /// key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For ED25519 key pairs, the key fingerprint is the base64-encoded SHA-256 digest, which
        /// is the default for OpenSSH, starting with OpenSSH 6.8.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string KeyFingerprint
        {
            get { return this._keyFingerprint; }
            set { this._keyFingerprint = value; }
        }

        // Check to see if KeyFingerprint property is set
        internal bool IsSetKeyFingerprint()
        {
            return this._keyFingerprint != null;
        }

        /// <summary>
        /// Gets and sets the property KeyMaterial. 
        /// <para>
        /// An unencrypted PEM encoded RSA or ED25519 private key.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string KeyMaterial
        {
            get { return this._keyMaterial; }
            set { this._keyMaterial = value; }
        }

        // Check to see if KeyMaterial property is set
        internal bool IsSetKeyMaterial()
        {
            return this._keyMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the key pair.
        /// </para>
        /// </summary>
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPairId. 
        /// <para>
        /// The ID of the key pair.
        /// </para>
        /// </summary>
        public string KeyPairId
        {
            get { return this._keyPairId; }
            set { this._keyPairId = value; }
        }

        // Check to see if KeyPairId property is set
        internal bool IsSetKeyPairId()
        {
            return this._keyPairId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags applied to the key pair.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}