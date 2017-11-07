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
    /// SseKmsEncryptedObjects class
    /// </summary>
    public class SseKmsEncryptedObjects
    {
        private SseKmsEncryptedObjectsStatus sseKmsEncryptedObjectsStatus;

        /// <summary>
        /// The replication for KMS encrypted S3 objects is disabled if status is not Enabled.
        /// </summary>
        public SseKmsEncryptedObjectsStatus SseKmsEncryptedObjectsStatus
        {
            get { return this.sseKmsEncryptedObjectsStatus; }
            set { this.sseKmsEncryptedObjectsStatus = value; }
        }

        // Check to see if SseKmsEncryptedObjectsStatus property is set
        internal bool IsSetSseKmsEncryptedObjectsStatus()
        {
            return this.sseKmsEncryptedObjectsStatus != null;
        }
    }
}
