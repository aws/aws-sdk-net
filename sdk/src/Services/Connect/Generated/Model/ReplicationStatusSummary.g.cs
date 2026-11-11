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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// API to create a replica of your Connect Customer instance in another Amazon Web Services
    /// Region. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-connect-global-resiliency.html">Set
    /// up Connect Customer Global Resiliency</a> in the <i>Connect Customer Administrator
    /// Guide</i>.
    /// </summary>
    public partial class ReplicationStatusSummary
    {
        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region. This can be either the source or the replica Region,
        /// depending where it appears in the summary list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 31)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// The state of the replication.
        /// </para>
        /// </summary>
        public InstanceReplicationStatus ReplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationStatus property is set.
        /// </summary>
        internal bool IsSetReplicationStatus() => this.ReplicationStatus != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatusReason. 
        /// <para>
        /// A description of the replication status. Use this information to resolve any issues
        /// that are preventing the successful replication of your Connect Customer instance to
        /// another Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ReplicationStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationStatusReason property is set.
        /// </summary>
        internal bool IsSetReplicationStatusReason() => this.ReplicationStatusReason != null;
    }
}
