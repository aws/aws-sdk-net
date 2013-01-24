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
    /// Describes Reserved Instance offerings that are available for purchase.
    /// </summary>
    /// <remarks>
    /// With Amazon EC2 Reserved Instances, you purchase the right to launch
    /// Amazon EC2 instances for a period of time (without getting insufficient
    /// capacity errors) and pay a lower usage rate for the actual time used.
    /// For more information about Reserved Instances, go to the Amazon
    /// Elastic Compute Cloud Developer Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeReservedInstancesOfferingsRequest
    {    
        private List<string> reservedInstancesIdField;
        private string instanceTypeField;
        private string availabilityZoneField;
        private string productDescriptionField;
        private List<Filter> filterField;
        private string instanceTenancyField;
        private string offeringTypeField;
        private bool? includeMarketplaceField;
        private Decimal? minDurationField;
        private Decimal? maxDurationField;
        private int? maxInstanceCountField;
        private string nextTokenField;
        private int? maxResultsField;

        /// <summary>
        /// ID of the Reserved Instances to describe.
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
        /// Sets the ID of the Reserved Instances to describe.
        /// </summary>
        /// <param name="list">ID of the Reserved Instances to describe.</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithReservedInstancesId(params string[] list)
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
        /// The instance type on which the Reserved Instance can be used.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceType")]
        public string InstanceType
        {
            get { return this.instanceTypeField; }
            set { this.instanceTypeField = value; }
        }

        /// <summary>
        /// Sets the instance type on which the Reserved Instance can be used.
        /// </summary>
        /// <param name="instanceType">The instance type on which the Reserved
        /// Instance can be used.</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithInstanceType(string instanceType)
        {
            this.instanceTypeField = instanceType;
            return this;
        }

        /// <summary>
        /// Checks if InstanceType property is set
        /// </summary>
        /// <returns>true if InstanceType property is set</returns>
        public bool IsSetInstanceType()
        {
            return this.instanceTypeField != null;
        }

        /// <summary>
        /// The Availability Zone in which the Reserved Instance can be used.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone in which the Reserved Instance can be used.
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone in which the Reserved
        /// Instance can be used.</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// The Reserved Instance description.
        /// </summary>
        /// <remarks>
        /// Instances that include (Amazon VPC) in the description
        /// are for use with Amazon VPC.
        /// </remarks>
        [XmlElementAttribute(ElementName = "ProductDescription")]
        public string ProductDescription
        {
            get { return this.productDescriptionField; }
            set { this.productDescriptionField = value; }
        }

        /// <summary>
        /// Sets the Reserved Instance description.
        /// </summary>
        /// <param name="productDescription">The Reserved Instance description.</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithProductDescription(string productDescription)
        {
            this.productDescriptionField = productDescription;
            return this;
        }

        /// <summary>
        /// Checks if ProductDescription property is set
        /// </summary>
        /// <returns>true if ProductDescription property is set</returns>
        public bool IsSetProductDescription()
        {
            return this.productDescriptionField != null;
        }

        /// <summary>
        /// A list of filters used to match system-defined properties and user-defined tags 
        /// associated with the specified ReservedInstances.
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
        /// Sets the filters used to match system-defined properties and user-defined tags 
        /// associated with the specified ReservedInstances.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags 
        /// associated with the specified ReservedInstances.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithFilter(params Filter[] list)
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

        /// <summary>
        /// The tenancy of the Reserved Instance offering.
        /// </summary>
        /// <remarks>
        /// A Reserved Instance with tenancy of dedicated will run on 
        /// single-tenant hardware and can only be launched within a VPC.
        /// Valid Values: default | dedicated
        /// </remarks>
        [XmlElementAttribute(ElementName = "InstanceTenancy")]
        public string InstanceTenancy
        {
            get { return this.instanceTenancyField; }
            set { this.instanceTenancyField = value; }
        }

        /// <summary>
        /// Sets the tenancy of the Reserved Instance offering. A Reserved Instance with tenancy of dedicated will run on 
        /// single-tenant hardware and can only be launched within a VPC.
        /// </summary>
        /// <param name="instanceTenancy">Instance Tenancy. Valid Values: default | dedicated</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithInstanceTenancy(string instanceTenancy)
        {
            this.instanceTenancyField = instanceTenancy;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceTenancy property is set.
        /// </summary>
        /// <returns>true if the InstanceTenancy property is set</returns>
        public bool IsSetInstanceTenancy()
        {
            return !string.IsNullOrEmpty(this.instanceTenancyField);
        }

        /// <summary>
        /// The Reserved Instance offering type.
        /// Valid Values: Heavy Utilization | Medium Utilization | Light Utilization
        /// </summary>
        [XmlElementAttribute(ElementName = "OfferingType")]
        public string OfferingType
        {
            get { return this.offeringTypeField; }
            set { this.offeringTypeField = value; }
        }

        /// <summary>
        /// Sets the Reserved Instance offering type.
        /// </summary>
        /// <param name="offeringType">Offering type. Valid values: Heavy Utilization | Medium Utilization | Light Utilization</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithOfferingType(string offeringType)
        {
            this.offeringTypeField = offeringType;
            return this;
        }

        /// <summary>
        /// Checks if the OfferingType property is set.
        /// </summary>
        /// <returns>true if the OfferingType property is set</returns>
        public bool IsSetOfferingType()
        {
            return !string.IsNullOrEmpty(this.offeringTypeField);
        }

        /// <summary>
        /// Whether to include Marketplace offerings in the response.
        /// </summary>
        [XmlElementAttribute(ElementName = "IncludeMarketplace")]
        public bool IncludeMarketplace
        {
            get { return this.includeMarketplaceField.GetValueOrDefault(); }
            set { this.includeMarketplaceField = value; }
        }

        /// <summary>
        /// Sets whether to include Reserved Instance Marketplace listings in the response.
        /// </summary>
        /// <param name="includeMarketplace">True to include Marketplace listings</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithIncludeMarketplace(bool includeMarketplace)
        {
            this.includeMarketplaceField = includeMarketplace;
            return this;
        }

        /// <summary>
        /// Checks whether the IncludeMarketplace property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetIncludeMarketplace()
        {
            return this.includeMarketplaceField != null;
        }

        /// <summary>
        /// The minimum duration (in seconds) to filter when searching for offerings.
        /// </summary>
        /// <remarks>Default: 2592000 (1 month)</remarks>
        [XmlElementAttribute(ElementName = "MinDuration")]
        public Decimal MinDuration
        {
            get { return this.minDurationField.GetValueOrDefault(); }
            set { this.minDurationField = value; }
        }

        /// <summary>
        /// Sets the minimum duration to filter when searching for offerings.
        /// </summary>
        /// <param name="minDuration">Duration in seconds; default: 2592000 (1 month)</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithMinDuration(Decimal minDuration)
        {
            this.minDurationField = minDuration;
            return this;
        }

        /// <summary>
        /// Checks if the MinDuration property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetMinDuration()
        {
            return this.minDurationField != null;
        }

        /// <summary>
        /// The maximum duration (in seconds) to filter when searching for offerings.
        /// </summary>
        /// <remarks>
        /// Default: 94608000 (3 years)
        /// </remarks>
        [XmlElementAttribute(ElementName = "MaxDuration")]
        public Decimal MaxDuration
        {
            get { return this.maxDurationField.GetValueOrDefault(); }
            set { this.maxDurationField = value; }
        }

        /// <summary>
        /// Sets the maximum duration to filter when searching for offerings.
        /// </summary>
        /// <param name="maxDuration">Duration in seconds; default: 94608000 (3 years)</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithMaxDuration(Decimal maxDuration)
        {
            this.maxDurationField = maxDuration;
            return this;
        }

        /// <summary>
        /// Checks if the MaxDuration property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetMaxDuration()
        {
            return this.maxDurationField != null;
        }

        /// <summary>
        /// The maximum number of instances to filter when searching for offerings.
        /// </summary>
        /// <remarks>Default: 20</remarks>
        [XmlElementAttribute(ElementName = "MaxInstanceCount")]
        public int MaxInstanceCount
        {
            get { return this.maxInstanceCountField.GetValueOrDefault(); }
            set { this.maxInstanceCountField = value; }
        }

        /// <summary>
        /// Sets the maximum number of instances to filter when searching for offerings.
        /// </summary>
        /// <param name="maxInstanceCount">Maximum instance count; default - 20</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithMaxInstanceCount(int maxInstanceCount)
        {
            this.maxInstanceCountField = maxInstanceCount;
            return this;
        }

        /// <summary>
        /// Checks if the MaxInstanceCount property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetMaxInstanceCount()
        {
            return this.maxInstanceCountField != null;
        }

        /// <summary>
        /// The maximum number of offerings to return per call.
        /// </summary>
        /// <remarks>Default: 1000, Maximum: 1000</remarks>
        [XmlElementAttribute(ElementName = "MaxResults")]
        public int MaxResults
        {
            get { return this.maxResultsField.GetValueOrDefault(); }
            set { this.maxResultsField = value; }
        }

        /// <summary>
        /// Sets the maximum number of offerings to return per call.
        /// </summary>
        /// <param name="maxResults">Maximum offerings to return; Default: 1000, Maximum: 1000</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithMaxResults(int maxResults)
        {
            this.maxResultsField = maxResults;
            return this;
        }

        /// <summary>
        /// Checks if the MaxResults property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetMaxResults()
        {
            return this.maxResultsField != null;
        }

        /// <summary>
        /// The token to get the next page of results.
        /// </summary>
        /// <remarks>Default: First page of results if the string is empty</remarks>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Sets the token to get the next page of results.
        /// </summary>
        /// <param name="nextToken">Token for next page; first page is returned if empty string</param>
        /// <returns>this instance</returns>
        public DescribeReservedInstancesOfferingsRequest WithNextToken(string nextToken)
        {
            this.nextTokenField = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if the NextToken property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetNextToken()
        {
            return !string.IsNullOrEmpty(this.nextTokenField);
        }
    }
}
