/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Describes a route table.
    /// </summary>
    public partial class RouteTable
    {
        private List<RouteTableAssociation> _associations = new List<RouteTableAssociation>();
        private List<PropagatingVgw> _propagatingVgws = new List<PropagatingVgw>();
        private List<Route> _routes = new List<Route>();
        private string _routeTableId;
        private List<Tag> _tags = new List<Tag>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Associations. 
        /// <para>
        /// The associations between the route table and one or more subnets.
        /// </para>
        /// </summary>
        public List<RouteTableAssociation> Associations
        {
            get { return this._associations; }
            set { this._associations = value; }
        }

        // Check to see if Associations property is set
        internal bool IsSetAssociations()
        {
            return this._associations != null && this._associations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PropagatingVgws. 
        /// <para>
        /// Any virtual private gateway (VGW) propagating routes.
        /// </para>
        /// </summary>
        public List<PropagatingVgw> PropagatingVgws
        {
            get { return this._propagatingVgws; }
            set { this._propagatingVgws = value; }
        }

        // Check to see if PropagatingVgws property is set
        internal bool IsSetPropagatingVgws()
        {
            return this._propagatingVgws != null && this._propagatingVgws.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Routes. 
        /// <para>
        /// The routes in the route table.
        /// </para>
        /// </summary>
        public List<Route> Routes
        {
            get { return this._routes; }
            set { this._routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this._routes != null && this._routes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the route table.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the route table.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}