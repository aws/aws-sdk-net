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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the ListOptimizationJobs operation.
    /// </summary>
    public partial class ListOptimizationJobsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<OptimizationJobSummary> _optimizationJobSummaries = AWSConfigs.InitializeCollections ? new List<OptimizationJobSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use in a subsequent request to get the next set of results following
        /// a truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// Gets and sets the property OptimizationJobSummaries. 
        /// <para>
        /// A list of optimization jobs and their properties that matches any of the filters you
        /// specified in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<OptimizationJobSummary> OptimizationJobSummaries
        {
            get { return this._optimizationJobSummaries; }
            set { this._optimizationJobSummaries = value; }
        }

        // Check to see if OptimizationJobSummaries property is set
        internal bool IsSetOptimizationJobSummaries()
        {
            return this._optimizationJobSummaries != null && (this._optimizationJobSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}