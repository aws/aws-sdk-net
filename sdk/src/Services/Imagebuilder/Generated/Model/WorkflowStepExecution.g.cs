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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains runtime details for a workflow step that has paused at a <c>WaitForAction</c>
    /// step, and is waiting for you to send an action.
    /// </summary>
    public partial class WorkflowStepExecution
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The name of the step action.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image build version that ran the workflow.
        /// </para>
        /// </summary>
        public string ImageBuildVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageBuildVersionArn property is set.
        /// </summary>
        internal bool IsSetImageBuildVersionArn() => this.ImageBuildVersionArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow step.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the workflow step started.
        /// </para>
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;

        /// <summary>
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// Uniquely identifies the workflow step that ran for the associated image build version.
        /// </para>
        /// </summary>
        public string StepExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the StepExecutionId property is set.
        /// </summary>
        internal bool IsSetStepExecutionId() => this.StepExecutionId != null;

        /// <summary>
        /// Gets and sets the property WorkflowBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow resource that ran.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string WorkflowBuildVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowBuildVersionArn property is set.
        /// </summary>
        internal bool IsSetWorkflowBuildVersionArn() => this.WorkflowBuildVersionArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionId. 
        /// <para>
        /// Uniquely identifies the runtime instance of the workflow that contains the workflow
        /// step that ran for the associated image build version.
        /// </para>
        /// </summary>
        public string WorkflowExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionId property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionId() => this.WorkflowExecutionId != null;
    }
}
