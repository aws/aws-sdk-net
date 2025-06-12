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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the GetConformancePackComplianceDetails operation.
    /// </summary>
    public partial class GetConformancePackComplianceDetailsResponse : AmazonWebServiceResponse
    {
        private string _conformancePackName;
        private List<ConformancePackEvaluationResult> _conformancePackRuleEvaluationResults = AWSConfigs.InitializeCollections ? new List<ConformancePackEvaluationResult>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// Name of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConformancePackName
        {
            get { return this._conformancePackName; }
            set { this._conformancePackName = value; }
        }

        // Check to see if ConformancePackName property is set
        internal bool IsSetConformancePackName()
        {
            return this._conformancePackName != null;
        }

        /// <summary>
        /// Gets and sets the property ConformancePackRuleEvaluationResults. 
        /// <para>
        /// Returns a list of <c>ConformancePackEvaluationResult</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ConformancePackEvaluationResult> ConformancePackRuleEvaluationResults
        {
            get { return this._conformancePackRuleEvaluationResults; }
            set { this._conformancePackRuleEvaluationResults = value; }
        }

        // Check to see if ConformancePackRuleEvaluationResults property is set
        internal bool IsSetConformancePackRuleEvaluationResults()
        {
            return this._conformancePackRuleEvaluationResults != null && (this._conformancePackRuleEvaluationResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned in a previous request that you use to request
        /// the next page of results in a paginated response.
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