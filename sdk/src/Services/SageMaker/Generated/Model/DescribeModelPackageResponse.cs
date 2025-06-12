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
    /// This is the response object from the DescribeModelPackage operation.
    /// </summary>
    public partial class DescribeModelPackageResponse : AmazonWebServiceResponse
    {
        private List<AdditionalInferenceSpecificationDefinition> _additionalInferenceSpecifications = AWSConfigs.InitializeCollections ? new List<AdditionalInferenceSpecificationDefinition>() : null;
        private string _approvalDescription;
        private bool? _certifyForMarketplace;
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private Dictionary<string, string> _customerMetadataProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _domain;
        private DriftCheckBaselines _driftCheckBaselines;
        private InferenceSpecification _inferenceSpecification;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private MetadataProperties _metadataProperties;
        private ModelApprovalStatus _modelApprovalStatus;
        private ModelPackageModelCard _modelCard;
        private ModelLifeCycle _modelLifeCycle;
        private ModelMetrics _modelMetrics;
        private string _modelPackageArn;
        private string _modelPackageDescription;
        private string _modelPackageGroupName;
        private string _modelPackageName;
        private ModelPackageStatus _modelPackageStatus;
        private ModelPackageStatusDetails _modelPackageStatusDetails;
        private int? _modelPackageVersion;
        private string _samplePayloadUrl;
        private ModelPackageSecurityConfig _securityConfig;
        private SkipModelValidation _skipModelValidation;
        private SourceAlgorithmSpecification _sourceAlgorithmSpecification;
        private string _sourceUri;
        private string _task;
        private ModelPackageValidationSpecification _validationSpecification;

        /// <summary>
        /// Gets and sets the property AdditionalInferenceSpecifications. 
        /// <para>
        /// An array of additional Inference Specification objects. Each additional Inference
        /// Specification specifies artifacts based on this model package that can be used on
        /// inference endpoints. Generally used with SageMaker Neo to store the compiled artifacts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._additionalInferenceSpecifications != null && (this._additionalInferenceSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApprovalDescription. 
        /// <para>
        /// A description provided for the model approval.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ApprovalDescription
        {
            get { return this._approvalDescription; }
            set { this._approvalDescription = value; }
        }

        // Check to see if ApprovalDescription property is set
        internal bool IsSetApprovalDescription()
        {
            return this._approvalDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CertifyForMarketplace. 
        /// <para>
        /// Whether the model package is certified for listing on Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public bool? CertifyForMarketplace
        {
            get { return this._certifyForMarketplace; }
            set { this._certifyForMarketplace = value; }
        }

        // Check to see if CertifyForMarketplace property is set
        internal bool IsSetCertifyForMarketplace()
        {
            return this._certifyForMarketplace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp specifying when the model package was created.
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
        /// Gets and sets the property CustomerMetadataProperties. 
        /// <para>
        /// The metadata properties associated with the model package versions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._customerMetadataProperties != null && (this._customerMetadataProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The machine learning domain of the model package you specified. Common machine learning
        /// domains include computer vision and natural language processing.
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
        /// Details about inference jobs that you can run with models based on this model package.
        /// </para>
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
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the model package was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
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
        /// The approval status of the model package.
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
        /// Gets and sets the property ModelCard. 
        /// <para>
        /// The model card associated with the model package. Since <c>ModelPackageModelCard</c>
        /// is tied to a model package, it is a specific usage of a model card and its schema
        /// is simplified compared to the schema of <c>ModelCard</c>. The <c>ModelPackageModelCard</c>
        /// schema does not include <c>model_package_details</c>, and <c>model_overview</c> is
        /// composed of the <c>model_creator</c> and <c>model_artifact</c> properties. For more
        /// information about the model package model card schema, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-registry-details.html#model-card-schema">Model
        /// package model card schema</a>. For more information about the model card associated
        /// with the model package, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-registry-details.html">View
        /// the Details of a Model Version</a>.
        /// </para>
        /// </summary>
        public ModelPackageModelCard ModelCard
        {
            get { return this._modelCard; }
            set { this._modelCard = value; }
        }

        // Check to see if ModelCard property is set
        internal bool IsSetModelCard()
        {
            return this._modelCard != null;
        }

        /// <summary>
        /// Gets and sets the property ModelLifeCycle. 
        /// <para>
        ///  A structure describing the current state of the model in its life cycle. 
        /// </para>
        /// </summary>
        public ModelLifeCycle ModelLifeCycle
        {
            get { return this._modelLifeCycle; }
            set { this._modelLifeCycle = value; }
        }

        // Check to see if ModelLifeCycle property is set
        internal bool IsSetModelLifeCycle()
        {
            return this._modelLifeCycle != null;
        }

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// Metrics for the model.
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
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelPackageArn
        {
            get { return this._modelPackageArn; }
            set { this._modelPackageArn = value; }
        }

        // Check to see if ModelPackageArn property is set
        internal bool IsSetModelPackageArn()
        {
            return this._modelPackageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageDescription. 
        /// <para>
        /// A brief summary of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// If the model is a versioned model, the name of the model group that the versioned
        /// model belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// The name of the model package being described.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property ModelPackageStatus. 
        /// <para>
        /// The current status of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelPackageStatus ModelPackageStatus
        {
            get { return this._modelPackageStatus; }
            set { this._modelPackageStatus = value; }
        }

        // Check to see if ModelPackageStatus property is set
        internal bool IsSetModelPackageStatus()
        {
            return this._modelPackageStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageStatusDetails. 
        /// <para>
        /// Details about the current status of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelPackageStatusDetails ModelPackageStatusDetails
        {
            get { return this._modelPackageStatusDetails; }
            set { this._modelPackageStatusDetails = value; }
        }

        // Check to see if ModelPackageStatusDetails property is set
        internal bool IsSetModelPackageStatusDetails()
        {
            return this._modelPackageStatusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageVersion. 
        /// <para>
        /// The version of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? ModelPackageVersion
        {
            get { return this._modelPackageVersion; }
            set { this._modelPackageVersion = value; }
        }

        // Check to see if ModelPackageVersion property is set
        internal bool IsSetModelPackageVersion()
        {
            return this._modelPackageVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SamplePayloadUrl. 
        /// <para>
        /// The Amazon Simple Storage Service (Amazon S3) path where the sample payload are stored.
        /// This path points to a single gzip compressed tar archive (.tar.gz suffix).
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// The KMS Key ID (<c>KMSKeyId</c>) used for encryption of model package information.
        /// </para>
        /// </summary>
        public ModelPackageSecurityConfig SecurityConfig
        {
            get { return this._securityConfig; }
            set { this._securityConfig = value; }
        }

        // Check to see if SecurityConfig property is set
        internal bool IsSetSecurityConfig()
        {
            return this._securityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SkipModelValidation. 
        /// <para>
        /// Indicates if you want to skip model validation.
        /// </para>
        /// </summary>
        public SkipModelValidation SkipModelValidation
        {
            get { return this._skipModelValidation; }
            set { this._skipModelValidation = value; }
        }

        // Check to see if SkipModelValidation property is set
        internal bool IsSetSkipModelValidation()
        {
            return this._skipModelValidation != null;
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
        /// Gets and sets the property SourceUri. 
        /// <para>
        /// The URI of the source for the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SourceUri
        {
            get { return this._sourceUri; }
            set { this._sourceUri = value; }
        }

        // Check to see if SourceUri property is set
        internal bool IsSetSourceUri()
        {
            return this._sourceUri != null;
        }

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// The machine learning task you specified that your model package accomplishes. Common
        /// machine learning tasks include object detection and image classification.
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
        /// Configurations for one or more transform jobs that SageMaker runs to test the model
        /// package.
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