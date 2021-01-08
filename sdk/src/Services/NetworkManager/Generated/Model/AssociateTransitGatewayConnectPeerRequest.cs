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
    /// Container for the parameters to the AssociateTransitGatewayConnectPeer operation.
    /// Associates a transit gateway Connect peer with a device, and optionally, with a link.
    /// If you specify a link, it must be associated with the specified device. 
    /// 
    ///  
    /// <para>
    /// You can only associate transit gateway Connect peers that have been created on a transit
    /// gateway that's registered in your global network.
    /// </para>
    ///  
    /// <para>
    /// You cannot associate a transit gateway Connect peer with more than one device and
    /// link. 
    /// </para>
    /// </summary>
    public partial class AssociateTransitGatewayConnectPeerRequest : AmazonNetworkManagerRequest
    {
        private string _deviceId;
        private string _globalNetworkId;
        private string _linkId;
        private string _transitGatewayConnectPeerArn;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The ID of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property TransitGatewayConnectPeerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Connect peer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayConnectPeerArn
        {
            get { return this._transitGatewayConnectPeerArn; }
            set { this._transitGatewayConnectPeerArn = value; }
        }

        // Check to see if TransitGatewayConnectPeerArn property is set
        internal bool IsSetTransitGatewayConnectPeerArn()
        {
            return this._transitGatewayConnectPeerArn != null;
        }

    }
}