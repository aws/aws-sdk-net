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
    /// This is the response object from the ListAnomaliesForInsight operation.
    /// </summary>
    public partial class ListAnomaliesForInsightResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProactiveAnomalySummary> _proactiveAnomalies = new List<ProactiveAnomalySummary>();
        private List<ReactiveAnomalySummary> _reactiveAnomalies = new List<ReactiveAnomalySummary>();

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
        /// Gets and sets the property ProactiveAnomalies. 
        /// <para>
        ///  An array of <code>ProactiveAnomalySummary</code> objects that represent the requested
        /// anomalies 
        /// </para>
        /// </summary>
        public List<ProactiveAnomalySummary> ProactiveAnomalies
        {
            get { return this._proactiveAnomalies; }
            set { this._proactiveAnomalies = value; }
        }

        // Check to see if ProactiveAnomalies property is set
        internal bool IsSetProactiveAnomalies()
        {
            return this._proactiveAnomalies != null && this._proactiveAnomalies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReactiveAnomalies. 
        /// <para>
        ///  An array of <code>ReactiveAnomalySummary</code> objects that represent the requested
        /// anomalies 
        /// </para>
        /// </summary>
        public List<ReactiveAnomalySummary> ReactiveAnomalies
        {
            get { return this._reactiveAnomalies; }
            set { this._reactiveAnomalies = value; }
        }

        // Check to see if ReactiveAnomalies property is set
        internal bool IsSetReactiveAnomalies()
        {
            return this._reactiveAnomalies != null && this._reactiveAnomalies.Count > 0; 
        }

    }
}