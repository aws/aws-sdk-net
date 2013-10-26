/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedInstancesOfferings operation.
    /// <para> The DescribeReservedInstancesOfferings operation describes Reserved Instance offerings that are available for purchase. With Amazon
    /// EC2 Reserved Instances, you purchase the right to launch Amazon EC2 instances for a period of time (without getting insufficient capacity
    /// errors) and pay a lower usage rate for the actual time used. </para>
    /// </summary>
    public partial class DescribeReservedInstancesOfferingsRequest : AmazonEC2Request
    {
        private List<string> reservedInstancesOfferingIds = new List<string>();
        private InstanceType instanceType;
        private string availabilityZone;
        private RIProductDescription productDescription;
        private List<Filter> filters = new List<Filter>();
        private Tenancy instanceTenancy;
        private OfferingTypeValues offeringType;
        private string nextToken;
        private int? maxResults;
        private bool? includeMarketplace;
        private long? minDuration;
        private long? maxDuration;
        private int? maxInstanceCount;


        /// <summary>
        /// An optional list of the unique IDs of the Reserved Instance offerings to describe.
        ///  
        /// </summary>
        public List<string> ReservedInstancesOfferingIds
        {
            get { return this.reservedInstancesOfferingIds; }
            set { this.reservedInstancesOfferingIds = value; }
        }

        // Check to see if ReservedInstancesOfferingIds property is set
        internal bool IsSetReservedInstancesOfferingIds()
        {
            return this.reservedInstancesOfferingIds.Count > 0;
        }

        /// <summary>
        /// The instance type on which the Reserved Instance can be used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>t1.micro, m1.small, m1.medium, m1.large, m1.xlarge, m2.xlarge, m2.2xlarge, m2.4xlarge, m3.xlarge, m3.2xlarge, c1.medium, c1.xlarge, hi1.4xlarge, hs1.8xlarge, cc1.4xlarge, cc2.8xlarge, cg1.4xlarge, cr1.8xlarge</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// The Availability Zone in which the Reserved Instance can be used.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The Reserved Instance product description.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Linux/UNIX, Linux/UNIX (Amazon VPC), Windows, Windows (Amazon VPC)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RIProductDescription ProductDescription
        {
            get { return this.productDescription; }
            set { this.productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this.productDescription != null;
        }

        /// <summary>
        /// A list of filters used to match properties for ReservedInstancesOfferings. For a complete reference to the available filter keys for this
        /// operation, see the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

        /// <summary>
        /// The tenancy of the Reserved Instance offering. A Reserved Instance with tenancy of dedicated will run on single-tenant hardware and can only
        /// be launched within a VPC.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>default, dedicated</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Tenancy InstanceTenancy
        {
            get { return this.instanceTenancy; }
            set { this.instanceTenancy = value; }
        }

        // Check to see if InstanceTenancy property is set
        internal bool IsSetInstanceTenancy()
        {
            return this.instanceTenancy != null;
        }

        /// <summary>
        /// The Reserved Instance offering type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Heavy Utilization, Medium Utilization, Light Utilization</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public OfferingTypeValues OfferingType
        {
            get { return this.offeringType; }
            set { this.offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this.offeringType != null;
        }
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
        public int MaxResults
        {
            get { return this.maxResults ?? default(int); }
            set { this.maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this.maxResults.HasValue;
        }

        /// <summary>
        /// Include Marketplace offerings in the response.
        ///  
        /// </summary>
        public bool IncludeMarketplace
        {
            get { return this.includeMarketplace ?? default(bool); }
            set { this.includeMarketplace = value; }
        }

        // Check to see if IncludeMarketplace property is set
        internal bool IsSetIncludeMarketplace()
        {
            return this.includeMarketplace.HasValue;
        }

        /// <summary>
        /// Minimum duration (in seconds) to filter when searching for offerings.
        ///  
        /// </summary>
        public long MinDuration
        {
            get { return this.minDuration ?? default(long); }
            set { this.minDuration = value; }
        }

        // Check to see if MinDuration property is set
        internal bool IsSetMinDuration()
        {
            return this.minDuration.HasValue;
        }

        /// <summary>
        /// Maximum duration (in seconds) to filter when searching for offerings.
        ///  
        /// </summary>
        public long MaxDuration
        {
            get { return this.maxDuration ?? default(long); }
            set { this.maxDuration = value; }
        }

        // Check to see if MaxDuration property is set
        internal bool IsSetMaxDuration()
        {
            return this.maxDuration.HasValue;
        }
        public int MaxInstanceCount
        {
            get { return this.maxInstanceCount ?? default(int); }
            set { this.maxInstanceCount = value; }
        }

        // Check to see if MaxInstanceCount property is set
        internal bool IsSetMaxInstanceCount()
        {
            return this.maxInstanceCount.HasValue;
        }

    }
}
    
