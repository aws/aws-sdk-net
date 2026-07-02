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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
    /// Container for the parameters to the UpdateCluster operation.
    /// Updates a cluster configuration. You can upgrade the Slurm version, modify scheduler
    /// settings, and update accounting configuration for an existing cluster. For more information
    /// about upgrading the Slurm version, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/working-with_clusters_upgrade.html">Upgrading
    /// the Slurm version on a cluster</a> in the <i>PCS User Guide</i>. 
    /// 
    ///  <note> 
    /// <para>
    /// You can only update clusters that are in <c>ACTIVE</c>, <c>UPDATE_FAILED</c>, or <c>SUSPENDED</c>
    /// state. All associated resources (queues and compute node groups) must be in <c>ACTIVE</c>
    /// state before you can update the cluster.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateClusterRequest : AmazonPCSRequest
    {
        private string _clientToken;
        private string _clusterIdentifier;
        private UpdateSchedulerRequest _scheduler;
        private UpdateClusterSlurmConfigurationRequest _slurmConfiguration;

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
        [AWSProperty(Min=8, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The name or ID of the cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Scheduler. 
        /// <para>
        /// The scheduler configuration to update for the cluster. Use this to upgrade the Slurm
        /// version. For more information, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/working-with_clusters_upgrade.html">Upgrading
        /// the Slurm version on a cluster</a> in the <i>PCS User Guide</i>.
        /// </para>
        /// </summary>
        public UpdateSchedulerRequest Scheduler
        {
            get { return this._scheduler; }
            set { this._scheduler = value; }
        }

        // Check to see if Scheduler property is set
        internal bool IsSetScheduler()
        {
            return this._scheduler != null;
        }

        /// <summary>
        /// Gets and sets the property SlurmConfiguration. 
        /// <para>
        /// Additional options related to the Slurm scheduler.
        /// </para>
        /// </summary>
        public UpdateClusterSlurmConfigurationRequest SlurmConfiguration
        {
            get { return this._slurmConfiguration; }
            set { this._slurmConfiguration = value; }
        }

        // Check to see if SlurmConfiguration property is set
        internal bool IsSetSlurmConfiguration()
        {
            return this._slurmConfiguration != null;
        }

    }
}