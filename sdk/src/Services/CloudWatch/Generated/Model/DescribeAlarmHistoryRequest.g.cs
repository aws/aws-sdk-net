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
    /// Container for the parameters to the DescribeAlarmHistory operation. Retrieves the
    /// history for the specified alarm. You can filter the results by date range or item
    /// type. If an alarm name is not specified, the histories for either all metric alarms
    /// or all composite alarms are returned. <para> CloudWatch retains the history of an
    /// alarm even if you delete the alarm. </para> <para> To use this operation and return
    /// information about a composite alarm, you must be signed on with the <c>cloudwatch:DescribeAlarmHistory</c>
    /// permission that is scoped to <c>*</c>. You can't return information about composite
    /// alarms if your <c>cloudwatch:DescribeAlarmHistory</c> permission has a narrower scope.
    /// </para>
    /// </summary>
    public partial class DescribeAlarmHistoryRequest : AmazonCloudWatchRequest
    {
        /// <summary>
        /// Gets and sets the property AlarmContributorId. 
        /// <para>
        /// The unique identifier of a specific alarm contributor to filter the alarm history
        /// results.
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
        /// The name of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AlarmName { get; set; }

        /// <summary>
        /// Checks to see if the AlarmName property is set.
        /// </summary>
        internal bool IsSetAlarmName() => this.AlarmName != null;

        /// <summary>
        /// Gets and sets the property AlarmTypes. 
        /// <para>
        /// Use this parameter to specify whether you want the operation to return metric alarms,
        /// composite alarms, or log alarms. If you omit this parameter, only metric alarms are
        /// returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AlarmTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AlarmTypes property is set.
        /// </summary>
        internal bool IsSetAlarmTypes() => this.AlarmTypes != null && (this.AlarmTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The ending date to retrieve alarm history.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property HistoryItemType. 
        /// <para>
        /// The type of alarm histories to retrieve.
        /// </para>
        /// </summary>
        public HistoryItemType HistoryItemType { get; set; }

        /// <summary>
        /// Checks to see if the HistoryItemType property is set.
        /// </summary>
        internal bool IsSetHistoryItemType() => this.HistoryItemType != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of alarm history records to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call to indicate that there is more data available.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ScanBy. 
        /// <para>
        /// Specified whether to return the newest or oldest alarm history first. Specify <c>TimestampDescending</c>
        /// to have the newest event history returned first, and specify <c>TimestampAscending</c>
        /// to have the oldest history returned first.
        /// </para>
        /// </summary>
        public ScanBy ScanBy { get; set; }

        /// <summary>
        /// Checks to see if the ScanBy property is set.
        /// </summary>
        internal bool IsSetScanBy() => this.ScanBy != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The starting date to retrieve alarm history.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;
    }
}
