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
    /// This is the response object from the DescribeEndpointConfig operation.
    /// </summary>
    public partial class DescribeEndpointConfigResponse : AmazonWebServiceResponse
    {
        private AsyncInferenceConfig _asyncInferenceConfig;
        private DateTime? _creationTime;
        private DataCaptureConfig _dataCaptureConfig;
        private bool? _enableNetworkIsolation;
        private string _endpointConfigArn;
        private string _endpointConfigName;
        private string _executionRoleArn;
        private ExplainerConfig _explainerConfig;
        private string _kmsKeyId;
        private List<ProductionVariant> _productionVariants = AWSConfigs.InitializeCollections ? new List<ProductionVariant>() : null;
        private List<ProductionVariant> _shadowProductionVariants = AWSConfigs.InitializeCollections ? new List<ProductionVariant>() : null;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property AsyncInferenceConfig. 
        /// <para>
        /// Returns the description of an endpoint configuration created using the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpointConfig.html">
        /// <c>CreateEndpointConfig</c> </a> API.
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
        /// A timestamp that shows when the endpoint configuration was created.
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
        /// Gets and sets the property DataCaptureConfig.
        /// </summary>
        public DataCaptureConfig DataCaptureConfig
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
        /// Gets and sets the property EnableNetworkIsolation. 
        /// <para>
        /// Indicates whether all model containers deployed to the endpoint are isolated. If they
        /// are, no inbound or outbound network calls can be made to or from the model containers.
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
        /// Gets and sets the property EndpointConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EndpointConfigArn
        {
            get { return this._endpointConfigArn; }
            set { this._endpointConfigArn = value; }
        }

        // Check to see if EndpointConfigArn property is set
        internal bool IsSetEndpointConfigArn()
        {
            return this._endpointConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// Name of the SageMaker endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that you assigned to the endpoint configuration.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Amazon Web Services KMS key ID Amazon SageMaker uses to encrypt data when storing
        /// it on the ML storage volume attached to the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductionVariants. 
        /// <para>
        /// An array of <c>ProductionVariant</c> objects, one for each model that you want to
        /// host at this endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<ProductionVariant> ProductionVariants
        {
            get { return this._productionVariants; }
            set { this._productionVariants = value; }
        }

        // Check to see if ProductionVariants property is set
        internal bool IsSetProductionVariants()
        {
            return this._productionVariants != null && (this._productionVariants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ShadowProductionVariants. 
        /// <para>
        /// An array of <c>ProductionVariant</c> objects, one for each model that you want to
        /// host at this endpoint in shadow mode with production traffic replicated from the model
        /// specified on <c>ProductionVariants</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ProductionVariant> ShadowProductionVariants
        {
            get { return this._shadowProductionVariants; }
            set { this._shadowProductionVariants = value; }
        }

        // Check to see if ShadowProductionVariants property is set
        internal bool IsSetShadowProductionVariants()
        {
            return this._shadowProductionVariants != null && (this._shadowProductionVariants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig.
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