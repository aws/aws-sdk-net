/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateRouteTable operation.
    /// <para>Associates a subnet with a route table. The subnet and route table must be in the same VPC. This association causes traffic
    /// originating from the subnet to be routed according to the routes in the route table. The action returns an association ID, which you need in
    /// order to disassociate the route table from the subnet later. A route table can be associated with multiple subnets.</para> <para>For more
    /// information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a>
    /// in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
    /// </summary>
    public partial class AssociateRouteTableRequest : AmazonEC2Request
    {
        private string subnetId;
        private string routeTableId;


        /// <summary>
        /// The ID of the subnet.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }

        /// <summary>
        /// The ID of the route table.
        ///  
        /// </summary>
        public string RouteTableId
        {
            get { return this.routeTableId; }
            set { this.routeTableId = value; }
        }

        // Check to see if RouteTableId property is set
        internal bool IsSetRouteTableId()
        {
            return this.routeTableId != null;
        }

    }
}
    
