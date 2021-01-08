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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// This is the response object from the ListProblems operation.
    /// </summary>
    public partial class ListProblemsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Problem> _problemList = new List<Problem>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ProblemList. 
        /// <para>
        /// The list of problems. 
        /// </para>
        /// </summary>
        public List<Problem> ProblemList
        {
            get { return this._problemList; }
            set { this._problemList = value; }
        }

        // Check to see if ProblemList property is set
        internal bool IsSetProblemList()
        {
            return this._problemList != null && this._problemList.Count > 0; 
        }

    }
}