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
    /// Contains details about the failure when the image creation process fails. Properties
    /// appear in the failure context when the related information is available for the failure.
    /// </summary>
    public partial class ImageFailureContext
    {
        /// <summary>
        /// Gets and sets the property ComponentFailure. 
        /// <para>
        /// The details about the component that failed, if the failure occurred while a component
        /// was running.
        /// </para>
        /// </summary>
        public ComponentFailureContext ComponentFailure { get; set; }

        /// <summary>
        /// Checks to see if the ComponentFailure property is set.
        /// </summary>
        internal bool IsSetComponentFailure() => this.ComponentFailure != null;

        /// <summary>
        /// Gets and sets the property DistributionFailure. 
        /// <para>
        /// The details about the distribution failure, if the failure occurred while Image Builder
        /// distributed or configured the image.
        /// </para>
        /// </summary>
        public DistributionFailureContext DistributionFailure { get; set; }

        /// <summary>
        /// Checks to see if the DistributionFailure property is set.
        /// </summary>
        internal bool IsSetDistributionFailure() => this.DistributionFailure != null;

        /// <summary>
        /// Gets and sets the property FailedStep. 
        /// <para>
        /// The name of the workflow step that failed, as it appears in the workflow document.
        /// </para>
        /// </summary>
        public string FailedStep { get; set; }

        /// <summary>
        /// Checks to see if the FailedStep property is set.
        /// </summary>
        internal bool IsSetFailedStep() => this.FailedStep != null;

        /// <summary>
        /// Gets and sets the property ImageStatus. 
        /// <para>
        /// The status that the image had when the failure occurred. This indicates the stage
        /// of the image creation process where the image failed, for example <c>BUILDING</c>
        /// or <c>DISTRIBUTING</c>.
        /// </para>
        /// </summary>
        public ImageStatus ImageStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImageStatus property is set.
        /// </summary>
        internal bool IsSetImageStatus() => this.ImageStatus != null;

        /// <summary>
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// The unique identifier of the workflow step execution that failed.
        /// </para>
        /// </summary>
        public string StepExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the StepExecutionId property is set.
        /// </summary>
        internal bool IsSetStepExecutionId() => this.StepExecutionId != null;

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow build version that was running when
        /// the image failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutionId. 
        /// <para>
        /// The unique identifier of the workflow execution that was running when the image failed.
        /// </para>
        /// </summary>
        public string WorkflowExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecutionId property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutionId() => this.WorkflowExecutionId != null;
    }
}
