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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the ListExplainabilities operation.
    /// </summary>
    public partial class ListExplainabilitiesResponse : AmazonWebServiceResponse
    {
        private List<ExplainabilitySummary> _explainabilities = new List<ExplainabilitySummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Explainabilities. 
        /// <para>
        /// An array of objects that summarize the properties of each Explainability resource.
        /// </para>
        /// </summary>
        public List<ExplainabilitySummary> Explainabilities
        {
            get { return this._explainabilities; }
            set { this._explainabilities = value; }
        }

        // Check to see if Explainabilities property is set
        internal bool IsSetExplainabilities()
        {
            return this._explainabilities != null && this._explainabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Returns this token if the response is truncated. To retrieve the next set of results,
        /// use the token in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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