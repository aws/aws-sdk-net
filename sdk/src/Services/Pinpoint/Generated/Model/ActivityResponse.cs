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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
        private string _applicationId;
        private string _campaignId;
        private string _end;
        private Dictionary<string, string> _executionMetrics = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _id;
        private string _result;
        private string _scheduledStart;
        private string _start;
        private string _state;
        private int? _successfulEndpointCount;
        private int? _timezonesCompletedCount;
        private int? _timezonesTotalCount;
        private int? _totalEndpointCount;
        private string _treatmentId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the campaign applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CampaignId. 
        /// <para>
        /// The unique identifier for the campaign that the activity applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CampaignId
        {
            get { return this._campaignId; }
            set { this._campaignId = value; }
        }

        // Check to see if CampaignId property is set
        internal bool IsSetCampaignId()
        {
            return this._campaignId != null;
        }

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The actual time, in ISO 8601 format, when the activity was marked CANCELLED or COMPLETED.
        /// </para>
        /// </summary>
        public string End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionMetrics. 
        /// <para>
        /// A JSON object that contains metrics relating to the campaign execution for this campaign
        /// activity. For information about the structure and contents of the results, see <a
        /// href="https://docs.aws.amazon.com//pinpoint/latest/developerguide/analytics-standard-metrics.html">Standard
        /// Amazon Pinpoint analytics metrics</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ExecutionMetrics
        {
            get { return this._executionMetrics; }
            set { this._executionMetrics = value; }
        }

        // Check to see if ExecutionMetrics property is set
        internal bool IsSetExecutionMetrics()
        {
            return this._executionMetrics != null && (this._executionMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// Specifies whether the activity succeeded. Possible values are SUCCESS and FAIL.
        /// </para>
        /// </summary>
        public string Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledStart. 
        /// <para>
        /// The scheduled start time, in ISO 8601 format, for the activity.
        /// </para>
        /// </summary>
        public string ScheduledStart
        {
            get { return this._scheduledStart; }
            set { this._scheduledStart = value; }
        }

        // Check to see if ScheduledStart property is set
        internal bool IsSetScheduledStart()
        {
            return this._scheduledStart != null;
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The actual start time, in ISO 8601 format, of the activity.
        /// </para>
        /// </summary>
        public string Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current status of the activity. Possible values are: PENDING, INITIALIZING, RUNNING,
        /// PAUSED, CANCELLED, and COMPLETED.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessfulEndpointCount. 
        /// <para>
        /// The total number of endpoints that the campaign successfully delivered messages to.
        /// </para>
        /// </summary>
        public int? SuccessfulEndpointCount
        {
            get { return this._successfulEndpointCount; }
            set { this._successfulEndpointCount = value; }
        }

        // Check to see if SuccessfulEndpointCount property is set
        internal bool IsSetSuccessfulEndpointCount()
        {
            return this._successfulEndpointCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimezonesCompletedCount. 
        /// <para>
        /// The total number of time zones that were completed.
        /// </para>
        /// </summary>
        public int? TimezonesCompletedCount
        {
            get { return this._timezonesCompletedCount; }
            set { this._timezonesCompletedCount = value; }
        }

        // Check to see if TimezonesCompletedCount property is set
        internal bool IsSetTimezonesCompletedCount()
        {
            return this._timezonesCompletedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimezonesTotalCount. 
        /// <para>
        /// The total number of unique time zones that are in the segment for the campaign.
        /// </para>
        /// </summary>
        public int? TimezonesTotalCount
        {
            get { return this._timezonesTotalCount; }
            set { this._timezonesTotalCount = value; }
        }

        // Check to see if TimezonesTotalCount property is set
        internal bool IsSetTimezonesTotalCount()
        {
            return this._timezonesTotalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalEndpointCount. 
        /// <para>
        /// The total number of endpoints that the campaign attempted to deliver messages to.
        /// </para>
        /// </summary>
        public int? TotalEndpointCount
        {
            get { return this._totalEndpointCount; }
            set { this._totalEndpointCount = value; }
        }

        // Check to see if TotalEndpointCount property is set
        internal bool IsSetTotalEndpointCount()
        {
            return this._totalEndpointCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TreatmentId. 
        /// <para>
        /// The unique identifier for the campaign treatment that the activity applies to. A treatment
        /// is a variation of a campaign that's used for A/B testing of a campaign.
        /// </para>
        /// </summary>
        public string TreatmentId
        {
            get { return this._treatmentId; }
            set { this._treatmentId = value; }
        }

        // Check to see if TreatmentId property is set
        internal bool IsSetTreatmentId()
        {
            return this._treatmentId != null;
        }

    }
}