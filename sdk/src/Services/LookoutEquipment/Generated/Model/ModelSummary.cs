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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Provides information about the specified machine learning model, including dataset
    /// and model names and ARNs, as well as status.
    /// </summary>
    public partial class ModelSummary
    {
        private long? _activeModelVersion;
        private string _activeModelVersionArn;
        private DateTime? _createdAt;
        private string _datasetArn;
        private string _datasetName;
        private long? _latestScheduledRetrainingModelVersion;
        private DateTime? _latestScheduledRetrainingStartTime;
        private ModelVersionStatus _latestScheduledRetrainingStatus;
        private string _modelArn;
        private string _modelName;
        private DateTime? _nextScheduledRetrainingStartDate;
        private RetrainingSchedulerStatus _retrainingSchedulerStatus;
        private ModelStatus _status;

        /// <summary>
        /// Gets and sets the property ActiveModelVersion. 
        /// <para>
        /// The model version that the inference scheduler uses to run an inference execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long ActiveModelVersion
        {
            get { return this._activeModelVersion.GetValueOrDefault(); }
            set { this._activeModelVersion = value; }
        }

        // Check to see if ActiveModelVersion property is set
        internal bool IsSetActiveModelVersion()
        {
            return this._activeModelVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActiveModelVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model version that is set as active. The active
        /// model version is the model version that the inference scheduler uses to run an inference
        /// execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ActiveModelVersionArn
        {
            get { return this._activeModelVersionArn; }
            set { this._activeModelVersionArn = value; }
        }

        // Check to see if ActiveModelVersionArn property is set
        internal bool IsSetActiveModelVersionArn()
        {
            return this._activeModelVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the specific model was created. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the dataset used to create the model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset being used for the machine learning model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingModelVersion. 
        /// <para>
        /// Indicates the most recent model version that was generated by retraining. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long LatestScheduledRetrainingModelVersion
        {
            get { return this._latestScheduledRetrainingModelVersion.GetValueOrDefault(); }
            set { this._latestScheduledRetrainingModelVersion = value; }
        }

        // Check to see if LatestScheduledRetrainingModelVersion property is set
        internal bool IsSetLatestScheduledRetrainingModelVersion()
        {
            return this._latestScheduledRetrainingModelVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingStartTime. 
        /// <para>
        /// Indicates the start time of the most recent scheduled retraining run. 
        /// </para>
        /// </summary>
        public DateTime LatestScheduledRetrainingStartTime
        {
            get { return this._latestScheduledRetrainingStartTime.GetValueOrDefault(); }
            set { this._latestScheduledRetrainingStartTime = value; }
        }

        // Check to see if LatestScheduledRetrainingStartTime property is set
        internal bool IsSetLatestScheduledRetrainingStartTime()
        {
            return this._latestScheduledRetrainingStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingStatus. 
        /// <para>
        /// Indicates the status of the most recent scheduled retraining run. 
        /// </para>
        /// </summary>
        public ModelVersionStatus LatestScheduledRetrainingStatus
        {
            get { return this._latestScheduledRetrainingStatus; }
            set { this._latestScheduledRetrainingStatus = value; }
        }

        // Check to see if LatestScheduledRetrainingStatus property is set
        internal bool IsSetLatestScheduledRetrainingStatus()
        {
            return this._latestScheduledRetrainingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the machine learning model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the machine learning model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property NextScheduledRetrainingStartDate. 
        /// <para>
        /// Indicates the date that the next scheduled retraining run will start on. Lookout for
        /// Equipment truncates the time you provide to <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-types.html#parameter-type-timestamp">the
        /// nearest UTC day</a>.
        /// </para>
        /// </summary>
        public DateTime NextScheduledRetrainingStartDate
        {
            get { return this._nextScheduledRetrainingStartDate.GetValueOrDefault(); }
            set { this._nextScheduledRetrainingStartDate = value; }
        }

        // Check to see if NextScheduledRetrainingStartDate property is set
        internal bool IsSetNextScheduledRetrainingStartDate()
        {
            return this._nextScheduledRetrainingStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetrainingSchedulerStatus. 
        /// <para>
        /// Indicates the status of the retraining scheduler. 
        /// </para>
        /// </summary>
        public RetrainingSchedulerStatus RetrainingSchedulerStatus
        {
            get { return this._retrainingSchedulerStatus; }
            set { this._retrainingSchedulerStatus = value; }
        }

        // Check to see if RetrainingSchedulerStatus property is set
        internal bool IsSetRetrainingSchedulerStatus()
        {
            return this._retrainingSchedulerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the machine learning model. 
        /// </para>
        /// </summary>
        public ModelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}