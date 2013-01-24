/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Changes the route table associated with a given subnet in a VPC.
    /// </summary>
    /// <remarks>
    /// After you execute this action, the subnet uses the routes in the
    /// new route table it's associated with. For more information about
    /// route tables, go to Route Tables in the Amazon Virtual Private
    /// Cloud User Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class ReplaceRouteTableAssociationRequest
    {    
        private string associationIdField;
        private string routeTableIdField;

        /// <summary>
        /// The ID representing the current association between the original route table and the
        /// subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "AssociationId")]
        public string AssociationId
        {
            get { return this.associationIdField; }
            set { this.associationIdField = value; }
        }

        /// <summary>
        /// Sets the ID representing the current association between the original route table and the
        /// subnet.
        /// </summary>
        /// <param name="associationId">The ID representing the current association 
        /// between the original route table and the
        /// subnet.</param>
        /// <returns>this instance</returns>
        public ReplaceRouteTableAssociationRequest WithAssociationId(string associationId)
        {
            this.associationIdField = associationId;
            return this;
        }

        /// <summary>
        /// Checks if AssociationId property is set
        /// </summary>
        /// <returns>true if AssociationId property is set</returns>
        public bool IsSetAssociationId()
        {
            return this.associationIdField != null;
        }

        /// <summary>
        /// The ID of the new route table to associate with the subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "RouteTableId")]
        public string RouteTableId
        {
            get { return this.routeTableIdField; }
            set { this.routeTableIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the new route table to associate with the subnet.
        /// </summary>
        /// <param name="routeTableId">The ID of the new route table to associate with 
        /// the subnet.</param>
        /// <returns>this instance</returns>
        public ReplaceRouteTableAssociationRequest WithRouteTableId(string routeTableId)
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

    }
}
