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
    /// Container for the parameters to the CreateProjectVersion operation. Creates a new
    /// version of Amazon Rekognition project (like a Custom Labels model or a custom adapter)
    /// and begins training. Models and adapters are managed as part of a Rekognition project.
    /// The response from <c>CreateProjectVersion</c> is an Amazon Resource Name (ARN) for
    /// the project version. <para> The FeatureConfig operation argument allows you to configure
    /// specific model or adapter settings. You can provide a description to the project version
    /// by using the VersionDescription argment. Training can take a while to complete. You
    /// can get the current status by calling <a>DescribeProjectVersions</a>. Training completed
    /// successfully if the value of the <c>Status</c> field is <c>TRAINING_COMPLETED</c>.
    /// Once training has successfully completed, call <a>DescribeProjectVersions</a> to get
    /// the training results and evaluate the model. </para> <para> This operation requires
    /// permissions to perform the <c>rekognition:CreateProjectVersion</c> action. </para>
    /// <note> <para> <i>The following applies only to projects with Amazon Rekognition Custom
    /// Labels as the chosen feature:</i> </para> <para> You can train a model in a project
    /// that doesn't have associated datasets by specifying manifest files in the <c>TrainingData</c>
    /// and <c>TestingData</c> fields. </para> <para> If you open the console after training
    /// a model with manifest files, Amazon Rekognition Custom Labels creates the datasets
    /// for you using the most recent manifest files. You can no longer train a model version
    /// for the project by specifying manifest files. </para> <para> Instead of training with
    /// a project without associated datasets, we recommend that you use the manifest files
    /// to create training and test datasets for the project. </para> </note> <para> </para>
    /// </summary>
    public partial class CreateProjectVersionRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property FeatureConfig. 
        /// <para>
        /// Feature-specific configuration of the training job. If the job configuration does
        /// not match the feature type associated with the project, an InvalidParameterException
        /// is returned.
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
        /// The identifier for your AWS Key Management Service key (AWS KMS key). You can supply
        /// the Amazon Resource Name (ARN) of your KMS key, the ID of your KMS key, an alias for
        /// your KMS key, or an alias ARN. The key is used to encrypt training images, test images,
        /// and manifest files copied into the service for the project version. Your source images
        /// are unaffected. The key is also used to encrypt training results and manifest files
        /// written to the output Amazon S3 bucket (<c>OutputConfig</c>).
        /// </para>
        ///  
        /// <para>
        /// If you choose to use your own KMS key, you need the following permissions on the KMS
        /// key.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// kms:CreateGrant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:DescribeKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:GenerateDataKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:Decrypt
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value for <c>KmsKeyId</c>, images copied into the service are
        /// encrypted using a key that AWS owns and manages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The Amazon S3 bucket location to store the results of training. The bucket can be
        /// any S3 bucket in your AWS account. You need <c>s3:PutObject</c> permission on the
        /// bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN of the Amazon Rekognition project that will manage the project version you
        /// want to train.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A set of tags (key-value pairs) that you want to attach to the project version. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TestingData. 
        /// <para>
        /// Specifies an external manifest that the service uses to test the project version.
        /// If you specify <c>TestingData</c> you must also specify <c>TrainingData</c>. The project
        /// must not have any associated datasets.
        /// </para>
        /// </summary>
        public TestingData TestingData { get; set; }

        /// <summary>
        /// Checks to see if the TestingData property is set.
        /// </summary>
        internal bool IsSetTestingData() => this.TestingData != null;

        /// <summary>
        /// Gets and sets the property TrainingData. 
        /// <para>
        /// Specifies an external manifest that the services uses to train the project version.
        /// If you specify <c>TrainingData</c> you must also specify <c>TestingData</c>. The project
        /// must not have any associated datasets. 
        /// </para>
        /// </summary>
        public TrainingData TrainingData { get; set; }

        /// <summary>
        /// Checks to see if the TrainingData property is set.
        /// </summary>
        internal bool IsSetTrainingData() => this.TrainingData != null;

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description applied to the project version being created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the VersionDescription property is set.
        /// </summary>
        internal bool IsSetVersionDescription() => this.VersionDescription != null;

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// A name for the version of the project version. This value must be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;
    }
}
