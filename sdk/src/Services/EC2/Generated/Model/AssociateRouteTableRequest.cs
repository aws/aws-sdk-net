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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateRouteTable operation.
    /// Associates a subnet in your VPC or an internet gateway or virtual private gateway
    /// attached to your VPC with a route table in your VPC. This association causes traffic
    /// from the subnet or gateway to be routed according to the routes in the route table.
    /// The action returns an association ID, which you need in order to disassociate the
    /// route table later. A route table can be associated with multiple subnets.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
    /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssociateRouteTableRequest : AmazonEC2Request
    {
        private string _gatewayId;
        private string _routeTableId;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The ID of the internet gateway or virtual private gateway.
        /// </para>
        /// </summary>
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the route table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouteTableId
        {
            get { return this._routeTableId; }
            set { this._routeTableId = value; }
        }

        // Check to see if RouteTableId property is set
        internal bool IsSetRouteTableId()
        {
            return this._routeTableId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}