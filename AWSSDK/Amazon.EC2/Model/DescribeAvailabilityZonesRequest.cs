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
    /// Lists Availability Zones that are currently
    /// available to the account and their states.
    /// </summary>
    /// <remarks>
    /// Availability Zones are not the same across accounts.
    /// The Availability Zone us-east-1a for account A is not
    /// necessarily the same as us-east-1a for account B.
    /// Zone assignments are mapped independently for each account.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeAvailabilityZonesRequest
    {    
        private List<string> zoneNameField;
        private List<Filter> filterField;

        /// <summary>
        /// One or more Availability Zone names.
        /// </summary>
        [XmlElementAttribute(ElementName = "ZoneName")]
        public List<string> ZoneName
        {
            get
            {
                if (this.zoneNameField == null)
                {
                    this.zoneNameField = new List<string>();
                }
                return this.zoneNameField;
            }
            set { this.zoneNameField = value; }
        }

        /// <summary>
        /// Sets Availability Zone names.
        /// </summary>
        /// <param name="list">Availability Zone name.</param>
        /// <returns>this instance</returns>
        public DescribeAvailabilityZonesRequest WithZoneName(params string[] list)
        {
            foreach (string item in list)
            {
                ZoneName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ZoneName property is set
        /// </summary>
        /// <returns>true if ZoneName property is set</returns>
        public bool IsSetZoneName()
        {
            return (ZoneName.Count > 0);
        }

        /// <summary>
        /// A list of filters used to match system-defined properties and user-defined tags associated with the specified 
        /// AvailabilityZones.
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
        /// Sets the filters used to match system-defined properties and user-defined tags associated with the specified 
        /// AvailabilityZones.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated with the specified 
        /// AvailabilityZones.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        public DescribeAvailabilityZonesRequest WithFilter(params Filter[] list)
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
