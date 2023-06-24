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
    /// A filter that you can use to specify whether replica modification sync is enabled.
    /// S3 on Outposts replica modification sync can help you keep object metadata synchronized
    /// between replicas and source objects. By default, S3 on Outposts replicates metadata
    /// from the source objects to the replicas only. When replica modification sync is enabled,
    /// S3 on Outposts replicates metadata changes made to the replica copies back to the
    /// source object, making the replication bidirectional.
    /// 
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
    public partial class ReplicaModifications
    {
        private ReplicaModificationsStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether S3 on Outposts replicates modifications to object metadata on replicas.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicaModificationsStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}