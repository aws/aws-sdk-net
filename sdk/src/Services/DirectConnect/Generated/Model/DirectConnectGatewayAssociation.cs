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
    /// The association between a direct connect gateway and virtual private gateway.
    /// </summary>
    public partial class DirectConnectGatewayAssociation
    {
        private DirectConnectGatewayAssociationState _associationState;
        private string _directConnectGatewayId;
        private string _stateChangeError;
        private string _virtualGatewayId;
        private string _virtualGatewayOwnerAccount;
        private string _virtualGatewayRegion;

        /// <summary>
        /// Gets and sets the property AssociationState.
        /// </summary>
        public DirectConnectGatewayAssociationState AssociationState
        {
            get { return this._associationState; }
            set { this._associationState = value; }
        }

        // Check to see if AssociationState property is set
        internal bool IsSetAssociationState()
        {
            return this._associationState != null;
        }

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayId.
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
        /// Gets and sets the property StateChangeError.
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

        /// <summary>
        /// Gets and sets the property VirtualGatewayId.
        /// </summary>
        public string VirtualGatewayId
        {
            get { return this._virtualGatewayId; }
            set { this._virtualGatewayId = value; }
        }

        // Check to see if VirtualGatewayId property is set
        internal bool IsSetVirtualGatewayId()
        {
            return this._virtualGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualGatewayOwnerAccount. 
        /// <para>
        /// The AWS account ID of the owner of the virtual private gateway.
        /// </para>
        /// </summary>
        public string VirtualGatewayOwnerAccount
        {
            get { return this._virtualGatewayOwnerAccount; }
            set { this._virtualGatewayOwnerAccount = value; }
        }

        // Check to see if VirtualGatewayOwnerAccount property is set
        internal bool IsSetVirtualGatewayOwnerAccount()
        {
            return this._virtualGatewayOwnerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualGatewayRegion.
        /// </summary>
        public string VirtualGatewayRegion
        {
            get { return this._virtualGatewayRegion; }
            set { this._virtualGatewayRegion = value; }
        }

        // Check to see if VirtualGatewayRegion property is set
        internal bool IsSetVirtualGatewayRegion()
        {
            return this._virtualGatewayRegion != null;
        }

    }
}