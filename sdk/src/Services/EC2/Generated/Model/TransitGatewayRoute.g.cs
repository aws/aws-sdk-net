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
    /// Describes a route for a transit gateway route table.
    /// </summary>
    public partial class TransitGatewayRoute
    {
        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The CIDR block used for destination matches.
        /// </para>
        /// </summary>
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidrBlock property is set.
        /// </summary>
        internal bool IsSetDestinationCidrBlock() => this.DestinationCidrBlock != null;

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list used for destination matches.
        /// </para>
        /// </summary>
        public string PrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListId property is set.
        /// </summary>
        internal bool IsSetPrefixListId() => this.PrefixListId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the route.
        /// </para>
        /// </summary>
        public TransitGatewayRouteState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachments. 
        /// <para>
        /// The attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TransitGatewayRouteAttachment> TransitGatewayAttachments { get; set; } = AWSConfigs.InitializeCollections ? new List<TransitGatewayRouteAttachment>() : null;

        /// <summary>
        /// Checks to see if the TransitGatewayAttachments property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachments() => this.TransitGatewayAttachments != null && (this.TransitGatewayAttachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableAnnouncementId. 
        /// <para>
        /// The ID of the transit gateway route table announcement. 
        /// </para>
        /// </summary>
        public string TransitGatewayRouteTableAnnouncementId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayRouteTableAnnouncementId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayRouteTableAnnouncementId() => this.TransitGatewayRouteTableAnnouncementId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The route type.
        /// </para>
        /// </summary>
        public TransitGatewayRouteType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
