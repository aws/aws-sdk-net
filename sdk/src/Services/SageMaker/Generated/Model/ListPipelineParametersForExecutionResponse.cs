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
    /// This is the response object from the ListPipelineParametersForExecution operation.
    /// </summary>
    public partial class ListPipelineParametersForExecutionResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Parameter> _pipelineParameters = new List<Parameter>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous <code>ListPipelineParametersForExecution</code> request
        /// was truncated, the response includes a <code>NextToken</code>. To retrieve the next
        /// set of parameters, use the token in the next request.
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
        /// Gets and sets the property PipelineParameters. 
        /// <para>
        /// Contains a list of pipeline parameters. This list can be empty. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Parameter> PipelineParameters
        {
            get { return this._pipelineParameters; }
            set { this._pipelineParameters = value; }
        }

        // Check to see if PipelineParameters property is set
        internal bool IsSetPipelineParameters()
        {
            return this._pipelineParameters != null && this._pipelineParameters.Count > 0; 
        }

    }
}