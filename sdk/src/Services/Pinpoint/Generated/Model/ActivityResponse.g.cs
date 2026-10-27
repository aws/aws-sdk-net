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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about an activity that was performed by a campaign.
    /// </summary>
    public partial class ActivityResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the campaign applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property CampaignId. 
        /// <para>
        /// The unique identifier for the campaign that the activity applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignId property is set.
        /// </summary>
        internal bool IsSetCampaignId() => this.CampaignId != null;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The actual time, in ISO 8601 format, when the activity was marked CANCELLED or COMPLETED.
        /// </para>
        /// </summary>
        public string End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End != null;

        /// <summary>
        /// Gets and sets the property ExecutionMetrics. 
        /// <para>
        /// A JSON object that contains metrics relating to the campaign execution for this campaign
        /// activity. For information about the structure and contents of the results, see <a
        /// href="https://docs.aws.amazon.com//pinpoint/latest/developerguide/analytics-standard-metrics.html">Standard
        /// Amazon Pinpoint analytics metrics</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ExecutionMetrics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ExecutionMetrics property is set.
        /// </summary>
        internal bool IsSetExecutionMetrics() => this.ExecutionMetrics != null && (this.ExecutionMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// Specifies whether the activity succeeded. Possible values are SUCCESS and FAIL.
        /// </para>
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property ScheduledStart. 
        /// <para>
        /// The scheduled start time, in ISO 8601 format, for the activity.
        /// </para>
        /// </summary>
        public string ScheduledStart { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledStart property is set.
        /// </summary>
        internal bool IsSetScheduledStart() => this.ScheduledStart != null;

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The actual start time, in ISO 8601 format, of the activity.
        /// </para>
        /// </summary>
        public string Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current status of the activity. Possible values are: PENDING, INITIALIZING, RUNNING,
        /// PAUSED, CANCELLED, and COMPLETED.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SuccessfulEndpointCount. 
        /// <para>
        /// The total number of endpoints that the campaign successfully delivered messages to.
        /// </para>
        /// </summary>
        public int? SuccessfulEndpointCount { get; set; }

        /// <summary>
        /// Checks to see if the SuccessfulEndpointCount property is set.
        /// </summary>
        internal bool IsSetSuccessfulEndpointCount() => this.SuccessfulEndpointCount.HasValue;

        /// <summary>
        /// Gets and sets the property TimezonesCompletedCount. 
        /// <para>
        /// The total number of time zones that were completed.
        /// </para>
        /// </summary>
        public int? TimezonesCompletedCount { get; set; }

        /// <summary>
        /// Checks to see if the TimezonesCompletedCount property is set.
        /// </summary>
        internal bool IsSetTimezonesCompletedCount() => this.TimezonesCompletedCount.HasValue;

        /// <summary>
        /// Gets and sets the property TimezonesTotalCount. 
        /// <para>
        /// The total number of unique time zones that are in the segment for the campaign.
        /// </para>
        /// </summary>
        public int? TimezonesTotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TimezonesTotalCount property is set.
        /// </summary>
        internal bool IsSetTimezonesTotalCount() => this.TimezonesTotalCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalEndpointCount. 
        /// <para>
        /// The total number of endpoints that the campaign attempted to deliver messages to.
        /// </para>
        /// </summary>
        public int? TotalEndpointCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalEndpointCount property is set.
        /// </summary>
        internal bool IsSetTotalEndpointCount() => this.TotalEndpointCount.HasValue;

        /// <summary>
        /// Gets and sets the property TreatmentId. 
        /// <para>
        /// The unique identifier for the campaign treatment that the activity applies to. A treatment
        /// is a variation of a campaign that's used for A/B testing of a campaign.
        /// </para>
        /// </summary>
        public string TreatmentId { get; set; }

        /// <summary>
        /// Checks to see if the TreatmentId property is set.
        /// </summary>
        internal bool IsSetTreatmentId() => this.TreatmentId != null;
    }
}
