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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents the output of a ListPipelineExecutions action.
    /// </summary>
    public partial class ListPipelineExecutionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PipelineExecutionSummary> _pipelineExecutionSummaries = new List<PipelineExecutionSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that can be used in the next ListPipelineExecutions call. To view all items
        /// in the list, continue to call this operation with each subsequent token until no more
        /// nextToken values are returned.
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

        /// <summary>
        /// Gets and sets the property PipelineExecutionSummaries. 
        /// <para>
        /// A list of executions in the history of a pipeline.
        /// </para>
        /// </summary>
        public List<PipelineExecutionSummary> PipelineExecutionSummaries
        {
            get { return this._pipelineExecutionSummaries; }
            set { this._pipelineExecutionSummaries = value; }
        }

        // Check to see if PipelineExecutionSummaries property is set
        internal bool IsSetPipelineExecutionSummaries()
        {
            return this._pipelineExecutionSummaries != null && this._pipelineExecutionSummaries.Count > 0; 
        }

    }
}