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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBridge operation.
    /// Creates a new bridge. The request must include one source.
    /// </summary>
    public partial class CreateBridgeRequest : AmazonMediaConnectRequest
    {
        private AddEgressGatewayBridgeRequest _egressGatewayBridge;
        private AddIngressGatewayBridgeRequest _ingressGatewayBridge;
        private string _name;
        private List<AddBridgeOutputRequest> _outputs = new List<AddBridgeOutputRequest>();
        private string _placementArn;
        private FailoverConfig _sourceFailoverConfig;
        private List<AddBridgeSourceRequest> _sources = new List<AddBridgeSourceRequest>();

        /// <summary>
        /// Gets and sets the property EgressGatewayBridge. Create a bridge with the egress bridge
        /// type. An egress bridge is a cloud-to-ground bridge. The content comes from an existing
        /// MediaConnect flow and is delivered to your premises.
        /// </summary>
        public AddEgressGatewayBridgeRequest EgressGatewayBridge
        {
            get { return this._egressGatewayBridge; }
            set { this._egressGatewayBridge = value; }
        }

        // Check to see if EgressGatewayBridge property is set
        internal bool IsSetEgressGatewayBridge()
        {
            return this._egressGatewayBridge != null;
        }

        /// <summary>
        /// Gets and sets the property IngressGatewayBridge. Create a bridge with the ingress
        /// bridge type. An ingress bridge is a ground-to-cloud bridge. The content originates
        /// at your premises and is delivered to the cloud.
        /// </summary>
        public AddIngressGatewayBridgeRequest IngressGatewayBridge
        {
            get { return this._ingressGatewayBridge; }
            set { this._ingressGatewayBridge = value; }
        }

        // Check to see if IngressGatewayBridge property is set
        internal bool IsSetIngressGatewayBridge()
        {
            return this._ingressGatewayBridge != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the bridge. This name can not be modified
        /// after the bridge is created.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. The outputs that you want to add to this bridge.
        /// </summary>
        public List<AddBridgeOutputRequest> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlacementArn. The bridge placement Amazon Resource Number
        /// (ARN).
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlacementArn
        {
            get { return this._placementArn; }
            set { this._placementArn = value; }
        }

        // Check to see if PlacementArn property is set
        internal bool IsSetPlacementArn()
        {
            return this._placementArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFailoverConfig. The settings for source failover.
        /// </summary>
        public FailoverConfig SourceFailoverConfig
        {
            get { return this._sourceFailoverConfig; }
            set { this._sourceFailoverConfig = value; }
        }

        // Check to see if SourceFailoverConfig property is set
        internal bool IsSetSourceFailoverConfig()
        {
            return this._sourceFailoverConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. The sources that you want to add to this bridge.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AddBridgeSourceRequest> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

    }
}