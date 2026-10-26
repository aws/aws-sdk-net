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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the StartReplicationBackfill operation. Starts a replication
    /// backfill for a registry. A replication backfill replicates a registry's existing images
    /// that match its replication configuration to the specified destination. Use the <a>DescribeReplicationBackfillResults</a>
    /// operation to monitor the progress of a replication backfill, and to retrieve its per-image
    /// results after it reaches a terminal status. <note> <para> The destination must already
    /// be configured in the registry's replication configuration. </para> </note> <note>
    /// <para> Only one replication backfill can be in progress for a given destination Region
    /// at a time. Starting a replication backfill for a destination Region that already has
    /// one in progress fails with a <c>ReplicationBackfillInProgressException</c>. In addition,
    /// a registry can have at most 10 replication backfills in progress at once. Starting
    /// a replication backfill that would exceed this limit fails with a <c>LimitExceededException</c>.
    /// </para> </note>
    /// </summary>
    public partial class StartReplicationBackfillRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination Region and registry to which the images are replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry from which to start
        /// the replication backfill. If you do not specify a registry, the default registry is
        /// assumed.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;
    }
}
