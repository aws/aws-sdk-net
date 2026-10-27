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
    /// The action of associating an EC2 resource, such as a subnet or internet gateway, with
    /// a route table.
    /// </summary>
    public partial class EC2AssociateRouteTableAction
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the EC2 route table that is associated with the remediation action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The ID of the gateway to be used with the EC2 route table that is associated with
        /// the remediation action.
        /// </para>
        /// </summary>
        public ActionTarget GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the EC2 route table that is associated with the remediation action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionTarget RouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableId property is set.
        /// </summary>
        internal bool IsSetRouteTableId() => this.RouteTableId != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet for the EC2 route table that is associated with the remediation
        /// action.
        /// </para>
        /// </summary>
        public ActionTarget SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
