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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the EnableStageTransition operation. Enables artifacts
    /// in a pipeline to transition to a stage in a pipeline.
    /// </summary>
    public partial class EnableStageTransitionRequest : AmazonCodePipelineRequest
    {
        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline in which you want to enable the flow of artifacts from one
        /// stage to another.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage where you want to enable the transition of artifacts, either
        /// into the stage (inbound) or from that stage to the next stage (outbound).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string StageName { get; set; }

        /// <summary>
        /// Checks to see if the StageName property is set.
        /// </summary>
        internal bool IsSetStageName() => this.StageName != null;

        /// <summary>
        /// Gets and sets the property TransitionType. 
        /// <para>
        /// Specifies whether artifacts are allowed to enter the stage and be processed by the
        /// actions in that stage (inbound) or whether already processed artifacts are allowed
        /// to transition to the next stage (outbound).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StageTransitionType TransitionType { get; set; }

        /// <summary>
        /// Checks to see if the TransitionType property is set.
        /// </summary>
        internal bool IsSetTransitionType() => this.TransitionType != null;
    }
}
