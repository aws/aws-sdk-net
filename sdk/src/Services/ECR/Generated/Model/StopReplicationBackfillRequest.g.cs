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
    /// Container for the parameters to the StopReplicationBackfill operation. Stops an in
    /// progress replication backfill for a registry. The backfill to stop is identified by
    /// the <c>replicationBackfillId</c> returned by the <a>StartReplicationBackfill</a> operation.
    /// <note> <para> Images that have already been replicated are not affected, and replications
    /// that are already in progress continue to completion. </para> </note>
    /// </summary>
    public partial class StopReplicationBackfillRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// replication backfill to stop. If you do not specify a registry, the default registry
        /// is assumed.
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
        /// The ID of the replication backfill to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationBackfillId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationBackfillId property is set.
        /// </summary>
        internal bool IsSetReplicationBackfillId() => this.ReplicationBackfillId != null;
    }
}
