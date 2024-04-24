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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains information about the encryption used to store the job results in Amazon
    /// S3.
    /// </summary>
    public partial class Encryption
    {
        private EncryptionType _encryptionType;
        private string _kmsContext;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The server-side encryption algorithm used when storing job results in Amazon S3, for
        /// example <c>AES256</c> or <c>aws:kms</c>.
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
        /// Gets and sets the property KMSContext. 
        /// <para>
        /// Optional. If the encryption type is <c>aws:kms</c>, you can use this value to specify
        /// the encryption context for the job results.
        /// </para>
        /// </summary>
        public string KMSContext
        {
            get { return this._kmsContext; }
            set { this._kmsContext = value; }
        }

        // Check to see if KMSContext property is set
        internal bool IsSetKMSContext()
        {
            return this._kmsContext != null;
        }

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The AWS KMS key ID to use for object encryption. All GET and PUT requests for an object
        /// protected by AWS KMS fail if not made by using Secure Sockets Layer (SSL) or Signature
        /// Version 4. 
        /// </para>
        /// </summary>
        public string KMSKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KMSKeyId property is set
        internal bool IsSetKMSKeyId()
        {
            return this._kmsKeyId != null;
        }

    }
}