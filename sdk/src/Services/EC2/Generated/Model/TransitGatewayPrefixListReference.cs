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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a prefix list reference.
    /// </summary>
    public partial class TransitGatewayPrefixListReference
    {
        private bool? _blackhole;
        private string _prefixListId;
        private string _prefixListOwnerId;
        private TransitGatewayPrefixListReferenceState _state;
        private TransitGatewayPrefixListAttachment _transitGatewayAttachment;
        private string _transitGatewayRouteTableId;

        /// <summary>
        /// Gets and sets the property Blackhole. 
        /// <para>
        /// Indicates whether traffic that matches this route is dropped.
        /// </para>
        /// </summary>
        public bool? Blackhole
        {
            get { return this._blackhole; }
            set { this._blackhole = value; }
        }

        // Check to see if Blackhole property is set
        internal bool IsSetBlackhole()
        {
            return this._blackhole.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
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
        /// Gets and sets the property PrefixListOwnerId. 
        /// <para>
        /// The ID of the prefix list owner.
        /// </para>
        /// </summary>
        public string PrefixListOwnerId
        {
            get { return this._prefixListOwnerId; }
            set { this._prefixListOwnerId = value; }
        }

        // Check to see if PrefixListOwnerId property is set
        internal bool IsSetPrefixListOwnerId()
        {
            return this._prefixListOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the prefix list reference.
        /// </para>
        /// </summary>
        public TransitGatewayPrefixListReferenceState State
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
        /// Gets and sets the property TransitGatewayAttachment. 
        /// <para>
        /// Information about the transit gateway attachment.
        /// </para>
        /// </summary>
        public TransitGatewayPrefixListAttachment TransitGatewayAttachment
        {
            get { return this._transitGatewayAttachment; }
            set { this._transitGatewayAttachment = value; }
        }

        // Check to see if TransitGatewayAttachment property is set
        internal bool IsSetTransitGatewayAttachment()
        {
            return this._transitGatewayAttachment != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table.
        /// </para>
        /// </summary>
        public string TransitGatewayRouteTableId
        {
            get { return this._transitGatewayRouteTableId; }
            set { this._transitGatewayRouteTableId = value; }
        }

        // Check to see if TransitGatewayRouteTableId property is set
        internal bool IsSetTransitGatewayRouteTableId()
        {
            return this._transitGatewayRouteTableId != null;
        }

    }
}