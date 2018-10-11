/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePrivateVirtualInterface operation.
    /// Creates a private virtual interface. A virtual interface is the VLAN that transports
    /// AWS Direct Connect traffic. A private virtual interface can be connected to either
    /// a Direct Connect gateway or a Virtual Private Gateway (VGW). Connecting the private
    /// virtual interface to a Direct Connect gateway enables the possibility for connecting
    /// to multiple VPCs, including VPCs in different AWS Regions. Connecting the private
    /// virtual interface to a VGW only provides access to a single VPC within the same Region.
    /// </summary>
    public partial class CreatePrivateVirtualInterfaceRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private NewPrivateVirtualInterface _newPrivateVirtualInterface;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property NewPrivateVirtualInterface. 
        /// <para>
        /// Information about the private virtual interface.
        /// </para>
        /// </summary>
        public NewPrivateVirtualInterface NewPrivateVirtualInterface
        {
            get { return this._newPrivateVirtualInterface; }
            set { this._newPrivateVirtualInterface = value; }
        }

        // Check to see if NewPrivateVirtualInterface property is set
        internal bool IsSetNewPrivateVirtualInterface()
        {
            return this._newPrivateVirtualInterface != null;
        }

    }
}