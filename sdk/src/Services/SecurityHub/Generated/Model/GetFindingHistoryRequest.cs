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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the GetFindingHistory operation.
    /// Returns history for a Security Hub finding in the last 90 days. The history includes
    /// changes made to any fields in the Amazon Web Services Security Finding Format (ASFF).
    /// </summary>
    public partial class GetFindingHistoryRequest : AmazonSecurityHubRequest
    {
        private DateTime? _endTime;
        private AwsSecurityFindingIdentifier _findingIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  An ISO 8601-formatted timestamp that indicates the end time of the requested finding
        /// history. A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The
        /// value cannot contain spaces, and date and time should be separated by <code>T</code>.
        /// For more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        ///  
        /// <para>
        /// If you provide values for both <code>StartTime</code> and <code>EndTime</code>, Security
        /// Hub returns finding history for the specified time period. If you provide a value
        /// for <code>StartTime</code> but not for <code>EndTime</code>, Security Hub returns
        /// finding history from the <code>StartTime</code> to the time at which the API is called.
        /// If you provide a value for <code>EndTime</code> but not for <code>StartTime</code>,
        /// Security Hub returns finding history from the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_AwsSecurityFindingFilters.html#securityhub-Type-AwsSecurityFindingFilters-CreatedAt">CreatedAt</a>
        /// timestamp of the finding to the <code>EndTime</code>. If you provide neither <code>StartTime</code>
        /// nor <code>EndTime</code>, Security Hub returns finding history from the CreatedAt
        /// timestamp of the finding to the time at which the API is called. In all of these scenarios,
        /// the response is limited to 100 results, and the maximum time period is limited to
        /// 90 days.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FindingIdentifier.
        /// </summary>
        [AWSProperty(Required=true)]
        public AwsSecurityFindingIdentifier FindingIdentifier
        {
            get { return this._findingIdentifier; }
            set { this._findingIdentifier = value; }
        }

        // Check to see if FindingIdentifier property is set
        internal bool IsSetFindingIdentifier()
        {
            return this._findingIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to be returned. If you don’t provide it, Security Hub
        /// returns up to 100 results of finding history. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A token for pagination purposes. Provide <code>NULL</code> as the initial value.
        /// In subsequent requests, provide the token included in the response to get up to an
        /// additional 100 results of finding history. If you don’t provide <code>NextToken</code>,
        /// Security Hub returns up to 100 results of finding history for each request. 
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
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  An ISO 8601-formatted timestamp that indicates the start time of the requested finding
        /// history. A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The
        /// value cannot contain spaces, and date and time should be separated by <code>T</code>.
        /// For more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>.
        /// </para>
        ///  
        /// <para>
        /// If you provide values for both <code>StartTime</code> and <code>EndTime</code>, Security
        /// Hub returns finding history for the specified time period. If you provide a value
        /// for <code>StartTime</code> but not for <code>EndTime</code>, Security Hub returns
        /// finding history from the <code>StartTime</code> to the time at which the API is called.
        /// If you provide a value for <code>EndTime</code> but not for <code>StartTime</code>,
        /// Security Hub returns finding history from the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_AwsSecurityFindingFilters.html#securityhub-Type-AwsSecurityFindingFilters-CreatedAt">CreatedAt</a>
        /// timestamp of the finding to the <code>EndTime</code>. If you provide neither <code>StartTime</code>
        /// nor <code>EndTime</code>, Security Hub returns finding history from the CreatedAt
        /// timestamp of the finding to the time at which the API is called. In all of these scenarios,
        /// the response is limited to 100 results, and the maximum time period is limited to
        /// 90 days. 
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}