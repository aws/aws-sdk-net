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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Filter values for the action execution.
    /// </summary>
    public partial class ActionExecutionFilter
    {
        private LatestInPipelineExecutionFilter _latestInPipelineExecution;
        private string _pipelineExecutionId;

        /// <summary>
        /// Gets and sets the property LatestInPipelineExecution. 
        /// <para>
        /// The latest execution in the pipeline.
        /// </para>
        ///  <note> 
        /// <para>
        /// Filtering on the latest execution is available for executions run on or after February
        /// 08, 2024.
        /// </para>
        ///  </note>
        /// </summary>
        public LatestInPipelineExecutionFilter LatestInPipelineExecution
        {
            get { return this._latestInPipelineExecution; }
            set { this._latestInPipelineExecution = value; }
        }

        // Check to see if LatestInPipelineExecution property is set
        internal bool IsSetLatestInPipelineExecution()
        {
            return this._latestInPipelineExecution != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The pipeline execution ID used to filter action execution history.
        /// </para>
        /// </summary>
        public string PipelineExecutionId
        {
            get { return this._pipelineExecutionId; }
            set { this._pipelineExecutionId = value; }
        }

        // Check to see if PipelineExecutionId property is set
        internal bool IsSetPipelineExecutionId()
        {
            return this._pipelineExecutionId != null;
        }

    }
}