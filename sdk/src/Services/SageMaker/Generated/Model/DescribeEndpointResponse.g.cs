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
    /// This is the response object from the DescribeEndpoint operation.
    /// </summary>
    public partial class DescribeEndpointResponse : AmazonWebServiceResponse
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
        /// A timestamp that shows when the endpoint was created.
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
        public DataCaptureConfigSummary DataCaptureConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataCaptureConfig property is set.
        /// </summary>
        internal bool IsSetDataCaptureConfig() => this.DataCaptureConfig != null;

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of the endpoint configuration associated with this endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string EndpointConfigName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfigName property is set.
        /// </summary>
        internal bool IsSetEndpointConfigName() => this.EndpointConfigName != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// Name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OutOfService</c>: Endpoint is not available to take incoming requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Creating</c>: <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
        /// is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Updating</c>: <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpoint.html">UpdateEndpoint</a>
        /// or <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpointWeightsAndCapacities.html">UpdateEndpointWeightsAndCapacities</a>
        /// is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SystemUpdating</c>: Endpoint is undergoing maintenance and cannot be updated or
        /// deleted or re-scaled until it has completed. This maintenance operation does not change
        /// any customer-specified values such as VPC config, KMS encryption, model, instance
        /// type, or instance count.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RollingBack</c>: Endpoint fails to scale up or down or change its variant weight
        /// and is in the process of rolling back to its previous configuration. Once the rollback
        /// completes, endpoint returns to an <c>InService</c> status. This transitional status
        /// only applies to an endpoint that has autoscaling enabled and is undergoing variant
        /// weight or capacity changes as part of an <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpointWeightsAndCapacities.html">UpdateEndpointWeightsAndCapacities</a>
        /// call or when the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateEndpointWeightsAndCapacities.html">UpdateEndpointWeightsAndCapacities</a>
        /// operation is called explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InService</c>: Endpoint is available to process incoming requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleting</c>: <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteEndpoint.html">DeleteEndpoint</a>
        /// is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: Endpoint could not be created, updated, or re-scaled. Use the <c>FailureReason</c>
        /// value returned by <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeEndpoint.html">DescribeEndpoint</a>
        /// for information about the failure. <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteEndpoint.html">DeleteEndpoint</a>
        /// is the only operation that can be performed on a failed endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UpdateRollbackFailed</c>: Both the rolling deployment and auto-rollback failed.
        /// Your endpoint is in service with a mix of the old and new endpoint configurations.
        /// For information about how to remedy this issue and restore the endpoint's status to
        /// <c>InService</c>, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/deployment-guardrails-rolling.html">Rolling
        /// Deployments</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointStatus EndpointStatus { get; set; }

        /// <summary>
        /// Checks to see if the EndpointStatus property is set.
        /// </summary>
        internal bool IsSetEndpointStatus() => this.EndpointStatus != null;

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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the status of the endpoint is <c>Failed</c>, the reason why it failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastDeploymentConfig. 
        /// <para>
        /// The most recent deployment configuration for the endpoint.
        /// </para>
        /// </summary>
        public DeploymentConfig LastDeploymentConfig { get; set; }

        /// <summary>
        /// Checks to see if the LastDeploymentConfig property is set.
        /// </summary>
        internal bool IsSetLastDeploymentConfig() => this.LastDeploymentConfig != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that shows when the endpoint was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

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
        /// Gets and sets the property PendingDeploymentSummary. 
        /// <para>
        /// Returns the summary of an in-progress deployment. This field is only returned when
        /// the endpoint is creating or updating with a new endpoint configuration.
        /// </para>
        /// </summary>
        public PendingDeploymentSummary PendingDeploymentSummary { get; set; }

        /// <summary>
        /// Checks to see if the PendingDeploymentSummary property is set.
        /// </summary>
        internal bool IsSetPendingDeploymentSummary() => this.PendingDeploymentSummary != null;

        /// <summary>
        /// Gets and sets the property ProductionVariants. 
        /// <para>
        /// An array of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ProductionVariantSummary.html">ProductionVariantSummary</a>
        /// objects, one for each model hosted behind this endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ProductionVariantSummary> ProductionVariants { get; set; } = AWSConfigs.InitializeCollections ? new List<ProductionVariantSummary>() : null;

        /// <summary>
        /// Checks to see if the ProductionVariants property is set.
        /// </summary>
        internal bool IsSetProductionVariants() => this.ProductionVariants != null && (this.ProductionVariants.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShadowProductionVariants. 
        /// <para>
        /// An array of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ProductionVariantSummary.html">ProductionVariantSummary</a>
        /// objects, one for each model that you want to host at this endpoint in shadow mode
        /// with production traffic replicated from the model specified on <c>ProductionVariants</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ProductionVariantSummary> ShadowProductionVariants { get; set; } = AWSConfigs.InitializeCollections ? new List<ProductionVariantSummary>() : null;

        /// <summary>
        /// Checks to see if the ShadowProductionVariants property is set.
        /// </summary>
        internal bool IsSetShadowProductionVariants() => this.ShadowProductionVariants != null && (this.ShadowProductionVariants.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
