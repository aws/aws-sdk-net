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
        /// <summary>
        /// Gets and sets the property AdditionalInferenceSpecifications. 
        /// <para>
        /// An array of additional Inference Specification objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public List<AdditionalInferenceSpecificationDefinition> AdditionalInferenceSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalInferenceSpecificationDefinition>() : null;

        /// <summary>
        /// Checks to see if the AdditionalInferenceSpecifications property is set.
        /// </summary>
        internal bool IsSetAdditionalInferenceSpecifications() => this.AdditionalInferenceSpecifications != null && (this.AdditionalInferenceSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApprovalDescription. 
        /// <para>
        /// A description provided when the model approval is set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ApprovalDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalDescription property is set.
        /// </summary>
        internal bool IsSetApprovalDescription() => this.ApprovalDescription != null;

        /// <summary>
        /// Gets and sets the property CertifyForMarketplace. 
        /// <para>
        /// Whether the model package is to be certified to be listed on Amazon Web Services Marketplace.
        /// For information about listing model packages on Amazon Web Services Marketplace, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-mkt-list.html">List
        /// Your Algorithm or Model Package on Amazon Web Services Marketplace</a>.
        /// </para>
        /// </summary>
        public bool? CertifyForMarketplace { get; set; }

        /// <summary>
        /// Checks to see if the CertifyForMarketplace property is set.
        /// </summary>
        internal bool IsSetCertifyForMarketplace() => this.CertifyForMarketplace.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Information about the user who created or modified an experiment, trial, trial component,
        /// lineage group, or project.
        /// </para>
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the model package was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerMetadataProperties. 
        /// <para>
        /// The metadata properties for the model package. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> CustomerMetadataProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomerMetadataProperties property is set.
        /// </summary>
        internal bool IsSetCustomerMetadataProperties() => this.CustomerMetadataProperties != null && (this.CustomerMetadataProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The machine learning domain of your model package and its components. Common machine
        /// learning domains include computer vision and natural language processing.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DriftCheckBaselines. 
        /// <para>
        /// Represents the drift check baselines that can be used when the model monitor is set
        /// using the model package.
        /// </para>
        /// </summary>
        public DriftCheckBaselines DriftCheckBaselines { get; set; }

        /// <summary>
        /// Checks to see if the DriftCheckBaselines property is set.
        /// </summary>
        internal bool IsSetDriftCheckBaselines() => this.DriftCheckBaselines != null;

        /// <summary>
        /// Gets and sets the property InferenceSpecification. 
        /// <para>
        /// Defines how to perform inference generation after a training job is run.
        /// </para>
        /// </summary>
        public InferenceSpecification InferenceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSpecification property is set.
        /// </summary>
        internal bool IsSetInferenceSpecification() => this.InferenceSpecification != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// Information about the user who created or modified an experiment, trial, trial component,
        /// lineage group, or project.
        /// </para>
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time the model package was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataProperties. 
        /// <para>
        /// Metadata properties of the tracking entity, trial, or trial component.
        /// </para>
        /// </summary>
        public MetadataProperties MetadataProperties { get; set; }

        /// <summary>
        /// Checks to see if the MetadataProperties property is set.
        /// </summary>
        internal bool IsSetMetadataProperties() => this.MetadataProperties != null;

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
        public ModelApprovalStatus ModelApprovalStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelApprovalStatus property is set.
        /// </summary>
        internal bool IsSetModelApprovalStatus() => this.ModelApprovalStatus != null;

        /// <summary>
        /// Gets and sets the property ModelCard.
        /// </summary>
        public ModelPackageModelCard ModelCard { get; set; }

        /// <summary>
        /// Checks to see if the ModelCard property is set.
        /// </summary>
        internal bool IsSetModelCard() => this.ModelCard != null;

        /// <summary>
        /// Gets and sets the property ModelLifeCycle. 
        /// <para>
        ///  A structure describing the current state of the model in its life cycle. 
        /// </para>
        /// </summary>
        public ModelLifeCycle ModelLifeCycle { get; set; }

        /// <summary>
        /// Checks to see if the ModelLifeCycle property is set.
        /// </summary>
        internal bool IsSetModelLifeCycle() => this.ModelLifeCycle != null;

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// Metrics for the model.
        /// </para>
        /// </summary>
        public ModelMetrics ModelMetrics { get; set; }

        /// <summary>
        /// Checks to see if the ModelMetrics property is set.
        /// </summary>
        internal bool IsSetModelMetrics() => this.ModelMetrics != null;

        /// <summary>
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ModelPackageArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageArn property is set.
        /// </summary>
        internal bool IsSetModelPackageArn() => this.ModelPackageArn != null;

        /// <summary>
        /// Gets and sets the property ModelPackageDescription. 
        /// <para>
        /// The description of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ModelPackageDescription { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageDescription property is set.
        /// </summary>
        internal bool IsSetModelPackageDescription() => this.ModelPackageDescription != null;

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// The model group to which the model belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ModelPackageGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageGroupName property is set.
        /// </summary>
        internal bool IsSetModelPackageGroupName() => this.ModelPackageGroupName != null;

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
        [AWSProperty(Min = 1, Max = 63)]
        public string ModelPackageName { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageName property is set.
        /// </summary>
        internal bool IsSetModelPackageName() => this.ModelPackageName != null;

        /// <summary>
        /// Gets and sets the property ModelPackageRegistrationType. 
        /// <para>
        ///  The package registration type of the model package. 
        /// </para>
        /// </summary>
        public ModelPackageRegistrationType ModelPackageRegistrationType { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageRegistrationType property is set.
        /// </summary>
        internal bool IsSetModelPackageRegistrationType() => this.ModelPackageRegistrationType != null;

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
        public ModelPackageStatus ModelPackageStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageStatus property is set.
        /// </summary>
        internal bool IsSetModelPackageStatus() => this.ModelPackageStatus != null;

        /// <summary>
        /// Gets and sets the property ModelPackageStatusDetails. 
        /// <para>
        /// Specifies the validation and image scan statuses of the model package.
        /// </para>
        /// </summary>
        public ModelPackageStatusDetails ModelPackageStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageStatusDetails property is set.
        /// </summary>
        internal bool IsSetModelPackageStatusDetails() => this.ModelPackageStatusDetails != null;

        /// <summary>
        /// Gets and sets the property ModelPackageVersion. 
        /// <para>
        /// The version number of a versioned model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? ModelPackageVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageVersion property is set.
        /// </summary>
        internal bool IsSetModelPackageVersion() => this.ModelPackageVersion.HasValue;

        /// <summary>
        /// Gets and sets the property SamplePayloadUrl. 
        /// <para>
        /// The Amazon Simple Storage Service path where the sample payload are stored. This path
        /// must point to a single gzip compressed tar archive (.tar.gz suffix).
        /// </para>
        /// </summary>
        public string SamplePayloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the SamplePayloadUrl property is set.
        /// </summary>
        internal bool IsSetSamplePayloadUrl() => this.SamplePayloadUrl != null;

        /// <summary>
        /// Gets and sets the property SecurityConfig.
        /// </summary>
        public ModelPackageSecurityConfig SecurityConfig { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfig property is set.
        /// </summary>
        internal bool IsSetSecurityConfig() => this.SecurityConfig != null;

        /// <summary>
        /// Gets and sets the property SkipModelValidation. 
        /// <para>
        /// Indicates if you want to skip model validation.
        /// </para>
        /// </summary>
        public SkipModelValidation SkipModelValidation { get; set; }

        /// <summary>
        /// Checks to see if the SkipModelValidation property is set.
        /// </summary>
        internal bool IsSetSkipModelValidation() => this.SkipModelValidation != null;

        /// <summary>
        /// Gets and sets the property SourceAlgorithmSpecification. 
        /// <para>
        /// A list of algorithms that were used to create a model package.
        /// </para>
        /// </summary>
        public SourceAlgorithmSpecification SourceAlgorithmSpecification { get; set; }

        /// <summary>
        /// Checks to see if the SourceAlgorithmSpecification property is set.
        /// </summary>
        internal bool IsSetSourceAlgorithmSpecification() => this.SourceAlgorithmSpecification != null;

        /// <summary>
        /// Gets and sets the property SourceUri. 
        /// <para>
        /// The URI of the source for the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SourceUri { get; set; }

        /// <summary>
        /// Checks to see if the SourceUri property is set.
        /// </summary>
        internal bool IsSetSourceUri() => this.SourceUri != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tags associated with the model package. For more information, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference Guide</i>.
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
        /// Gets and sets the property Task. 
        /// <para>
        /// The machine learning task your model package accomplishes. Common machine learning
        /// tasks include object detection and image classification.
        /// </para>
        /// </summary>
        public string Task { get; set; }

        /// <summary>
        /// Checks to see if the Task property is set.
        /// </summary>
        internal bool IsSetTask() => this.Task != null;

        /// <summary>
        /// Gets and sets the property ValidationSpecification. 
        /// <para>
        /// Specifies batch transform jobs that SageMaker runs to validate your model package.
        /// </para>
        /// </summary>
        public ModelPackageValidationSpecification ValidationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ValidationSpecification property is set.
        /// </summary>
        internal bool IsSetValidationSpecification() => this.ValidationSpecification != null;
    }
}
