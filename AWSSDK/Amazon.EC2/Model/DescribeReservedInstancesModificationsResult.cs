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
using System.IO;
using Amazon.Runtime;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Reserved Instances Modifications Result
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeReservedInstancesModificationsResult
    {
        
        private List<ReservedInstancesModification> reservedInstancesModificationsField;
        private string nextTokenField;

        /// <summary>
        /// The list of Reserved Instances modification requests.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesModifications")]
        public List<ReservedInstancesModification> ReservedInstancesModifications
        {
            get
            {
                if (this.reservedInstancesModificationsField == null)
                    this.reservedInstancesModificationsField = new List<ReservedInstancesModification>();
                return this.reservedInstancesModificationsField;
            }
            set { this.reservedInstancesModificationsField = value; }
        }

        // Check to see if ReservedInstancesModifications property is set
        internal bool IsSetReservedInstancesModifications()
        {
            return this.ReservedInstancesModifications.Count > 0;
        }

        /// <summary>
        /// The string specifying the next paginated set of results to return.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
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
