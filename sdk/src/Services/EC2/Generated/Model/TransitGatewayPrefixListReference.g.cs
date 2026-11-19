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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Blackhole. 
        /// <para>
        /// Indicates whether traffic that matches this route is dropped.
        /// </para>
        /// </summary>
        public bool? Blackhole { get; set; }

        /// <summary>
        /// Checks to see if the Blackhole property is set.
        /// </summary>
        internal bool IsSetBlackhole() => this.Blackhole.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListId property is set.
        /// </summary>
        internal bool IsSetPrefixListId() => this.PrefixListId != null;

        /// <summary>
        /// Gets and sets the property PrefixListOwnerId. 
        /// <para>
        /// The ID of the prefix list owner.
        /// </para>
        /// </summary>
        public string PrefixListOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListOwnerId property is set.
        /// </summary>
        internal bool IsSetPrefixListOwnerId() => this.PrefixListOwnerId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the prefix list reference.
        /// </para>
        /// </summary>
        public TransitGatewayPrefixListReferenceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachment. 
        /// <para>
        /// Information about the transit gateway attachment.
        /// </para>
        /// </summary>
        public TransitGatewayPrefixListAttachment TransitGatewayAttachment { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAttachment property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachment() => this.TransitGatewayAttachment != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table.
        /// </para>
        /// </summary>
        public string TransitGatewayRouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayRouteTableId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayRouteTableId() => this.TransitGatewayRouteTableId != null;
    }
}
