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
    /// A container that describes additional filters for identifying the source objects that
    /// you want to replicate. You can choose to enable or disable the replication of these
    /// objects.
    /// </summary>
    public partial class SourceSelectionCriteria
    {
        private ReplicaModifications _replicaModifications;
        private SseKmsEncryptedObjects _sseKmsEncryptedObjects;

        /// <summary>
        /// Gets and sets the property ReplicaModifications. 
        /// <para>
        /// A filter that you can use to specify whether replica modification sync is enabled.
        /// S3 on Outposts replica modification sync can help you keep object metadata synchronized
        /// between replicas and source objects. By default, S3 on Outposts replicates metadata
        /// from the source objects to the replicas only. When replica modification sync is enabled,
        /// S3 on Outposts replicates metadata changes made to the replica copies back to the
        /// source object, making the replication bidirectional.
        /// </para>
        ///  
        /// <para>
        /// To replicate object metadata modifications on replicas, you can specify this element
        /// and set the <code>Status</code> of this element to <code>Enabled</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must enable replica modification sync on the source and destination buckets to
        /// replicate replica metadata changes between the source and the replicas.
        /// </para>
        ///  </note>
        /// </summary>
        public ReplicaModifications ReplicaModifications
        {
            get { return this._replicaModifications; }
            set { this._replicaModifications = value; }
        }

        // Check to see if ReplicaModifications property is set
        internal bool IsSetReplicaModifications()
        {
            return this._replicaModifications != null;
        }

        /// <summary>
        /// Gets and sets the property SseKmsEncryptedObjects. 
        /// <para>
        /// A filter that you can use to select Amazon S3 objects that are encrypted with server-side
        /// encryption by using Key Management Service (KMS) keys. If you include <code>SourceSelectionCriteria</code>
        /// in the replication configuration, this element is required. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public SseKmsEncryptedObjects SseKmsEncryptedObjects
        {
            get { return this._sseKmsEncryptedObjects; }
            set { this._sseKmsEncryptedObjects = value; }
        }

        // Check to see if SseKmsEncryptedObjects property is set
        internal bool IsSetSseKmsEncryptedObjects()
        {
            return this._sseKmsEncryptedObjects != null;
        }

    }
}