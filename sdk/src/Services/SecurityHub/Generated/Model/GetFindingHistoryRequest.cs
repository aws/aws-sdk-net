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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the GetFindingHistory operation.
    /// Returns the history of a Security Hub finding. The history includes changes made
    /// to any fields in the Amazon Web Services Security Finding Format (ASFF) except top-level
    /// timestamp fields, such as the <c>CreatedAt</c> and <c>UpdatedAt</c> fields. 
    /// 
    ///  
    /// <para>
    /// This operation might return fewer results than the maximum number of results (<c>MaxResults</c>)
    /// specified in a request, even when more results are available. If this occurs, the
    /// response includes a <c>NextToken</c> value, which you should use to retrieve the next
    /// set of results in the response. The presence of a <c>NextToken</c> value in a response
    /// doesn't necessarily indicate that the results are incomplete. However, you should
    /// continue to specify a <c>NextToken</c> value until you receive a response that doesn't
    /// include this value.
    /// </para>
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
        /// history.
        /// </para>
        ///  
        /// <para>
        /// If you provide values for both <c>StartTime</c> and <c>EndTime</c>, Security Hub returns
        /// finding history for the specified time period. If you provide a value for <c>StartTime</c>
        /// but not for <c>EndTime</c>, Security Hub returns finding history from the <c>StartTime</c>
        /// to the time at which the API is called. If you provide a value for <c>EndTime</c>
        /// but not for <c>StartTime</c>, Security Hub returns finding history from the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_AwsSecurityFindingFilters.html#securityhub-Type-AwsSecurityFindingFilters-CreatedAt">CreatedAt</a>
        /// timestamp of the finding to the <c>EndTime</c>. If you provide neither <c>StartTime</c>
        /// nor <c>EndTime</c>, Security Hub returns finding history from the <c>CreatedAt</c>
        /// timestamp of the finding to the time at which the API is called. In all of these scenarios,
        /// the response is limited to 100 results.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
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
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        ///  A token for pagination purposes. Provide <c>NULL</c> as the initial value. In subsequent
        /// requests, provide the token included in the response to get up to an additional 100
        /// results of finding history. If you don’t provide <c>NextToken</c>, Security Hub returns
        /// up to 100 results of finding history for each request. 
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
        /// A timestamp that indicates the start time of the requested finding history.
        /// </para>
        ///  
        /// <para>
        /// If you provide values for both <c>StartTime</c> and <c>EndTime</c>, Security Hub returns
        /// finding history for the specified time period. If you provide a value for <c>StartTime</c>
        /// but not for <c>EndTime</c>, Security Hub returns finding history from the <c>StartTime</c>
        /// to the time at which the API is called. If you provide a value for <c>EndTime</c>
        /// but not for <c>StartTime</c>, Security Hub returns finding history from the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_AwsSecurityFindingFilters.html#securityhub-Type-AwsSecurityFindingFilters-CreatedAt">CreatedAt</a>
        /// timestamp of the finding to the <c>EndTime</c>. If you provide neither <c>StartTime</c>
        /// nor <c>EndTime</c>, Security Hub returns finding history from the <c>CreatedAt</c>
        /// timestamp of the finding to the time at which the API is called. In all of these scenarios,
        /// the response is limited to 100 results.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}