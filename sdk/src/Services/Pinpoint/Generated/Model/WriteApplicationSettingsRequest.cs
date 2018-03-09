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
        /// Gets and sets the property Limits. The default campaign limits for the app. These
        /// limits apply to each campaign for the app, unless the campaign overrides the default
        /// with limits of its own.
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
        /// Gets and sets the property QuietTime. The default quiet time for the app. Each campaign
        /// for this app sends no messages during this time unless the campaign overrides the
        /// default with a quiet time of its own.
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