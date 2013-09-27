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
    /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeReservedInstancesListingsRequest : EC2Request
    {
        private List<string> reservedInstancesListingIdField;
        private List<string> reservedInstancesIdField;
        private List<Filter> filterField;

        /// <summary>
        /// Ids of the Reserved Instance Listings to describe.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesListingId")]
        public List<string> ReservedInstancesListingId
        {
            get
            {
                if (this.reservedInstancesListingIdField == null)
                    this.reservedInstancesListingIdField = new List<string>();

                return this.reservedInstancesListingIdField;
            }
            set { this.reservedInstancesListingIdField = value; }
        }

        /// <summary>
        /// Sets the Ids of the Reserved Instance Listings to describe.
        /// </summary>
        /// <param name="list">Reserved Instance Listing Ids</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedInstancesListingsRequest WithReservedInstancesListingId(params string[] list)
        {
            foreach (string item in list)
            {
                this.ReservedInstancesListingId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the ReservedInstancesListingId property is set
        /// </summary>
        /// <returns>true if the property is set</returns>
        public bool IsSetReservedInstancesListingId()
        {
            return (this.ReservedInstancesListingId.Count > 0);
        }

        /// <summary>
        /// IDs of the Reserved Instances to describe.
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
        /// Sets the IDs of the Reserved Instances to describe.
        /// </summary>
        /// <param name="list">IDs of the Reserved Instances to describe.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedInstancesListingsRequest WithReservedInstancesId(params string[] list)
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
        /// A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified ReservedInstancesOfferings.
        /// </summary>
        /// <remarks>
        /// The filters available for this operation are:
        /// * status - The status of the Reserved Instance listing. Valid Values: pending | active | cancelled | closed .
        /// * status-message - The reason for the status.
        /// * reserved-instances-listing-id - The ID of the Reserved Instance listing.
        /// * reserved-instances-id - The ID of the Reserved Instances.
        /// </remarks>
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
        /// Sets filters used to match system-defined properties and user-defined tags associated with 
        /// the specified ReservedInstancesOfferings.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified ReservedInstancesOfferings.
        /// </param>
        /// <returns>this instance</returns>
        /// <remarks>
        /// The filters available for this operation are:
        /// * status - The status of the Reserved Instance listing. Valid Values: pending | active | cancelled | closed .
        /// * status-message - The reason for the status.
        /// * reserved-instances-listing-id - The ID of the Reserved Instance listing.
        /// * reserved-instances-id - The ID of the Reserved Instances.
        /// </remarks>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedInstancesListingsRequest WithFilter(params Filter[] list)
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
