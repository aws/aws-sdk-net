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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Represents the history of a specific alarm.
    /// </summary>
    public partial class AlarmHistoryItem
    {
        /// <summary>
        /// Gets and sets the property AlarmContributorAttributes. 
        /// <para>
        /// A map of attributes that describe the alarm contributor associated with this history
        /// item, providing context about the contributor's characteristics at the time of the
        /// event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 150)]
        public Dictionary<string, string> AlarmContributorAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AlarmContributorAttributes property is set.
        /// </summary>
        internal bool IsSetAlarmContributorAttributes() => this.AlarmContributorAttributes != null && (this.AlarmContributorAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AlarmContributorId. 
        /// <para>
        /// The unique identifier of the alarm contributor associated with this history item,
        /// if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public string AlarmContributorId { get; set; }

        /// <summary>
        /// Checks to see if the AlarmContributorId property is set.
        /// </summary>
        internal bool IsSetAlarmContributorId() => this.AlarmContributorId != null;

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The descriptive name for the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AlarmName { get; set; }

        /// <summary>
        /// Checks to see if the AlarmName property is set.
        /// </summary>
        internal bool IsSetAlarmName() => this.AlarmName != null;

        /// <summary>
        /// Gets and sets the property AlarmType. 
        /// <para>
        /// The type of alarm, either metric alarm or composite alarm.
        /// </para>
        /// </summary>
        public AlarmType AlarmType { get; set; }

        /// <summary>
        /// Checks to see if the AlarmType property is set.
        /// </summary>
        internal bool IsSetAlarmType() => this.AlarmType != null;

        /// <summary>
        /// Gets and sets the property HistoryData. 
        /// <para>
        /// Data about the alarm, in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4095)]
        public string HistoryData { get; set; }

        /// <summary>
        /// Checks to see if the HistoryData property is set.
        /// </summary>
        internal bool IsSetHistoryData() => this.HistoryData != null;

        /// <summary>
        /// Gets and sets the property HistoryItemType. 
        /// <para>
        /// The type of alarm history item.
        /// </para>
        /// </summary>
        public HistoryItemType HistoryItemType { get; set; }

        /// <summary>
        /// Checks to see if the HistoryItemType property is set.
        /// </summary>
        internal bool IsSetHistoryItemType() => this.HistoryItemType != null;

        /// <summary>
        /// Gets and sets the property HistorySummary. 
        /// <para>
        /// A summary of the alarm history, in text format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string HistorySummary { get; set; }

        /// <summary>
        /// Checks to see if the HistorySummary property is set.
        /// </summary>
        internal bool IsSetHistorySummary() => this.HistorySummary != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time stamp for the alarm history item.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
