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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// <para> If you have listed your own Reserved Instances for sale in the Reserved Instance
    /// Marketplace, they will be excluded from these results. This is to ensure that you
    /// do not purchase your own Reserved Instances. </para> <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Sell
    /// in the Reserved Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// <note> <para> The order of the elements in the response, including those within nested
    /// structures, might vary. Applications should not assume the elements appear in a particular
    /// order. </para> </note>
    /// </summary>
    public partial class DescribeReservedInstancesOfferingsRequest : AmazonEC2Request
    {
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
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

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
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeMarketplace. 
        /// <para>
        /// Include Reserved Instance Marketplace offerings in the response.
        /// </para>
        /// </summary>
        public bool? IncludeMarketplace { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMarketplace property is set.
        /// </summary>
        internal bool IsSetIncludeMarketplace() => this.IncludeMarketplace.HasValue;

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
        public Tenancy InstanceTenancy { get; set; }

        /// <summary>
        /// Checks to see if the InstanceTenancy property is set.
        /// </summary>
        internal bool IsSetInstanceTenancy() => this.InstanceTenancy != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type that the reservation will cover (for example, <c>m1.small</c>).
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Amazon
        /// EC2 instance types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

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
        public long? MaxDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaxDuration property is set.
        /// </summary>
        internal bool IsSetMaxDuration() => this.MaxDuration.HasValue;

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
        public int? MaxInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxInstanceCount property is set.
        /// </summary>
        internal bool IsSetMaxInstanceCount() => this.MaxInstanceCount.HasValue;

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
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

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
        public long? MinDuration { get; set; }

        /// <summary>
        /// Checks to see if the MinDuration property is set.
        /// </summary>
        internal bool IsSetMinDuration() => this.MinDuration.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OfferingClass. 
        /// <para>
        /// The offering class of the Reserved Instance. Can be <c>standard</c> or <c>convertible</c>.
        /// </para>
        /// </summary>
        public OfferingClassType OfferingClass { get; set; }

        /// <summary>
        /// Checks to see if the OfferingClass property is set.
        /// </summary>
        internal bool IsSetOfferingClass() => this.OfferingClass != null;

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The Reserved Instance offering type. If you are using tools that predate the 2011-11-01
        /// API version, you only have access to the <c>Medium Utilization</c> Reserved Instance
        /// offering type. 
        /// </para>
        /// </summary>
        public OfferingTypeValues OfferingType { get; set; }

        /// <summary>
        /// Checks to see if the OfferingType property is set.
        /// </summary>
        internal bool IsSetOfferingType() => this.OfferingType != null;

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The Reserved Instance product platform description. Instances that include <c>(Amazon
        /// VPC)</c> in the description are for use with Amazon VPC.
        /// </para>
        /// </summary>
        public RIProductDescription ProductDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProductDescription property is set.
        /// </summary>
        internal bool IsSetProductDescription() => this.ProductDescription != null;

        /// <summary>
        /// Gets and sets the property ReservedInstancesOfferingIds. 
        /// <para>
        /// One or more Reserved Instances offering IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReservedInstancesOfferingIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReservedInstancesOfferingIds property is set.
        /// </summary>
        internal bool IsSetReservedInstancesOfferingIds() => this.ReservedInstancesOfferingIds != null && (this.ReservedInstancesOfferingIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
