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
    /// Describes the association between a route server and a VPC.
    /// 
    ///  
    /// <para>
    /// A route server association is the connection established between a route server and
    /// a VPC.
    /// </para>
    /// </summary>
    public partial class RouteServerAssociation
    {
        /// <summary>
        /// Gets and sets the property RouteServerId. 
        /// <para>
        /// The ID of the associated route server.
        /// </para>
        /// </summary>
        public string RouteServerId { get; set; }

        /// <summary>
        /// Checks to see if the RouteServerId property is set.
        /// </summary>
        internal bool IsSetRouteServerId() => this.RouteServerId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the association.
        /// </para>
        /// </summary>
        public RouteServerAssociationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the associated VPC.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
