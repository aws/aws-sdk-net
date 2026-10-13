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
    /// Container for the parameters to the CreateEndpointConfig operation. Creates an endpoint
    /// configuration that SageMaker hosting services uses to deploy models. In the configuration,
    /// you identify one or more models, created using the <c>CreateModel</c> API, to deploy
    /// and the resources that you want SageMaker to provision. Then you call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
    /// API. <note> <para> Use this API if you want to use SageMaker hosting services to deploy
    /// models into production. </para> </note> <para> In the request, you define a <c>ProductionVariant</c>,
    /// for each model that you want to deploy. Each <c>ProductionVariant</c> parameter also
    /// describes the resources that you want SageMaker to provision. This includes the number
    /// and type of ML compute instances to deploy. </para> <para> If you are hosting multiple
    /// models, you also assign a <c>VariantWeight</c> to specify how much traffic you want
    /// to allocate to each model. For example, suppose that you want to host two models,
    /// A and B, and you assign traffic weight 2 for model A and 1 for model B. SageMaker
    /// distributes two-thirds of the traffic to Model A, and one-third to model B. </para>
    /// <note> <para> When you call <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>,
    /// a load call is made to DynamoDB to verify that your endpoint configuration exists.
    /// When you read data from a DynamoDB table supporting <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
    /// <c>Eventually Consistent Reads</c> </a>, the response might not reflect the results
    /// of a recently completed write operation. The response might include some stale data.
    /// If the dependent entities are not yet in DynamoDB, this causes a validation error.
    /// If you repeat your read request after a short time, the response should return the
    /// latest data. So retry logic is recommended to handle these possible issues. We also
    /// recommend that customers call <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeEndpointConfig.html">DescribeEndpointConfig</a>
    /// before calling <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
    /// to minimize the potential impact of a DynamoDB eventually consistent read. </para>
    /// </note>
    /// </summary>
    public partial class CreateEndpointConfigRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AsyncInferenceConfig. 
        /// <para>
        /// Specifies configuration for how an endpoint performs asynchronous inference. This
        /// is a required field in order for your Endpoint to be invoked using <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_runtime_InvokeEndpointAsync.html">InvokeEndpointAsync</a>.
        /// </para>
        /// </summary>
        public AsyncInferenceConfig AsyncInferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the AsyncInferenceConfig property is set.
        /// </summary>
        internal bool IsSetAsyncInferenceConfig() => this.AsyncInferenceConfig != null;

        /// <summary>
        /// Gets and sets the property DataCaptureConfig.
        /// </summary>
        public DataCaptureConfig DataCaptureConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataCaptureConfig property is set.
        /// </summary>
        internal bool IsSetDataCaptureConfig() => this.DataCaptureConfig != null;

        /// <summary>
        /// Gets and sets the property EnableNetworkIsolation. 
        /// <para>
        /// Sets whether all model containers deployed to the endpoint are isolated. If they are,
        /// no inbound or outbound network calls can be made to or from the model containers.
        /// </para>
        /// </summary>
        public bool? EnableNetworkIsolation { get; set; }

        /// <summary>
        /// Checks to see if the EnableNetworkIsolation property is set.
        /// </summary>
        internal bool IsSetEnableNetworkIsolation() => this.EnableNetworkIsolation.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of the endpoint configuration. You specify this name in a <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
        /// request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string EndpointConfigName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfigName property is set.
        /// </summary>
        internal bool IsSetEndpointConfigName() => this.EndpointConfigName != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker AI can assume
        /// to perform actions on your behalf. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">SageMaker
        /// AI Roles</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to pass this role to Amazon SageMaker AI, the caller of this action must
        /// have the <c>iam:PassRole</c> permission.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property ExplainerConfig. 
        /// <para>
        /// A member of <c>CreateEndpointConfig</c> that enables explainers.
        /// </para>
        /// </summary>
        public ExplainerConfig ExplainerConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExplainerConfig property is set.
        /// </summary>
        internal bool IsSetExplainerConfig() => this.ExplainerConfig != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Amazon Web Services Key Management Service key
        /// that SageMaker uses to encrypt data on the storage volume attached to the ML compute
        /// instance that hosts the endpoint.
        /// </para>
        ///  
        /// <para>
        /// The KmsKeyId can be any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <c>alias/ExampleAlias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name ARN: <c>arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The KMS key policy must grant permission to the IAM role that you specify in your
        /// <c>CreateEndpoint</c>, <c>UpdateEndpoint</c> requests. For more information, refer
        /// to the Amazon Web Services Key Management Service section<a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">
        /// Using Key Policies in Amazon Web Services KMS </a> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Certain Nitro-based instances include local storage, dependent on the instance type.
        /// Local storage volumes are encrypted using a hardware module on the instance. If any
        /// of the models that you specify in the <c>ProductionVariants</c> parameter use nitro-based
        /// instances with local storage, the <c>KmsKeyId</c> parameter does not encrypt instance
        /// local storage.
        /// </para>
        ///  
        /// <para>
        /// For a list of instance types that support local instance storage, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html#instance-store-volumes">Instance
        /// Store Volumes</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about local instance storage encryption, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ssd-instance-store.html">SSD
        /// Instance Store Volumes</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MetricsConfig. 
        /// <para>
        /// The configuration parameters for utilization metrics.
        /// </para>
        /// </summary>
        public MetricsConfig MetricsConfig { get; set; }

        /// <summary>
        /// Checks to see if the MetricsConfig property is set.
        /// </summary>
        internal bool IsSetMetricsConfig() => this.MetricsConfig != null;

        /// <summary>
        /// Gets and sets the property ProductionVariants. 
        /// <para>
        /// An array of <c>ProductionVariant</c> objects, one for each model that you want to
        /// host at this endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<ProductionVariant> ProductionVariants { get; set; } = AWSConfigs.InitializeCollections ? new List<ProductionVariant>() : null;

        /// <summary>
        /// Checks to see if the ProductionVariants property is set.
        /// </summary>
        internal bool IsSetProductionVariants() => this.ProductionVariants != null && (this.ProductionVariants.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShadowProductionVariants. 
        /// <para>
        /// An array of <c>ProductionVariant</c> objects, one for each model that you want to
        /// host at this endpoint in shadow mode with production traffic replicated from the model
        /// specified on <c>ProductionVariants</c>. If you use this field, you can only specify
        /// one variant for <c>ProductionVariants</c> and one variant for <c>ShadowProductionVariants</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ProductionVariant> ShadowProductionVariants { get; set; } = AWSConfigs.InitializeCollections ? new List<ProductionVariant>() : null;

        /// <summary>
        /// Checks to see if the ShadowProductionVariants property is set.
        /// </summary>
        internal bool IsSetShadowProductionVariants() => this.ShadowProductionVariants != null && (this.ShadowProductionVariants.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcConfig.
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
