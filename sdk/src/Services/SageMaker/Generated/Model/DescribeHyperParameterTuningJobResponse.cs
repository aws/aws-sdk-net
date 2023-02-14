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
    /// This is the response object from the DescribeHyperParameterTuningJob operation.
    /// </summary>
    public partial class DescribeHyperParameterTuningJobResponse : AmazonWebServiceResponse
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
        private HyperParameterTrainingJobDefinition _trainingJobDefinition;
        private List<HyperParameterTrainingJobDefinition> _trainingJobDefinitions = new List<HyperParameterTrainingJobDefinition>();
        private TrainingJobStatusCounters _trainingJobStatusCounters;
        private HyperParameterTuningJobCompletionDetails _tuningJobCompletionDetails;
        private HyperParameterTuningJobWarmStartConfig _warmStartConfig;

        /// <summary>
        /// Gets and sets the property BestTrainingJob. 
        /// <para>
        /// A <a>TrainingJobSummary</a> object that describes the training job that completed
        /// with the best current <a>HyperParameterTuningJobObjective</a>.
        /// </para>
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
        /// The date and time that the tuning job started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// If the tuning job failed, the reason it failed.
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
        /// The date and time that the tuning job ended.
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
        /// The Amazon Resource Name (ARN) of the tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// <para>
        /// The <a>HyperParameterTuningJobConfig</a> object that specifies the configuration of
        /// the tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name of the tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// The status of the tuning job: InProgress, Completed, Failed, Stopping, or Stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The date and time that the status of the tuning job was modified. 
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
        /// <para>
        /// The <a>ObjectiveStatusCounters</a> object that specifies the number of training jobs,
        /// categorized by the status of their final objective metric, that this tuning job launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// <para>
        /// If the hyperparameter tuning job is an warm start tuning job with a <code>WarmStartType</code>
        /// of <code>IDENTICAL_DATA_AND_ALGORITHM</code>, this is the <a>TrainingJobSummary</a>
        /// for the training job with the best objective metric value of all training jobs launched
        /// by this tuning job and all parent jobs specified for the warm start tuning job.
        /// </para>
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
        /// Gets and sets the property TrainingJobDefinition. 
        /// <para>
        /// The <a>HyperParameterTrainingJobDefinition</a> object that specifies the definition
        /// of the training jobs that this tuning job launches.
        /// </para>
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
        /// A list of the <a>HyperParameterTrainingJobDefinition</a> objects launched for this
        /// tuning job.
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
        /// <para>
        /// The <a>TrainingJobStatusCounters</a> object that specifies the number of training
        /// jobs, categorized by status, that this tuning job launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Tuning job completion information returned as the response from a hyperparameter tuning
        /// job. This information tells if your tuning job has or has not converged. It also includes
        /// the number of training jobs that have not improved model performance as evaluated
        /// against the objective function.
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
        /// <para>
        /// The configuration for starting the hyperparameter parameter tuning job using one or
        /// more previous tuning jobs as a starting point. The results of previous tuning jobs
        /// are used to inform which combinations of hyperparameters to search over in the new
        /// tuning job.
        /// </para>
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