/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAlarmHistory operation.
    /// Retrieves history for the specified alarm. Filter alarms by date range or item type.
    /// If an alarm name is not specified, Amazon CloudWatch returns histories for all of
    /// the owner's alarms.
    /// </summary>
    public partial class DescribeAlarmHistoryRequest : AmazonCloudWatchRequest
    {
        private string _alarmName;
        private DateTime? _endDate;
        private HistoryItemType _historyItemType;
        private int? _maxRecords;
        private string _nextToken;
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        ///  The name of the alarm. 
        /// </para>
        /// </summary>
        public string AlarmName
        {
            get { return this._alarmName; }
            set { this._alarmName = value; }
        }

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this._alarmName != null;
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        ///  The ending date to retrieve alarm history. 
        /// </para>
        /// </summary>
        public DateTime EndDate
        {
            get { return this._endDate.GetValueOrDefault(); }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HistoryItemType. 
        /// <para>
        ///  The type of alarm histories to retrieve. 
        /// </para>
        /// </summary>
        public HistoryItemType HistoryItemType
        {
            get { return this._historyItemType; }
            set { this._historyItemType = value; }
        }

        // Check to see if HistoryItemType property is set
        internal bool IsSetHistoryItemType()
        {
            return this._historyItemType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///  The maximum number of alarm history records to retrieve. 
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token returned by a previous call to indicate that there is more data available.
        /// 
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
        /// Gets and sets the property StartDate. 
        /// <para>
        ///  The starting date to retrieve alarm history. 
        /// </para>
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

    }
}