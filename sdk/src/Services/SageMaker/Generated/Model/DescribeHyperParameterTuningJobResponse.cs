/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        private DateTime? _creationTime;
        private string _failureReason;
        private DateTime? _hyperParameterTuningEndTime;
        private string _hyperParameterTuningJobArn;
        private HyperParameterTuningJobConfig _hyperParameterTuningJobConfig;
        private string _hyperParameterTuningJobName;
        private HyperParameterTuningJobStatus _hyperParameterTuningJobStatus;
        private DateTime? _lastModifiedTime;
        private ObjectiveStatusCounters _objectiveStatusCounters;
        private HyperParameterTrainingJobDefinition _trainingJobDefinition;
        private TrainingJobStatusCounters _trainingJobStatusCounters;

        /// <summary>
        /// Gets and sets the property BestTrainingJob. 
        /// <para>
        /// A object that describes the training job that completed with the best current .
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the tuning job started.
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
        /// If the tuning job failed, the reason it failed.
        /// </para>
        /// </summary>
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
        /// The object that specifies the configuration of the tuning job.
        /// </para>
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
        /// The name of the tuning job.
        /// </para>
        /// </summary>
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
        /// The object that specifies the number of training jobs, categorized by the status of
        /// their final objective metric, that this tuning job launched.
        /// </para>
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
        /// Gets and sets the property TrainingJobDefinition. 
        /// <para>
        /// The object that specifies the definition of the training jobs that this tuning job
        /// launches.
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
        /// Gets and sets the property TrainingJobStatusCounters. 
        /// <para>
        /// The object that specifies the number of training jobs, categorized by status, that
        /// this tuning job launched.
        /// </para>
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

    }
}