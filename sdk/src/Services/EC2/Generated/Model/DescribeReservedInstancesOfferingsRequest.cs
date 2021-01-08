/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedInstancesOfferings operation.
    /// Describes Reserved Instance offerings that are available for purchase. With Reserved
    /// Instances, you purchase the right to launch instances for a period of time. During
    /// that time period, you do not receive insufficient capacity errors, and you pay a lower
    /// usage rate than the rate charged for On-Demand instances for the actual time used.
    /// 
    ///  
    /// <para>
    /// If you have listed your own Reserved Instances for sale in the Reserved Instance Marketplace,
    /// they will be excluded from these results. This is to ensure that you do not purchase
    /// your own Reserved Instances.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
    /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeReservedInstancesOfferingsRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private List<Filter> _filters = new List<Filter>();
        private bool? _includeMarketplace;
        private Tenancy _instanceTenancy;
        private InstanceType _instanceType;
        private long? _maxDuration;
        private int? _maxInstanceCount;
        private int? _maxResults;
        private long? _minDuration;
        private string _nextToken;
        private OfferingClassType _offeringClass;
        private OfferingTypeValues _offeringType;
        private RIProductDescription _productDescription;
        private List<string> _reservedInstancesOfferingIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the Reserved Instance can be used.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone where the Reserved Instance
        /// can be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>duration</code> - The duration of the Reserved Instance (for example, one year
        /// or three years), in seconds (<code>31536000</code> | <code>94608000</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fixed-price</code> - The purchase price of the Reserved Instance (for example,
        /// 9800.0).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-type</code> - The instance type that is covered by the reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>marketplace</code> - Set to <code>true</code> to show only Reserved Instance
        /// Marketplace offerings. When this filter is not used, which is the default behavior,
        /// all offerings from both AWS and the Reserved Instance Marketplace are listed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>product-description</code> - The Reserved Instance product platform description.
        /// Instances that include <code>(Amazon VPC)</code> in the product platform description
        /// will only be displayed to EC2-Classic account holders and are for use with Amazon
        /// VPC. (<code>Linux/UNIX</code> | <code>Linux/UNIX (Amazon VPC)</code> | <code>SUSE
        /// Linux</code> | <code>SUSE Linux (Amazon VPC)</code> | <code>Red Hat Enterprise Linux</code>
        /// | <code>Red Hat Enterprise Linux (Amazon VPC)</code> | <code>Windows</code> | <code>Windows
        /// (Amazon VPC)</code> | <code>Windows with SQL Server Standard</code> | <code>Windows
        /// with SQL Server Standard (Amazon VPC)</code> | <code>Windows with SQL Server Web</code>
        /// | <code> Windows with SQL Server Web (Amazon VPC)</code> | <code>Windows with SQL
        /// Server Enterprise</code> | <code>Windows with SQL Server Enterprise (Amazon VPC)</code>)
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>reserved-instances-offering-id</code> - The Reserved Instances offering ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>scope</code> - The scope of the Reserved Instance (<code>Availability Zone</code>
        /// or <code>Region</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>usage-price</code> - The usage price of the Reserved Instance, per hour (for
        /// example, 0.84).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeMarketplace. 
        /// <para>
        /// Include Reserved Instance Marketplace offerings in the response.
        /// </para>
        /// </summary>
        public bool IncludeMarketplace
        {
            get { return this._includeMarketplace.GetValueOrDefault(); }
            set { this._includeMarketplace = value; }
        }

        // Check to see if IncludeMarketplace property is set
        internal bool IsSetIncludeMarketplace()
        {
            return this._includeMarketplace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceTenancy. 
        /// <para>
        /// The tenancy of the instances covered by the reservation. A Reserved Instance with
        /// a tenancy of <code>dedicated</code> is applied to instances that run in a VPC on single-tenant
        /// hardware (i.e., Dedicated Instances).
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> The <code>host</code> value cannot be used with this parameter.
        /// Use the <code>default</code> or <code>dedicated</code> values only.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>default</code> 
        /// </para>
        /// </summary>
        public Tenancy InstanceTenancy
        {
            get { return this._instanceTenancy; }
            set { this._instanceTenancy = value; }
        }

        // Check to see if InstanceTenancy property is set
        internal bool IsSetInstanceTenancy()
        {
            return this._instanceTenancy != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type that the reservation will cover (for example, <code>m1.small</code>).
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxDuration. 
        /// <para>
        /// The maximum duration (in seconds) to filter when searching for offerings.
        /// </para>
        ///  
        /// <para>
        /// Default: 94608000 (3 years)
        /// </para>
        /// </summary>
        public long MaxDuration
        {
            get { return this._maxDuration.GetValueOrDefault(); }
            set { this._maxDuration = value; }
        }

        // Check to see if MaxDuration property is set
        internal bool IsSetMaxDuration()
        {
            return this._maxDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxInstanceCount. 
        /// <para>
        /// The maximum number of instances to filter when searching for offerings.
        /// </para>
        ///  
        /// <para>
        /// Default: 20
        /// </para>
        /// </summary>
        public int MaxInstanceCount
        {
            get { return this._maxInstanceCount.GetValueOrDefault(); }
            set { this._maxInstanceCount = value; }
        }

        // Check to see if MaxInstanceCount property is set
        internal bool IsSetMaxInstanceCount()
        {
            return this._maxInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results of the initial request can be seen by sending another request with the returned
        /// <code>NextToken</code> value. The maximum is 100.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinDuration. 
        /// <para>
        /// The minimum duration (in seconds) to filter when searching for offerings.
        /// </para>
        ///  
        /// <para>
        /// Default: 2592000 (1 month)
        /// </para>
        /// </summary>
        public long MinDuration
        {
            get { return this._minDuration.GetValueOrDefault(); }
            set { this._minDuration = value; }
        }

        // Check to see if MinDuration property is set
        internal bool IsSetMinDuration()
        {
            return this._minDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingClass. 
        /// <para>
        /// The offering class of the Reserved Instance. Can be <code>standard</code> or <code>convertible</code>.
        /// </para>
        /// </summary>
        public OfferingClassType OfferingClass
        {
            get { return this._offeringClass; }
            set { this._offeringClass = value; }
        }

        // Check to see if OfferingClass property is set
        internal bool IsSetOfferingClass()
        {
            return this._offeringClass != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The Reserved Instance offering type. If you are using tools that predate the 2011-11-01
        /// API version, you only have access to the <code>Medium Utilization</code> Reserved
        /// Instance offering type. 
        /// </para>
        /// </summary>
        public OfferingTypeValues OfferingType
        {
            get { return this._offeringType; }
            set { this._offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this._offeringType != null;
        }

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The Reserved Instance product platform description. Instances that include <code>(Amazon
        /// VPC)</code> in the description are for use with Amazon VPC.
        /// </para>
        /// </summary>
        public RIProductDescription ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this._productDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesOfferingIds. 
        /// <para>
        /// One or more Reserved Instances offering IDs.
        /// </para>
        /// </summary>
        public List<string> ReservedInstancesOfferingIds
        {
            get { return this._reservedInstancesOfferingIds; }
            set { this._reservedInstancesOfferingIds = value; }
        }

        // Check to see if ReservedInstancesOfferingIds property is set
        internal bool IsSetReservedInstancesOfferingIds()
        {
            return this._reservedInstancesOfferingIds != null && this._reservedInstancesOfferingIds.Count > 0; 
        }

    }
}