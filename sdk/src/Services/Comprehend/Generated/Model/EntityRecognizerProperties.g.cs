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
    /// Describes information about an entity recognizer.
    /// </summary>
    public partial class EntityRecognizerProperties
    {
        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role that grants Amazon Comprehend read
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the recognizer creation completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EntityRecognizerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the entity recognizer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EntityRecognizerArn { get; set; }

        /// <summary>
        /// Checks to see if the EntityRecognizerArn property is set.
        /// </summary>
        internal bool IsSetEntityRecognizerArn() => this.EntityRecognizerArn != null;

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
        /// The input data properties of an entity recognizer.
        /// </para>
        /// </summary>
        public EntityRecognizerInputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        ///  The language of the input documents. All documents must be in the same language.
        /// Only English ("en") is currently supported.
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
        ///  A description of the status of the recognizer.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

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
        /// Output data configuration.
        /// </para>
        /// </summary>
        public EntityRecognizerOutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property RecognizerMetadata. 
        /// <para>
        ///  Provides information about an entity recognizer.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public EntityRecognizerMetadata RecognizerMetadata { get; set; }

        /// <summary>
        /// Checks to see if the RecognizerMetadata property is set.
        /// </summary>
        internal bool IsSetRecognizerMetadata() => this.RecognizerMetadata != null;

        /// <summary>
        /// Gets and sets the property SourceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source model. This model was imported from a
        /// different Amazon Web Services account to create the entity recognizer model in your
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
        /// Provides the status of the entity recognizer.
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
        /// The time that the recognizer was submitted for processing.
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
        /// The time that training of the entity recognizer was completed.
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
        /// The time that training of the entity recognizer started.
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
        /// The version name you assigned to the entity recognizer.
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
        /// resources you are using for your custom entity recognizer. For more information, see
        /// <a href="https://docs.aws.amazon.com/vpc/latest/userguide/what-is-amazon-vpc.html">Amazon
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
