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
    /// A container for your trained model that can be deployed for SageMaker inference. This
    /// can include inference code, artifacts, and metadata. The model package type can be
    /// one of the following.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Versioned model: A part of a model package group in Model Registry.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Unversioned model: Not part of a model package group and used in Amazon Web Services
    /// Marketplace.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateModelPackage.html">
    /// <c>CreateModelPackage</c> </a>.
    /// </para>
    /// </summary>
    public partial class ModelPackage
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
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _task;
        private ModelPackageValidationSpecification _validationSpecification;

        /// <summary>
        /// Gets and sets the property AdditionalInferenceSpecifications. 
        /// <para>
        /// An array of additional Inference Specification objects.
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
        /// A description provided when the model approval is set.
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
        /// Whether the model package is to be certified to be listed on Amazon Web Services Marketplace.
        /// For information about listing model packages on Amazon Web Services Marketplace, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-mkt-list.html">List
        /// Your Algorithm or Model Package on Amazon Web Services Marketplace</a>.
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
        /// <para>
        /// Information about the user who created or modified an experiment, trial, trial component,
        /// lineage group, or project.
        /// </para>
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
        /// The time that the model package was created.
        /// </para>
        /// </summary>
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
        /// The metadata properties for the model package. 
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
        /// using the model package.
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
        /// Defines how to perform inference generation after a training job is run.
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
        /// <para>
        /// Information about the user who created or modified an experiment, trial, trial component,
        /// lineage group, or project.
        /// </para>
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
        /// The last time the model package was modified.
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
        /// <para>
        /// Metadata properties of the tracking entity, trial, or trial component.
        /// </para>
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
        /// The approval status of the model. This can be one of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>APPROVED</c> - The model is approved
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> - The model is rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_MANUAL_APPROVAL</c> - The model is waiting for manual approval.
        /// </para>
        ///  </li> </ul>
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
        [AWSProperty(Min=1, Max=2048)]
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
        /// The description of the model package.
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
        /// The model group to which the model belongs.
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
        /// The name of the model package. The name can be as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a versioned model, the name is automatically generated by SageMaker Model Registry
        /// and follows the format '<c>ModelPackageGroupName/ModelPackageVersion</c>'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an unversioned model, you must provide the name.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property ModelPackageStatus. 
        /// <para>
        /// The status of the model package. This can be one of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - The model package is pending being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - The model package is in the process of being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The model package was successfully created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The model package failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The model package is in the process of being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Specifies the validation and image scan statuses of the model package.
        /// </para>
        /// </summary>
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
        /// The version number of a versioned model.
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
        /// The Amazon Simple Storage Service path where the sample payload are stored. This path
        /// must point to a single gzip compressed tar archive (.tar.gz suffix).
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
        /// A list of algorithms that were used to create a model package.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tags associated with the model package. For more information, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// The machine learning task your model package accomplishes. Common machine learning
        /// tasks include object detection and image classification.
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
        /// Specifies batch transform jobs that SageMaker runs to validate your model package.
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