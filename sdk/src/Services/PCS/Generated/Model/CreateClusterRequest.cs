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
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a cluster in your account. PCS creates the cluster controller in a service-owned
    /// account. The cluster controller communicates with the cluster resources in your account.
    /// The subnets and security groups for the cluster must already exist before you use
    /// this API action.
    /// 
    ///  <note> 
    /// <para>
    /// It takes time for PCS to create the cluster. The cluster is in a <c>Creating</c> state
    /// until it is ready to use. There can only be 1 cluster in a <c>Creating</c> state per
    /// Amazon Web Services Region per Amazon Web Services account. <c>CreateCluster</c> fails
    /// with a <c>ServiceQuotaExceededException</c> if there is already a cluster in a <c>Creating</c>
    /// state.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateClusterRequest : AmazonPCSRequest
    {
        private string _clientToken;
        private string _clusterName;
        private NetworkingRequest _networking;
        private SchedulerRequest _scheduler;
        private Size _size;
        private ClusterSlurmConfigurationRequest _slurmConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A name to identify the cluster. Example: <c>MyCluster</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=40)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Networking. 
        /// <para>
        /// The networking configuration used to set up the cluster's control plane.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkingRequest Networking
        {
            get { return this._networking; }
            set { this._networking = value; }
        }

        // Check to see if Networking property is set
        internal bool IsSetNetworking()
        {
            return this._networking != null;
        }

        /// <summary>
        /// Gets and sets the property Scheduler. 
        /// <para>
        /// The cluster management and job scheduling software associated with the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchedulerRequest Scheduler
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
        /// Gets and sets the property Size. 
        /// <para>
        /// A value that determines the maximum number of compute nodes in the cluster and the
        /// maximum number of jobs (active and queued).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SMALL</c>: 32 compute nodes and 256 jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEDIUM</c>: 512 compute nodes and 8192 jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LARGE</c>: 2048 compute nodes and 16,384 jobs
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Size Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size != null;
        }

        /// <summary>
        /// Gets and sets the property SlurmConfiguration. 
        /// <para>
        /// Additional options related to the Slurm scheduler.
        /// </para>
        /// </summary>
        public ClusterSlurmConfigurationRequest SlurmConfiguration
        {
            get { return this._slurmConfiguration; }
            set { this._slurmConfiguration = value; }
        }

        // Check to see if SlurmConfiguration property is set
        internal bool IsSetSlurmConfiguration()
        {
            return this._slurmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// 1 or more tags added to the resource. Each tag consists of a tag key and tag value.
        /// The tag value is optional and can be an empty string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}