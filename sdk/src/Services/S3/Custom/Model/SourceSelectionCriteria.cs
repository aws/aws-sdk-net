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
    /// SourceSelectionCriteria class
    /// </summary>
    public class SourceSelectionCriteria
    {
        private SseKmsEncryptedObjects sseKmsEncryptedObjects;

        /// <summary>
        /// Container for filter information of selection of KMS Encrypted
        /// S3 objects. The element is required if you include
        /// <code>SourceSelectionCriteria</code> in the replication
        /// configuration.
        /// </summary>
        public SseKmsEncryptedObjects SseKmsEncryptedObjects
        {
            get { return this.sseKmsEncryptedObjects; }
            set { this.sseKmsEncryptedObjects = value; }
        }

        // Check to see if SseKmsEncryptedObjects property is set
        internal bool IsSetSseKmsEncryptedObjects()
        {
            return this.sseKmsEncryptedObjects != null;
        }
    }
}
