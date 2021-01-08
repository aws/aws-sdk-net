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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the SearchInsights operation.
    /// </summary>
    public partial class SearchInsightsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProactiveInsightSummary> _proactiveInsights = new List<ProactiveInsightSummary>();
        private List<ReactiveInsightSummary> _reactiveInsights = new List<ReactiveInsightSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If there are no more pages, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property ProactiveInsights. 
        /// <para>
        ///  The returned proactive insights. 
        /// </para>
        /// </summary>
        public List<ProactiveInsightSummary> ProactiveInsights
        {
            get { return this._proactiveInsights; }
            set { this._proactiveInsights = value; }
        }

        // Check to see if ProactiveInsights property is set
        internal bool IsSetProactiveInsights()
        {
            return this._proactiveInsights != null && this._proactiveInsights.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReactiveInsights. 
        /// <para>
        ///  The returned reactive insights. 
        /// </para>
        /// </summary>
        public List<ReactiveInsightSummary> ReactiveInsights
        {
            get { return this._reactiveInsights; }
            set { this._reactiveInsights = value; }
        }

        // Check to see if ReactiveInsights property is set
        internal bool IsSetReactiveInsights()
        {
            return this._reactiveInsights != null && this._reactiveInsights.Count > 0; 
        }

    }
}