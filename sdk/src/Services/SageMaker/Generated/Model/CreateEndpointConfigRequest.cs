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
    /// Container for the parameters to the CreateEndpointConfig operation.
    /// Creates an endpoint configuration that SageMaker hosting services uses to deploy models.
    /// In the configuration, you identify one or more models, created using the <code>CreateModel</code>
    /// API, to deploy and the resources that you want SageMaker to provision. Then you call
    /// the <a>CreateEndpoint</a> API.
    /// 
    ///  <note> 
    /// <para>
    ///  Use this API if you want to use SageMaker hosting services to deploy models into
    /// production. 
    /// </para>
    ///  </note> 
    /// <para>
    /// In the request, you define a <code>ProductionVariant</code>, for each model that you
    /// want to deploy. Each <code>ProductionVariant</code> parameter also describes the resources
    /// that you want SageMaker to provision. This includes the number and type of ML compute
    /// instances to deploy. 
    /// </para>
    ///  
    /// <para>
    /// If you are hosting multiple models, you also assign a <code>VariantWeight</code> to
    /// specify how much traffic you want to allocate to each model. For example, suppose
    /// that you want to host two models, A and B, and you assign traffic weight 2 for model
    /// A and 1 for model B. SageMaker distributes two-thirds of the traffic to Model A, and
    /// one-third to model B. 
    /// </para>
    ///  <note> 
    /// <para>
    /// When you call <a>CreateEndpoint</a>, a load call is made to DynamoDB to verify that
    /// your endpoint configuration exists. When you read data from a DynamoDB table supporting
    /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
    /// <code>Eventually Consistent Reads</code> </a>, the response might not reflect the
    /// results of a recently completed write operation. The response might include some stale
    /// data. If the dependent entities are not yet in DynamoDB, this causes a validation
    /// error. If you repeat your read request after a short time, the response should return
    /// the latest data. So retry logic is recommended to handle these possible issues. We
    /// also recommend that customers call <a>DescribeEndpointConfig</a> before calling <a>CreateEndpoint</a>
    /// to minimize the potential impact of a DynamoDB eventually consistent read.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateEndpointConfigRequest : AmazonSageMakerRequest
    {
        private AsyncInferenceConfig _asyncInferenceConfig;
        private DataCaptureConfig _dataCaptureConfig;
        private string _endpointConfigName;
        private ExplainerConfig _explainerConfig;
        private string _kmsKeyId;
        private List<ProductionVariant> _productionVariants = new List<ProductionVariant>();
        private List<ProductionVariant> _shadowProductionVariants = new List<ProductionVariant>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AsyncInferenceConfig. 
        /// <para>
        /// Specifies configuration for how an endpoint performs asynchronous inference. This
        /// is a required field in order for your Endpoint to be invoked using <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_runtime_InvokeEndpointAsync.html">InvokeEndpointAsync</a>.
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
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of the endpoint configuration. You specify this name in a <a>CreateEndpoint</a>
        /// request. 
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
        /// Gets and sets the property ExplainerConfig. 
        /// <para>
        /// A member of <code>CreateEndpointConfig</code> that enables explainers.
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
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <code>alias/ExampleAlias</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name ARN: <code>arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The KMS key policy must grant permission to the IAM role that you specify in your
        /// <code>CreateEndpoint</code>, <code>UpdateEndpoint</code> requests. For more information,
        /// refer to the Amazon Web Services Key Management Service section<a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">
        /// Using Key Policies in Amazon Web Services KMS </a> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Certain Nitro-based instances include local storage, dependent on the instance type.
        /// Local storage volumes are encrypted using a hardware module on the instance. You can't
        /// request a <code>KmsKeyId</code> when using an instance type with local storage. If
        /// any of the models that you specify in the <code>ProductionVariants</code> parameter
        /// use nitro-based instances with local storage, do not specify a value for the <code>KmsKeyId</code>
        /// parameter. If you specify a value for <code>KmsKeyId</code> when using any nitro-based
        /// instances with local storage, the call to <code>CreateEndpointConfig</code> fails.
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
        [AWSProperty(Max=2048)]
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
        /// An array of <code>ProductionVariant</code> objects, one for each model that you want
        /// to host at this endpoint.
        /// </para>
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
            return this._productionVariants != null && this._productionVariants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ShadowProductionVariants. 
        /// <para>
        /// An array of <code>ProductionVariant</code> objects, one for each model that you want
        /// to host at this endpoint in shadow mode with production traffic replicated from the
        /// model specified on <code>ProductionVariants</code>. If you use this field, you can
        /// only specify one variant for <code>ProductionVariants</code> and one variant for <code>ShadowProductionVariants</code>.
        /// </para>
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
            return this._shadowProductionVariants != null && this._shadowProductionVariants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
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

    }
}