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
    /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeVirtualInterfaces"/>
    public class DescribeVirtualInterfacesRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the ConnectionId property
        /// </summary>
        /// <param name="connectionId">The value to set for the ConnectionId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVirtualInterfacesRequest WithConnectionId(string connectionId)
        {
            this.connectionId = connectionId;
            return this;
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

        /// <summary>
        /// Sets the VirtualInterfaceId property
        /// </summary>
        /// <param name="virtualInterfaceId">The value to set for the VirtualInterfaceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVirtualInterfacesRequest WithVirtualInterfaceId(string virtualInterfaceId)
        {
            this.virtualInterfaceId = virtualInterfaceId;
            return this;
        }
            

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this.virtualInterfaceId != null;
        }
    }
}
    
