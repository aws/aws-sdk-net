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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// This is the response object from the GetLambdaFunctionRecommendations operation.
    /// </summary>
    public partial class GetLambdaFunctionRecommendationsResponse : AmazonWebServiceResponse
    {
        private List<LambdaFunctionRecommendation> _lambdaFunctionRecommendations = new List<LambdaFunctionRecommendation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LambdaFunctionRecommendations. 
        /// <para>
        /// An array of objects that describe function recommendations.
        /// </para>
        /// </summary>
        public List<LambdaFunctionRecommendation> LambdaFunctionRecommendations
        {
            get { return this._lambdaFunctionRecommendations; }
            set { this._lambdaFunctionRecommendations = value; }
        }

        // Check to see if LambdaFunctionRecommendations property is set
        internal bool IsSetLambdaFunctionRecommendations()
        {
            return this._lambdaFunctionRecommendations != null && this._lambdaFunctionRecommendations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to advance to the next page of function recommendations.
        /// </para>
        ///  
        /// <para>
        /// This value is null when there are no more pages of function recommendations to return.
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