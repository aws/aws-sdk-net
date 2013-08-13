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
    /// Disassociates a subnet from a route table.
    /// </summary>
    /// <remarks>
    /// After you perform this action, the subnet no longer
    /// uses the routes in the route table. Instead it uses
    /// the routes in the VPC's main route table.
    /// For more information about route tables, go to Route
    /// Tables in the Amazon Virtual Private Cloud User Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DisassociateRouteTableRequest : EC2Request
    {    
        private string associationIdField;

        /// <summary>
        /// The association ID representing the current 
        /// association between the route table and
        /// subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "AssociationId")]
        public string AssociationId
        {
            get { return this.associationIdField; }
            set { this.associationIdField = value; }
        }

        /// <summary>
        /// Sets the association ID representing the current 
        /// association between the route table and
        /// subnet.
        /// </summary>
        /// <param name="associationId">The association ID representing the current 
        /// association between the route table and
        /// subnet.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DisassociateRouteTableRequest WithAssociationId(string associationId)
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

    }
}
