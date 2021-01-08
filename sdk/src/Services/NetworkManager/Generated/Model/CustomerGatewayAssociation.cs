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
    /// Describes the association between a customer gateway, a device, and a link.
    /// </summary>
    public partial class CustomerGatewayAssociation
    {
        private string _customerGatewayArn;
        private string _deviceId;
        private string _globalNetworkId;
        private string _linkId;
        private CustomerGatewayAssociationState _state;

        /// <summary>
        /// Gets and sets the property CustomerGatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer gateway.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property State. 
        /// <para>
        /// The association state.
        /// </para>
        /// </summary>
        public CustomerGatewayAssociationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}