/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeVirtualInterfaces operation.
    /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer than 15 minutes before DescribeVirtualInterfaces
    /// is called are also returned. If a connection ID is included then only virtual interfaces associated with this connection will be returned.
    /// If a virtual interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN)
    /// transmits the traffic between the Direct Connect location and the customer.</para> <para>If a connection ID is provided, only virtual
    /// interfaces provisioned on the specified connection will be returned. If a virtual interface ID is provided, only this particular virtual
    /// interface will be returned.</para>
    /// </summary>
    public partial class DescribeVirtualInterfacesRequest : AmazonDirectConnectRequest
    {
        private string connectionId;
        private string virtualInterfaceId;


        /// <summary>
        /// ID of the connection. Example: dxcon-fg5678gh Default: None
        ///  
        /// </summary>
        public string ConnectionId
        {
            get { return this.connectionId; }
            set { this.connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this.connectionId != null;
        }

        /// <summary>
        /// ID of the virtual interface. Example: dxvif-123dfg56 Default: None
        ///  
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this.virtualInterfaceId; }
            set { this.virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this.virtualInterfaceId != null;
        }

    }
}
    
