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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
    /// This is the response object from the ConfirmTransitVirtualInterface operation.
    /// </summary>
    public partial class ConfirmTransitVirtualInterfaceResponse : AmazonWebServiceResponse
    {
        private VirtualInterfaceState _virtualInterfaceState;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceState. 
        /// <para>
        /// The state of the virtual interface. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>confirming</c>: The creation of the virtual interface is pending confirmation
        /// from the virtual interface owner. If the owner of the virtual interface is different
        /// from the owner of the connection on which it is provisioned, then the virtual interface
        /// will remain in this state until it is confirmed by the virtual interface owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>verifying</c>: This state only applies to public virtual interfaces. Each public
        /// virtual interface needs validation before the virtual interface can be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: A virtual interface is in this state from the time that it is created
        /// until the virtual interface is ready to forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: A virtual interface that is able to forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>down</c>: A virtual interface that is BGP down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>testing</c>: A virtual interface is in this state immediately after calling <a>StartBgpFailoverTest</a>
        /// and remains in this state during the duration of the test.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: A virtual interface is in this state immediately after calling <a>DeleteVirtualInterface</a>
        /// until it can no longer forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: A virtual interface that cannot forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rejected</c>: The virtual interface owner has declined creation of the virtual
        /// interface. If a virtual interface in the <c>Confirming</c> state is deleted by the
        /// virtual interface owner, the virtual interface enters the <c>Rejected</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown</c>: The state of the virtual interface is not available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VirtualInterfaceState VirtualInterfaceState
        {
            get { return this._virtualInterfaceState; }
            set { this._virtualInterfaceState = value; }
        }

        // Check to see if VirtualInterfaceState property is set
        internal bool IsSetVirtualInterfaceState()
        {
            return this._virtualInterfaceState != null;
        }

    }
}