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
    /// Specifies encryption-related information for an Amazon S3 bucket that is a destination
    /// for replicated objects.
    /// 
    ///  <note> 
    /// <para>
    /// If you're specifying a customer managed KMS key, we recommend using a fully qualified
    /// KMS key ARN. If you use a KMS key alias instead, then KMS resolves the key within
    /// the requester’s account. This behavior can result in data that's encrypted with a
    /// KMS key that belongs to the requester, and not the bucket owner.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class EncryptionConfiguration
    {
        private string _replicaKmsKeyID;

        /// <summary>
        /// Gets and sets the property ReplicaKmsKeyID. 
        /// <para>
        /// Specifies the ID (Key ARN or Alias ARN) of the customer managed Amazon Web Services
        /// KMS key stored in Amazon Web Services Key Management Service (KMS) for the destination
        /// bucket. Amazon S3 uses this key to encrypt replica objects. Amazon S3 only supports
        /// symmetric encryption KMS keys. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
        /// keys in Amazon Web Services KMS</a> in the <i>Amazon Web Services Key Management Service
        /// Developer Guide</i>.
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