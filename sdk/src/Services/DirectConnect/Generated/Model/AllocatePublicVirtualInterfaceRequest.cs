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
    /// Container for the parameters to the AllocatePublicVirtualInterface operation.
    /// Provisions a public virtual interface to be owned by the specified Amazon Web Services
    /// account.
    /// 
    ///  
    /// <para>
    /// The owner of a connection calls this function to provision a public virtual interface
    /// to be owned by the specified Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    /// Virtual interfaces created using this function must be confirmed by the owner using
    /// <a>ConfirmPublicVirtualInterface</a>. Until this step has been completed, the virtual
    /// interface is in the <c>confirming</c> state and is not available to handle traffic.
    /// </para>
    ///  
    /// <para>
    /// When creating an IPv6 public virtual interface, omit the Amazon address and customer
    /// address. IPv6 addresses are automatically assigned from the Amazon pool of IPv6 addresses;
    /// you cannot specify custom IPv6 addresses.
    /// </para>
    /// </summary>
    public partial class AllocatePublicVirtualInterfaceRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private NewPublicVirtualInterfaceAllocation _newPublicVirtualInterfaceAllocation;
        private string _ownerAccount;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection on which the public virtual interface is provisioned.
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
        /// Gets and sets the property NewPublicVirtualInterfaceAllocation. 
        /// <para>
        /// Information about the public virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NewPublicVirtualInterfaceAllocation NewPublicVirtualInterfaceAllocation
        {
            get { return this._newPublicVirtualInterfaceAllocation; }
            set { this._newPublicVirtualInterfaceAllocation = value; }
        }

        // Check to see if NewPublicVirtualInterfaceAllocation property is set
        internal bool IsSetNewPublicVirtualInterfaceAllocation()
        {
            return this._newPublicVirtualInterfaceAllocation != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the public virtual interface.
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