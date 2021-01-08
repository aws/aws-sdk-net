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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateModel operation.
    /// Creates a model in Amazon SageMaker. In the request, you name the model and describe
    /// a primary container. For the primary container, you specify the Docker image that
    /// contains inference code, artifacts (from prior training), and a custom environment
    /// map that the inference code uses when you deploy the model for predictions.
    /// 
    ///  
    /// <para>
    /// Use this API to create a model if you want to use Amazon SageMaker hosting services
    /// or run a batch transform job.
    /// </para>
    ///  
    /// <para>
    /// To host your model, you create an endpoint configuration with the <code>CreateEndpointConfig</code>
    /// API, and then create an endpoint with the <code>CreateEndpoint</code> API. Amazon
    /// SageMaker then deploys all of the containers that you defined for the model in the
    /// hosting environment. 
    /// </para>
    ///  
    /// <para>
    /// For an example that calls this method when deploying a model to Amazon SageMaker hosting
    /// services, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/ex1-deploy-model.html#ex1-deploy-model-boto">Deploy
    /// the Model to Amazon SageMaker Hosting Services (AWS SDK for Python (Boto 3)).</a>
    /// 
    /// </para>
    ///  
    /// <para>
    /// To run a batch transform using your model, you start a job with the <code>CreateTransformJob</code>
    /// API. Amazon SageMaker uses your model and your dataset to get inferences which are
    /// then saved to a specified S3 location.
    /// </para>
    ///  
    /// <para>
    /// In the <code>CreateModel</code> request, you must define a container with the <code>PrimaryContainer</code>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// In the request, you also provide an IAM role that Amazon SageMaker can assume to access
    /// model artifacts and docker image for deployment on ML compute hosting instances or
    /// for batch transform jobs. In addition, you also use the IAM role to manage permissions
    /// the inference code needs. For example, if the inference code access any other AWS
    /// resources, you grant necessary permissions via this role.
    /// </para>
    /// </summary>
    public partial class CreateModelRequest : AmazonSageMakerRequest
    {
        private List<ContainerDefinition> _containers = new List<ContainerDefinition>();
        private bool? _enableNetworkIsolation;
        private string _executionRoleArn;
        private string _modelName;
        private ContainerDefinition _primaryContainer;
        private List<Tag> _tags = new List<Tag>();
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// Specifies the containers in the inference pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<ContainerDefinition> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers != null && this._containers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableNetworkIsolation. 
        /// <para>
        /// Isolates the model container. No inbound or outbound network calls can be made to
        /// or from the model container.
        /// </para>
        /// </summary>
        public bool EnableNetworkIsolation
        {
            get { return this._enableNetworkIsolation.GetValueOrDefault(); }
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
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker can assume to
        /// access model artifacts and docker image for deployment on ML compute instances or
        /// for batch transform jobs. Deploying on ML compute instances is part of model hosting.
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">Amazon
        /// SageMaker Roles</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to pass this role to Amazon SageMaker, the caller of this API must have
        /// the <code>iam:PassRole</code> permission.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the new model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// An array of key-value pairs. You can use tags to categorize your AWS resources in
        /// different ways, for example, by purpose, owner, or environment. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a>.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A <a>VpcConfig</a> object that specifies the VPC that you want your model to connect
        /// to. Control access to and from your model container by configuring the VPC. <code>VpcConfig</code>
        /// is used in hosting services and in batch transform. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/host-vpc.html">Protect
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