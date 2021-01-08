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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the RetryStageExecution operation.
    /// Resumes the pipeline execution by retrying the last failed actions in a stage. You
    /// can retry a stage immediately if any of the actions in the stage fail. When you retry,
    /// all actions that are still in progress continue working, and failed actions are triggered
    /// again.
    /// </summary>
    public partial class RetryStageExecutionRequest : AmazonCodePipelineRequest
    {
        private string _pipelineExecutionId;
        private string _pipelineName;
        private StageRetryMode _retryMode;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The ID of the pipeline execution in the failed stage to be retried. Use the <a>GetPipelineState</a>
        /// action to retrieve the current pipelineExecutionId of the failed stage
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline that contains the failed stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property RetryMode. 
        /// <para>
        /// The scope of the retry attempt. Currently, the only supported value is FAILED_ACTIONS.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StageRetryMode RetryMode
        {
            get { return this._retryMode; }
            set { this._retryMode = value; }
        }

        // Check to see if RetryMode property is set
        internal bool IsSetRetryMode()
        {
            return this._retryMode != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the failed stage to be retried.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

    }
}