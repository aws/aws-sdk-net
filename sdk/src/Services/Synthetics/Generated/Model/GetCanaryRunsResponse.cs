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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This is the response object from the GetCanaryRuns operation.
    /// </summary>
    public partial class GetCanaryRunsResponse : AmazonWebServiceResponse
    {
        private List<CanaryRun> _canaryRuns = new List<CanaryRun>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CanaryRuns. 
        /// <para>
        /// An array of structures. Each structure contains the details of one of the retrieved
        /// canary runs.
        /// </para>
        /// </summary>
        public List<CanaryRun> CanaryRuns
        {
            get { return this._canaryRuns; }
            set { this._canaryRuns = value; }
        }

        // Check to see if CanaryRuns property is set
        internal bool IsSetCanaryRuns()
        {
            return this._canaryRuns != null && this._canaryRuns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there is more data available. You can use this token in
        /// a subsequent <code>GetCanaryRuns</code> operation to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=252)]
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