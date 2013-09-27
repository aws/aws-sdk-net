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
    /// Lists elastic IP addresses assigned to your
    /// account or provides information about a
    /// specific address.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeAddressesRequest : EC2Request
    {    
        private List<string> publicIpField;
        private List<string> allocationIdField;
        private List<Filter> filterField;

        /// <summary>
        /// Elastic IP address to describe.
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicIp")]
        public List<string> PublicIp
        {
            get
            {
                if (this.publicIpField == null)
                {
                    this.publicIpField = new List<string>();
                }
                return this.publicIpField;
            }
            set { this.publicIpField = value; }
        }

        /// <summary>
        /// Sets the elastic IP address to describe.
        /// </summary>
        /// <param name="list">Elastic IP address to describe.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAddressesRequest WithPublicIp(params string[] list)
        {
            foreach (string item in list)
            {
                PublicIp.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if PublicIp property is set
        /// </summary>
        /// <returns>true if PublicIp property is set</returns>
        public bool IsSetPublicIp()
        {
            return (PublicIp.Count > 0);
        }

        /// <summary>
        /// One or more allocation IDs corresponding to the address 
        /// or addresses to describe. Applies only to VPC addresses.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllocationId")]
        public List<string> AllocationId
        {
            get
            {
                if (this.allocationIdField == null)
                {
                    this.allocationIdField = new List<string>();
                }
                return this.allocationIdField;
            }
            set { this.allocationIdField = value; }
        }

        /// <summary>
        /// Sets allocation IDs corresponding to the address 
        /// or addresses to describe. Applies only to VPC addresses.
        /// </summary>
        /// <param name="list">One or more allocation IDs corresponding to the address 
        /// or addresses to describe. Applies only to VPC addresses.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAddressesRequest WithAllocationId(params string[] list)
        {
            foreach (string item in list)
            {
                AllocationId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AllocationId property is set
        /// </summary>
        /// <returns>true if AllocationId property is set</returns>
        public bool IsSetAllocationId()
        {
            return (AllocationId.Count > 0);
        }

        /// <summary>
        /// A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified DescribeAddresses.
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
        /// Sets the list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified DescribeAddresses.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified DescribeAddresses.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAddressesRequest WithFilter(params Filter[] list)
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
