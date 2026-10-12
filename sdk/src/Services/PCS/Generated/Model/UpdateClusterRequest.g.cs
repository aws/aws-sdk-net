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

namespace Amazon.PCS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCluster operation. Updates a cluster configuration.
    /// You can update the scheduler version, modify scheduler settings, and update accounting
    /// configuration for an existing cluster. For more information about updating the scheduler
    /// version, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/working-with_clusters_version_update.html">Updating
    /// the scheduler version on a cluster</a> in the <i>PCS User Guide</i>. <note> <para>
    /// You can only update clusters that are in <c>ACTIVE</c>, <c>UPDATE_FAILED</c>, or <c>SUSPENDED</c>
    /// state. All associated resources (queues and compute node groups) must be in <c>ACTIVE</c>
    /// state before you can update the cluster. </para> </note>
    /// </summary>
    public partial class UpdateClusterRequest : AmazonPCSRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully, the subsequent
        /// retries with the same client token return the result from the original successful
        /// request and they have no additional effect. If you don't specify a client token, the
        /// CLI and SDK automatically generate 1 for you.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The name or ID of the cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property Scheduler. 
        /// <para>
        /// The scheduler configuration to update for the cluster. Use this to update the scheduler
        /// version. For more information, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/working-with_clusters_version_update.html">Updating
        /// the scheduler version on a cluster</a> in the <i>PCS User Guide</i>.
        /// </para>
        /// </summary>
        public UpdateSchedulerRequest Scheduler { get; set; }

        /// <summary>
        /// Checks to see if the Scheduler property is set.
        /// </summary>
        internal bool IsSetScheduler() => this.Scheduler != null;

        /// <summary>
        /// Gets and sets the property SlurmConfiguration. 
        /// <para>
        /// Additional options related to the Slurm scheduler.
        /// </para>
        /// </summary>
        public UpdateClusterSlurmConfigurationRequest SlurmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SlurmConfiguration property is set.
        /// </summary>
        internal bool IsSetSlurmConfiguration() => this.SlurmConfiguration != null;
    }
}
