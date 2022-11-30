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
    /// This is the response object from the DescribeEndpoint operation.
    /// </summary>
    public partial class DescribeEndpointResponse : AmazonWebServiceResponse
    {
        private AsyncInferenceConfig _asyncInferenceConfig;
        private DateTime? _creationTime;
        private DataCaptureConfigSummary _dataCaptureConfig;
        private string _endpointArn;
        private string _endpointConfigName;
        private string _endpointName;
        private EndpointStatus _endpointStatus;
        private ExplainerConfig _explainerConfig;
        private string _failureReason;
        private DeploymentConfig _lastDeploymentConfig;
        private DateTime? _lastModifiedTime;
        private PendingDeploymentSummary _pendingDeploymentSummary;
        private List<ProductionVariantSummary> _productionVariants = new List<ProductionVariantSummary>();
        private List<ProductionVariantSummary> _shadowProductionVariants = new List<ProductionVariantSummary>();

        /// <summary>
        /// Gets and sets the property AsyncInferenceConfig. 
        /// <para>
        /// Returns the description of an endpoint configuration created using the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpointConfig.html">
        /// <code>CreateEndpointConfig</code> </a> API.
        /// </para>
        /// </summary>
        public AsyncInferenceConfig AsyncInferenceConfig
        {
            get { return this._asyncInferenceConfig; }
            set { this._asyncInferenceConfig = value; }
        }

        // Check to see if AsyncInferenceConfig property is set
        internal bool IsSetAsyncInferenceConfig()
        {
            return this._asyncInferenceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the endpoint was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataCaptureConfig.
        /// </summary>
        public DataCaptureConfigSummary DataCaptureConfig
        {
            get { return this._dataCaptureConfig; }
            set { this._dataCaptureConfig = value; }
        }

        // Check to see if DataCaptureConfig property is set
        internal bool IsSetDataCaptureConfig()
        {
            return this._dataCaptureConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of the endpoint configuration associated with this endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string EndpointConfigName
        {
            get { return this._endpointConfigName; }
            set { this._endpointConfigName = value; }
        }

        // Check to see if EndpointConfigName property is set
        internal bool IsSetEndpointConfigName()
        {
            return this._endpointConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// Name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>OutOfService</code>: Endpoint is not available to take incoming requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Creating</code>: <a>CreateEndpoint</a> is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Updating</code>: <a>UpdateEndpoint</a> or <a>UpdateEndpointWeightsAndCapacities</a>
        /// is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SystemUpdating</code>: Endpoint is undergoing maintenance and cannot be updated
        /// or deleted or re-scaled until it has completed. This maintenance operation does not
        /// change any customer-specified values such as VPC config, KMS encryption, model, instance
        /// type, or instance count.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RollingBack</code>: Endpoint fails to scale up or down or change its variant
        /// weight and is in the process of rolling back to its previous configuration. Once the
        /// rollback completes, endpoint returns to an <code>InService</code> status. This transitional
        /// status only applies to an endpoint that has autoscaling enabled and is undergoing
        /// variant weight or capacity changes as part of an <a>UpdateEndpointWeightsAndCapacities</a>
        /// call or when the <a>UpdateEndpointWeightsAndCapacities</a> operation is called explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InService</code>: Endpoint is available to process incoming requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Deleting</code>: <a>DeleteEndpoint</a> is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code>: Endpoint could not be created, updated, or re-scaled. Use <a>DescribeEndpointOutput$FailureReason</a>
        /// for information about the failure. <a>DeleteEndpoint</a> is the only operation that
        /// can be performed on a failed endpoint.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointStatus EndpointStatus
        {
            get { return this._endpointStatus; }
            set { this._endpointStatus = value; }
        }

        // Check to see if EndpointStatus property is set
        internal bool IsSetEndpointStatus()
        {
            return this._endpointStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ExplainerConfig. 
        /// <para>
        /// The configuration parameters for an explainer.
        /// </para>
        /// </summary>
        public ExplainerConfig ExplainerConfig
        {
            get { return this._explainerConfig; }
            set { this._explainerConfig = value; }
        }

        // Check to see if ExplainerConfig property is set
        internal bool IsSetExplainerConfig()
        {
            return this._explainerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the status of the endpoint is <code>Failed</code>, the reason why it failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastDeploymentConfig. 
        /// <para>
        /// The most recent deployment configuration for the endpoint.
        /// </para>
        /// </summary>
        public DeploymentConfig LastDeploymentConfig
        {
            get { return this._lastDeploymentConfig; }
            set { this._lastDeploymentConfig = value; }
        }

        // Check to see if LastDeploymentConfig property is set
        internal bool IsSetLastDeploymentConfig()
        {
            return this._lastDeploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that shows when the endpoint was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingDeploymentSummary. 
        /// <para>
        /// Returns the summary of an in-progress deployment. This field is only returned when
        /// the endpoint is creating or updating with a new endpoint configuration.
        /// </para>
        /// </summary>
        public PendingDeploymentSummary PendingDeploymentSummary
        {
            get { return this._pendingDeploymentSummary; }
            set { this._pendingDeploymentSummary = value; }
        }

        // Check to see if PendingDeploymentSummary property is set
        internal bool IsSetPendingDeploymentSummary()
        {
            return this._pendingDeploymentSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ProductionVariants. 
        /// <para>
        ///  An array of <a>ProductionVariantSummary</a> objects, one for each model hosted behind
        /// this endpoint. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ProductionVariantSummary> ProductionVariants
        {
            get { return this._productionVariants; }
            set { this._productionVariants = value; }
        }

        // Check to see if ProductionVariants property is set
        internal bool IsSetProductionVariants()
        {
            return this._productionVariants != null && this._productionVariants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ShadowProductionVariants. 
        /// <para>
        ///  Array of <code>ProductionVariant</code> objects. There is one for each model that
        /// you want to host at this endpoint in shadow mode with production traffic replicated
        /// from the model specified on <code>ProductionVariants</code>.If you use this field,
        /// you can only specify one variant for <code>ProductionVariants</code> and one variant
        /// for <code>ShadowProductionVariants</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ProductionVariantSummary> ShadowProductionVariants
        {
            get { return this._shadowProductionVariants; }
            set { this._shadowProductionVariants = value; }
        }

        // Check to see if ShadowProductionVariants property is set
        internal bool IsSetShadowProductionVariants()
        {
            return this._shadowProductionVariants != null && this._shadowProductionVariants.Count > 0; 
        }

    }
}