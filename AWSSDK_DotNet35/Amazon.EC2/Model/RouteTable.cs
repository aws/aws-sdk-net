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
    /// <summary>Route Table
    /// </summary>
    public class RouteTable
    {
        
        private string routeTableId;
        private string vpcId;
        private List<Route> routes = new List<Route>();
        private List<RouteTableAssociation> associations = new List<RouteTableAssociation>();
        private List<Tag> tags = new List<Tag>();
        private List<PropagatingVgw> propagatingVgws = new List<PropagatingVgw>();

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
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }
        public List<Route> Routes
        {
            get { return this.routes; }
            set { this.routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this.routes.Count > 0;
        }
        public List<RouteTableAssociation> Associations
        {
            get { return this.associations; }
            set { this.associations = value; }
        }

        // Check to see if Associations property is set
        internal bool IsSetAssociations()
        {
            return this.associations.Count > 0;
        }
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
        public List<PropagatingVgw> PropagatingVgws
        {
            get { return this.propagatingVgws; }
            set { this.propagatingVgws = value; }
        }

        // Check to see if PropagatingVgws property is set
        internal bool IsSetPropagatingVgws()
        {
            return this.propagatingVgws.Count > 0;
        }
    }
}
