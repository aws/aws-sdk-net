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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Reserved Instances Offerings Result
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeReservedInstancesOfferingsResult
    {    
        private List<ReservedInstancesOffering> reservedInstancesOfferingField;
        private string nextTokenField;

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
        /// Checks if ReservedInstancesOffering property is set
        /// </summary>
        /// <returns>true if ReservedInstancesOffering property is set</returns>
        public bool IsSetReservedInstancesOffering()
        {
            return (ReservedInstancesOffering.Count > 0);
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// The string marking the next set of results returned. Displays empty
        /// if there are no more results to be returned.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Checks if NextToken property is set
        /// </summary>
        /// <returns>true if NextToken property is set</returns>
        public bool IsSetNextToken()
        {
            return this.nextTokenField != null;
        }

        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        /// <summary>
        /// String Representation of this object. Overrides Object.ToString()
        /// </summary>
        /// <returns>This object as a string</returns>
        public override string ToString()
        {
            return this.ToXML();
        }
    }
}
