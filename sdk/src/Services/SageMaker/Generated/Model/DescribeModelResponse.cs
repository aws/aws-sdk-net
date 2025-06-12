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
    /// This is the response object from the DescribeModel operation.
    /// </summary>
    public partial class DescribeModelResponse : AmazonWebServiceResponse
    {
        private List<ContainerDefinition> _containers = AWSConfigs.InitializeCollections ? new List<ContainerDefinition>() : null;
        private DateTime? _creationTime;
        private DeploymentRecommendation _deploymentRecommendation;
        private bool? _enableNetworkIsolation;
        private string _executionRoleArn;
        private InferenceExecutionConfig _inferenceExecutionConfig;
        private string _modelArn;
        private string _modelName;
        private ContainerDefinition _primaryContainer;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The containers in the inference pipeline.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the model was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentRecommendation. 
        /// <para>
        /// A set of recommended deployment configurations for the model.
        /// </para>
        /// </summary>
        public DeploymentRecommendation DeploymentRecommendation
        {
            get { return this._deploymentRecommendation; }
            set { this._deploymentRecommendation = value; }
        }

        // Check to see if DeploymentRecommendation property is set
        internal bool IsSetDeploymentRecommendation()
        {
            return this._deploymentRecommendation != null;
        }

        /// <summary>
        /// Gets and sets the property EnableNetworkIsolation. 
        /// <para>
        /// If <c>True</c>, no inbound or outbound network calls can be made to or from the model
        /// container.
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
        /// The Amazon Resource Name (ARN) of the IAM role that you specified for the model.
        /// </para>
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
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Name of the SageMaker model.
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
        /// The location of the primary inference code, associated artifacts, and custom environment
        /// map that the inference code uses when it is deployed in production. 
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
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html">VpcConfig</a>
        /// object that specifies the VPC that this model has access to. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/host-vpc.html">Protect
        /// Endpoints by Using an Amazon Virtual Private Cloud</a> 
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