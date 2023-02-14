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
    /// An entity returned by the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_SearchRecord.html">SearchRecord</a>
    /// API containing the properties of a hyperparameter tuning job.
    /// </summary>
    public partial class HyperParameterTuningJobSearchEntity
    {
        private HyperParameterTrainingJobSummary _bestTrainingJob;
        private HyperParameterTuningJobConsumedResources _consumedResources;
        private DateTime? _creationTime;
        private string _failureReason;
        private DateTime? _hyperParameterTuningEndTime;
        private string _hyperParameterTuningJobArn;
        private HyperParameterTuningJobConfig _hyperParameterTuningJobConfig;
        private string _hyperParameterTuningJobName;
        private HyperParameterTuningJobStatus _hyperParameterTuningJobStatus;
        private DateTime? _lastModifiedTime;
        private ObjectiveStatusCounters _objectiveStatusCounters;
        private HyperParameterTrainingJobSummary _overallBestTrainingJob;
        private List<Tag> _tags = new List<Tag>();
        private HyperParameterTrainingJobDefinition _trainingJobDefinition;
        private List<HyperParameterTrainingJobDefinition> _trainingJobDefinitions = new List<HyperParameterTrainingJobDefinition>();
        private TrainingJobStatusCounters _trainingJobStatusCounters;
        private HyperParameterTuningJobCompletionDetails _tuningJobCompletionDetails;
        private HyperParameterTuningJobWarmStartConfig _warmStartConfig;

        /// <summary>
        /// Gets and sets the property BestTrainingJob.
        /// </summary>
        public HyperParameterTrainingJobSummary BestTrainingJob
        {
            get { return this._bestTrainingJob; }
            set { this._bestTrainingJob = value; }
        }

        // Check to see if BestTrainingJob property is set
        internal bool IsSetBestTrainingJob()
        {
            return this._bestTrainingJob != null;
        }

        /// <summary>
        /// Gets and sets the property ConsumedResources. 
        /// <para>
        /// The total amount of resources consumed by a hyperparameter tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobConsumedResources ConsumedResources
        {
            get { return this._consumedResources; }
            set { this._consumedResources = value; }
        }

        // Check to see if ConsumedResources property is set
        internal bool IsSetConsumedResources()
        {
            return this._consumedResources != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that a hyperparameter tuning job was created.
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The error that was created when a hyperparameter tuning job failed.
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
        /// Gets and sets the property HyperParameterTuningEndTime. 
        /// <para>
        /// The time that a hyperparameter tuning job ended.
        /// </para>
        /// </summary>
        public DateTime HyperParameterTuningEndTime
        {
            get { return this._hyperParameterTuningEndTime.GetValueOrDefault(); }
            set { this._hyperParameterTuningEndTime = value; }
        }

        // Check to see if HyperParameterTuningEndTime property is set
        internal bool IsSetHyperParameterTuningEndTime()
        {
            return this._hyperParameterTuningEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string HyperParameterTuningJobArn
        {
            get { return this._hyperParameterTuningJobArn; }
            set { this._hyperParameterTuningJobArn = value; }
        }

        // Check to see if HyperParameterTuningJobArn property is set
        internal bool IsSetHyperParameterTuningJobArn()
        {
            return this._hyperParameterTuningJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobConfig.
        /// </summary>
        public HyperParameterTuningJobConfig HyperParameterTuningJobConfig
        {
            get { return this._hyperParameterTuningJobConfig; }
            set { this._hyperParameterTuningJobConfig = value; }
        }

        // Check to see if HyperParameterTuningJobConfig property is set
        internal bool IsSetHyperParameterTuningJobConfig()
        {
            return this._hyperParameterTuningJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobName. 
        /// <para>
        /// The name of a hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string HyperParameterTuningJobName
        {
            get { return this._hyperParameterTuningJobName; }
            set { this._hyperParameterTuningJobName = value; }
        }

        // Check to see if HyperParameterTuningJobName property is set
        internal bool IsSetHyperParameterTuningJobName()
        {
            return this._hyperParameterTuningJobName != null;
        }

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobStatus. 
        /// <para>
        /// The status of a hyperparameter tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobStatus HyperParameterTuningJobStatus
        {
            get { return this._hyperParameterTuningJobStatus; }
            set { this._hyperParameterTuningJobStatus = value; }
        }

        // Check to see if HyperParameterTuningJobStatus property is set
        internal bool IsSetHyperParameterTuningJobStatus()
        {
            return this._hyperParameterTuningJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time that a hyperparameter tuning job was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectiveStatusCounters.
        /// </summary>
        public ObjectiveStatusCounters ObjectiveStatusCounters
        {
            get { return this._objectiveStatusCounters; }
            set { this._objectiveStatusCounters = value; }
        }

        // Check to see if ObjectiveStatusCounters property is set
        internal bool IsSetObjectiveStatusCounters()
        {
            return this._objectiveStatusCounters != null;
        }

        /// <summary>
        /// Gets and sets the property OverallBestTrainingJob.
        /// </summary>
        public HyperParameterTrainingJobSummary OverallBestTrainingJob
        {
            get { return this._overallBestTrainingJob; }
            set { this._overallBestTrainingJob = value; }
        }

        // Check to see if OverallBestTrainingJob property is set
        internal bool IsSetOverallBestTrainingJob()
        {
            return this._overallBestTrainingJob != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with a hyperparameter tuning job. For more information see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrainingJobDefinition.
        /// </summary>
        public HyperParameterTrainingJobDefinition TrainingJobDefinition
        {
            get { return this._trainingJobDefinition; }
            set { this._trainingJobDefinition = value; }
        }

        // Check to see if TrainingJobDefinition property is set
        internal bool IsSetTrainingJobDefinition()
        {
            return this._trainingJobDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJobDefinitions. 
        /// <para>
        /// The job definitions included in a hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<HyperParameterTrainingJobDefinition> TrainingJobDefinitions
        {
            get { return this._trainingJobDefinitions; }
            set { this._trainingJobDefinitions = value; }
        }

        // Check to see if TrainingJobDefinitions property is set
        internal bool IsSetTrainingJobDefinitions()
        {
            return this._trainingJobDefinitions != null && this._trainingJobDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrainingJobStatusCounters.
        /// </summary>
        public TrainingJobStatusCounters TrainingJobStatusCounters
        {
            get { return this._trainingJobStatusCounters; }
            set { this._trainingJobStatusCounters = value; }
        }

        // Check to see if TrainingJobStatusCounters property is set
        internal bool IsSetTrainingJobStatusCounters()
        {
            return this._trainingJobStatusCounters != null;
        }

        /// <summary>
        /// Gets and sets the property TuningJobCompletionDetails. 
        /// <para>
        /// Information about either a current or completed hyperparameter tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobCompletionDetails TuningJobCompletionDetails
        {
            get { return this._tuningJobCompletionDetails; }
            set { this._tuningJobCompletionDetails = value; }
        }

        // Check to see if TuningJobCompletionDetails property is set
        internal bool IsSetTuningJobCompletionDetails()
        {
            return this._tuningJobCompletionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property WarmStartConfig.
        /// </summary>
        public HyperParameterTuningJobWarmStartConfig WarmStartConfig
        {
            get { return this._warmStartConfig; }
            set { this._warmStartConfig = value; }
        }

        // Check to see if WarmStartConfig property is set
        internal bool IsSetWarmStartConfig()
        {
            return this._warmStartConfig != null;
        }

    }
}