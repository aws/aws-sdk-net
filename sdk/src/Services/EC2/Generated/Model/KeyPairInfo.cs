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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a key pair.
    /// </summary>
    public partial class KeyPairInfo
    {
        private DateTime? _createTime;
        private string _keyFingerprint;
        private string _keyName;
        private string _keyPairId;
        private KeyType _keyType;
        private string _publicKey;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// If you used Amazon EC2 to create the key pair, this is the date and time when the
        /// key was created, in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601 date-time format</a>, in the UTC time zone.
        /// </para>
        ///  
        /// <para>
        /// If you imported an existing key pair to Amazon EC2, this is the date and time the
        /// key was imported, in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601 date-time format</a>, in the UTC time zone.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyFingerprint. 
        /// <para>
        /// If you used <a>CreateKeyPair</a> to create the key pair:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For RSA key pairs, the key fingerprint is the SHA-1 digest of the DER encoded private
        /// key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For ED25519 key pairs, the key fingerprint is the base64-encoded SHA-256 digest, which
        /// is the default for OpenSSH, starting with <a href="http://www.openssh.com/txt/release-6.8">OpenSSH
        /// 6.8</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you used <a>ImportKeyPair</a> to provide Amazon Web Services the public key:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For RSA key pairs, the key fingerprint is the MD5 public key fingerprint as specified
        /// in section 4 of RFC4716.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For ED25519 key pairs, the key fingerprint is the base64-encoded SHA-256 digest, which
        /// is the default for OpenSSH, starting with <a href="http://www.openssh.com/txt/release-6.8">OpenSSH
        /// 6.8</a>.
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
        /// Gets and sets the property KeyType. 
        /// <para>
        /// The type of key pair.
        /// </para>
        /// </summary>
        public KeyType KeyType
        {
            get { return this._keyType; }
            set { this._keyType = value; }
        }

        // Check to see if KeyType property is set
        internal bool IsSetKeyType()
        {
            return this._keyType != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key material.
        /// </para>
        /// </summary>
        public string PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags applied to the key pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}