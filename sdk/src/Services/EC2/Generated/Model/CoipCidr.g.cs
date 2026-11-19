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
    /// Information about a customer-owned IP address range.
    /// </summary>
    public partial class CoipCidr
    {
        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        ///  An address range in a customer-owned IP address space. 
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property CoipPoolId. 
        /// <para>
        ///  The ID of the address pool. 
        /// </para>
        /// </summary>
        public string CoipPoolId { get; set; }

        /// <summary>
        /// Checks to see if the CoipPoolId property is set.
        /// </summary>
        internal bool IsSetCoipPoolId() => this.CoipPoolId != null;

        /// <summary>
        /// Gets and sets the property LocalGatewayRouteTableId. 
        /// <para>
        ///  The ID of the local gateway route table. 
        /// </para>
        /// </summary>
        public string LocalGatewayRouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayRouteTableId property is set.
        /// </summary>
        internal bool IsSetLocalGatewayRouteTableId() => this.LocalGatewayRouteTableId != null;
    }
}
