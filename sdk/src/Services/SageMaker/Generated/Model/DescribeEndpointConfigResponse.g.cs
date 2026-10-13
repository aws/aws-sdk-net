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
    /// This is the response object from the DescribeEndpointConfig operation.
    /// </summary>
    public partial class DescribeEndpointConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AsyncInferenceConfig. 
        /// <para>
        /// Returns the description of an endpoint configuration created using the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpointConfig.html">
        /// <c>CreateEndpointConfig</c> </a> API.
        /// </para>
        /// </summary>
        public AsyncInferenceConfig AsyncInferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the AsyncInferenceConfig property is set.
        /// </summary>
        internal bool IsSetAsyncInferenceConfig() => this.AsyncInferenceConfig != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the endpoint configuration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        /// Indicates whether all model containers deployed to the endpoint are isolated. If they
        /// are, no inbound or outbound network calls can be made to or from the model containers.
        /// </para>
        /// </summary>
        public bool? EnableNetworkIsolation { get; set; }

        /// <summary>
        /// Checks to see if the EnableNetworkIsolation property is set.
        /// </summary>
        internal bool IsSetEnableNetworkIsolation() => this.EnableNetworkIsolation.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string EndpointConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfigArn property is set.
        /// </summary>
        internal bool IsSetEndpointConfigArn() => this.EndpointConfigArn != null;

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// Name of the SageMaker endpoint configuration.
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
        /// The Amazon Resource Name (ARN) of the IAM role that you assigned to the endpoint configuration.
        /// </para>
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
        /// The configuration parameters for an explainer.
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
        /// Amazon Web Services KMS key ID Amazon SageMaker uses to encrypt data when storing
        /// it on the ML storage volume attached to the instance.
        /// </para>
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
        /// specified on <c>ProductionVariants</c>.
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
        /// Gets and sets the property VpcConfig.
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
