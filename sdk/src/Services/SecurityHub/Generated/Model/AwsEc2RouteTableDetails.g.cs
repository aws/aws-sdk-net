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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about a route table for the specified VPC.
    /// </summary>
    public partial class AwsEc2RouteTableDetails
    {
        /// <summary>
        /// Gets and sets the property AssociationSet. 
        /// <para>
        ///  The associations between a route table and one or more subnets or a gateway. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociationSetDetails> AssociationSet { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociationSetDetails>() : null;

        /// <summary>
        /// Checks to see if the AssociationSet property is set.
        /// </summary>
        internal bool IsSetAssociationSet() => this.AssociationSet != null && (this.AssociationSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        ///  The ID of the Amazon Web Services account that owns the route table. 
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PropagatingVgwSet. 
        /// <para>
        ///  Describes a virtual private gateway propagating route. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PropagatingVgwSetDetails> PropagatingVgwSet { get; set; } = AWSConfigs.InitializeCollections ? new List<PropagatingVgwSetDetails>() : null;

        /// <summary>
        /// Checks to see if the PropagatingVgwSet property is set.
        /// </summary>
        internal bool IsSetPropagatingVgwSet() => this.PropagatingVgwSet != null && (this.PropagatingVgwSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteSet. 
        /// <para>
        ///  The routes in the route table. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteSetDetails> RouteSet { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteSetDetails>() : null;

        /// <summary>
        /// Checks to see if the RouteSet property is set.
        /// </summary>
        internal bool IsSetRouteSet() => this.RouteSet != null && (this.RouteSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        ///  The ID of the route table. 
        /// </para>
        /// </summary>
        public string RouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableId property is set.
        /// </summary>
        internal bool IsSetRouteTableId() => this.RouteTableId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        ///  The ID of the virtual private cloud (VPC). 
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
