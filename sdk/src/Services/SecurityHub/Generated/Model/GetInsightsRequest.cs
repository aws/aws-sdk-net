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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the GetInsights operation.
    /// Lists and describes insights that are specified by insight ARNs.
    /// </summary>
    public partial class GetInsightsRequest : AmazonSecurityHubRequest
    {
        private List<string> _insightArns = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InsightArns. 
        /// <para>
        /// The ARNS of the insights that you want to describe.
        /// </para>
        /// </summary>
        public List<string> InsightArns
        {
            get { return this._insightArns; }
            set { this._insightArns = value; }
        }

        // Check to see if InsightArns property is set
        internal bool IsSetInsightArns()
        {
            return this._insightArns != null && this._insightArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Indicates the maximum number of items that you want in the response.
        /// </para>
        /// </summary>
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
        /// Paginates results. Set the value of this parameter to NULL on your first call to the
        /// GetInsights operation. For subsequent calls to the operation, fill nextToken in the
        /// request with the value of nextToken from the previous response to continue listing
        /// data.
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