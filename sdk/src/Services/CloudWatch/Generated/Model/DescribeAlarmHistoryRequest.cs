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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAlarmHistory operation.
    /// Retrieves the history for the specified alarm. You can filter the results by date
    /// range or item type. If an alarm name is not specified, the histories for either all
    /// metric alarms or all composite alarms are returned.
    /// 
    ///  
    /// <para>
    /// CloudWatch retains the history of an alarm even if you delete the alarm.
    /// </para>
    ///  
    /// <para>
    /// To use this operation and return information about a composite alarm, you must be
    /// signed on with the <c>cloudwatch:DescribeAlarmHistory</c> permission that is scoped
    /// to <c>*</c>. You can't return information about composite alarms if your <c>cloudwatch:DescribeAlarmHistory</c>
    /// permission has a narrower scope.
    /// </para>
    /// </summary>
    public partial class DescribeAlarmHistoryRequest : AmazonCloudWatchRequest
    {
        private string _alarmContributorId;
        private string _alarmName;
        private List<string> _alarmTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _endDate;
        private HistoryItemType _historyItemType;
        private int? _maxRecords;
        private string _nextToken;
        private ScanBy _scanBy;
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property AlarmContributorId. 
        /// <para>
        /// The unique identifier of a specific alarm contributor to filter the alarm history
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string AlarmContributorId
        {
            get { return this._alarmContributorId; }
            set { this._alarmContributorId = value; }
        }

        // Check to see if AlarmContributorId property is set
        internal bool IsSetAlarmContributorId()
        {
            return this._alarmContributorId != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property AlarmTypes. 
        /// <para>
        /// Use this parameter to specify whether you want the operation to return metric alarms
        /// or composite alarms. If you omit this parameter, only metric alarms are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AlarmTypes
        {
            get { return this._alarmTypes; }
            set { this._alarmTypes = value; }
        }

        // Check to see if AlarmTypes property is set
        internal bool IsSetAlarmTypes()
        {
            return this._alarmTypes != null && (this._alarmTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The ending date to retrieve alarm history.
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
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
        /// The type of alarm histories to retrieve.
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
        /// The maximum number of alarm history records to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxRecords
        {
            get { return this._maxRecords; }
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
        /// The token returned by a previous call to indicate that there is more data available.
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
        /// Gets and sets the property ScanBy. 
        /// <para>
        /// Specified whether to return the newest or oldest alarm history first. Specify <c>TimestampDescending</c>
        /// to have the newest event history returned first, and specify <c>TimestampAscending</c>
        /// to have the oldest history returned first.
        /// </para>
        /// </summary>
        public ScanBy ScanBy
        {
            get { return this._scanBy; }
            set { this._scanBy = value; }
        }

        // Check to see if ScanBy property is set
        internal bool IsSetScanBy()
        {
            return this._scanBy != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The starting date to retrieve alarm history.
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

    }
}