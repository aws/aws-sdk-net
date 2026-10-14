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
    /// Information about the DeleteRoute action in Amazon EC2.
    /// </summary>
    public partial class EC2DeleteRouteAction
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the DeleteRoute action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// Information about the IPv4 CIDR range for the route. The value you specify must match
        /// the CIDR for the route exactly.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidrBlock property is set.
        /// </summary>
        internal bool IsSetDestinationCidrBlock() => this.DestinationCidrBlock != null;

        /// <summary>
        /// Gets and sets the property DestinationIpv6CidrBlock. 
        /// <para>
        /// Information about the IPv6 CIDR range for the route. The value you specify must match
        /// the CIDR for the route exactly.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DestinationIpv6CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIpv6CidrBlock property is set.
        /// </summary>
        internal bool IsSetDestinationIpv6CidrBlock() => this.DestinationIpv6CidrBlock != null;

        /// <summary>
        /// Gets and sets the property DestinationPrefixListId. 
        /// <para>
        /// Information about the ID of the prefix list for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DestinationPrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPrefixListId property is set.
        /// </summary>
        internal bool IsSetDestinationPrefixListId() => this.DestinationPrefixListId != null;

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// Information about the ID of the route table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionTarget RouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableId property is set.
        /// </summary>
        internal bool IsSetRouteTableId() => this.RouteTableId != null;
    }
}
