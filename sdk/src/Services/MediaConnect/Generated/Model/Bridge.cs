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
    /// A Bridge is the connection between your datacenter's Instances and the AWS cloud.
    /// A bridge can be used to send video from the AWS cloud to your datacenter or from your
    /// datacenter to the AWS cloud.
    /// </summary>
    public partial class Bridge
    {
        private string _bridgeArn;
        private List<MessageDetail> _bridgeMessages = new List<MessageDetail>();
        private BridgeState _bridgeState;
        private EgressGatewayBridge _egressGatewayBridge;
        private IngressGatewayBridge _ingressGatewayBridge;
        private string _name;
        private List<BridgeOutput> _outputs = new List<BridgeOutput>();
        private string _placementArn;
        private FailoverConfig _sourceFailoverConfig;
        private List<BridgeSource> _sources = new List<BridgeSource>();

        /// <summary>
        /// Gets and sets the property BridgeArn. The Amazon Resource Number (ARN) of the bridge.
        /// </summary>
        [AWSProperty(Required=true)]
        public string BridgeArn
        {
            get { return this._bridgeArn; }
            set { this._bridgeArn = value; }
        }

        // Check to see if BridgeArn property is set
        internal bool IsSetBridgeArn()
        {
            return this._bridgeArn != null;
        }

        /// <summary>
        /// Gets and sets the property BridgeMessages.
        /// </summary>
        public List<MessageDetail> BridgeMessages
        {
            get { return this._bridgeMessages; }
            set { this._bridgeMessages = value; }
        }

        // Check to see if BridgeMessages property is set
        internal bool IsSetBridgeMessages()
        {
            return this._bridgeMessages != null && this._bridgeMessages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BridgeState.
        /// </summary>
        [AWSProperty(Required=true)]
        public BridgeState BridgeState
        {
            get { return this._bridgeState; }
            set { this._bridgeState = value; }
        }

        // Check to see if BridgeState property is set
        internal bool IsSetBridgeState()
        {
            return this._bridgeState != null;
        }

        /// <summary>
        /// Gets and sets the property EgressGatewayBridge.
        /// </summary>
        public EgressGatewayBridge EgressGatewayBridge
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
        /// Gets and sets the property IngressGatewayBridge.
        /// </summary>
        public IngressGatewayBridge IngressGatewayBridge
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
        /// Gets and sets the property Name. The name of the bridge.
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
        /// Gets and sets the property Outputs. The outputs on this bridge.
        /// </summary>
        public List<BridgeOutput> Outputs
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
        /// Gets and sets the property PlacementArn. The placement Amazon Resource Number (ARN)
        /// of the bridge.
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
        /// Gets and sets the property SourceFailoverConfig.
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
        /// Gets and sets the property Sources. The sources on this bridge.
        /// </summary>
        public List<BridgeSource> Sources
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