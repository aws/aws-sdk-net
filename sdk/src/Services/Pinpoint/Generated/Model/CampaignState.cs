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
    public partial class CampaignState
    {
        private CampaignStatus _campaignStatus;

        /// <summary>
        /// Gets and sets the property CampaignStatus. The status of the campaign, or the status
        /// of a treatment that belongs to an A/B test campaign.Valid values: SCHEDULED, EXECUTING,
        /// PENDING_NEXT_RUN, COMPLETED, PAUSED
        /// </summary>
        public CampaignStatus CampaignStatus
        {
            get { return this._campaignStatus; }
            set { this._campaignStatus = value; }
        }

        // Check to see if CampaignStatus property is set
        internal bool IsSetCampaignStatus()
        {
            return this._campaignStatus != null;
        }

    }
}