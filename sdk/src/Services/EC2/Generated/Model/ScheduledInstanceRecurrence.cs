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
    /// Describes the recurring schedule for a Scheduled Instance.
    /// </summary>
    public partial class ScheduledInstanceRecurrence
    {
        private string _frequency;
        private int? _interval;
        private List<int> _occurrenceDaySet = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private bool? _occurrenceRelativeToEnd;
        private string _occurrenceUnit;

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The frequency (<c>Daily</c>, <c>Weekly</c>, or <c>Monthly</c>).
        /// </para>
        /// </summary>
        public string Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval quantity. The interval unit depends on the value of <c>frequency</c>.
        /// For example, every 2 weeks or every 2 months.
        /// </para>
        /// </summary>
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OccurrenceDaySet. 
        /// <para>
        /// The days. For a monthly schedule, this is one or more days of the month (1-31). For
        /// a weekly schedule, this is one or more days of the week (1-7, where 1 is Sunday).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> OccurrenceDaySet
        {
            get { return this._occurrenceDaySet; }
            set { this._occurrenceDaySet = value; }
        }

        // Check to see if OccurrenceDaySet property is set
        internal bool IsSetOccurrenceDaySet()
        {
            return this._occurrenceDaySet != null && (this._occurrenceDaySet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OccurrenceRelativeToEnd. 
        /// <para>
        /// Indicates whether the occurrence is relative to the end of the specified week or month.
        /// </para>
        /// </summary>
        public bool? OccurrenceRelativeToEnd
        {
            get { return this._occurrenceRelativeToEnd; }
            set { this._occurrenceRelativeToEnd = value; }
        }

        // Check to see if OccurrenceRelativeToEnd property is set
        internal bool IsSetOccurrenceRelativeToEnd()
        {
            return this._occurrenceRelativeToEnd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OccurrenceUnit. 
        /// <para>
        /// The unit for <c>occurrenceDaySet</c> (<c>DayOfWeek</c> or <c>DayOfMonth</c>).
        /// </para>
        /// </summary>
        public string OccurrenceUnit
        {
            get { return this._occurrenceUnit; }
            set { this._occurrenceUnit = value; }
        }

        // Check to see if OccurrenceUnit property is set
        internal bool IsSetOccurrenceUnit()
        {
            return this._occurrenceUnit != null;
        }

    }
}