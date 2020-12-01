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
    /// This is the response object from the ListPipelineExecutionSteps operation.
    /// </summary>
    public partial class ListPipelineExecutionStepsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PipelineExecutionStep> _pipelineExecutionSteps = new List<PipelineExecutionStep>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous <code>ListPipelineExecutionSteps</code> request was
        /// truncated, the response includes a <code>NextToken</code>. To retrieve the next set
        /// of pipeline execution steps, use the token in the next request.
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
        /// Gets and sets the property PipelineExecutionSteps. 
        /// <para>
        /// A list of <code>PipeLineExecutionStep</code> objects. Each <code>PipeLineExecutionStep</code>
        /// consists of StepName, StartTime, EndTime, StepStatus, and Metadata. Metadata is an
        /// object with properties for each job that contains relevant information about the job
        /// created by the step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PipelineExecutionStep> PipelineExecutionSteps
        {
            get { return this._pipelineExecutionSteps; }
            set { this._pipelineExecutionSteps = value; }
        }

        // Check to see if PipelineExecutionSteps property is set
        internal bool IsSetPipelineExecutionSteps()
        {
            return this._pipelineExecutionSteps != null && this._pipelineExecutionSteps.Count > 0; 
        }

    }
}