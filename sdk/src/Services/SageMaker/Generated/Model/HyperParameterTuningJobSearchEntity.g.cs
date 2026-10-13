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
    /// An entity returned by the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_SearchRecord.html">SearchRecord</a>
    /// API containing the properties of a hyperparameter tuning job.
    /// </summary>
    public partial class HyperParameterTuningJobSearchEntity
    {
        /// <summary>
        /// Gets and sets the property BestTrainingJob.
        /// </summary>
        public HyperParameterTrainingJobSummary BestTrainingJob { get; set; }

        /// <summary>
        /// Checks to see if the BestTrainingJob property is set.
        /// </summary>
        internal bool IsSetBestTrainingJob() => this.BestTrainingJob != null;

        /// <summary>
        /// Gets and sets the property ConsumedResources. 
        /// <para>
        /// The total amount of resources consumed by a hyperparameter tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobConsumedResources ConsumedResources { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedResources property is set.
        /// </summary>
        internal bool IsSetConsumedResources() => this.ConsumedResources != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that a hyperparameter tuning job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The error that was created when a hyperparameter tuning job failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningEndTime. 
        /// <para>
        /// The time that a hyperparameter tuning job ended.
        /// </para>
        /// </summary>
        public DateTime? HyperParameterTuningEndTime { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningEndTime property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningEndTime() => this.HyperParameterTuningEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string HyperParameterTuningJobArn { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningJobArn property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningJobArn() => this.HyperParameterTuningJobArn != null;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobConfig.
        /// </summary>
        public HyperParameterTuningJobConfig HyperParameterTuningJobConfig { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningJobConfig property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningJobConfig() => this.HyperParameterTuningJobConfig != null;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobName. 
        /// <para>
        /// The name of a hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string HyperParameterTuningJobName { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningJobName property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningJobName() => this.HyperParameterTuningJobName != null;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobStatus. 
        /// <para>
        /// The status of a hyperparameter tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobStatus HyperParameterTuningJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningJobStatus property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningJobStatus() => this.HyperParameterTuningJobStatus != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time that a hyperparameter tuning job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectiveStatusCounters.
        /// </summary>
        public ObjectiveStatusCounters ObjectiveStatusCounters { get; set; }

        /// <summary>
        /// Checks to see if the ObjectiveStatusCounters property is set.
        /// </summary>
        internal bool IsSetObjectiveStatusCounters() => this.ObjectiveStatusCounters != null;

        /// <summary>
        /// Gets and sets the property OverallBestTrainingJob.
        /// </summary>
        public HyperParameterTrainingJobSummary OverallBestTrainingJob { get; set; }

        /// <summary>
        /// Checks to see if the OverallBestTrainingJob property is set.
        /// </summary>
        internal bool IsSetOverallBestTrainingJob() => this.OverallBestTrainingJob != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with a hyperparameter tuning job. For more information see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrainingJobDefinition.
        /// </summary>
        public HyperParameterTrainingJobDefinition TrainingJobDefinition { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobDefinition property is set.
        /// </summary>
        internal bool IsSetTrainingJobDefinition() => this.TrainingJobDefinition != null;

        /// <summary>
        /// Gets and sets the property TrainingJobDefinitions. 
        /// <para>
        /// The job definitions included in a hyperparameter tuning job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<HyperParameterTrainingJobDefinition> TrainingJobDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<HyperParameterTrainingJobDefinition>() : null;

        /// <summary>
        /// Checks to see if the TrainingJobDefinitions property is set.
        /// </summary>
        internal bool IsSetTrainingJobDefinitions() => this.TrainingJobDefinitions != null && (this.TrainingJobDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrainingJobStatusCounters.
        /// </summary>
        public TrainingJobStatusCounters TrainingJobStatusCounters { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobStatusCounters property is set.
        /// </summary>
        internal bool IsSetTrainingJobStatusCounters() => this.TrainingJobStatusCounters != null;

        /// <summary>
        /// Gets and sets the property TuningJobCompletionDetails. 
        /// <para>
        /// Information about either a current or completed hyperparameter tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobCompletionDetails TuningJobCompletionDetails { get; set; }

        /// <summary>
        /// Checks to see if the TuningJobCompletionDetails property is set.
        /// </summary>
        internal bool IsSetTuningJobCompletionDetails() => this.TuningJobCompletionDetails != null;

        /// <summary>
        /// Gets and sets the property WarmStartConfig.
        /// </summary>
        public HyperParameterTuningJobWarmStartConfig WarmStartConfig { get; set; }

        /// <summary>
        /// Checks to see if the WarmStartConfig property is set.
        /// </summary>
        internal bool IsSetWarmStartConfig() => this.WarmStartConfig != null;
    }
}
