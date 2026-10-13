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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property EncryptedById. 
        /// <para>
        /// Optional ID of the key used to encrypt or wrap the key metadata in Iceberg table encryption.
        /// This field references another encryption key that was used to encrypt the current
        /// key's metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2056)]
        public string EncryptedById { get; set; }

        /// <summary>
        /// Checks to see if the EncryptedById property is set.
        /// </summary>
        internal bool IsSetEncryptedById() => this.EncryptedById != null;

        /// <summary>
        /// Gets and sets the property EncryptedKeyMetadata. 
        /// <para>
        /// Encrypted key and metadata, base64 encoded. The format of encrypted key metadata is
        /// determined by the table's encryption scheme and can be a wrapped format specific to
        /// the table's KMS provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2056)]
        public string EncryptedKeyMetadata { get; set; }

        /// <summary>
        /// Checks to see if the EncryptedKeyMetadata property is set.
        /// </summary>
        internal bool IsSetEncryptedKeyMetadata() => this.EncryptedKeyMetadata != null;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Unique identifier of the encryption key used for Iceberg table encryption. This ID
        /// is used to reference the key in table metadata and track which key was used to encrypt
        /// specific data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2056)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A string to string map of additional metadata used by the table's encryption scheme.
        /// These properties provide additional context and configuration for the encryption key
        /// implementation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Properties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
