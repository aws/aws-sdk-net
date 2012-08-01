/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Associates a subnet with a route table. The subnet and route table must be in the same VPC. This
    /// association causes traffic originating from the subnet to be routed according to the routes in the route
    /// table. The action returns an association ID, which you need if you want to disassociate the route table
    /// from the subnet later. A route table can be associated with multiple subnets.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class AssociateRouteTableRequest
    {    
        private string routeTableIdField;
        private string subnetIdField;

        /// <summary>
        /// Gets and sets the RouteTableId property.
        /// The ID of the route table.
        /// </summary>
        [XmlElementAttribute(ElementName = "RouteTableId")]
        public string RouteTableId
        {
            get { return this.routeTableIdField; }
            set { this.routeTableIdField = value; }
        }

        /// <summary>
        /// Sets the RouteTableId property
        /// </summary>
        /// <param name="routeTableId">The ID of the route table.</param>
        /// <returns>this instance</returns>
        public AssociateRouteTableRequest WithRouteTableId(string routeTableId)
        {
            this.routeTableIdField = routeTableId;
            return this;
        }

        /// <summary>
        /// Checks if RouteTableId property is set
        /// </summary>
        /// <returns>true if RouteTableId property is set</returns>
        public bool IsSetRouteTableId()
        {
            return this.routeTableIdField != null;
        }

        /// <summary>
        /// Gets and sets the SubnetId property.
        /// The ID of the subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets the SubnetId property
        /// </summary>
        /// <param name="subnetId">The ID of the subnet.</param>
        /// <returns>this instance</returns>
        public AssociateRouteTableRequest WithSubnetId(string subnetId)
        {
            this.subnetIdField = subnetId;
            return this;
        }

        /// <summary>
        /// Checks if SubnetId property is set
        /// </summary>
        /// <returns>true if SubnetId property is set</returns>
        public bool IsSetSubnetId()
        {
            return this.subnetIdField != null;
        }

    }
}
