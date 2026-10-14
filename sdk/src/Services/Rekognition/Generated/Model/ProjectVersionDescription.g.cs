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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// A description of a version of a Amazon Rekognition project version.
    /// </summary>
    public partial class ProjectVersionDescription
    {
        /// <summary>
        /// Gets and sets the property BaseModelVersion. 
        /// <para>
        /// The base detection model version used to create the project version.
        /// </para>
        /// </summary>
        public string BaseModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the BaseModelVersion property is set.
        /// </summary>
        internal bool IsSetBaseModelVersion() => this.BaseModelVersion != null;

        /// <summary>
        /// Gets and sets the property BillableTrainingTimeInSeconds. 
        /// <para>
        /// The duration, in seconds, that you were billed for a successful training of the model
        /// version. This value is only returned if the model version has been successfully trained.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? BillableTrainingTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the BillableTrainingTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetBillableTrainingTimeInSeconds() => this.BillableTrainingTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The Unix datetime for the date and time that training started.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationResult. 
        /// <para>
        /// The training results. <c>EvaluationResult</c> is only returned if training is successful.
        /// </para>
        /// </summary>
        public EvaluationResult EvaluationResult { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationResult property is set.
        /// </summary>
        internal bool IsSetEvaluationResult() => this.EvaluationResult != null;

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// The feature that was customized.
        /// </para>
        /// </summary>
        public CustomizationFeature Feature { get; set; }

        /// <summary>
        /// Checks to see if the Feature property is set.
        /// </summary>
        internal bool IsSetFeature() => this.Feature != null;

        /// <summary>
        /// Gets and sets the property FeatureConfig. 
        /// <para>
        /// Feature specific configuration that was applied during training.
        /// </para>
        /// </summary>
        public CustomizationFeatureConfig FeatureConfig { get; set; }

        /// <summary>
        /// Checks to see if the FeatureConfig property is set.
        /// </summary>
        internal bool IsSetFeatureConfig() => this.FeatureConfig != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifer for the AWS Key Management Service key (AWS KMS key) that was used to
        /// encrypt the model during training. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property ManifestSummary. 
        /// <para>
        /// The location of the summary manifest. The summary manifest provides aggregate data
        /// validation results for the training and test datasets.
        /// </para>
        /// </summary>
        public GroundTruthManifest ManifestSummary { get; set; }

        /// <summary>
        /// Checks to see if the ManifestSummary property is set.
        /// </summary>
        internal bool IsSetManifestSummary() => this.ManifestSummary != null;

        /// <summary>
        /// Gets and sets the property MaxInferenceUnits. 
        /// <para>
        /// The maximum number of inference units Amazon Rekognition uses to auto-scale the model.
        /// Applies only to Custom Labels projects. For more information, see <a>StartProjectVersion</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxInferenceUnits { get; set; }

        /// <summary>
        /// Checks to see if the MaxInferenceUnits property is set.
        /// </summary>
        internal bool IsSetMaxInferenceUnits() => this.MaxInferenceUnits.HasValue;

        /// <summary>
        /// Gets and sets the property MinInferenceUnits. 
        /// <para>
        /// The minimum number of inference units used by the model. Applies only to Custom Labels
        /// projects. For more information, see <a>StartProjectVersion</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MinInferenceUnits { get; set; }

        /// <summary>
        /// Checks to see if the MinInferenceUnits property is set.
        /// </summary>
        internal bool IsSetMinInferenceUnits() => this.MinInferenceUnits.HasValue;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The location where training results are saved.
        /// </para>
        /// </summary>
        public OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property ProjectVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProjectVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectVersionArn property is set.
        /// </summary>
        internal bool IsSetProjectVersionArn() => this.ProjectVersionArn != null;

        /// <summary>
        /// Gets and sets the property SourceProjectVersionArn. 
        /// <para>
        /// If the model version was copied from a different project, <c>SourceProjectVersionArn</c>
        /// contains the ARN of the source model version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string SourceProjectVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceProjectVersionArn property is set.
        /// </summary>
        internal bool IsSetSourceProjectVersionArn() => this.SourceProjectVersionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the model version.
        /// </para>
        /// </summary>
        public ProjectVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A descriptive message for an error or warning that occurred.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TestingDataResult. 
        /// <para>
        /// Contains information about the testing results.
        /// </para>
        /// </summary>
        public TestingDataResult TestingDataResult { get; set; }

        /// <summary>
        /// Checks to see if the TestingDataResult property is set.
        /// </summary>
        internal bool IsSetTestingDataResult() => this.TestingDataResult != null;

        /// <summary>
        /// Gets and sets the property TrainingDataResult. 
        /// <para>
        /// Contains information about the training results.
        /// </para>
        /// </summary>
        public TrainingDataResult TrainingDataResult { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataResult property is set.
        /// </summary>
        internal bool IsSetTrainingDataResult() => this.TrainingDataResult != null;

        /// <summary>
        /// Gets and sets the property TrainingEndTimestamp. 
        /// <para>
        /// The Unix date and time that training of the model ended.
        /// </para>
        /// </summary>
        public DateTime? TrainingEndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the TrainingEndTimestamp property is set.
        /// </summary>
        internal bool IsSetTrainingEndTimestamp() => this.TrainingEndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A user-provided description of the project version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the VersionDescription property is set.
        /// </summary>
        internal bool IsSetVersionDescription() => this.VersionDescription != null;
    }
}
