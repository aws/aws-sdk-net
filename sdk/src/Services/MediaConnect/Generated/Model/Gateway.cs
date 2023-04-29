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
    /// The settings for a gateway, including its networks.
    /// </summary>
    public partial class Gateway
    {
        private List<string> _egressCidrBlocks = new List<string>();
        private string _gatewayArn;
        private List<MessageDetail> _gatewayMessages = new List<MessageDetail>();
        private GatewayState _gatewayState;
        private string _name;
        private List<GatewayNetwork> _networks = new List<GatewayNetwork>();

        /// <summary>
        /// Gets and sets the property EgressCidrBlocks. The range of IP addresses that contribute
        /// content or initiate output requests for flows communicating with this gateway. These
        /// IP addresses should be in the form of a Classless Inter-Domain Routing (CIDR) block;
        /// for example, 10.0.0.0/16.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> EgressCidrBlocks
        {
            get { return this._egressCidrBlocks; }
            set { this._egressCidrBlocks = value; }
        }

        // Check to see if EgressCidrBlocks property is set
        internal bool IsSetEgressCidrBlocks()
        {
            return this._egressCidrBlocks != null && this._egressCidrBlocks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GatewayArn. The Amazon Resource Name (ARN) of the gateway.
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayMessages.
        /// </summary>
        public List<MessageDetail> GatewayMessages
        {
            get { return this._gatewayMessages; }
            set { this._gatewayMessages = value; }
        }

        // Check to see if GatewayMessages property is set
        internal bool IsSetGatewayMessages()
        {
            return this._gatewayMessages != null && this._gatewayMessages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GatewayState. The current status of the gateway.
        /// </summary>
        public GatewayState GatewayState
        {
            get { return this._gatewayState; }
            set { this._gatewayState = value; }
        }

        // Check to see if GatewayState property is set
        internal bool IsSetGatewayState()
        {
            return this._gatewayState != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the gateway. This name can not be modified
        /// after the gateway is created.
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
        /// Gets and sets the property Networks. The list of networks in the gateway.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GatewayNetwork> Networks
        {
            get { return this._networks; }
            set { this._networks = value; }
        }

        // Check to see if Networks property is set
        internal bool IsSetNetworks()
        {
            return this._networks != null && this._networks.Count > 0; 
        }

    }
}