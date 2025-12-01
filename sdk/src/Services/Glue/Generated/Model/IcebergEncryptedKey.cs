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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Encryption key structure used for Iceberg table encryption. Contains the key ID, encrypted
    /// key metadata, optional reference to the encrypting key, and additional properties
    /// for the table's encryption scheme.
    /// </summary>
    public partial class IcebergEncryptedKey
    {
        private string _encryptedById;
        private string _encryptedKeyMetadata;
        private string _keyId;
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property EncryptedById. 
        /// <para>
        /// Optional ID of the key used to encrypt or wrap the key metadata in Iceberg table encryption.
        /// This field references another encryption key that was used to encrypt the current
        /// key's metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2056)]
        public string EncryptedById
        {
            get { return this._encryptedById; }
            set { this._encryptedById = value; }
        }

        // Check to see if EncryptedById property is set
        internal bool IsSetEncryptedById()
        {
            return this._encryptedById != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptedKeyMetadata. 
        /// <para>
        /// Encrypted key and metadata, base64 encoded. The format of encrypted key metadata is
        /// determined by the table's encryption scheme and can be a wrapped format specific to
        /// the table's KMS provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2056)]
        public string EncryptedKeyMetadata
        {
            get { return this._encryptedKeyMetadata; }
            set { this._encryptedKeyMetadata = value; }
        }

        // Check to see if EncryptedKeyMetadata property is set
        internal bool IsSetEncryptedKeyMetadata()
        {
            return this._encryptedKeyMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Unique identifier of the encryption key used for Iceberg table encryption. This ID
        /// is used to reference the key in table metadata and track which key was used to encrypt
        /// specific data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2056)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A string to string map of additional metadata used by the table's encryption scheme.
        /// These properties provide additional context and configuration for the encryption key
        /// implementation.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}