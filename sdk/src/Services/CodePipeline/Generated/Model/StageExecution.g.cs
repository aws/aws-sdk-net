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
    /// Represents information about the run of a stage.
    /// </summary>
    public partial class StageExecution
    {
        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The ID of the pipeline execution associated with the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PipelineExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineExecutionId property is set.
        /// </summary>
        internal bool IsSetPipelineExecutionId() => this.PipelineExecutionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the stage, or for a completed stage, the last status of the stage.
        /// </para>
        ///  <note> 
        /// <para>
        /// A status of cancelled means that the pipeline’s definition was updated before the
        /// stage execution could be completed.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public StageExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of pipeline execution for the stage, such as a rollback pipeline execution.
        /// </para>
        /// </summary>
        public ExecutionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
