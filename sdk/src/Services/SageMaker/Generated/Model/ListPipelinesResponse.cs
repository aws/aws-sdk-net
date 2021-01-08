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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the ListPipelines operation.
    /// </summary>
    public partial class ListPipelinesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PipelineSummary> _pipelineSummaries = new List<PipelineSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous <code>ListPipelines</code> request was truncated, the
        /// response includes a <code>NextToken</code>. To retrieve the next set of pipelines,
        /// use the token in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Gets and sets the property PipelineSummaries. 
        /// <para>
        /// Contains a sorted list of <code>PipelineSummary</code> objects matching the specified
        /// filters. Each <code>PipelineSummary</code> consists of PipelineArn, PipelineName,
        /// ExperimentName, PipelineDescription, CreationTime, LastModifiedTime, LastRunTime,
        /// and RoleArn. This list can be empty. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PipelineSummary> PipelineSummaries
        {
            get { return this._pipelineSummaries; }
            set { this._pipelineSummaries = value; }
        }

        // Check to see if PipelineSummaries property is set
        internal bool IsSetPipelineSummaries()
        {
            return this._pipelineSummaries != null && this._pipelineSummaries.Count > 0; 
        }

    }
}