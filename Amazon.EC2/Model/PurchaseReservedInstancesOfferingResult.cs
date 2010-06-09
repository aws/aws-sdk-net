/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Purchase Reserved Instances Offering Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class PurchaseReservedInstancesOfferingResult
    {
        private string reservedInstancesIdField;

        /// <summary>
        /// Gets and sets the ReservedInstancesId property.
        /// The IDs of the purchased Reserved Instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesId")]
        public string ReservedInstancesId
        {
            get { return this.reservedInstancesIdField ; }
            set { this.reservedInstancesIdField= value; }
        }

        /// <summary>
        /// Sets the ReservedInstancesId property
        /// </summary>
        /// <param name="reservedInstancesId">The IDs of the purchased Reserved Instances.</param>
        /// <returns>this instance</returns>
        public PurchaseReservedInstancesOfferingResult WithReservedInstancesId(string reservedInstancesId)
        {
            this.reservedInstancesIdField = reservedInstancesId;
            return this;
        }

        /// <summary>
        /// Checks if ReservedInstancesId property is set
        /// </summary>
        /// <returns>true if ReservedInstancesId property is set</returns>
        public bool IsSetReservedInstancesId()
        {
            return  this.reservedInstancesIdField != null;
        }

    }
}
