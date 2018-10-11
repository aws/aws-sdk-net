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
    /// This is the response object from the ConfirmPrivateVirtualInterface operation.
    /// </summary>
    public partial class ConfirmPrivateVirtualInterfaceResponse : AmazonWebServiceResponse
    {
        private VirtualInterfaceState _virtualInterfaceState;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceState. 
        /// <para>
        /// The state of the virtual interface. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>confirming</code>: The creation of the virtual interface is pending confirmation
        /// from the virtual interface owner. If the owner of the virtual interface is different
        /// from the owner of the connection on which it is provisioned, then the virtual interface
        /// will remain in this state until it is confirmed by the virtual interface owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>verifying</code>: This state only applies to public virtual interfaces. Each
        /// public virtual interface needs validation before the virtual interface can be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending</code>: A virtual interface is in this state from the time that it
        /// is created until the virtual interface is ready to forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>available</code>: A virtual interface that is able to forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>down</code>: A virtual interface that is BGP down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleting</code>: A virtual interface is in this state immediately after calling
        /// <a>DeleteVirtualInterface</a> until it can no longer forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleted</code>: A virtual interface that cannot forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rejected</code>: The virtual interface owner has declined creation of the virtual
        /// interface. If a virtual interface in the <code>Confirming</code> state is deleted
        /// by the virtual interface owner, the virtual interface enters the <code>Rejected</code>
        /// state.
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