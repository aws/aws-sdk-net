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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Contains the type of server-side encryption used.
    /// </summary>
    public partial class S3Encryption
    {
        private ServerSideEncryptionMethod _encryptionType;
        private string _kmsContext;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The server-side encryption algorithm used when storing job results in Amazon S3 (for
        /// example, AES256, <c>aws:kms</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServerSideEncryptionMethod EncryptionType
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
        /// If the encryption type is <c>aws:kms</c>, this optional value can be used to specify
        /// the encryption context for the restore results.
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
        /// If the encryption type is <c>aws:kms</c>, this optional value specifies the ID of
        /// the symmetric encryption customer managed key to use for encryption of job results.
        /// Amazon S3 only supports symmetric encryption KMS keys. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
        /// keys in KMS</a> in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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