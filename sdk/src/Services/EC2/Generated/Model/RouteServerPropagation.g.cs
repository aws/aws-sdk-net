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
    /// Describes the route propagation configuration between a route server and a route table.
    /// 
    ///  
    /// <para>
    /// When enabled, route server propagation installs the routes in the FIB on the route
    /// table you've specified. Route server supports IPv4 and IPv6 route propagation.
    /// </para>
    /// </summary>
    public partial class RouteServerPropagation
    {
        /// <summary>
        /// Gets and sets the property RouteServerId. 
        /// <para>
        /// The ID of the route server configured for route propagation.
        /// </para>
        /// </summary>
        public string RouteServerId { get; set; }

        /// <summary>
        /// Checks to see if the RouteServerId property is set.
        /// </summary>
        internal bool IsSetRouteServerId() => this.RouteServerId != null;

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the route table configured for route server propagation.
        /// </para>
        /// </summary>
        public string RouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableId property is set.
        /// </summary>
        internal bool IsSetRouteTableId() => this.RouteTableId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of route propagation.
        /// </para>
        /// </summary>
        public RouteServerPropagationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
