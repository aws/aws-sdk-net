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
    /// Specifies whether S3 on Outposts replicates delete markers. If you specify a <code>Filter</code>
    /// element in your replication configuration, you must also include a <code>DeleteMarkerReplication</code>
    /// element. If your <code>Filter</code> includes a <code>Tag</code> element, the <code>DeleteMarkerReplication</code>
    /// element's <code>Status</code> child element must be set to <code>Disabled</code>,
    /// because S3 on Outposts does not support replicating delete markers for tag-based rules.
    /// 
    ///  
    /// <para>
    /// For more information about delete marker replication, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsReplication.html#outposts-replication-what-is-replicated">How
    /// delete operations affect replication</a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DeleteMarkerReplication
    {
        private DeleteMarkerReplicationStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates whether to replicate delete markers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeleteMarkerReplicationStatus Status
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