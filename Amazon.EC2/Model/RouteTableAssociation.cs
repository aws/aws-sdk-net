/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{

    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class RouteTableAssociation
    {    
        private string routeTableAssociationIdField;
        private string routeTableIdField;
        private string subnetIdField;
        private bool? mainField;

        /// <summary>
        /// Gets and sets the RouteTableAssociationId property.
        /// An identifier representing the association between a route table and
        /// a subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "RouteTableAssociationId")]
        public string RouteTableAssociationId
        {
            get { return this.routeTableAssociationIdField; }
            set { this.routeTableAssociationIdField = value; }
        }

        /// <summary>
        /// Sets the RouteTableAssociationId property
        /// </summary>
        /// <param name="routeTableAssociationId">An identifier representing the association between a route table and
        /// a subnet.</param>
        /// <returns>this instance</returns>
        public RouteTableAssociation WithRouteTableAssociationId(string routeTableAssociationId)
        {
            this.routeTableAssociationIdField = routeTableAssociationId;
            return this;
        }

        /// <summary>
        /// Checks if RouteTableAssociationId property is set
        /// </summary>
        /// <returns>true if RouteTableAssociationId property is set</returns>
        public bool IsSetRouteTableAssociationId()
        {
            return this.routeTableAssociationIdField != null;
        }

        /// <summary>
        /// Gets and sets the RouteTableId property.
        /// The ID of the route table in the association.
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
        /// <param name="routeTableId">The ID of the route table in the association.</param>
        /// <returns>this instance</returns>
        public RouteTableAssociation WithRouteTableId(string routeTableId)
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
        /// The ID of the subnet in the association.
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
        /// <param name="subnetId">The ID of the subnet in the association.</param>
        /// <returns>this instance</returns>
        public RouteTableAssociation WithSubnetId(string subnetId)
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

        /// <summary>
        /// Gets and sets the Main property.
        /// Whether this is the main route table.
        /// </summary>
        [XmlElementAttribute(ElementName = "Main")]
        public bool Main
        {
            get { return this.mainField.GetValueOrDefault(); }
            set { this.mainField = value; }
        }

        /// <summary>
        /// Sets the Main property
        /// </summary>
        /// <param name="main">Whether this is the main route table.</param>
        /// <returns>this instance</returns>
        public RouteTableAssociation WithMain(bool main)
        {
            this.mainField = main;
            return this;
        }

        /// <summary>
        /// Checks if Main property is set
        /// </summary>
        /// <returns>true if Main property is set</returns>
        public bool IsSetMain()
        {
            return this.mainField.HasValue;
        }

    }
}
