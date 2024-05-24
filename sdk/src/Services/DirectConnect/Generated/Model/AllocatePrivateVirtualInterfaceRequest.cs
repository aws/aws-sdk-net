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
    /// Container for the parameters to the AllocatePrivateVirtualInterface operation.
    /// Provisions a private virtual interface to be owned by the specified Amazon Web Services
    /// account.
    /// 
    ///  
    /// <para>
    /// Virtual interfaces created using this action must be confirmed by the owner using
    /// <a>ConfirmPrivateVirtualInterface</a>. Until then, the virtual interface is in the
    /// <c>Confirming</c> state and is not available to handle traffic.
    /// </para>
    /// </summary>
    public partial class AllocatePrivateVirtualInterfaceRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private NewPrivateVirtualInterfaceAllocation _newPrivateVirtualInterfaceAllocation;
        private string _ownerAccount;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection on which the private virtual interface is provisioned.
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
        /// Gets and sets the property NewPrivateVirtualInterfaceAllocation. 
        /// <para>
        /// Information about the private virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NewPrivateVirtualInterfaceAllocation NewPrivateVirtualInterfaceAllocation
        {
            get { return this._newPrivateVirtualInterfaceAllocation; }
            set { this._newPrivateVirtualInterfaceAllocation = value; }
        }

        // Check to see if NewPrivateVirtualInterfaceAllocation property is set
        internal bool IsSetNewPrivateVirtualInterfaceAllocation()
        {
            return this._newPrivateVirtualInterfaceAllocation != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the virtual private interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

    }
}