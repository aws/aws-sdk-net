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
    /// Describes a transit gateway Connect peer association.
    /// </summary>
    public partial class TransitGatewayConnectPeerAssociation
    {
        private string _deviceId;
        private string _globalNetworkId;
        private string _linkId;
        private TransitGatewayConnectPeerAssociationState _state;
        private string _transitGatewayConnectPeerArn;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The ID of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        [AWSProperty(Min=0, Max=50)]
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

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the association.
        /// </para>
        /// </summary>
        public TransitGatewayConnectPeerAssociationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayConnectPeerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transit gateway Connect peer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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