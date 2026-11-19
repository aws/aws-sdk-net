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
    /// Container for the parameters to the DescribeScheduledInstanceAvailability operation.
    /// Finds available schedules that meet the specified criteria. <para> You can search
    /// for an available schedule no more than 3 months in advance. You must meet the minimum
    /// required duration of 1,200 hours per year. For example, the minimum daily schedule
    /// is 4 hours, the minimum weekly schedule is 24 hours, and the minimum monthly schedule
    /// is 100 hours. </para> <para> After you find a schedule that meets your needs, call
    /// <a>PurchaseScheduledInstances</a> to purchase Scheduled Instances with that schedule.
    /// </para>
    /// </summary>
    public partial class DescribeScheduledInstanceAvailabilityRequest : AmazonEC2Request
    {
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
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone (for example, <c>us-west-2a</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-type</c> - The instance type (for example, <c>c4.large</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>platform</c> - The platform (<c>Linux/UNIX</c> or <c>Windows</c>).
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
        /// Gets and sets the property FirstSlotStartTimeRange. 
        /// <para>
        /// The time period for the first schedule to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SlotDateTimeRangeRequest FirstSlotStartTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the FirstSlotStartTimeRange property is set.
        /// </summary>
        internal bool IsSetFirstSlotStartTimeRange() => this.FirstSlotStartTimeRange != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. This value can be between
        /// 5 and 300. The default value is 300. To retrieve the remaining results, make another
        /// call with the returned <c>NextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 300)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MaxSlotDurationInHours. 
        /// <para>
        /// The maximum available duration, in hours. This value must be greater than <c>MinSlotDurationInHours</c>
        /// and less than 1,720.
        /// </para>
        /// </summary>
        public int? MaxSlotDurationInHours { get; set; }

        /// <summary>
        /// Checks to see if the MaxSlotDurationInHours property is set.
        /// </summary>
        internal bool IsSetMaxSlotDurationInHours() => this.MaxSlotDurationInHours.HasValue;

        /// <summary>
        /// Gets and sets the property MinSlotDurationInHours. 
        /// <para>
        /// The minimum available duration, in hours. The minimum required duration is 1,200 hours
        /// per year. For example, the minimum daily schedule is 4 hours, the minimum weekly schedule
        /// is 24 hours, and the minimum monthly schedule is 100 hours.
        /// </para>
        /// </summary>
        public int? MinSlotDurationInHours { get; set; }

        /// <summary>
        /// Checks to see if the MinSlotDurationInHours property is set.
        /// </summary>
        internal bool IsSetMinSlotDurationInHours() => this.MinSlotDurationInHours.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// The schedule recurrence.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduledInstanceRecurrenceRequest Recurrence { get; set; }

        /// <summary>
        /// Checks to see if the Recurrence property is set.
        /// </summary>
        internal bool IsSetRecurrence() => this.Recurrence != null;
    }
}
