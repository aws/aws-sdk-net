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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The container for the summary information about a training job.
    /// </summary>
    public partial class HyperParameterTrainingJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the training job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that the training job failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property FinalHyperParameterTuningJobObjectiveMetric. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_FinalHyperParameterTuningJobObjectiveMetric.html">FinalHyperParameterTuningJobObjectiveMetric</a>
        /// object that specifies the value of the objective metric of the tuning job that launched
        /// this training job.
        /// </para>
        /// </summary>
        public FinalHyperParameterTuningJobObjectiveMetric FinalHyperParameterTuningJobObjectiveMetric { get; set; }

        /// <summary>
        /// Checks to see if the FinalHyperParameterTuningJobObjectiveMetric property is set.
        /// </summary>
        internal bool IsSetFinalHyperParameterTuningJobObjectiveMetric() => this.FinalHyperParameterTuningJobObjectiveMetric != null;

        /// <summary>
        /// Gets and sets the property ObjectiveStatus. 
        /// <para>
        /// The status of the objective metric for the training job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Succeeded: The final objective metric for the training job was evaluated by the hyperparameter
        /// tuning job and used in the hyperparameter tuning process.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Pending: The training job is in progress and evaluation of its final objective metric
        /// is pending.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Failed: The final objective metric for the training job was not evaluated, and was
        /// not used in the hyperparameter tuning process. This typically occurs when the training
        /// job failed or did not emit an objective metric.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ObjectiveStatus ObjectiveStatus { get; set; }

        /// <summary>
        /// Checks to see if the ObjectiveStatus property is set.
        /// </summary>
        internal bool IsSetObjectiveStatus() => this.ObjectiveStatus != null;

        /// <summary>
        /// Gets and sets the property TrainingEndTime. 
        /// <para>
        /// Specifies the time when the training job ends on training instances. You are billed
        /// for the time interval between the value of <c>TrainingStartTime</c> and this time.
        /// For successful jobs and stopped jobs, this is the time after model artifacts are uploaded.
        /// For failed jobs, this is the time when SageMaker detects a job failure.
        /// </para>
        /// </summary>
        public DateTime? TrainingEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingEndTime property is set.
        /// </summary>
        internal bool IsSetTrainingEndTime() => this.TrainingEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string TrainingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobArn property is set.
        /// </summary>
        internal bool IsSetTrainingJobArn() => this.TrainingJobArn != null;

        /// <summary>
        /// Gets and sets the property TrainingJobDefinitionName. 
        /// <para>
        /// The training job definition name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TrainingJobDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobDefinitionName property is set.
        /// </summary>
        internal bool IsSetTrainingJobDefinitionName() => this.TrainingJobDefinitionName != null;

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of the training job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string TrainingJobName { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobName property is set.
        /// </summary>
        internal bool IsSetTrainingJobName() => this.TrainingJobName != null;

        /// <summary>
        /// Gets and sets the property TrainingJobStatus. 
        /// <para>
        /// The status of the training job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainingJobStatus TrainingJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobStatus property is set.
        /// </summary>
        internal bool IsSetTrainingJobStatus() => this.TrainingJobStatus != null;

        /// <summary>
        /// Gets and sets the property TrainingStartTime. 
        /// <para>
        /// The date and time that the training job started.
        /// </para>
        /// </summary>
        public DateTime? TrainingStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingStartTime property is set.
        /// </summary>
        internal bool IsSetTrainingStartTime() => this.TrainingStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TunedHyperParameters. 
        /// <para>
        /// A list of the hyperparameters for which you specified ranges to search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public Dictionary<string, string> TunedHyperParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TunedHyperParameters property is set.
        /// </summary>
        internal bool IsSetTunedHyperParameters() => this.TunedHyperParameters != null && (this.TunedHyperParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TuningJobName. 
        /// <para>
        /// The HyperParameter tuning job that launched the training job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string TuningJobName { get; set; }

        /// <summary>
        /// Checks to see if the TuningJobName property is set.
        /// </summary>
        internal bool IsSetTuningJobName() => this.TuningJobName != null;
    }
}
