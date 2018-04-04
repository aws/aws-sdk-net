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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the GetAggregateComplianceDetailsByConfigRule operation.
    /// </summary>
    public partial class GetAggregateComplianceDetailsByConfigRuleResponse : AmazonWebServiceResponse
    {
        private List<AggregateEvaluationResult> _aggregateEvaluationResults = new List<AggregateEvaluationResult>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AggregateEvaluationResults. 
        /// <para>
        /// Returns an AggregateEvaluationResults object.
        /// </para>
        /// </summary>
        public List<AggregateEvaluationResult> AggregateEvaluationResults
        {
            get { return this._aggregateEvaluationResults; }
            set { this._aggregateEvaluationResults = value; }
        }

        // Check to see if AggregateEvaluationResults property is set
        internal bool IsSetAggregateEvaluationResults()
        {
            return this._aggregateEvaluationResults != null && this._aggregateEvaluationResults.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The nextToken string returned on a previous page that you use to get the next page
        /// of results in a paginated response.
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