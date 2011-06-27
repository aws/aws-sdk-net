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
    public class RouteTable
    {    
        private string routeTableIdField;
        private string vpcIdField;
        private List<Route> routesField;
        private List<RouteTableAssociation> associationsField;
        private List<Tag> tagField;

        /// <summary>
        /// Gets and sets the RouteTableId property.
        /// The route table's ID.
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
        /// <param name="routeTableId">The route table's ID.</param>
        /// <returns>this instance</returns>
        public RouteTable WithRouteTableId(string routeTableId)
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
        /// Gets and sets the VpcId property.
        /// The ID of the VPC the route table is in.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The ID of the VPC the route table is in.</param>
        /// <returns>this instance</returns>
        public RouteTable WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
        }

        /// <summary>
        /// Checks if VpcId property is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return this.vpcIdField != null;
        }

        /// <summary>
        /// Gets and sets the Routes property.
        /// A list of routes in the route table.
        /// </summary>
        [XmlElementAttribute(ElementName = "Routes")]
        public List<Route> Routes
        {
            get
            {
                if (this.routesField == null)
                {
                    this.routesField = new List<Route>();
                }
                return this.routesField;
            }
            set { this.routesField = value; }
        }

        /// <summary>
        /// Sets the Routes property
        /// </summary>
        /// <param name="list">A list of routes in the route table.</param>
        /// <returns>this instance</returns>
        public RouteTable WithRoutes(params Route[] list)
        {
            foreach (Route item in list)
            {
                Routes.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Routes property is set
        /// </summary>
        /// <returns>true if Routes property is set</returns>
        public bool IsSetRoutes()
        {
            return (Routes.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Associations property.
        /// A list of associations between the route table and one or more
        /// subnets.
        /// </summary>
        [XmlElementAttribute(ElementName = "Associations")]
        public List<RouteTableAssociation> Associations
        {
            get
            {
                if (this.associationsField == null)
                {
                    this.associationsField = new List<RouteTableAssociation>();
                }
                return this.associationsField;
            }
            set { this.associationsField = value; }
        }

        /// <summary>
        /// Sets the Associations property
        /// </summary>
        /// <param name="list">A list of associations between the route table and one or more
        /// subnets.</param>
        /// <returns>this instance</returns>
        public RouteTable WithAssociations(params RouteTableAssociation[] list)
        {
            foreach (RouteTableAssociation item in list)
            {
                Associations.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Associations property is set
        /// </summary>
        /// <returns>true if Associations property is set</returns>
        public bool IsSetAssociations()
        {
            return (Associations.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Tag property.
        /// A list of tags for the RouteTable.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the Tag property
        /// </summary>
        /// <param name="list">A list of tags for the RouteTable.</param>
        /// <returns>this instance</returns>
        public RouteTable WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

    }
}
