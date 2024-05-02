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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Describes an Amazon Lookout for Vision model.
    /// </summary>
    public partial class ModelDescription
    {
        private DateTime? _creationTimestamp;
        private string _description;
        private DateTime? _evaluationEndTimestamp;
        private OutputS3Object _evaluationManifest;
        private OutputS3Object _evaluationResult;
        private string _kmsKeyId;
        private int? _maxInferenceUnits;
        private int? _minInferenceUnits;
        private string _modelArn;
        private string _modelVersion;
        private OutputConfig _outputConfig;
        private ModelPerformance _performance;
        private ModelStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The unix timestamp for the date and time that the model was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationEndTimestamp. 
        /// <para>
        /// The unix timestamp for the date and time that the evaluation ended. 
        /// </para>
        /// </summary>
        public DateTime? EvaluationEndTimestamp
        {
            get { return this._evaluationEndTimestamp; }
            set { this._evaluationEndTimestamp = value; }
        }

        // Check to see if EvaluationEndTimestamp property is set
        internal bool IsSetEvaluationEndTimestamp()
        {
            return this._evaluationEndTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationManifest. 
        /// <para>
        /// The S3 location where Amazon Lookout for Vision saves the manifest file that was used
        /// to test the trained model and generate the performance scores.
        /// </para>
        /// </summary>
        public OutputS3Object EvaluationManifest
        {
            get { return this._evaluationManifest; }
            set { this._evaluationManifest = value; }
        }

        // Check to see if EvaluationManifest property is set
        internal bool IsSetEvaluationManifest()
        {
            return this._evaluationManifest != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationResult. 
        /// <para>
        /// The S3 location where Amazon Lookout for Vision saves the performance metrics.
        /// </para>
        /// </summary>
        public OutputS3Object EvaluationResult
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifer for the AWS Key Management Service (AWS KMS) key that was used to encrypt
        /// the model during training.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxInferenceUnits. 
        /// <para>
        /// The maximum number of inference units Amazon Lookout for Vision uses to auto-scale
        /// the model. For more information, see <a>StartModel</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxInferenceUnits
        {
            get { return this._maxInferenceUnits; }
            set { this._maxInferenceUnits = value; }
        }

        // Check to see if MaxInferenceUnits property is set
        internal bool IsSetMaxInferenceUnits()
        {
            return this._maxInferenceUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinInferenceUnits. 
        /// <para>
        /// The minimum number of inference units used by the model. For more information, see
        /// <a>StartModel</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MinInferenceUnits
        {
            get { return this._minInferenceUnits; }
            set { this._minInferenceUnits = value; }
        }

        // Check to see if MinInferenceUnits property is set
        internal bool IsSetMinInferenceUnits()
        {
            return this._minInferenceUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The S3 location where Amazon Lookout for Vision saves model training files.
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
        /// Gets and sets the property Performance. 
        /// <para>
        /// Performance metrics for the model. Created during training.
        /// </para>
        /// </summary>
        public ModelPerformance Performance
        {
            get { return this._performance; }
            set { this._performance = value; }
        }

        // Check to see if Performance property is set
        internal bool IsSetPerformance()
        {
            return this._performance != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the model.
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

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for the model.
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

    }
}