/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// <para> The <c>AlarmHistoryItem</c> data type contains descriptive information about the history of a specific alarm. If you call
    /// DescribeAlarmHistory, Amazon CloudWatch returns this data type as part of the DescribeAlarmHistoryResult data type. </para>
    /// </summary>
    public class AlarmHistoryItem
    {
        
        private string alarmName;
        private DateTime? timestamp;
        private HistoryItemType historyItemType;
        private string historySummary;
        private string historyData;

        /// <summary>
        /// The descriptive name for the alarm.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AlarmName
        {
            get { return this.alarmName; }
            set { this.alarmName = value; }
        }

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this.alarmName != null;
        }

        /// <summary>
        /// The time stamp for the alarm history item. Amazon CloudWatch uses Coordinated Universal Time (UTC) when returning time stamps, which do not
        /// accommodate seasonal adjustments such as daylight savings time. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp">Time stamps</a> in the
        /// <i>Amazon CloudWatch Developer Guide</i>.
        ///  
        /// </summary>
        public DateTime Timestamp
        {
            get { return this.timestamp ?? default(DateTime); }
            set { this.timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this.timestamp.HasValue;
        }

        /// <summary>
        /// The type of alarm history item.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ConfigurationUpdate, StateUpdate, Action</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public HistoryItemType HistoryItemType
        {
            get { return this.historyItemType; }
            set { this.historyItemType = value; }
        }

        // Check to see if HistoryItemType property is set
        internal bool IsSetHistoryItemType()
        {
            return this.historyItemType != null;
        }

        /// <summary>
        /// A human-readable summary of the alarm history.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HistorySummary
        {
            get { return this.historySummary; }
            set { this.historySummary = value; }
        }

        // Check to see if HistorySummary property is set
        internal bool IsSetHistorySummary()
        {
            return this.historySummary != null;
        }

        /// <summary>
        /// Machine-readable data about the alarm in JSON format.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 4095</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HistoryData
        {
            get { return this.historyData; }
            set { this.historyData = value; }
        }

        // Check to see if HistoryData property is set
        internal bool IsSetHistoryData()
        {
            return this.historyData != null;
        }
    }
}
