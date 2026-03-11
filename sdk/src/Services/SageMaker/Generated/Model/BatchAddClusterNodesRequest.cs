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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the BatchAddClusterNodes operation.
    /// Adds nodes to a HyperPod cluster by incrementing the target count for one or more
    /// instance groups. This operation returns a unique <c>NodeLogicalId</c> for each node
    /// being added, which can be used to track the provisioning status of the node. This
    /// API provides a safer alternative to <c>UpdateCluster</c> for scaling operations by
    /// avoiding unintended configuration changes.
    /// 
    ///  <note> 
    /// <para>
    /// This API is only supported for clusters using <c>Continuous</c> as the <c>NodeProvisioningMode</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchAddClusterNodesRequest : AmazonSageMakerRequest
    {
        private string _clientToken;
        private string _clusterName;
        private List<AddClusterNodeSpecification> _nodesToAdd = AWSConfigs.InitializeCollections ? new List<AddClusterNodeSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. This token is valid for 8 hours. If you retry the request with the same
        /// client token within this timeframe and the same parameters, the API returns the same
        /// set of <c>NodeLogicalIds</c> with their latest status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
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
        /// The name of the HyperPod cluster to which you want to add nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property NodesToAdd. 
        /// <para>
        /// A list of instance groups and the number of nodes to add to each. You can specify
        /// up to 5 instance groups in a single request, with a maximum of 50 nodes total across
        /// all instance groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<AddClusterNodeSpecification> NodesToAdd
        {
            get { return this._nodesToAdd; }
            set { this._nodesToAdd = value; }
        }

        // Check to see if NodesToAdd property is set
        internal bool IsSetNodesToAdd()
        {
            return this._nodesToAdd != null && (this._nodesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}