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
    /// Gives you information about one or more sets of DHCP options. You can
    /// specify one or more DHCP options set IDs, or no IDs (to describe
    /// all your sets of DHCP options).
    /// </summary>
    /// <remarks>
    /// The returned information consists of:
    /// 1. The DHCP options set ID
    /// 2. The options
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeDhcpOptionsRequest
    {    
        private List<string> dhcpOptionsIdField;
        private List<Filter> filterField;

        /// <summary>
        /// One or more DHCP options set IDs.
        /// </summary>
        [XmlElementAttribute(ElementName = "DhcpOptionsId")]
        public List<string> DhcpOptionsId
        {
            get
            {
                if (this.dhcpOptionsIdField == null)
                {
                    this.dhcpOptionsIdField = new List<string>();
                }
                return this.dhcpOptionsIdField;
            }
            set { this.dhcpOptionsIdField = value; }
        }

        /// <summary>
        /// Sets DHCP options set IDs.
        /// </summary>
        /// <param name="list">A DHCP options set ID.</param>
        /// <returns>this instance</returns>
        public DescribeDhcpOptionsRequest WithDhcpOptionsId(params string[] list)
        {
            foreach (string item in list)
            {
                DhcpOptionsId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if DhcpOptionsId property is set
        /// </summary>
        /// <returns>true if DhcpOptionsId property is set</returns>
        public bool IsSetDhcpOptionsId()
        {
            return (DhcpOptionsId.Count > 0);
        }

        /// <summary>
        /// A list of filters used to match system-defined properties and user-defined tags associated with the specified 
        /// DhcpOptions.
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
        /// Sets filters used to match system-defined properties and user-defined tags associated with the specified 
        /// DhcpOptions.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated with the specified 
        /// DhcpOptions.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        public DescribeDhcpOptionsRequest WithFilter(params Filter[] list)
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
