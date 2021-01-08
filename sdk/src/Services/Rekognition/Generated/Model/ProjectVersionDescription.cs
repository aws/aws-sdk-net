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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// The description of a version of a model.
    /// </summary>
    public partial class ProjectVersionDescription
    {
        private long? _billableTrainingTimeInSeconds;
        private DateTime? _creationTimestamp;
        private EvaluationResult _evaluationResult;
        private GroundTruthManifest _manifestSummary;
        private int? _minInferenceUnits;
        private OutputConfig _outputConfig;
        private string _projectVersionArn;
        private ProjectVersionStatus _status;
        private string _statusMessage;
        private TestingDataResult _testingDataResult;
        private TrainingDataResult _trainingDataResult;
        private DateTime? _trainingEndTimestamp;

        /// <summary>
        /// Gets and sets the property BillableTrainingTimeInSeconds. 
        /// <para>
        /// The duration, in seconds, that the model version has been billed for training. This
        /// value is only returned if the model version has been successfully trained.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long BillableTrainingTimeInSeconds
        {
            get { return this._billableTrainingTimeInSeconds.GetValueOrDefault(); }
            set { this._billableTrainingTimeInSeconds = value; }
        }

        // Check to see if BillableTrainingTimeInSeconds property is set
        internal bool IsSetBillableTrainingTimeInSeconds()
        {
            return this._billableTrainingTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The Unix datetime for the date and time that training started.
        /// </para>
        /// </summary>
        public DateTime CreationTimestamp
        {
            get { return this._creationTimestamp.GetValueOrDefault(); }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationResult. 
        /// <para>
        /// The training results. <code>EvaluationResult</code> is only returned if training is
        /// successful.
        /// </para>
        /// </summary>
        public EvaluationResult EvaluationResult
        {
            get { return this._evaluationResult; }
            set { this._evaluationResult = value; }
        }

        // Check to see if EvaluationResult property is set
        internal bool IsSetEvaluationResult()
        {
            return this._evaluationResult != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestSummary. 
        /// <para>
        /// The location of the summary manifest. The summary manifest provides aggregate data
        /// validation results for the training and test datasets.
        /// </para>
        /// </summary>
        public GroundTruthManifest ManifestSummary
        {
            get { return this._manifestSummary; }
            set { this._manifestSummary = value; }
        }

        // Check to see if ManifestSummary property is set
        internal bool IsSetManifestSummary()
        {
            return this._manifestSummary != null;
        }

        /// <summary>
        /// Gets and sets the property MinInferenceUnits. 
        /// <para>
        /// The minimum number of inference units used by the model. For more information, see
        /// <a>StartProjectVersion</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MinInferenceUnits
        {
            get { return this._minInferenceUnits.GetValueOrDefault(); }
            set { this._minInferenceUnits = value; }
        }

        // Check to see if MinInferenceUnits property is set
        internal bool IsSetMinInferenceUnits()
        {
            return this._minInferenceUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The location where training results are saved.
        /// </para>
        /// </summary>
        public OutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ProjectVersionArn
        {
            get { return this._projectVersionArn; }
            set { this._projectVersionArn = value; }
        }

        // Check to see if ProjectVersionArn property is set
        internal bool IsSetProjectVersionArn()
        {
            return this._projectVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the model version.
        /// </para>
        /// </summary>
        public ProjectVersionStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A descriptive message for an error or warning that occurred.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TestingDataResult. 
        /// <para>
        /// Contains information about the testing results.
        /// </para>
        /// </summary>
        public TestingDataResult TestingDataResult
        {
            get { return this._testingDataResult; }
            set { this._testingDataResult = value; }
        }

        // Check to see if TestingDataResult property is set
        internal bool IsSetTestingDataResult()
        {
            return this._testingDataResult != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingDataResult. 
        /// <para>
        /// Contains information about the training results.
        /// </para>
        /// </summary>
        public TrainingDataResult TrainingDataResult
        {
            get { return this._trainingDataResult; }
            set { this._trainingDataResult = value; }
        }

        // Check to see if TrainingDataResult property is set
        internal bool IsSetTrainingDataResult()
        {
            return this._trainingDataResult != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingEndTimestamp. 
        /// <para>
        /// The Unix date and time that training of the model ended.
        /// </para>
        /// </summary>
        public DateTime TrainingEndTimestamp
        {
            get { return this._trainingEndTimestamp.GetValueOrDefault(); }
            set { this._trainingEndTimestamp = value; }
        }

        // Check to see if TrainingEndTimestamp property is set
        internal bool IsSetTrainingEndTimestamp()
        {
            return this._trainingEndTimestamp.HasValue; 
        }

    }
}