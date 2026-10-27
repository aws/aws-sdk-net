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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// The configuration properties of a flywheel iteration.
    /// </summary>
    public partial class FlywheelIterationProperties
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation start time of the flywheel iteration.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The completion time of this flywheel iteration.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluatedModelArn. 
        /// <para>
        /// The ARN of the evaluated model associated with this flywheel iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EvaluatedModelArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatedModelArn property is set.
        /// </summary>
        internal bool IsSetEvaluatedModelArn() => this.EvaluatedModelArn != null;

        /// <summary>
        /// Gets and sets the property EvaluatedModelMetrics.
        /// </summary>
        public FlywheelModelEvaluationMetrics EvaluatedModelMetrics { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatedModelMetrics property is set.
        /// </summary>
        internal bool IsSetEvaluatedModelMetrics() => this.EvaluatedModelMetrics != null;

        /// <summary>
        /// Gets and sets the property EvaluationManifestS3Prefix. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EvaluationManifestS3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationManifestS3Prefix property is set.
        /// </summary>
        internal bool IsSetEvaluationManifestS3Prefix() => this.EvaluationManifestS3Prefix != null;

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FlywheelArn { get; set; }

        /// <summary>
        /// Checks to see if the FlywheelArn property is set.
        /// </summary>
        internal bool IsSetFlywheelArn() => this.FlywheelArn != null;

        /// <summary>
        /// Gets and sets the property FlywheelIterationId. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string FlywheelIterationId { get; set; }

        /// <summary>
        /// Checks to see if the FlywheelIterationId property is set.
        /// </summary>
        internal bool IsSetFlywheelIterationId() => this.FlywheelIterationId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the status of the flywheel iteration.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the flywheel iteration.
        /// </para>
        /// </summary>
        public FlywheelIterationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The ARN of the trained model associated with this flywheel iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TrainedModelArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelArn property is set.
        /// </summary>
        internal bool IsSetTrainedModelArn() => this.TrainedModelArn != null;

        /// <summary>
        /// Gets and sets the property TrainedModelMetrics. 
        /// <para>
        /// The metrics associated with the trained model.
        /// </para>
        /// </summary>
        public FlywheelModelEvaluationMetrics TrainedModelMetrics { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelMetrics property is set.
        /// </summary>
        internal bool IsSetTrainedModelMetrics() => this.TrainedModelMetrics != null;
    }
}
