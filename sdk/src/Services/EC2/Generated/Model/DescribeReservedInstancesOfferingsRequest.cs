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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Sell
    /// in the Reserved Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeReservedInstancesOfferingsRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
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
        private List<string> _reservedInstancesOfferingIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the Reserved Instance can be used.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> can be specified, but
        /// not both.
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
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> can be specified, but
        /// not both.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone where the Reserved Instance can
        /// be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone-id</c> - The ID of the Availability Zone where the Reserved
        /// Instance can be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>duration</c> - The duration of the Reserved Instance (for example, one year or
        /// three years), in seconds (<c>31536000</c> | <c>94608000</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fixed-price</c> - The purchase price of the Reserved Instance (for example, 9800.0).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-type</c> - The instance type that is covered by the reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>marketplace</c> - Set to <c>true</c> to show only Reserved Instance Marketplace
        /// offerings. When this filter is not used, which is the default behavior, all offerings
        /// from both Amazon Web Services and the Reserved Instance Marketplace are listed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>product-description</c> - The Reserved Instance product platform description (<c>Linux/UNIX</c>
        /// | <c>Linux with SQL Server Standard</c> | <c>Linux with SQL Server Web</c> | <c>Linux
        /// with SQL Server Enterprise</c> | <c>SUSE Linux</c> | <c>Red Hat Enterprise Linux</c>
        /// | <c>Red Hat Enterprise Linux with HA</c> | <c>Windows</c> | <c>Windows with SQL Server
        /// Standard</c> | <c>Windows with SQL Server Web</c> | <c>Windows with SQL Server Enterprise</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reserved-instances-offering-id</c> - The Reserved Instances offering ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>scope</c> - The scope of the Reserved Instance (<c>Availability Zone</c> or <c>Region</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>usage-price</c> - The usage price of the Reserved Instance, per hour (for example,
        /// 0.84).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeMarketplace. 
        /// <para>
        /// Include Reserved Instance Marketplace offerings in the response.
        /// </para>
        /// </summary>
        public bool? IncludeMarketplace
        {
            get { return this._includeMarketplace; }
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
        /// a tenancy of <c>dedicated</c> is applied to instances that run in a VPC on single-tenant
        /// hardware (i.e., Dedicated Instances).
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> The <c>host</c> value cannot be used with this parameter. Use the
        /// <c>default</c> or <c>dedicated</c> values only.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>default</c> 
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
        /// The instance type that the reservation will cover (for example, <c>m1.small</c>).
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Amazon
        /// EC2 instance types</a> in the <i>Amazon EC2 User Guide</i>.
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
        public long? MaxDuration
        {
            get { return this._maxDuration; }
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
        public int? MaxInstanceCount
        {
            get { return this._maxInstanceCount; }
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
        /// <c>NextToken</c> value. The maximum is 100.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        public long? MinDuration
        {
            get { return this._minDuration; }
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
        /// The offering class of the Reserved Instance. Can be <c>standard</c> or <c>convertible</c>.
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
        /// API version, you only have access to the <c>Medium Utilization</c> Reserved Instance
        /// offering type. 
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
        /// The Reserved Instance product platform description. Instances that include <c>(Amazon
        /// VPC)</c> in the description are for use with Amazon VPC.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReservedInstancesOfferingIds
        {
            get { return this._reservedInstancesOfferingIds; }
            set { this._reservedInstancesOfferingIds = value; }
        }

        // Check to see if ReservedInstancesOfferingIds property is set
        internal bool IsSetReservedInstancesOfferingIds()
        {
            return this._reservedInstancesOfferingIds != null && (this._reservedInstancesOfferingIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}