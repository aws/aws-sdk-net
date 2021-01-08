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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This is the response object from the DescribeInsightRules operation.
    /// </summary>
    public partial class DescribeInsightRulesResponse : AmazonWebServiceResponse
    {
        private List<InsightRule> _insightRules = new List<InsightRule>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InsightRules. 
        /// <para>
        /// The rules returned by the operation.
        /// </para>
        /// </summary>
        public List<InsightRule> InsightRules
        {
            get { return this._insightRules; }
            set { this._insightRules = value; }
        }

        // Check to see if InsightRules property is set
        internal bool IsSetInsightRules()
        {
            return this._insightRules != null && this._insightRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If this parameter is present, it is a token that marks the start of the next batch
        /// of returned results. 
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