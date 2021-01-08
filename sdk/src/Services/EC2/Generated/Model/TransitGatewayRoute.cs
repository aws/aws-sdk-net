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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a route for a transit gateway route table.
    /// </summary>
    public partial class TransitGatewayRoute
    {
        private string _destinationCidrBlock;
        private string _prefixListId;
        private TransitGatewayRouteState _state;
        private List<TransitGatewayRouteAttachment> _transitGatewayAttachments = new List<TransitGatewayRouteAttachment>();
        private TransitGatewayRouteType _type;

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The CIDR block used for destination matches.
        /// </para>
        /// </summary>
        public string DestinationCidrBlock
        {
            get { return this._destinationCidrBlock; }
            set { this._destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this._destinationCidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list used for destination matches.
        /// </para>
        /// </summary>
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the route.
        /// </para>
        /// </summary>
        public TransitGatewayRouteState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachments. 
        /// <para>
        /// The attachments.
        /// </para>
        /// </summary>
        public List<TransitGatewayRouteAttachment> TransitGatewayAttachments
        {
            get { return this._transitGatewayAttachments; }
            set { this._transitGatewayAttachments = value; }
        }

        // Check to see if TransitGatewayAttachments property is set
        internal bool IsSetTransitGatewayAttachments()
        {
            return this._transitGatewayAttachments != null && this._transitGatewayAttachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The route type.
        /// </para>
        /// </summary>
        public TransitGatewayRouteType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}