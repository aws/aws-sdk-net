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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// The configuration properties of a flywheel iteration.
    /// </summary>
    public partial class FlywheelIterationProperties
    {
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private string _evaluatedModelArn;
        private FlywheelModelEvaluationMetrics _evaluatedModelMetrics;
        private string _evaluationManifestS3Prefix;
        private string _flywheelArn;
        private string _flywheelIterationId;
        private string _message;
        private FlywheelIterationStatus _status;
        private string _trainedModelArn;
        private FlywheelModelEvaluationMetrics _trainedModelMetrics;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation start time of the flywheel iteration.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The completion time of this flywheel iteration.
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
        /// Gets and sets the property EvaluatedModelArn. 
        /// <para>
        /// The ARN of the evaluated model associated with this flywheel iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EvaluatedModelArn
        {
            get { return this._evaluatedModelArn; }
            set { this._evaluatedModelArn = value; }
        }

        // Check to see if EvaluatedModelArn property is set
        internal bool IsSetEvaluatedModelArn()
        {
            return this._evaluatedModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatedModelMetrics.
        /// </summary>
        public FlywheelModelEvaluationMetrics EvaluatedModelMetrics
        {
            get { return this._evaluatedModelMetrics; }
            set { this._evaluatedModelMetrics = value; }
        }

        // Check to see if EvaluatedModelMetrics property is set
        internal bool IsSetEvaluatedModelMetrics()
        {
            return this._evaluatedModelMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationManifestS3Prefix.
        /// </summary>
        [AWSProperty(Max=1024)]
        public string EvaluationManifestS3Prefix
        {
            get { return this._evaluationManifestS3Prefix; }
            set { this._evaluationManifestS3Prefix = value; }
        }

        // Check to see if EvaluationManifestS3Prefix property is set
        internal bool IsSetEvaluationManifestS3Prefix()
        {
            return this._evaluationManifestS3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property FlywheelArn.
        /// </summary>
        [AWSProperty(Max=256)]
        public string FlywheelArn
        {
            get { return this._flywheelArn; }
            set { this._flywheelArn = value; }
        }

        // Check to see if FlywheelArn property is set
        internal bool IsSetFlywheelArn()
        {
            return this._flywheelArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlywheelIterationId.
        /// </summary>
        [AWSProperty(Max=63)]
        public string FlywheelIterationId
        {
            get { return this._flywheelIterationId; }
            set { this._flywheelIterationId = value; }
        }

        // Check to see if FlywheelIterationId property is set
        internal bool IsSetFlywheelIterationId()
        {
            return this._flywheelIterationId != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the status of the flywheel iteration.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the flywheel iteration.
        /// </para>
        /// </summary>
        public FlywheelIterationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The ARN of the trained model associated with this flywheel iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string TrainedModelArn
        {
            get { return this._trainedModelArn; }
            set { this._trainedModelArn = value; }
        }

        // Check to see if TrainedModelArn property is set
        internal bool IsSetTrainedModelArn()
        {
            return this._trainedModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModelMetrics. 
        /// <para>
        /// The metrics associated with the trained model.
        /// </para>
        /// </summary>
        public FlywheelModelEvaluationMetrics TrainedModelMetrics
        {
            get { return this._trainedModelMetrics; }
            set { this._trainedModelMetrics = value; }
        }

        // Check to see if TrainedModelMetrics property is set
        internal bool IsSetTrainedModelMetrics()
        {
            return this._trainedModelMetrics != null;
        }

    }
}