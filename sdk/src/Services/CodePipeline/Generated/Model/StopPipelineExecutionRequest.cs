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
    /// Container for the parameters to the StopPipelineExecution operation.
    /// Stops the specified pipeline execution. You choose to either stop the pipeline execution
    /// by completing in-progress actions without starting subsequent actions, or by abandoning
    /// in-progress actions. While completing or abandoning in-progress actions, the pipeline
    /// execution is in a <c>Stopping</c> state. After all in-progress actions are completed
    /// or abandoned, the pipeline execution is in a <c>Stopped</c> state.
    /// </summary>
    public partial class StopPipelineExecutionRequest : AmazonCodePipelineRequest
    {
        private bool? _abandon;
        private string _pipelineExecutionId;
        private string _pipelineName;
        private string _reason;

        /// <summary>
        /// Gets and sets the property Abandon. 
        /// <para>
        /// Use this option to stop the pipeline execution by abandoning, rather than finishing,
        /// in-progress actions.
        /// </para>
        ///  <note> 
        /// <para>
        /// This option can lead to failed or out-of-sequence tasks.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Abandon
        {
            get { return this._abandon; }
            set { this._abandon = value; }
        }

        // Check to see if Abandon property is set
        internal bool IsSetAbandon()
        {
            return this._abandon.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The ID of the pipeline execution to be stopped in the current stage. Use the <c>GetPipelineState</c>
        /// action to retrieve the current pipelineExecutionId.
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
        /// The name of the pipeline to stop.
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// Use this option to enter comments, such as the reason the pipeline was stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}