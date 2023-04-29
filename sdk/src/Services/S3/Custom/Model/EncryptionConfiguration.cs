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

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies encryption-related information for an Amazon S3 bucket that is a destination
    /// for replicated objects.
    /// </summary>
    public class EncryptionConfiguration
    {
        private string replicaKmsKeyID;

        /// <summary>
        /// Gets and sets the property ReplicaKmsKeyID. 
        /// <para>
        /// Specifies the ID (Key ARN or Alias ARN) of the customer managed Amazon Web Services
        /// KMS key stored in Amazon Web Services Key Management Service (KMS) for the destination
        /// bucket. Amazon S3 uses this key to encrypt replica objects. Amazon S3 only supports
        /// symmetric encryption KMS keys. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">
        /// Asymmetric keys in Amazon Web Services KMS</a> in the <i>Amazon Web Services Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ReplicaKmsKeyID
        {
            get { return this.replicaKmsKeyID; }
            set { this.replicaKmsKeyID = value; }
        }

        // Check to see if ReplicaKmsKeyID property is set
        internal bool isSetReplicaKmsKeyID()
        {
            return this.replicaKmsKeyID != null;
        }
    }
}
