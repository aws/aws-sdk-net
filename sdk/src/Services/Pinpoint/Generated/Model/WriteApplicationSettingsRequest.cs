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
    /// Creating application setting request
    /// </summary>
    public partial class WriteApplicationSettingsRequest
    {
        private CampaignHook _campaignHook;
        private bool? _cloudWatchMetricsEnabled;
        private CampaignLimits _limits;
        private QuietTime _quietTime;

        /// <summary>
        /// Gets and sets the property CampaignHook. Default campaign hook information.
        /// </summary>
        public CampaignHook CampaignHook
        {
            get { return this._campaignHook; }
            set { this._campaignHook = value; }
        }

        // Check to see if CampaignHook property is set
        internal bool IsSetCampaignHook()
        {
            return this._campaignHook != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchMetricsEnabled. The CloudWatchMetrics settings
        /// for the app.
        /// </summary>
        public bool CloudWatchMetricsEnabled
        {
            get { return this._cloudWatchMetricsEnabled.GetValueOrDefault(); }
            set { this._cloudWatchMetricsEnabled = value; }
        }

        // Check to see if CloudWatchMetricsEnabled property is set
        internal bool IsSetCloudWatchMetricsEnabled()
        {
            return this._cloudWatchMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limits. The limits that apply to each campaign in the project
        /// by default. Campaigns can also have their own limits, which override the settings
        /// at the project level.
        /// </summary>
        public CampaignLimits Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }

        // Check to see if Limits property is set
        internal bool IsSetLimits()
        {
            return this._limits != null;
        }

        /// <summary>
        /// Gets and sets the property QuietTime. The default quiet time for the app. Campaigns
        /// in the app don't send messages to endpoints during the quiet time.Note: Make sure
        /// that your endpoints include the Demographics.Timezone attribute if you plan to enable
        /// a quiet time for your app. If your endpoints don't include this attribute, they'll
        /// receive the messages that you send them, even if quiet time is enabled.When you set
        /// up an app to use quiet time, campaigns in that app don't send messages during the
        /// time range you specified, as long as all of the following are true:- The endpoint
        /// includes a valid Demographic.Timezone attribute.- The current time in the endpoint's
        /// time zone is later than or equal to the time specified in the QuietTime.Start attribute
        /// for the app (or campaign, if applicable).- The current time in the endpoint's time
        /// zone is earlier than or equal to the time specified in the QuietTime.End attribute
        /// for the app (or campaign, if applicable).Individual campaigns within the app can have
        /// their own quiet time settings, which override the quiet time settings at the app level.
        /// </summary>
        public QuietTime QuietTime
        {
            get { return this._quietTime; }
            set { this._quietTime = value; }
        }

        // Check to see if QuietTime property is set
        internal bool IsSetQuietTime()
        {
            return this._quietTime != null;
        }

    }
}