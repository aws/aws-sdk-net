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
    /// Describes a transit gateway route table.
    /// </summary>
    public partial class TransitGatewayRouteTable
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultAssociationRouteTable. 
        /// <para>
        /// Indicates whether this is the default association route table for the transit gateway.
        /// </para>
        /// </summary>
        public bool? DefaultAssociationRouteTable { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAssociationRouteTable property is set.
        /// </summary>
        internal bool IsSetDefaultAssociationRouteTable() => this.DefaultAssociationRouteTable.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultPropagationRouteTable. 
        /// <para>
        /// Indicates whether this is the default propagation route table for the transit gateway.
        /// </para>
        /// </summary>
        public bool? DefaultPropagationRouteTable { get; set; }

        /// <summary>
        /// Checks to see if the DefaultPropagationRouteTable property is set.
        /// </summary>
        internal bool IsSetDefaultPropagationRouteTable() => this.DefaultPropagationRouteTable.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the transit gateway route table.
        /// </para>
        /// </summary>
        public TransitGatewayRouteTableState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the route table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway.
        /// </para>
        /// </summary>
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;

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
