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
    /// Container for the parameters to the DescribeScheduledInstanceAvailability operation.
    /// Finds available schedules that meet the specified criteria.
    /// 
    ///  
    /// <para>
    /// You can search for an available schedule no more than 3 months in advance. You must
    /// meet the minimum required duration of 1,200 hours per year. For example, the minimum
    /// daily schedule is 4 hours, the minimum weekly schedule is 24 hours, and the minimum
    /// monthly schedule is 100 hours.
    /// </para>
    ///  
    /// <para>
    /// After you find a schedule that meets your needs, call <a>PurchaseScheduledInstances</a>
    /// to purchase Scheduled Instances with that schedule.
    /// </para>
    /// </summary>
    public partial class DescribeScheduledInstanceAvailabilityRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private SlotDateTimeRangeRequest _firstSlotStartTimeRange;
        private int? _maxResults;
        private int? _maxSlotDurationInHours;
        private int? _minSlotDurationInHours;
        private string _nextToken;
        private ScheduledInstanceRecurrenceRequest _recurrence;

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
        /// Gets and sets the property FirstSlotStartTimeRange. 
        /// <para>
        /// The time period for the first schedule to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlotDateTimeRangeRequest FirstSlotStartTimeRange
        {
            get { return this._firstSlotStartTimeRange; }
            set { this._firstSlotStartTimeRange = value; }
        }

        // Check to see if FirstSlotStartTimeRange property is set
        internal bool IsSetFirstSlotStartTimeRange()
        {
            return this._firstSlotStartTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. This value can be between
        /// 5 and 300. The default value is 300. To retrieve the remaining results, make another
        /// call with the returned <c>NextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=300)]
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
        /// Gets and sets the property MaxSlotDurationInHours. 
        /// <para>
        /// The maximum available duration, in hours. This value must be greater than <c>MinSlotDurationInHours</c>
        /// and less than 1,720.
        /// </para>
        /// </summary>
        public int? MaxSlotDurationInHours
        {
            get { return this._maxSlotDurationInHours; }
            set { this._maxSlotDurationInHours = value; }
        }

        // Check to see if MaxSlotDurationInHours property is set
        internal bool IsSetMaxSlotDurationInHours()
        {
            return this._maxSlotDurationInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSlotDurationInHours. 
        /// <para>
        /// The minimum available duration, in hours. The minimum required duration is 1,200 hours
        /// per year. For example, the minimum daily schedule is 4 hours, the minimum weekly schedule
        /// is 24 hours, and the minimum monthly schedule is 100 hours.
        /// </para>
        /// </summary>
        public int? MinSlotDurationInHours
        {
            get { return this._minSlotDurationInHours; }
            set { this._minSlotDurationInHours = value; }
        }

        // Check to see if MinSlotDurationInHours property is set
        internal bool IsSetMinSlotDurationInHours()
        {
            return this._minSlotDurationInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
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
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// The schedule recurrence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduledInstanceRecurrenceRequest Recurrence
        {
            get { return this._recurrence; }
            set { this._recurrence = value; }
        }

        // Check to see if Recurrence property is set
        internal bool IsSetRecurrence()
        {
            return this._recurrence != null;
        }

    }
}