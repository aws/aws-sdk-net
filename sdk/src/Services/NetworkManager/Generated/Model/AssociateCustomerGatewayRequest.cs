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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateCustomerGateway operation.
    /// Associates a customer gateway with a device and optionally, with a link. If you specify
    /// a link, it must be associated with the specified device. 
    /// 
    ///  
    /// <para>
    /// You can only associate customer gateways that are connected to a VPN attachment on
    /// a transit gateway or core network registered in your global network. When you register
    /// a transit gateway or core network, customer gateways that are connected to the transit
    /// gateway are automatically included in the global network. To list customer gateways
    /// that are connected to a transit gateway, use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeVpnConnections.html">DescribeVpnConnections</a>
    /// EC2 API and filter by <c>transit-gateway-id</c>.
    /// </para>
    ///  
    /// <para>
    /// You cannot associate a customer gateway with more than one device and link. 
    /// </para>
    /// </summary>
    public partial class AssociateCustomerGatewayRequest : AmazonNetworkManagerRequest
    {
        private string _customerGatewayArn;
        private string _deviceId;
        private string _globalNetworkId;
        private string _linkId;

        /// <summary>
        /// Gets and sets the property CustomerGatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
        public string CustomerGatewayArn
        {
            get { return this._customerGatewayArn; }
            set { this._customerGatewayArn = value; }
        }

        // Check to see if CustomerGatewayArn property is set
        internal bool IsSetCustomerGatewayArn()
        {
            return this._customerGatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The ID of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

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
        /// Gets and sets the property LinkId. 
        /// <para>
        /// The ID of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string LinkId
        {
            get { return this._linkId; }
            set { this._linkId = value; }
        }

        // Check to see if LinkId property is set
        internal bool IsSetLinkId()
        {
            return this._linkId != null;
        }

    }
}