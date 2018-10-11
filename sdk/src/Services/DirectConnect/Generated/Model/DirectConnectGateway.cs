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
    /// Information about a Direct Connect gateway, which enables you to connect virtual interfaces
    /// and virtual private gateways.
    /// </summary>
    public partial class DirectConnectGateway
    {
        private long? _amazonSideAsn;
        private string _directConnectGatewayId;
        private string _directConnectGatewayName;
        private DirectConnectGatewayState _directConnectGatewayState;
        private string _ownerAccount;
        private string _stateChangeError;

        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// The autonomous system number (ASN) for the Amazon side of the connection.
        /// </para>
        /// </summary>
        public long AmazonSideAsn
        {
            get { return this._amazonSideAsn.GetValueOrDefault(); }
            set { this._amazonSideAsn = value; }
        }

        // Check to see if AmazonSideAsn property is set
        internal bool IsSetAmazonSideAsn()
        {
            return this._amazonSideAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayId. 
        /// <para>
        /// The ID of the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayId
        {
            get { return this._directConnectGatewayId; }
            set { this._directConnectGatewayId = value; }
        }

        // Check to see if DirectConnectGatewayId property is set
        internal bool IsSetDirectConnectGatewayId()
        {
            return this._directConnectGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayName. 
        /// <para>
        /// The name of the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayName
        {
            get { return this._directConnectGatewayName; }
            set { this._directConnectGatewayName = value; }
        }

        // Check to see if DirectConnectGatewayName property is set
        internal bool IsSetDirectConnectGatewayName()
        {
            return this._directConnectGatewayName != null;
        }

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayState. 
        /// <para>
        /// The state of the Direct Connect gateway. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>pending</code>: The initial state after calling <a>CreateDirectConnectGateway</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>available</code>: The Direct Connect gateway is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleting</code>: The initial state after calling <a>DeleteDirectConnectGateway</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleted</code>: The Direct Connect gateway is deleted and cannot pass traffic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DirectConnectGatewayState DirectConnectGatewayState
        {
            get { return this._directConnectGatewayState; }
            set { this._directConnectGatewayState = value; }
        }

        // Check to see if DirectConnectGatewayState property is set
        internal bool IsSetDirectConnectGatewayState()
        {
            return this._directConnectGatewayState != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the AWS account that owns the Direct Connect gateway.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property StateChangeError. 
        /// <para>
        /// The error message if the state of an object failed to advance.
        /// </para>
        /// </summary>
        public string StateChangeError
        {
            get { return this._stateChangeError; }
            set { this._stateChangeError = value; }
        }

        // Check to see if StateChangeError property is set
        internal bool IsSetStateChangeError()
        {
            return this._stateChangeError != null;
        }

    }
}