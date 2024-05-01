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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListDomainDeliverabilityCampaigns operation.
    /// Retrieve deliverability data for all the campaigns that used a specific domain to
    /// send email during a specified time range. This data is available for a domain only
    /// if you enabled the Deliverability dashboard for the domain.
    /// </summary>
    public partial class ListDomainDeliverabilityCampaignsRequest : AmazonSimpleEmailServiceV2Request
    {
        private DateTime? _endDate;
        private string _nextToken;
        private int? _pageSize;
        private DateTime? _startDate;
        private string _subscribedDomain;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The last day that you want to obtain deliverability data for. This value has to be
        /// less than or equal to 30 days after the value of the <c>StartDate</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that’s returned from a previous call to the <c>ListDomainDeliverabilityCampaigns</c>
        /// operation. This token indicates the position of a campaign in the list of campaigns.
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

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of results to include in response to a single call to the <c>ListDomainDeliverabilityCampaigns</c>
        /// operation. If the number of results is larger than the number that you specify in
        /// this parameter, the response includes a <c>NextToken</c> element, which you can use
        /// to obtain additional results.
        /// </para>
        /// </summary>
        public int? PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The first day that you want to obtain deliverability data for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubscribedDomain. 
        /// <para>
        /// The domain to obtain deliverability data for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscribedDomain
        {
            get { return this._subscribedDomain; }
            set { this._subscribedDomain = value; }
        }

        // Check to see if SubscribedDomain property is set
        internal bool IsSetSubscribedDomain()
        {
            return this._subscribedDomain != null;
        }

    }
}