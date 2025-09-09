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
    /// Represents the history of a specific alarm.
    /// </summary>
    public partial class AlarmHistoryItem
    {
        private Dictionary<string, string> _alarmContributorAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _alarmContributorId;
        private string _alarmName;
        private AlarmType _alarmType;
        private string _historyData;
        private HistoryItemType _historyItemType;
        private string _historySummary;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property AlarmContributorAttributes. 
        /// <para>
        /// A map of attributes that describe the alarm contributor associated with this history
        /// item, providing context about the contributor's characteristics at the time of the
        /// event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public Dictionary<string, string> AlarmContributorAttributes
        {
            get { return this._alarmContributorAttributes; }
            set { this._alarmContributorAttributes = value; }
        }

        // Check to see if AlarmContributorAttributes property is set
        internal bool IsSetAlarmContributorAttributes()
        {
            return this._alarmContributorAttributes != null && (this._alarmContributorAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AlarmContributorId. 
        /// <para>
        /// The unique identifier of the alarm contributor associated with this history item,
        /// if applicable.
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
        /// The descriptive name for the alarm.
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
        /// Gets and sets the property AlarmType. 
        /// <para>
        /// The type of alarm, either metric alarm or composite alarm.
        /// </para>
        /// </summary>
        public AlarmType AlarmType
        {
            get { return this._alarmType; }
            set { this._alarmType = value; }
        }

        // Check to see if AlarmType property is set
        internal bool IsSetAlarmType()
        {
            return this._alarmType != null;
        }

        /// <summary>
        /// Gets and sets the property HistoryData. 
        /// <para>
        /// Data about the alarm, in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4095)]
        public string HistoryData
        {
            get { return this._historyData; }
            set { this._historyData = value; }
        }

        // Check to see if HistoryData property is set
        internal bool IsSetHistoryData()
        {
            return this._historyData != null;
        }

        /// <summary>
        /// Gets and sets the property HistoryItemType. 
        /// <para>
        /// The type of alarm history item.
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
        /// Gets and sets the property HistorySummary. 
        /// <para>
        /// A summary of the alarm history, in text format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string HistorySummary
        {
            get { return this._historySummary; }
            set { this._historySummary = value; }
        }

        // Check to see if HistorySummary property is set
        internal bool IsSetHistorySummary()
        {
            return this._historySummary != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time stamp for the alarm history item.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}