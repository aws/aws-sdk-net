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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An array of objects that provide deliverability data for all the campaigns that used
    /// a specific domain to send email during a specified time range. This data is available
    /// for a domain only if you enabled the Deliverability dashboard for the domain.
    /// </summary>
    public partial class ListDomainDeliverabilityCampaignsResponse : AmazonWebServiceResponse
    {
        private List<DomainDeliverabilityCampaign> _domainDeliverabilityCampaigns = new List<DomainDeliverabilityCampaign>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DomainDeliverabilityCampaigns. 
        /// <para>
        /// An array of responses, one for each campaign that used the domain to send email during
        /// the specified time range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DomainDeliverabilityCampaign> DomainDeliverabilityCampaigns
        {
            get { return this._domainDeliverabilityCampaigns; }
            set { this._domainDeliverabilityCampaigns = value; }
        }

        // Check to see if DomainDeliverabilityCampaigns property is set
        internal bool IsSetDomainDeliverabilityCampaigns()
        {
            return this._domainDeliverabilityCampaigns != null && this._domainDeliverabilityCampaigns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that’s returned from a previous call to the <code>ListDomainDeliverabilityCampaigns</code>
        /// operation. This token indicates the position of the campaign in the list of campaigns.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}