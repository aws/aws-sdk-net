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
    /// Container for the parameters to the DescribeCapacityBlockOfferings operation. Describes
    /// Capacity Block offerings available for purchase in the Amazon Web Services Region
    /// that you're currently using. With Capacity Blocks, you can purchase a specific GPU
    /// instance type or EC2 UltraServer for a period of time. <para> To search for an available
    /// Capacity Block offering, you specify a reservation duration and instance count. </para>
    /// </summary>
    public partial class DescribeCapacityBlockOfferingsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AllAvailabilityZones. 
        /// <para>
        ///  Include all Availability Zones and Local Zones, regardless of your opt-in status.
        /// If you do not use this parameter, the results include available offerings from all
        /// Availability Zones in the Amazon Web Services Region and Local Zones you are opted
        /// into. 
        /// </para>
        /// </summary>
        public bool? AllAvailabilityZones { get; set; }

        /// <summary>
        /// Checks to see if the AllAvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAllAvailabilityZones() => this.AllAvailabilityZones.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityDurationHours. 
        /// <para>
        /// The reservation duration for the Capacity Block, in hours. You must specify the duration
        /// in 1-day increments up 14 days, and in 7-day increments up to 182 days.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? CapacityDurationHours { get; set; }

        /// <summary>
        /// Checks to see if the CapacityDurationHours property is set.
        /// </summary>
        internal bool IsSetCapacityDurationHours() => this.CapacityDurationHours.HasValue;

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
        /// Gets and sets the property EndDateRange. 
        /// <para>
        /// The latest end date for the Capacity Block offering.
        /// </para>
        /// </summary>
        public DateTime? EndDateRange { get; set; }

        /// <summary>
        /// Checks to see if the EndDateRange property is set.
        /// </summary>
        internal bool IsSetEndDateRange() => this.EndDateRange.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances for which to reserve capacity. Each Capacity Block can have
        /// up to 64 instances, and you can have up to 256 instances across Capacity Blocks.
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance for which the Capacity Block offering reserves capacity.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartDateRange. 
        /// <para>
        /// The earliest start date for the Capacity Block offering.
        /// </para>
        /// </summary>
        public DateTime? StartDateRange { get; set; }

        /// <summary>
        /// Checks to see if the StartDateRange property is set.
        /// </summary>
        internal bool IsSetStartDateRange() => this.StartDateRange.HasValue;

        /// <summary>
        /// Gets and sets the property UltraserverCount. 
        /// <para>
        /// The number of EC2 UltraServers in the offerings.
        /// </para>
        /// </summary>
        public int? UltraserverCount { get; set; }

        /// <summary>
        /// Checks to see if the UltraserverCount property is set.
        /// </summary>
        internal bool IsSetUltraserverCount() => this.UltraserverCount.HasValue;

        /// <summary>
        /// Gets and sets the property UltraserverType. 
        /// <para>
        /// The EC2 UltraServer type of the Capacity Block offerings.
        /// </para>
        /// </summary>
        public string UltraserverType { get; set; }

        /// <summary>
        /// Checks to see if the UltraserverType property is set.
        /// </summary>
        internal bool IsSetUltraserverType() => this.UltraserverType != null;
    }
}
