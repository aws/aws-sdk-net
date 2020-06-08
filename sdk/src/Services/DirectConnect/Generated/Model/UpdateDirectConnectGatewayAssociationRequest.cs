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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDirectConnectGatewayAssociation operation.
    /// Updates the specified attributes of the Direct Connect gateway association.
    /// 
    ///  
    /// <para>
    /// Add or remove prefixes from the association.
    /// </para>
    /// </summary>
    public partial class UpdateDirectConnectGatewayAssociationRequest : AmazonDirectConnectRequest
    {
        private List<RouteFilterPrefix> _addAllowedPrefixesToDirectConnectGateway = new List<RouteFilterPrefix>();
        private string _associationId;
        private List<RouteFilterPrefix> _removeAllowedPrefixesToDirectConnectGateway = new List<RouteFilterPrefix>();

        /// <summary>
        /// Gets and sets the property AddAllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// The Amazon VPC prefixes to advertise to the Direct Connect gateway.
        /// </para>
        /// </summary>
        public List<RouteFilterPrefix> AddAllowedPrefixesToDirectConnectGateway
        {
            get { return this._addAllowedPrefixesToDirectConnectGateway; }
            set { this._addAllowedPrefixesToDirectConnectGateway = value; }
        }

        // Check to see if AddAllowedPrefixesToDirectConnectGateway property is set
        internal bool IsSetAddAllowedPrefixesToDirectConnectGateway()
        {
            return this._addAllowedPrefixesToDirectConnectGateway != null && this._addAllowedPrefixesToDirectConnectGateway.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the Direct Connect gateway association.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveAllowedPrefixesToDirectConnectGateway. 
        /// <para>
        /// The Amazon VPC prefixes to no longer advertise to the Direct Connect gateway.
        /// </para>
        /// </summary>
        public List<RouteFilterPrefix> RemoveAllowedPrefixesToDirectConnectGateway
        {
            get { return this._removeAllowedPrefixesToDirectConnectGateway; }
            set { this._removeAllowedPrefixesToDirectConnectGateway = value; }
        }

        // Check to see if RemoveAllowedPrefixesToDirectConnectGateway property is set
        internal bool IsSetRemoveAllowedPrefixesToDirectConnectGateway()
        {
            return this._removeAllowedPrefixesToDirectConnectGateway != null && this._removeAllowedPrefixesToDirectConnectGateway.Count > 0; 
        }

    }
}