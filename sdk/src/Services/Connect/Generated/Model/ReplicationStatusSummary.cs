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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Status information about the replication process, where you use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ReplicateInstance.html">ReplicateInstance</a>
    /// API to create a replica of your Amazon Connect instance in another Amazon Web Services
    /// Region. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-connect-global-resiliency.html">Set
    /// up Amazon Connect Global Resiliency</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </summary>
    public partial class ReplicationStatusSummary
    {
        private string _region;
        private InstanceReplicationStatus _replicationStatus;
        private string _replicationStatusReason;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region. This can be either the source or the replica Region,
        /// depending where it appears in the summary list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=31)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// The state of the replication.
        /// </para>
        /// </summary>
        public InstanceReplicationStatus ReplicationStatus
        {
            get { return this._replicationStatus; }
            set { this._replicationStatus = value; }
        }

        // Check to see if ReplicationStatus property is set
        internal bool IsSetReplicationStatus()
        {
            return this._replicationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatusReason. 
        /// <para>
        /// A description of the replication status. Use this information to resolve any issues
        /// that are preventing the successful replication of your Amazon Connect instance to
        /// another Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ReplicationStatusReason
        {
            get { return this._replicationStatusReason; }
            set { this._replicationStatusReason = value; }
        }

        // Check to see if ReplicationStatusReason property is set
        internal bool IsSetReplicationStatusReason()
        {
            return this._replicationStatusReason != null;
        }

    }
}