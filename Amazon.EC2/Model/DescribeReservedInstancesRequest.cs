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
 *  API Version: 2010-08-31
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
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-08-31/", IsNullable = false)]
    public class DescribeReservedInstancesRequest
    {    
        private List<string> reservedInstancesIdField;
        private List<Filter> filterField;

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

        /// <summary>
        /// Gets and sets the Filter property.
        /// A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified ReservedInstancesOfferings.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.
        /// </summary>
        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                {
                    this.filterField = new List<Filter>();
                }
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        /// <summary>
        /// Sets the Filter property
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified ReservedInstancesOfferings.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesRequest WithFilter(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Filter property is set
        /// </summary>
        /// <returns>true if Filter property is set</returns>
        public bool IsSetFilter()
        {
            return (Filter.Count > 0);
        }

    }
}
