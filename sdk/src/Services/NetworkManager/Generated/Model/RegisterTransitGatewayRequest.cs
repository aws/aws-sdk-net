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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterTransitGateway operation.
    /// Registers a transit gateway in your global network. Not all Regions support transit
    /// gateways for global networks. For a list of the supported Regions, see <a href="https://docs.aws.amazon.com/network-manager/latest/tgwnm/what-are-global-networks.html#nm-available-regions">Region
    /// Availability</a> in the <i>Amazon Web Services Transit Gateways for Global Networks
    /// User Guide</i>. The transit gateway can be in any of the supported Amazon Web Services
    /// Regions, but it must be owned by the same Amazon Web Services account that owns the
    /// global network. You cannot register a transit gateway in more than one global network.
    /// </summary>
    public partial class RegisterTransitGatewayRequest : AmazonNetworkManagerRequest
    {
        private string _globalNetworkId;
        private string _transitGatewayArn;

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string GlobalNetworkId
        {
            get { return this._globalNetworkId; }
            set { this._globalNetworkId = value; }
        }

        // Check to see if GlobalNetworkId property is set
        internal bool IsSetGlobalNetworkId()
        {
            return this._globalNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
        public string TransitGatewayArn
        {
            get { return this._transitGatewayArn; }
            set { this._transitGatewayArn = value; }
        }

        // Check to see if TransitGatewayArn property is set
        internal bool IsSetTransitGatewayArn()
        {
            return this._transitGatewayArn != null;
        }

    }
}