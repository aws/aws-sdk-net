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
    /// Container for the parameters to the AllocateTransitVirtualInterface operation.
    /// Provisions a transit virtual interface to be owned by the specified Amazon Web Services
    /// account. Use this type of interface to connect a transit gateway to your Direct Connect
    /// gateway.
    /// 
    ///  
    /// <para>
    /// The owner of a connection provisions a transit virtual interface to be owned by the
    /// specified Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    /// After you create a transit virtual interface, it must be confirmed by the owner using
    /// <a>ConfirmTransitVirtualInterface</a>. Until this step has been completed, the transit
    /// virtual interface is in the <c>requested</c> state and is not available to handle
    /// traffic.
    /// </para>
    /// </summary>
    public partial class AllocateTransitVirtualInterfaceRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private NewTransitVirtualInterfaceAllocation _newTransitVirtualInterfaceAllocation;
        private string _ownerAccount;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection on which the transit virtual interface is provisioned.
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
        /// Gets and sets the property NewTransitVirtualInterfaceAllocation. 
        /// <para>
        /// Information about the transit virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NewTransitVirtualInterfaceAllocation NewTransitVirtualInterfaceAllocation
        {
            get { return this._newTransitVirtualInterfaceAllocation; }
            set { this._newTransitVirtualInterfaceAllocation = value; }
        }

        // Check to see if NewTransitVirtualInterfaceAllocation property is set
        internal bool IsSetNewTransitVirtualInterfaceAllocation()
        {
            return this._newTransitVirtualInterfaceAllocation != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the transit virtual interface.
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