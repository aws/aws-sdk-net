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
    /// Targeted in-app message campaign.
    /// </summary>
    public partial class InAppMessageCampaign
    {
        private string _campaignId;
        private int? _dailyCap;
        private InAppMessage _inAppMessage;
        private int? _priority;
        private InAppCampaignSchedule _schedule;
        private int? _sessionCap;
        private int? _totalCap;
        private string _treatmentId;

        /// <summary>
        /// Gets and sets the property CampaignId. 
        /// <para>
        /// Campaign id of the corresponding campaign.
        /// </para>
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
        /// Gets and sets the property DailyCap. 
        /// <para>
        /// Daily cap which controls the number of times any in-app messages can be shown to the
        /// endpoint during a day.
        /// </para>
        /// </summary>
        public int? DailyCap
        {
            get { return this._dailyCap; }
            set { this._dailyCap = value; }
        }

        // Check to see if DailyCap property is set
        internal bool IsSetDailyCap()
        {
            return this._dailyCap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InAppMessage. 
        /// <para>
        /// In-app message content with all fields required for rendering an in-app message.
        /// </para>
        /// </summary>
        public InAppMessage InAppMessage
        {
            get { return this._inAppMessage; }
            set { this._inAppMessage = value; }
        }

        // Check to see if InAppMessage property is set
        internal bool IsSetInAppMessage()
        {
            return this._inAppMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Priority of the in-app message.
        /// </para>
        /// </summary>
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// Schedule of the campaign.
        /// </para>
        /// </summary>
        public InAppCampaignSchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property SessionCap. 
        /// <para>
        /// Session cap which controls the number of times an in-app message can be shown to the
        /// endpoint during an application session.
        /// </para>
        /// </summary>
        public int? SessionCap
        {
            get { return this._sessionCap; }
            set { this._sessionCap = value; }
        }

        // Check to see if SessionCap property is set
        internal bool IsSetSessionCap()
        {
            return this._sessionCap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCap. 
        /// <para>
        /// Total cap which controls the number of times an in-app message can be shown to the
        /// endpoint.
        /// </para>
        /// </summary>
        public int? TotalCap
        {
            get { return this._totalCap; }
            set { this._totalCap = value; }
        }

        // Check to see if TotalCap property is set
        internal bool IsSetTotalCap()
        {
            return this._totalCap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TreatmentId. 
        /// <para>
        /// Treatment id of the campaign.
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