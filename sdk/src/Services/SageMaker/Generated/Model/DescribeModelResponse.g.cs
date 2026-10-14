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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeModel operation.
    /// </summary>
    public partial class DescribeModelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The containers in the inference pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public List<ContainerDefinition> Containers { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerDefinition>() : null;

        /// <summary>
        /// Checks to see if the Containers property is set.
        /// </summary>
        internal bool IsSetContainers() => this.Containers != null && (this.Containers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the model was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentRecommendation. 
        /// <para>
        /// A set of recommended deployment configurations for the model.
        /// </para>
        /// </summary>
        public DeploymentRecommendation DeploymentRecommendation { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentRecommendation property is set.
        /// </summary>
        internal bool IsSetDeploymentRecommendation() => this.DeploymentRecommendation != null;

        /// <summary>
        /// Gets and sets the property EnableNetworkIsolation. 
        /// <para>
        /// If <c>True</c>, no inbound or outbound network calls can be made to or from the model
        /// container.
        /// </para>
        /// </summary>
        public bool? EnableNetworkIsolation { get; set; }

        /// <summary>
        /// Checks to see if the EnableNetworkIsolation property is set.
        /// </summary>
        internal bool IsSetEnableNetworkIsolation() => this.EnableNetworkIsolation.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that you specified for the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property InferenceExecutionConfig. 
        /// <para>
        /// Specifies details of how containers in a multi-container endpoint are called.
        /// </para>
        /// </summary>
        public InferenceExecutionConfig InferenceExecutionConfig { get; set; }

        /// <summary>
        /// Checks to see if the InferenceExecutionConfig property is set.
        /// </summary>
        internal bool IsSetInferenceExecutionConfig() => this.InferenceExecutionConfig != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// Name of the SageMaker model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property PrimaryContainer. 
        /// <para>
        /// The location of the primary inference code, associated artifacts, and custom environment
        /// map that the inference code uses when it is deployed in production. 
        /// </para>
        /// </summary>
        public ContainerDefinition PrimaryContainer { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryContainer property is set.
        /// </summary>
        internal bool IsSetPrimaryContainer() => this.PrimaryContainer != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html">VpcConfig</a>
        /// object that specifies the VPC that this model has access to. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/host-vpc.html">Protect
        /// Endpoints by Using an Amazon Virtual Private Cloud</a> 
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
