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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ActivityResponse
    {
        private string _applicationId;
        private string _campaignId;
        private string _end;
        private string _id;
        private string _result;
        private string _scheduledStart;
        private string _start;
        private string _state;
        private int? _successfulEndpointCount;
        private int? _totalEndpointCount;
        private string _treatmentId;

        /// <summary>
        /// Gets and sets the property ApplicationId. The ID of the application to which the campaign
        /// applies.
        /// </summary>
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
        /// Gets and sets the property CampaignId. The ID of the campaign to which the activity
        /// applies.
        /// </summary>
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
        /// Gets and sets the property End. The actual time the activity was marked CANCELLED
        /// or COMPLETED. Provided in ISO 8601 format.
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
        /// Gets and sets the property Id. The unique activity ID.
        /// </summary>
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
        /// Gets and sets the property Result. Indicates whether the activity succeeded.Valid
        /// values: SUCCESS, FAIL
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
        /// Gets and sets the property ScheduledStart. The scheduled start time for the activity
        /// in ISO 8601 format.
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
        /// Gets and sets the property Start. The actual start time of the activity in ISO 8601
        /// format.
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
        /// Gets and sets the property State. The state of the activity.Valid values: PENDING,
        /// INITIALIZING, RUNNING, PAUSED, CANCELLED, COMPLETED
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
        /// Gets and sets the property SuccessfulEndpointCount. The total number of endpoints
        /// to which the campaign successfully delivered messages.
        /// </summary>
        public int SuccessfulEndpointCount
        {
            get { return this._successfulEndpointCount.GetValueOrDefault(); }
            set { this._successfulEndpointCount = value; }
        }

        // Check to see if SuccessfulEndpointCount property is set
        internal bool IsSetSuccessfulEndpointCount()
        {
            return this._successfulEndpointCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalEndpointCount. The total number of endpoints to which
        /// the campaign attempts to deliver messages.
        /// </summary>
        public int TotalEndpointCount
        {
            get { return this._totalEndpointCount.GetValueOrDefault(); }
            set { this._totalEndpointCount = value; }
        }

        // Check to see if TotalEndpointCount property is set
        internal bool IsSetTotalEndpointCount()
        {
            return this._totalEndpointCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TreatmentId. The ID of a variation of the campaign used
        /// for A/B testing.
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