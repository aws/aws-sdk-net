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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Information about the expected route in the route table.
    /// </summary>
    public partial class ExpectedRoute
    {
        /// <summary>
        /// Gets and sets the property AllowedTargets. 
        /// <para>
        /// Information about the allowed targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedTargets property is set.
        /// </summary>
        internal bool IsSetAllowedTargets() => this.AllowedTargets != null && (this.AllowedTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContributingSubnets. 
        /// <para>
        /// Information about the contributing subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ContributingSubnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContributingSubnets property is set.
        /// </summary>
        internal bool IsSetContributingSubnets() => this.ContributingSubnets != null && (this.ContributingSubnets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IpV4Cidr. 
        /// <para>
        /// Information about the IPv4 CIDR block.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string IpV4Cidr { get; set; }

        /// <summary>
        /// Checks to see if the IpV4Cidr property is set.
        /// </summary>
        internal bool IsSetIpV4Cidr() => this.IpV4Cidr != null;

        /// <summary>
        /// Gets and sets the property IpV6Cidr. 
        /// <para>
        /// Information about the IPv6 CIDR block.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string IpV6Cidr { get; set; }

        /// <summary>
        /// Checks to see if the IpV6Cidr property is set.
        /// </summary>
        internal bool IsSetIpV6Cidr() => this.IpV6Cidr != null;

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// Information about the ID of the prefix list for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListId property is set.
        /// </summary>
        internal bool IsSetPrefixListId() => this.PrefixListId != null;

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// Information about the route table ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableId property is set.
        /// </summary>
        internal bool IsSetRouteTableId() => this.RouteTableId != null;
    }
}
