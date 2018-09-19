/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// EncryptionConfiguration class
    /// </summary>
    public class EncryptionConfiguration
    {
        private string replicaKmsKeyID;

        /// <summary>
        /// The ID of the AWS KMS key for the region where the destination bucket
        /// resides. Amazon S3 uses this key to encrypt the replica object.
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
