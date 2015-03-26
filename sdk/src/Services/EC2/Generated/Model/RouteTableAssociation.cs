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
    /// Describes an association between a route table and a subnet.
    /// </summary>
    public partial class RouteTableAssociation
    {
        private bool? _main;
        private string _routeTableAssociationId;
        private string _routeTableId;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property Main. 
        /// <para>
        /// Indicates whether this is the main route table.
        /// </para>
        /// </summary>
        public bool Main
        {
            get { return this._main.GetValueOrDefault(); }
            set { this._main = value; }
        }

        // Check to see if Main property is set
        internal bool IsSetMain()
        {
            return this._main.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RouteTableAssociationId. 
        /// <para>
        /// The ID of the association between a route table and a subnet.
        /// </para>
        /// </summary>
        public string RouteTableAssociationId
        {
            get { return this._routeTableAssociationId; }
            set { this._routeTableAssociationId = value; }
        }

        // Check to see if RouteTableAssociationId property is set
        internal bool IsSetRouteTableAssociationId()
        {
            return this._routeTableAssociationId != null;
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