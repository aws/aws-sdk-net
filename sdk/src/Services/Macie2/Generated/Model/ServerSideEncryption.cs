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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the default server-side encryption settings for an S3 bucket
    /// or the encryption settings for an S3 object.
    /// </summary>
    public partial class ServerSideEncryption
    {
        private EncryptionType _encryptionType;
        private string _kmsMasterKeyId;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The server-side encryption algorithm that's used when storing data in the bucket or
        /// object. If default encryption settings aren't configured for the bucket or the object
        /// isn't encrypted using server-side encryption, this value is NONE.
        /// </para>
        /// </summary>
        public EncryptionType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsMasterKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) or unique identifier (key ID) for the KMS key that's
        /// used to encrypt data in the bucket or the object. This value is null if an KMS key
        /// isn't used to encrypt the data.
        /// </para>
        /// </summary>
        public string KmsMasterKeyId
        {
            get { return this._kmsMasterKeyId; }
            set { this._kmsMasterKeyId = value; }
        }

        // Check to see if KmsMasterKeyId property is set
        internal bool IsSetKmsMasterKeyId()
        {
            return this._kmsMasterKeyId != null;
        }

    }
}