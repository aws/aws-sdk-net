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
    /// Container for the parameters to the DisableStageTransition operation.
    /// Prevents artifacts in a pipeline from transitioning to the next stage in the pipeline.
    /// </summary>
    public partial class DisableStageTransitionRequest : AmazonCodePipelineRequest
    {
        private string _pipelineName;
        private string _reason;
        private string _stageName;
        private StageTransitionType _transitionType;

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline in which you want to disable the flow of artifacts from one
        /// stage to another.
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
        /// The reason given to the user that a stage is disabled, such as waiting for manual
        /// approval or manual tests. This message is displayed in the pipeline console UI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
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

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage where you want to disable the inbound or outbound transition
        /// of artifacts.
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

        /// <summary>
        /// Gets and sets the property TransitionType. 
        /// <para>
        /// Specifies whether artifacts are prevented from transitioning into the stage and being
        /// processed by the actions in that stage (inbound), or prevented from transitioning
        /// from the stage after they have been processed by the actions in that stage (outbound).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StageTransitionType TransitionType
        {
            get { return this._transitionType; }
            set { this._transitionType = value; }
        }

        // Check to see if TransitionType property is set
        internal bool IsSetTransitionType()
        {
            return this._transitionType != null;
        }

    }
}