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
    /// Describe Reserved Instances Offerings Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeReservedInstancesOfferingsResult
    {
        private List<ReservedInstancesOffering> reservedInstancesOfferingField;
        /// <summary>
        /// Gets and sets the ReservedInstancesOffering property.
        /// list of reserved instances offering
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesOffering")]
        public List<ReservedInstancesOffering> ReservedInstancesOffering
        {
            get
            {
                if (this.reservedInstancesOfferingField == null)
                {
                    this.reservedInstancesOfferingField = new List<ReservedInstancesOffering>();
                }
                return this.reservedInstancesOfferingField;
            }
            set { this.reservedInstancesOfferingField = value; }
        }

        /// <summary>
        /// Sets the ReservedInstancesOffering property
        /// </summary>
        /// <param name="list">list of reserved instances offering</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsResult WithReservedInstancesOffering(params ReservedInstancesOffering[] list)
        {
            foreach (ReservedInstancesOffering item in list)
            {
                ReservedInstancesOffering.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ReservedInstancesOffering property is set
        /// </summary>
        /// <returns>true if ReservedInstancesOffering property is set</returns>
        public bool IsSetReservedInstancesOffering()
        {
            return (ReservedInstancesOffering.Count > 0);
        }

    }
}
