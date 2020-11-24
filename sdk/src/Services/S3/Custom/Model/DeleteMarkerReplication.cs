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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// <para>Specifies whether Amazon S3 replicates delete markers. 
    /// If you specify a <code>Filter</code> in your replication configuration, 
    /// you must also include a <code>DeleteMarkerReplication</code> element. 
    /// If your <code>Filter</code> includes a <code>Tag</code> element, 
    /// the <code>DeleteMarkerReplication</code> <code>Status</code> must be set to Disabled,
    /// because Amazon S3 does not support replicating delete markers for tag-based rules. 
    /// For an example configuration, 
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-add-config.html#replication-config-min-rule-config\">Basic Rule Configuration</a>. 
    /// </para> <para>For more information about delete marker replication, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/delete-marker-replication.html\">Basic Rule Configuration</a>. 
    /// </para> <note> <para>If you are using an earlier version of the replication configuration, 
    /// Amazon S3 handles replication of delete markers differently. For more information, 
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-add-config.html#replication-backward-compat-considerations\">Backward Compatibility</a>.</para> </note>
    /// </summary>
    public partial class DeleteMarkerReplication
    {
        private DeleteMarkerReplicationStatus status;

        /// <summary>
        /// <para>Indicates whether to replicate delete markers.</para>
        /// </summary>
        public DeleteMarkerReplicationStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}
