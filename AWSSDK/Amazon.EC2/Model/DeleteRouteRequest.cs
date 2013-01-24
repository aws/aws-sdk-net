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
    /// Deletes a route from a route table in a VPC.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DeleteRouteRequest
    {    
        private string routeTableIdField;
        private string destinationCidrBlockField;

        /// <summary>
        /// The ID of the route table where the route will be deleted.
        /// </summary>
        [XmlElementAttribute(ElementName = "RouteTableId")]
        public string RouteTableId
        {
            get { return this.routeTableIdField; }
            set { this.routeTableIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the route table where the route will be deleted.
        /// </summary>
        /// <param name="routeTableId">The ID of the route table where the route will 
        /// be deleted.</param>
        /// <returns>this instance</returns>
        public DeleteRouteRequest WithRouteTableId(string routeTableId)
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
        /// The CIDR range for the route you want to delete.
        /// The value you specify must exactly
        /// match the CIDR for the route you want to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationCidrBlock")]
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlockField; }
            set { this.destinationCidrBlockField = value; }
        }

        /// <summary>
        /// Sets the CIDR range for the route you want to delete.
        /// </summary>
        /// <param name="destinationCidrBlock">The CIDR range for the route you want to 
        /// delete. The value you specify must exactly
        /// match the CIDR for the route you want to
        /// delete.</param>
        /// <returns>this instance</returns>
        public DeleteRouteRequest WithDestinationCidrBlock(string destinationCidrBlock)
        {
            this.destinationCidrBlockField = destinationCidrBlock;
            return this;
        }

        /// <summary>
        /// Checks if DestinationCidrBlock property is set
        /// </summary>
        /// <returns>true if DestinationCidrBlock property is set</returns>
        public bool IsSetDestinationCidrBlock()
        {
            return this.destinationCidrBlockField != null;
        }

    }
}
