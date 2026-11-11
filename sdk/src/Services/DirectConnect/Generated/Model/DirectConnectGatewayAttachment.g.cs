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
    /// Information about an attachment between a Direct Connect gateway and a virtual interface.
    /// </summary>
    public partial class DirectConnectGatewayAttachment
    {
        /// <summary>
        /// Gets and sets the property AttachmentState. 
        /// <para>
        /// The state of the attachment. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>attaching</c>: The initial state after a virtual interface is created using the
        /// Direct Connect gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attached</c>: The Direct Connect gateway and virtual interface are attached and
        /// ready to pass traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>detaching</c>: The initial state after calling <a>DeleteVirtualInterface</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>detached</c>: The virtual interface is detached from the Direct Connect gateway.
        /// Traffic flow between the Direct Connect gateway and virtual interface is stopped.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DirectConnectGatewayAttachmentState AttachmentState { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentState property is set.
        /// </summary>
        internal bool IsSetAttachmentState() => this.AttachmentState != null;

        /// <summary>
        /// Gets and sets the property AttachmentType. 
        /// <para>
        /// The type of attachment.
        /// </para>
        /// </summary>
        public DirectConnectGatewayAttachmentType AttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentType property is set.
        /// </summary>
        internal bool IsSetAttachmentType() => this.AttachmentType != null;

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayId. 
        /// <para>
        /// The ID of the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the DirectConnectGatewayId property is set.
        /// </summary>
        internal bool IsSetDirectConnectGatewayId() => this.DirectConnectGatewayId != null;

        /// <summary>
        /// Gets and sets the property StateChangeError. 
        /// <para>
        /// The error message if the state of an object failed to advance.
        /// </para>
        /// </summary>
        public string StateChangeError { get; set; }

        /// <summary>
        /// Checks to see if the StateChangeError property is set.
        /// </summary>
        internal bool IsSetStateChangeError() => this.StateChangeError != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID of the virtual interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceId property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceId() => this.VirtualInterfaceId != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceOwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the virtual interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceOwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceOwnerAccount property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceOwnerAccount() => this.VirtualInterfaceOwnerAccount != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceRegion. 
        /// <para>
        /// The Amazon Web Services Region where the virtual interface is located.
        /// </para>
        /// </summary>
        public string VirtualInterfaceRegion { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceRegion property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceRegion() => this.VirtualInterfaceRegion != null;
    }
}
