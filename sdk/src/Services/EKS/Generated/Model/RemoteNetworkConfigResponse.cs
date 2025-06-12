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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The configuration in the cluster for EKS Hybrid Nodes. You can add, change, or remove
    /// this configuration after the cluster is created.
    /// </summary>
    public partial class RemoteNetworkConfigResponse
    {
        private List<RemoteNodeNetwork> _remoteNodeNetworks = AWSConfigs.InitializeCollections ? new List<RemoteNodeNetwork>() : null;
        private List<RemotePodNetwork> _remotePodNetworks = AWSConfigs.InitializeCollections ? new List<RemotePodNetwork>() : null;

        /// <summary>
        /// Gets and sets the property RemoteNodeNetworks. 
        /// <para>
        /// The list of network CIDRs that can contain hybrid nodes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<RemoteNodeNetwork> RemoteNodeNetworks
        {
            get { return this._remoteNodeNetworks; }
            set { this._remoteNodeNetworks = value; }
        }

        // Check to see if RemoteNodeNetworks property is set
        internal bool IsSetRemoteNodeNetworks()
        {
            return this._remoteNodeNetworks != null && (this._remoteNodeNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemotePodNetworks. 
        /// <para>
        /// The list of network CIDRs that can contain pods that run Kubernetes webhooks on hybrid
        /// nodes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<RemotePodNetwork> RemotePodNetworks
        {
            get { return this._remotePodNetworks; }
            set { this._remotePodNetworks = value; }
        }

        // Check to see if RemotePodNetworks property is set
        internal bool IsSetRemotePodNetworks()
        {
            return this._remotePodNetworks != null && (this._remotePodNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}