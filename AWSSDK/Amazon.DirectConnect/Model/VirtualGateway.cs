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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para>You can create one or more Direct Connect private virtual interfaces linking to your virtual private gateway.</para> <para>Virtual
    /// private gateway can be managed via AWS Virtual Private Cloud Console or the EC2 CreateVpnGateway API.</para>
    /// </summary>
    public class VirtualGateway  
    {
        
        private string virtualGatewayId;
        private string virtualGatewayState;

        /// <summary>
        /// Virtual private gateway to a VPC. Example: vgw-123er56
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
        public VirtualGateway WithVirtualGatewayId(string virtualGatewayId)
        {
            this.virtualGatewayId = virtualGatewayId;
            return this;
        }
            

        // Check to see if VirtualGatewayId property is set
        internal bool IsSetVirtualGatewayId()
        {
            return this.virtualGatewayId != null;       
        }

        /// <summary>
        /// State of the virtual private gateway. <ul> <li><b>Pending</b>: This is the initial state after calling <i>CreateVpnGateway</i>.</li>
        /// <li><b>Available</b>: Ready for use by a private virtual interface.</li> <li><b>Deleting</b>: This is the initial state after calling
        /// <i>DeleteVpnGateway</i>.</li> <li><b>Deleted</b>: In this state, a private virtual interface is unable to send traffic over this
        /// gateway.</li> </ul>
        ///  
        /// </summary>
        public string VirtualGatewayState
        {
            get { return this.virtualGatewayState; }
            set { this.virtualGatewayState = value; }
        }

        /// <summary>
        /// Sets the VirtualGatewayState property
        /// </summary>
        /// <param name="virtualGatewayState">The value to set for the VirtualGatewayState property </param>
        /// <returns>this instance</returns>
        public VirtualGateway WithVirtualGatewayState(string virtualGatewayState)
        {
            this.virtualGatewayState = virtualGatewayState;
            return this;
        }
            

        // Check to see if VirtualGatewayState property is set
        internal bool IsSetVirtualGatewayState()
        {
            return this.virtualGatewayState != null;       
        }
    }
}
