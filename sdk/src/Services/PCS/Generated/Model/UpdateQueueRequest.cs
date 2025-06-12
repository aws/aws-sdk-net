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
    /// Container for the parameters to the UpdateQueue operation.
    /// Updates the compute node group configuration of a queue. Use this API to change the
    /// compute node groups that the queue can send jobs to.
    /// </summary>
    public partial class UpdateQueueRequest : AmazonPCSRequest
    {
        private string _clientToken;
        private string _clusterIdentifier;
        private List<ComputeNodeGroupConfiguration> _computeNodeGroupConfigurations = AWSConfigs.InitializeCollections ? new List<ComputeNodeGroupConfiguration>() : null;
        private string _queueIdentifier;

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
        /// The name or ID of the cluster of the queue.
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
        /// Gets and sets the property ComputeNodeGroupConfigurations. 
        /// <para>
        /// The list of compute node group configurations to associate with the queue. Queues
        /// assign jobs to associated compute node groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComputeNodeGroupConfiguration> ComputeNodeGroupConfigurations
        {
            get { return this._computeNodeGroupConfigurations; }
            set { this._computeNodeGroupConfigurations = value; }
        }

        // Check to see if ComputeNodeGroupConfigurations property is set
        internal bool IsSetComputeNodeGroupConfigurations()
        {
            return this._computeNodeGroupConfigurations != null && (this._computeNodeGroupConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueueIdentifier. 
        /// <para>
        /// The name or ID of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueIdentifier
        {
            get { return this._queueIdentifier; }
            set { this._queueIdentifier = value; }
        }

        // Check to see if QueueIdentifier property is set
        internal bool IsSetQueueIdentifier()
        {
            return this._queueIdentifier != null;
        }

    }
}