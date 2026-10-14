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
    /// Provides information about a document classifier.
    /// </summary>
    public partial class DocumentClassifierProperties
    {
        /// <summary>
        /// Gets and sets the property ClassifierMetadata. 
        /// <para>
        /// Information about the document classifier, including the number of documents used
        /// for training the classifier, the number of documents used for test the classifier,
        /// and an accuracy rating.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ClassifierMetadata ClassifierMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ClassifierMetadata property is set.
        /// </summary>
        internal bool IsSetClassifierMetadata() => this.ClassifierMetadata != null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon Comprehend read
        /// access to your input data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DocumentClassifierArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the document classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DocumentClassifierArn { get; set; }

        /// <summary>
        /// Checks to see if the DocumentClassifierArn property is set.
        /// </summary>
        internal bool IsSetDocumentClassifierArn() => this.DocumentClassifierArn != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that training the document classifier completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the flywheel
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FlywheelArn { get; set; }

        /// <summary>
        /// Checks to see if the FlywheelArn property is set.
        /// </summary>
        internal bool IsSetFlywheelArn() => this.FlywheelArn != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The input data configuration that you supplied when you created the document classifier
        /// for training.
        /// </para>
        /// </summary>
        public DocumentClassifierInputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code for the language of the documents that the classifier was trained
        /// on.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Additional information about the status of the classifier.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Indicates the mode in which the specific classifier was trained. This also indicates
        /// the format of input documents and the format of the confusion matrix. Each classifier
        /// can only be trained in one mode and this cannot be changed once the classifier is
        /// trained.
        /// </para>
        /// </summary>
        public DocumentClassifierMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property ModelKmsKeyId. 
        /// <para>
        /// ID for the KMS key that Amazon Comprehend uses to encrypt trained custom models. The
        /// ModelKmsKeyId can be either of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID: <c>"1234abcd-12ab-34cd-56ef-1234567890ab"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key: <c>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ModelKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ModelKmsKeyId property is set.
        /// </summary>
        internal bool IsSetModelKmsKeyId() => this.ModelKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        ///  Provides output results configuration parameters for custom classifier jobs.
        /// </para>
        /// </summary>
        public DocumentClassifierOutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property SourceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source model. This model was imported from a
        /// different Amazon Web Services account to create the document classifier model in your
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SourceModelArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceModelArn property is set.
        /// </summary>
        internal bool IsSetSourceModelArn() => this.SourceModelArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the document classifier. If the status is <c>TRAINED</c> the classifier
        /// is ready to use. If the status is <c>TRAINED_WITH_WARNINGS</c> the classifier training
        /// succeeded, but you should review the warnings returned in the <c>CreateDocumentClassifier</c>
        /// response.
        /// </para>
        ///  
        /// <para>
        ///  If the status is <c>FAILED</c> you can see additional information about why the classifier
        /// wasn't trained in the <c>Message</c> field.
        /// </para>
        /// </summary>
        public ModelStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The time that the document classifier was submitted for training.
        /// </para>
        /// </summary>
        public DateTime? SubmitTime { get; set; }

        /// <summary>
        /// Checks to see if the SubmitTime property is set.
        /// </summary>
        internal bool IsSetSubmitTime() => this.SubmitTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingEndTime. 
        /// <para>
        /// The time that training of the document classifier was completed. Indicates the time
        /// when the training completes on documentation classifiers. You are billed for the time
        /// interval between this time and the value of TrainingStartTime.
        /// </para>
        /// </summary>
        public DateTime? TrainingEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingEndTime property is set.
        /// </summary>
        internal bool IsSetTrainingEndTime() => this.TrainingEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingStartTime. 
        /// <para>
        /// Indicates the time when the training starts on documentation classifiers. You are
        /// billed for the time interval between this time and the value of TrainingEndTime. 
        /// </para>
        /// </summary>
        public DateTime? TrainingStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingStartTime property is set.
        /// </summary>
        internal bool IsSetTrainingStartTime() => this.TrainingStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version name that you assigned to the document classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;

        /// <summary>
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// ID for the Amazon Web Services Key Management Service (KMS) key that Amazon Comprehend
        /// uses to encrypt data on the storage volume attached to the ML compute instance(s)
        /// that process the analysis job. The VolumeKmsKeyId can be either of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID: <c>"1234abcd-12ab-34cd-56ef-1234567890ab"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key: <c>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string VolumeKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeKmsKeyId property is set.
        /// </summary>
        internal bool IsSetVolumeKmsKeyId() => this.VolumeKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        ///  Configuration parameters for a private Virtual Private Cloud (VPC) containing the
        /// resources you are using for your custom classifier. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/what-is-amazon-vpc.html">Amazon
        /// VPC</a>. 
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
