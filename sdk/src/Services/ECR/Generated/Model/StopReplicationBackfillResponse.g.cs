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
    /// This is the response object from the StopReplicationBackfill operation.
    /// </summary>
    public partial class StopReplicationBackfillResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination Region and registry to which the images are replicated.
        /// </para>
        /// </summary>
        public ReplicationDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID associated with the request.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property ReplicationBackfillId. 
        /// <para>
        /// The ID of the replication backfill.
        /// </para>
        /// </summary>
        public string ReplicationBackfillId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationBackfillId property is set.
        /// </summary>
        internal bool IsSetReplicationBackfillId() => this.ReplicationBackfillId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the replication backfill was started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the replication backfill. When you stop a replication backfill,
        /// its status is <c>STOPPED</c> if the backfill is stopped immediately, or <c>STOPPING</c>
        /// if there are replications still in progress that must complete before the backfill
        /// stops.
        /// </para>
        /// </summary>
        public ReplicationBackfillStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
