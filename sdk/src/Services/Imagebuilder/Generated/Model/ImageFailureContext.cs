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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
        private ComponentFailureContext _componentFailure;
        private DistributionFailureContext _distributionFailure;
        private string _failedStep;
        private ImageStatus _imageStatus;
        private string _stepExecutionId;
        private string _workflowArn;
        private string _workflowExecutionId;

        /// <summary>
        /// Gets and sets the property ComponentFailure. 
        /// <para>
        /// The details about the component that failed, if the failure occurred while a component
        /// was running.
        /// </para>
        /// </summary>
        public ComponentFailureContext ComponentFailure
        {
            get { return this._componentFailure; }
            set { this._componentFailure = value; }
        }

        // Check to see if ComponentFailure property is set
        internal bool IsSetComponentFailure()
        {
            return this._componentFailure != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionFailure. 
        /// <para>
        /// The details about the distribution failure, if the failure occurred while Image Builder
        /// distributed or configured the image.
        /// </para>
        /// </summary>
        public DistributionFailureContext DistributionFailure
        {
            get { return this._distributionFailure; }
            set { this._distributionFailure = value; }
        }

        // Check to see if DistributionFailure property is set
        internal bool IsSetDistributionFailure()
        {
            return this._distributionFailure != null;
        }

        /// <summary>
        /// Gets and sets the property FailedStep. 
        /// <para>
        /// The name of the workflow step that failed, as it appears in the workflow document.
        /// </para>
        /// </summary>
        public string FailedStep
        {
            get { return this._failedStep; }
            set { this._failedStep = value; }
        }

        // Check to see if FailedStep property is set
        internal bool IsSetFailedStep()
        {
            return this._failedStep != null;
        }

        /// <summary>
        /// Gets and sets the property ImageStatus. 
        /// <para>
        /// The status that the image had when the failure occurred. This indicates the stage
        /// of the image creation process where the image failed, for example <c>BUILDING</c>
        /// or <c>DISTRIBUTING</c>.
        /// </para>
        /// </summary>
        public ImageStatus ImageStatus
        {
            get { return this._imageStatus; }
            set { this._imageStatus = value; }
        }

        // Check to see if ImageStatus property is set
        internal bool IsSetImageStatus()
        {
            return this._imageStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// The unique identifier of the workflow step execution that failed.
        /// </para>
        /// </summary>
        public string StepExecutionId
        {
            get { return this._stepExecutionId; }
            set { this._stepExecutionId = value; }
        }

        // Check to see if StepExecutionId property is set
        internal bool IsSetStepExecutionId()
        {
            return this._stepExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow build version that was running when
        /// the image failed.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string WorkflowArn
        {
            get { return this._workflowArn; }
            set { this._workflowArn = value; }
        }

        // Check to see if WorkflowArn property is set
        internal bool IsSetWorkflowArn()
        {
            return this._workflowArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionId. 
        /// <para>
        /// The unique identifier of the workflow execution that was running when the image failed.
        /// </para>
        /// </summary>
        public string WorkflowExecutionId
        {
            get { return this._workflowExecutionId; }
            set { this._workflowExecutionId = value; }
        }

        // Check to see if WorkflowExecutionId property is set
        internal bool IsSetWorkflowExecutionId()
        {
            return this._workflowExecutionId != null;
        }

    }
}