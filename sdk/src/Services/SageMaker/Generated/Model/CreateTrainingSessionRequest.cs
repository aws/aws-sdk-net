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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrainingSession operation.
    /// Creates a training session in Amazon SageMaker. A training session provisions compute
    /// resources for fine-tuning a foundation model using Low-Rank Adaptation (LoRA). After
    /// the session is created, you can submit training operations and sample inference requests
    /// through the Amazon SageMaker Training Session Runtime API.
    /// 
    ///  
    /// <para>
    /// The following operations are related to <c>CreateTrainingSession</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>DescribeTrainingSession</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListTrainingSessions</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StopTrainingSession</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteTrainingSession</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateTrainingSessionRequest : AmazonSageMakerRequest
    {
        private LoraConfig _loraConfig;
        private TrainingSessionModelConfig _modelConfig;
        private string _modelPackageGroupArn;
        private TrainingSessionOutputConfig _outputConfig;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _trainingSessionName;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property LoraConfig. 
        /// <para>
        /// The Low-Rank Adaptation (LoRA) configuration for the training session, including the
        /// rank and alpha parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LoraConfig LoraConfig
        {
            get { return this._loraConfig; }
            set { this._loraConfig = value; }
        }

        // Check to see if LoraConfig property is set
        internal bool IsSetLoraConfig()
        {
            return this._loraConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelConfig. 
        /// <para>
        /// The configuration for the base model, including the model ARN and end-user license
        /// agreement (EULA) acceptance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingSessionModelConfig ModelConfig
        {
            get { return this._modelConfig; }
            set { this._modelConfig = value; }
        }

        // Check to see if ModelConfig property is set
        internal bool IsSetModelConfig()
        {
            return this._modelConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package group where checkpoints and fine-tuned
        /// model artifacts are published.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ModelPackageGroupArn
        {
            get { return this._modelPackageGroupArn; }
            set { this._modelPackageGroupArn = value; }
        }

        // Check to see if ModelPackageGroupArn property is set
        internal bool IsSetModelPackageGroupArn()
        {
            return this._modelPackageGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for the training session, including the S3 location and optional
        /// encryption settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingSessionOutputConfig OutputConfig
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker assumes to access
        /// resources on your behalf. The role must have permissions to access the output S3 path
        /// and model package group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs to apply to the training session as tags. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainingSessionName. 
        /// <para>
        /// The name of the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string TrainingSessionName
        {
            get { return this._trainingSessionName; }
            set { this._trainingSessionName = value; }
        }

        // Check to see if TrainingSessionName property is set
        internal bool IsSetTrainingSessionName()
        {
            return this._trainingSessionName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The Virtual Private Cloud (VPC) configuration for the training session. Specify subnets
        /// and security groups to run the training session in your VPC.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}