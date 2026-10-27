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
    /// Targeted in-app message campaign.
    /// </summary>
    public partial class InAppMessageCampaign
    {
        /// <summary>
        /// Gets and sets the property CampaignId. 
        /// <para>
        /// Campaign id of the corresponding campaign.
        /// </para>
        /// </summary>
        public string CampaignId { get; set; }

        /// <summary>
        /// Checks to see if the CampaignId property is set.
        /// </summary>
        internal bool IsSetCampaignId() => this.CampaignId != null;

        /// <summary>
        /// Gets and sets the property DailyCap. 
        /// <para>
        /// Daily cap which controls the number of times any in-app messages can be shown to the
        /// endpoint during a day.
        /// </para>
        /// </summary>
        public int? DailyCap { get; set; }

        /// <summary>
        /// Checks to see if the DailyCap property is set.
        /// </summary>
        internal bool IsSetDailyCap() => this.DailyCap.HasValue;

        /// <summary>
        /// Gets and sets the property InAppMessage. 
        /// <para>
        /// In-app message content with all fields required for rendering an in-app message.
        /// </para>
        /// </summary>
        public InAppMessage InAppMessage { get; set; }

        /// <summary>
        /// Checks to see if the InAppMessage property is set.
        /// </summary>
        internal bool IsSetInAppMessage() => this.InAppMessage != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Priority of the in-app message.
        /// </para>
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// Schedule of the campaign.
        /// </para>
        /// </summary>
        public InAppCampaignSchedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property SessionCap. 
        /// <para>
        /// Session cap which controls the number of times an in-app message can be shown to the
        /// endpoint during an application session.
        /// </para>
        /// </summary>
        public int? SessionCap { get; set; }

        /// <summary>
        /// Checks to see if the SessionCap property is set.
        /// </summary>
        internal bool IsSetSessionCap() => this.SessionCap.HasValue;

        /// <summary>
        /// Gets and sets the property TotalCap. 
        /// <para>
        /// Total cap which controls the number of times an in-app message can be shown to the
        /// endpoint.
        /// </para>
        /// </summary>
        public int? TotalCap { get; set; }

        /// <summary>
        /// Checks to see if the TotalCap property is set.
        /// </summary>
        internal bool IsSetTotalCap() => this.TotalCap.HasValue;

        /// <summary>
        /// Gets and sets the property TreatmentId. 
        /// <para>
        /// Treatment id of the campaign.
        /// </para>
        /// </summary>
        public string TreatmentId { get; set; }

        /// <summary>
        /// Checks to see if the TreatmentId property is set.
        /// </summary>
        internal bool IsSetTreatmentId() => this.TreatmentId != null;
    }
}
