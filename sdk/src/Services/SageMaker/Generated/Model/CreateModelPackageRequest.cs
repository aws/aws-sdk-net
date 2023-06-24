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
    /// Container for the parameters to the CreateModelPackage operation.
    /// Creates a model package that you can use to create SageMaker models or list on Amazon
    /// Web Services Marketplace, or a versioned model that is part of a model group. Buyers
    /// can subscribe to model packages listed on Amazon Web Services Marketplace to create
    /// models in SageMaker.
    /// 
    ///  
    /// <para>
    /// To create a model package by specifying a Docker container that contains your inference
    /// code and the Amazon S3 location of your model artifacts, provide values for <code>InferenceSpecification</code>.
    /// To create a model from an algorithm resource that you created or subscribed to in
    /// Amazon Web Services Marketplace, provide a value for <code>SourceAlgorithmSpecification</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// There are two types of model packages:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Versioned - a model that is part of a model group in the model registry.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Unversioned - a model package that is not part of a model group.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateModelPackageRequest : AmazonSageMakerRequest
    {
        private List<AdditionalInferenceSpecificationDefinition> _additionalInferenceSpecifications = new List<AdditionalInferenceSpecificationDefinition>();
        private bool? _certifyForMarketplace;
        private string _clientToken;
        private Dictionary<string, string> _customerMetadataProperties = new Dictionary<string, string>();
        private string _domain;
        private DriftCheckBaselines _driftCheckBaselines;
        private InferenceSpecification _inferenceSpecification;
        private MetadataProperties _metadataProperties;
        private ModelApprovalStatus _modelApprovalStatus;
        private ModelMetrics _modelMetrics;
        private string _modelPackageDescription;
        private string _modelPackageGroupName;
        private string _modelPackageName;
        private string _samplePayloadUrl;
        private SourceAlgorithmSpecification _sourceAlgorithmSpecification;
        private List<Tag> _tags = new List<Tag>();
        private string _task;
        private ModelPackageValidationSpecification _validationSpecification;

        /// <summary>
        /// Gets and sets the property AdditionalInferenceSpecifications. 
        /// <para>
        /// An array of additional Inference Specification objects. Each additional Inference
        /// Specification specifies artifacts based on this model package that can be used on
        /// inference endpoints. Generally used with SageMaker Neo to store the compiled artifacts.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public List<AdditionalInferenceSpecificationDefinition> AdditionalInferenceSpecifications
        {
            get { return this._additionalInferenceSpecifications; }
            set { this._additionalInferenceSpecifications = value; }
        }

        // Check to see if AdditionalInferenceSpecifications property is set
        internal bool IsSetAdditionalInferenceSpecifications()
        {
            return this._additionalInferenceSpecifications != null && this._additionalInferenceSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CertifyForMarketplace. 
        /// <para>
        /// Whether to certify the model package for listing on Amazon Web Services Marketplace.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional for unversioned models, and does not apply to versioned
        /// models.
        /// </para>
        /// </summary>
        public bool CertifyForMarketplace
        {
            get { return this._certifyForMarketplace.GetValueOrDefault(); }
            set { this._certifyForMarketplace = value; }
        }

        // Check to see if CertifyForMarketplace property is set
        internal bool IsSetCertifyForMarketplace()
        {
            return this._certifyForMarketplace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token that guarantees that the call to this API is idempotent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerMetadataProperties. 
        /// <para>
        /// The metadata properties associated with the model package versions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> CustomerMetadataProperties
        {
            get { return this._customerMetadataProperties; }
            set { this._customerMetadataProperties = value; }
        }

        // Check to see if CustomerMetadataProperties property is set
        internal bool IsSetCustomerMetadataProperties()
        {
            return this._customerMetadataProperties != null && this._customerMetadataProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The machine learning domain of your model package and its components. Common machine
        /// learning domains include computer vision and natural language processing.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DriftCheckBaselines. 
        /// <para>
        /// Represents the drift check baselines that can be used when the model monitor is set
        /// using the model package. For more information, see the topic on <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/pipelines-quality-clarify-baseline-lifecycle.html#pipelines-quality-clarify-baseline-drift-detection">Drift
        /// Detection against Previous Baselines in SageMaker Pipelines</a> in the <i>Amazon SageMaker
        /// Developer Guide</i>. 
        /// </para>
        /// </summary>
        public DriftCheckBaselines DriftCheckBaselines
        {
            get { return this._driftCheckBaselines; }
            set { this._driftCheckBaselines = value; }
        }

        // Check to see if DriftCheckBaselines property is set
        internal bool IsSetDriftCheckBaselines()
        {
            return this._driftCheckBaselines != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceSpecification. 
        /// <para>
        /// Specifies details about inference jobs that can be run with models based on this model
        /// package, including the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon ECR paths of containers that contain the inference code and model artifacts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The instance types that the model package supports for transform jobs and real-time
        /// endpoints used for inference.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The input and output content formats that the model package supports for inference.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InferenceSpecification InferenceSpecification
        {
            get { return this._inferenceSpecification; }
            set { this._inferenceSpecification = value; }
        }

        // Check to see if InferenceSpecification property is set
        internal bool IsSetInferenceSpecification()
        {
            return this._inferenceSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataProperties.
        /// </summary>
        public MetadataProperties MetadataProperties
        {
            get { return this._metadataProperties; }
            set { this._metadataProperties = value; }
        }

        // Check to see if MetadataProperties property is set
        internal bool IsSetMetadataProperties()
        {
            return this._metadataProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ModelApprovalStatus. 
        /// <para>
        /// Whether the model is approved for deployment.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional for versioned models, and does not apply to unversioned
        /// models.
        /// </para>
        ///  
        /// <para>
        /// For versioned models, the value of this parameter must be set to <code>Approved</code>
        /// to deploy the model.
        /// </para>
        /// </summary>
        public ModelApprovalStatus ModelApprovalStatus
        {
            get { return this._modelApprovalStatus; }
            set { this._modelApprovalStatus = value; }
        }

        // Check to see if ModelApprovalStatus property is set
        internal bool IsSetModelApprovalStatus()
        {
            return this._modelApprovalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// A structure that contains model metrics reports.
        /// </para>
        /// </summary>
        public ModelMetrics ModelMetrics
        {
            get { return this._modelMetrics; }
            set { this._modelMetrics = value; }
        }

        // Check to see if ModelMetrics property is set
        internal bool IsSetModelMetrics()
        {
            return this._modelMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageDescription. 
        /// <para>
        /// A description of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ModelPackageDescription
        {
            get { return this._modelPackageDescription; }
            set { this._modelPackageDescription = value; }
        }

        // Check to see if ModelPackageDescription property is set
        internal bool IsSetModelPackageDescription()
        {
            return this._modelPackageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the model package group that this model
        /// version belongs to.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for versioned models, and does not apply to unversioned
        /// models.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=170)]
        public string ModelPackageGroupName
        {
            get { return this._modelPackageGroupName; }
            set { this._modelPackageGroupName = value; }
        }

        // Check to see if ModelPackageGroupName property is set
        internal bool IsSetModelPackageGroupName()
        {
            return this._modelPackageGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageName. 
        /// <para>
        /// The name of the model package. The name must have 1 to 63 characters. Valid characters
        /// are a-z, A-Z, 0-9, and - (hyphen).
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for unversioned models. It is not applicable to versioned
        /// models.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ModelPackageName
        {
            get { return this._modelPackageName; }
            set { this._modelPackageName = value; }
        }

        // Check to see if ModelPackageName property is set
        internal bool IsSetModelPackageName()
        {
            return this._modelPackageName != null;
        }

        /// <summary>
        /// Gets and sets the property SamplePayloadUrl. 
        /// <para>
        /// The Amazon Simple Storage Service (Amazon S3) path where the sample payload is stored.
        /// This path must point to a single gzip compressed tar archive (.tar.gz suffix). This
        /// archive can hold multiple files that are all equally used in the load test. Each file
        /// in the archive must satisfy the size constraints of the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_runtime_InvokeEndpoint.html#API_runtime_InvokeEndpoint_RequestSyntax">InvokeEndpoint</a>
        /// call.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string SamplePayloadUrl
        {
            get { return this._samplePayloadUrl; }
            set { this._samplePayloadUrl = value; }
        }

        // Check to see if SamplePayloadUrl property is set
        internal bool IsSetSamplePayloadUrl()
        {
            return this._samplePayloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAlgorithmSpecification. 
        /// <para>
        /// Details about the algorithm that was used to create the model package.
        /// </para>
        /// </summary>
        public SourceAlgorithmSpecification SourceAlgorithmSpecification
        {
            get { return this._sourceAlgorithmSpecification; }
            set { this._sourceAlgorithmSpecification = value; }
        }

        // Check to see if SourceAlgorithmSpecification property is set
        internal bool IsSetSourceAlgorithmSpecification()
        {
            return this._sourceAlgorithmSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key value pairs associated with the model. For more information, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference Guide</i>.
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
        /// Gets and sets the property Task. 
        /// <para>
        /// The machine learning task your model package accomplishes. Common machine learning
        /// tasks include object detection and image classification. The following tasks are supported
        /// by Inference Recommender: <code>"IMAGE_CLASSIFICATION"</code> | <code>"OBJECT_DETECTION"</code>
        /// | <code>"TEXT_GENERATION"</code> |<code>"IMAGE_SEGMENTATION"</code> | <code>"FILL_MASK"</code>
        /// | <code>"CLASSIFICATION"</code> | <code>"REGRESSION"</code> | <code>"OTHER"</code>.
        /// </para>
        ///  
        /// <para>
        /// Specify "OTHER" if none of the tasks listed fit your use case.
        /// </para>
        /// </summary>
        public string Task
        {
            get { return this._task; }
            set { this._task = value; }
        }

        // Check to see if Task property is set
        internal bool IsSetTask()
        {
            return this._task != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationSpecification. 
        /// <para>
        /// Specifies configurations for one or more transform jobs that SageMaker runs to test
        /// the model package.
        /// </para>
        /// </summary>
        public ModelPackageValidationSpecification ValidationSpecification
        {
            get { return this._validationSpecification; }
            set { this._validationSpecification = value; }
        }

        // Check to see if ValidationSpecification property is set
        internal bool IsSetValidationSpecification()
        {
            return this._validationSpecification != null;
        }

    }
}