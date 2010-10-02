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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes Reserved Instances that you purchased.
    /// For more information about Reserved
    /// Instances, go to the Amazon
    /// Elastic Compute Cloud Developer Guide.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class DescribeReservedInstancesRequest
    {    
        private List<string> reservedInstancesIdField;

        /// <summary>
        /// Gets and sets the ReservedInstancesId property.
        /// IDs of the Reserved Instance to describe.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesId")]
        public List<string> ReservedInstancesId
        {
            get
            {
                if (this.reservedInstancesIdField == null)
                {
                    this.reservedInstancesIdField = new List<string>();
                }
                return this.reservedInstancesIdField;
            }
            set { this.reservedInstancesIdField = value; }
        }

        /// <summary>
        /// Sets the ReservedInstancesId property
        /// </summary>
        /// <param name="list">IDs of the Reserved Instance to describe.</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesRequest WithReservedInstancesId(params string[] list)
        {
            foreach (string item in list)
            {
                ReservedInstancesId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ReservedInstancesId property is set
        /// </summary>
        /// <returns>true if ReservedInstancesId property is set</returns>
        public bool IsSetReservedInstancesId()
        {
            return (ReservedInstancesId.Count > 0);
        }

    }
}
