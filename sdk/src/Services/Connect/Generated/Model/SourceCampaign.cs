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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the campaign.
    /// </summary>
    public partial class SourceCampaign
    {
        private string _campaignId;
        private string _outboundRequestId;

        /// <summary>
        /// Gets and sets the property CampaignId. 
        /// <para>
        /// A unique identifier for a campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property OutboundRequestId. 
        /// <para>
        /// A unique identifier for a each request part of same campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string OutboundRequestId
        {
            get { return this._outboundRequestId; }
            set { this._outboundRequestId = value; }
        }

        // Check to see if OutboundRequestId property is set
        internal bool IsSetOutboundRequestId()
        {
            return this._outboundRequestId != null;
        }

    }
}