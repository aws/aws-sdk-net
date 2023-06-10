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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Specifies encryption-related information for an Amazon S3 bucket that is a destination
    /// for replicated objects.
    /// 
    ///  <note> 
    /// <para>
    /// This is not supported by Amazon S3 on Outposts buckets.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class EncryptionConfiguration
    {
        private string _replicaKmsKeyID;

        /// <summary>
        /// Gets and sets the property ReplicaKmsKeyID. 
        /// <para>
        /// Specifies the ID of the customer managed KMS key that's stored in Key Management Service
        /// (KMS) for the destination bucket. This ID is either the Amazon Resource Name (ARN)
        /// for the KMS key or the alias ARN for the KMS key. Amazon S3 uses this KMS key to encrypt
        /// replica objects. Amazon S3 supports only symmetric encryption KMS keys. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#symmetric-cmks">Symmetric
        /// encryption KMS keys</a> in the <i>Amazon Web Services Key Management Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string ReplicaKmsKeyID
        {
            get { return this._replicaKmsKeyID; }
            set { this._replicaKmsKeyID = value; }
        }

        // Check to see if ReplicaKmsKeyID property is set
        internal bool IsSetReplicaKmsKeyID()
        {
            return this._replicaKmsKeyID != null;
        }

    }
}