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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes an association between a route table and a subnet.</para>
    /// </summary>
    public class RouteTableAssociation
    {
        
        private string routeTableAssociationId;
        private string routeTableId;
        private string subnetId;
        private bool? main;


        /// <summary>
        /// The ID of the association between a route table and a subnet.
        ///  
        /// </summary>
        public string RouteTableAssociationId
        {
            get { return this.routeTableAssociationId; }
            set { this.routeTableAssociationId = value; }
        }

        // Check to see if RouteTableAssociationId property is set
        internal bool IsSetRouteTableAssociationId()
        {
            return this.routeTableAssociationId != null;
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
        /// Indicates whether this is the main route table.
        ///  
        /// </summary>
        public bool Main
        {
            get { return this.main ?? default(bool); }
            set { this.main = value; }
        }

        // Check to see if Main property is set
        internal bool IsSetMain()
        {
            return this.main.HasValue;
        }
    }
}
