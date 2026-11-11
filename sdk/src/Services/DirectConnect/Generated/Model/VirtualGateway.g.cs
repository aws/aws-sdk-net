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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about a virtual private gateway for a private virtual interface.
    /// </summary>
    public partial class VirtualGateway
    {
        /// <summary>
        /// Gets and sets the property VirtualGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway.
        /// </para>
        /// </summary>
        public string VirtualGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualGatewayId property is set.
        /// </summary>
        internal bool IsSetVirtualGatewayId() => this.VirtualGatewayId != null;

        /// <summary>
        /// Gets and sets the property VirtualGatewayState. 
        /// <para>
        /// The state of the virtual private gateway. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>pending</c>: Initial state after creating the virtual private gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: Ready for use by a private virtual interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: Initial state after deleting the virtual private gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The virtual private gateway is deleted. The private virtual interface
        /// is unable to send traffic over this gateway.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string VirtualGatewayState { get; set; }

        /// <summary>
        /// Checks to see if the VirtualGatewayState property is set.
        /// </summary>
        internal bool IsSetVirtualGatewayState() => this.VirtualGatewayState != null;
    }
}
