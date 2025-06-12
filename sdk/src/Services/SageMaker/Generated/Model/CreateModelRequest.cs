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
    /// Container for the parameters to the CreateModel operation.
    /// Creates a model in SageMaker. In the request, you name the model and describe a primary
    /// container. For the primary container, you specify the Docker image that contains inference
    /// code, artifacts (from prior training), and a custom environment map that the inference
    /// code uses when you deploy the model for predictions.
    /// 
    ///  
    /// <para>
    /// Use this API to create a model if you want to use SageMaker hosting services or run
    /// a batch transform job.
    /// </para>
    ///  
    /// <para>
    /// To host your model, you create an endpoint configuration with the <c>CreateEndpointConfig</c>
    /// API, and then create an endpoint with the <c>CreateEndpoint</c> API. SageMaker then
    /// deploys all of the containers that you defined for the model in the hosting environment.
    /// 
    /// </para>
    ///  
    /// <para>
    /// To run a batch transform using your model, you start a job with the <c>CreateTransformJob</c>
    /// API. SageMaker uses your model and your dataset to get inferences which are then saved
    /// to a specified S3 location.
    /// </para>
    ///  
    /// <para>
    /// In the request, you also provide an IAM role that SageMaker can assume to access model
    /// artifacts and docker image for deployment on ML compute hosting instances or for batch
    /// transform jobs. In addition, you also use the IAM role to manage permissions the inference
    /// code needs. For example, if the inference code access any other Amazon Web Services
    /// resources, you grant necessary permissions via this role.
    /// </para>
    /// </summary>
    public partial class CreateModelRequest : AmazonSageMakerRequest
    {
        private List<ContainerDefinition> _containers = AWSConfigs.InitializeCollections ? new List<ContainerDefinition>() : null;
        private bool? _enableNetworkIsolation;
        private string _executionRoleArn;
        private InferenceExecutionConfig _inferenceExecutionConfig;
        private string _modelName;
        private ContainerDefinition _primaryContainer;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// Specifies the containers in the inference pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public List<ContainerDefinition> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers != null && (this._containers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnableNetworkIsolation. 
        /// <para>
        /// Isolates the model container. No inbound or outbound network calls can be made to
        /// or from the model container.
        /// </para>
        /// </summary>
        public bool? EnableNetworkIsolation
        {
            get { return this._enableNetworkIsolation; }
            set { this._enableNetworkIsolation = value; }
        }

        // Check to see if EnableNetworkIsolation property is set
        internal bool IsSetEnableNetworkIsolation()
        {
            return this._enableNetworkIsolation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that SageMaker can assume to access
        /// model artifacts and docker image for deployment on ML compute instances or for batch
        /// transform jobs. Deploying on ML compute instances is part of model hosting. For more
        /// information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">SageMaker
        /// Roles</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to pass this role to SageMaker, the caller of this API must have the <c>iam:PassRole</c>
        /// permission.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceExecutionConfig. 
        /// <para>
        /// Specifies details of how containers in a multi-container endpoint are called.
        /// </para>
        /// </summary>
        public InferenceExecutionConfig InferenceExecutionConfig
        {
            get { return this._inferenceExecutionConfig; }
            set { this._inferenceExecutionConfig = value; }
        }

        // Check to see if InferenceExecutionConfig property is set
        internal bool IsSetInferenceExecutionConfig()
        {
            return this._inferenceExecutionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the new model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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
        /// Gets and sets the property PrimaryContainer. 
        /// <para>
        /// The location of the primary docker image containing inference code, associated artifacts,
        /// and custom environment map that the inference code uses when the model is deployed
        /// for predictions. 
        /// </para>
        /// </summary>
        public ContainerDefinition PrimaryContainer
        {
            get { return this._primaryContainer; }
            set { this._primaryContainer = value; }
        }

        // Check to see if PrimaryContainer property is set
        internal bool IsSetPrimaryContainer()
        {
            return this._primaryContainer != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
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
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html">VpcConfig</a>
        /// object that specifies the VPC that you want your model to connect to. Control access
        /// to and from your model container by configuring the VPC. <c>VpcConfig</c> is used
        /// in hosting services and in batch transform. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/host-vpc.html">Protect
        /// Endpoints by Using an Amazon Virtual Private Cloud</a> and <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-vpc.html">Protect
        /// Data in Batch Transform Jobs by Using an Amazon Virtual Private Cloud</a>.
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