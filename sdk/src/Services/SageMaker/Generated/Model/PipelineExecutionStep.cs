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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// An execution of a step in a pipeline.
    /// </summary>
    public partial class PipelineExecutionStep
    {
        private int? _attemptCount;
        private CacheHitResult _cacheHitResult;
        private DateTime? _endTime;
        private string _failureReason;
        private PipelineExecutionStepMetadata _metadata;
        private DateTime? _startTime;
        private string _stepDescription;
        private string _stepDisplayName;
        private string _stepName;
        private StepStatus _stepStatus;

        /// <summary>
        /// Gets and sets the property AttemptCount. 
        /// <para>
        /// The current attempt of the execution step. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/pipelines-retry-policy.html">Retry
        /// Policy for SageMaker Pipelines steps</a>.
        /// </para>
        /// </summary>
        public int AttemptCount
        {
            get { return this._attemptCount.GetValueOrDefault(); }
            set { this._attemptCount = value; }
        }

        // Check to see if AttemptCount property is set
        internal bool IsSetAttemptCount()
        {
            return this._attemptCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheHitResult. 
        /// <para>
        /// If this pipeline execution step was cached, details on the cache hit.
        /// </para>
        /// </summary>
        public CacheHitResult CacheHitResult
        {
            get { return this._cacheHitResult; }
            set { this._cacheHitResult = value; }
        }

        // Check to see if CacheHitResult property is set
        internal bool IsSetCacheHitResult()
        {
            return this._cacheHitResult != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the step stopped executing.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why the step failed execution. This is only returned if the step failed
        /// its execution.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata to run the pipeline step.
        /// </para>
        /// </summary>
        public PipelineExecutionStepMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the step started executing.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepDescription. 
        /// <para>
        /// The description of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string StepDescription
        {
            get { return this._stepDescription; }
            set { this._stepDescription = value; }
        }

        // Check to see if StepDescription property is set
        internal bool IsSetStepDescription()
        {
            return this._stepDescription != null;
        }

        /// <summary>
        /// Gets and sets the property StepDisplayName. 
        /// <para>
        /// The display name of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string StepDisplayName
        {
            get { return this._stepDisplayName; }
            set { this._stepDisplayName = value; }
        }

        // Check to see if StepDisplayName property is set
        internal bool IsSetStepDisplayName()
        {
            return this._stepDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of the step that is executed.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

        /// <summary>
        /// Gets and sets the property StepStatus. 
        /// <para>
        /// The status of the step execution.
        /// </para>
        /// </summary>
        public StepStatus StepStatus
        {
            get { return this._stepStatus; }
            set { this._stepStatus = value; }
        }

        // Check to see if StepStatus property is set
        internal bool IsSetStepStatus()
        {
            return this._stepStatus != null;
        }

    }
}