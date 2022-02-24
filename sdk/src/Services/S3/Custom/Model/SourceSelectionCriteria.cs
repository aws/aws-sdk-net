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
    /// A container that describes additional filters for identifying the source objects that
    /// you want to replicate. You can choose to enable or disable the replication of these
    /// objects. Currently, Amazon S3 supports only the filter that you can specify for objects
    /// created with server-side encryption using a customer managed key stored in Amazon
    /// Web Services Key Management Service (SSE-KMS).
    /// </summary>
    public class SourceSelectionCriteria
    {
        private SseKmsEncryptedObjects sseKmsEncryptedObjects;
        private ReplicaModifications replicaModifications;

        /// <summary>
        /// Gets and sets the property SseKmsEncryptedObjects. 
        /// <para>
        ///  A container for filter information for the selection of Amazon S3 objects encrypted
        /// with Amazon Web Services KMS. If you include <code>SourceSelectionCriteria</code>
        /// in the replication configuration, this element is required. 
        /// </para>
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

        /// <summary>
        /// <para>A filter that you can specify for selections for modifications on replicas. 
        /// Amazon S3 doesn't replicate replica modifications by default. In the 
        /// latest version of replication configuration (when <code>Filter</code> is specified), you can 
        /// specify this element and set the status to <code>Enabled</code> to replicate modifications on
        /// replicas. </para> <note> <para> If you don't specify the <code>Filter</code> element, 
        /// Amazon S3 assumes that the replication configuration is the earlier version, V1. 
        /// In the earlier version, this element is not allowed</para> </note>
        /// </summary>
        public ReplicaModifications ReplicaModifications
        {
            get { return this.replicaModifications; }
            set { this.replicaModifications = value; }
        }

        internal bool IsSetReplicaModifications()
        {
            return this.replicaModifications != null;
        }
    }
}
