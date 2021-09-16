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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Get in-app messages response object.
    /// </summary>
    public partial class InAppMessagesResponse
    {
        private List<InAppMessageCampaign> _inAppMessageCampaigns = new List<InAppMessageCampaign>();

        /// <summary>
        /// Gets and sets the property InAppMessageCampaigns. 
        /// <para>
        /// List of targeted in-app message campaigns.
        /// </para>
        /// </summary>
        public List<InAppMessageCampaign> InAppMessageCampaigns
        {
            get { return this._inAppMessageCampaigns; }
            set { this._inAppMessageCampaigns = value; }
        }

        // Check to see if InAppMessageCampaigns property is set
        internal bool IsSetInAppMessageCampaigns()
        {
            return this._inAppMessageCampaigns != null && this._inAppMessageCampaigns.Count > 0; 
        }

    }
}