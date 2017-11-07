/*
 * Copyright 2010-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// ServerSideEncryptionByDefault class
    /// </summary>
    public class ServerSideEncryptionByDefault
    {
        private ServerSideEncryptionMethod serverSideEncryptionAlgorithm;
        private string serverSideEncryptionKeyManagementServiceKeyId;

        /// <summary>
        /// Server-side encryption algorithm to use for the default encryption.
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionAlgorithm
        {
            get { return this.serverSideEncryptionAlgorithm; }
            set { this.serverSideEncryptionAlgorithm = value; }
        }

        // Check to see if ServerSideEncryptionAlgorithm property is set
        internal bool IsSetServerSideEncryptionAlgorithm()
        {
            return this.serverSideEncryptionAlgorithm != null;
        }
        /// <summary>
        /// KMS master key ID to use for the default encryption. 
        /// This parameter is allowed if SSEAlgorithm is aws:kms.
        /// </summary>
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this.serverSideEncryptionKeyManagementServiceKeyId; }
            set { this.serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        // Check to see if ServerSideEncryptionKeyManagementServiceKeyId property is set
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return this.serverSideEncryptionKeyManagementServiceKeyId != null;
        }

    }
}