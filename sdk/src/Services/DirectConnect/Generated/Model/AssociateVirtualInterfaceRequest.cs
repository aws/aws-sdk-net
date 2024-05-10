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
    /// Container for the parameters to the AssociateVirtualInterface operation.
    /// Associates a virtual interface with a specified link aggregation group (LAG) or connection.
    /// Connectivity to Amazon Web Services is temporarily interrupted as the virtual interface
    /// is being migrated. If the target connection or LAG has an associated virtual interface
    /// with a conflicting VLAN number or a conflicting IP address, the operation fails.
    /// 
    ///  
    /// <para>
    /// Virtual interfaces associated with a hosted connection cannot be associated with a
    /// LAG; hosted connections must be migrated along with their virtual interfaces using
    /// <a>AssociateHostedConnection</a>.
    /// </para>
    ///  
    /// <para>
    /// To reassociate a virtual interface to a new connection or LAG, the requester must
    /// own either the virtual interface itself or the connection to which the virtual interface
    /// is currently associated. Additionally, the requester must own the connection or LAG
    /// for the association.
    /// </para>
    /// </summary>
    public partial class AssociateVirtualInterfaceRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private string _virtualInterfaceId;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the LAG or connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID of the virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VirtualInterfaceId
        {
            get { return this._virtualInterfaceId; }
            set { this._virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this._virtualInterfaceId != null;
        }

    }
}