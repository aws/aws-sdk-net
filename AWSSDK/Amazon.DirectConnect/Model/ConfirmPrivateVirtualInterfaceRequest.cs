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
    /// Container for the parameters to the ConfirmPrivateVirtualInterface operation.
    /// <para>Accept ownership of a private virtual interface created by another customer.</para> <para>After the virtual interface owner calls this
    /// function, the virtual interface will be created and attached to the given virtual private gateway, and will be available for handling
    /// traffic.</para>
    /// </summary>
    /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.ConfirmPrivateVirtualInterface"/>
    public class ConfirmPrivateVirtualInterfaceRequest : AmazonWebServiceRequest
    {
        private string virtualInterfaceId;
        private string virtualGatewayId;

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
        public ConfirmPrivateVirtualInterfaceRequest WithVirtualInterfaceId(string virtualInterfaceId)
        {
            this.virtualInterfaceId = virtualInterfaceId;
            return this;
        }
            

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this.virtualInterfaceId != null;
        }

        /// <summary>
        /// ID of the virtual private gateway that will be attached to the virtual interface. A virtual private gateway can be managed via the Amazon
        /// Virtual Private Cloud (VPC) console or the <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html">EC2 CreateVpnGateway</a> action.
        /// Default: None
        ///  
        /// </summary>
        public string VirtualGatewayId
        {
            get { return this.virtualGatewayId; }
            set { this.virtualGatewayId = value; }
        }

        /// <summary>
        /// Sets the VirtualGatewayId property
        /// </summary>
        /// <param name="virtualGatewayId">The value to set for the VirtualGatewayId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfirmPrivateVirtualInterfaceRequest WithVirtualGatewayId(string virtualGatewayId)
        {
            this.virtualGatewayId = virtualGatewayId;
            return this;
        }
            

        // Check to see if VirtualGatewayId property is set
        internal bool IsSetVirtualGatewayId()
        {
            return this.virtualGatewayId != null;
        }
    }
}
    
