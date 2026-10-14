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
    /// This is the response object from the DescribeModelPackage operation.
    /// </summary>
    public partial class DescribeModelPackageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdditionalInferenceSpecifications. 
        /// <para>
        /// An array of additional Inference Specification objects. Each additional Inference
        /// Specification specifies artifacts based on this model package that can be used on
        /// inference endpoints. Generally used with SageMaker Neo to store the compiled artifacts.
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
        /// A description provided for the model approval.
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
        /// Whether the model package is certified for listing on Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public bool? CertifyForMarketplace { get; set; }

        /// <summary>
        /// Checks to see if the CertifyForMarketplace property is set.
        /// </summary>
        internal bool IsSetCertifyForMarketplace() => this.CertifyForMarketplace.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp specifying when the model package was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerMetadataProperties. 
        /// <para>
        /// The metadata properties associated with the model package versions.
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
        /// The machine learning domain of the model package you specified. Common machine learning
        /// domains include computer vision and natural language processing.
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
        /// using the model package. For more information, see the topic on <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/pipelines-quality-clarify-baseline-lifecycle.html#pipelines-quality-clarify-baseline-drift-detection">Drift
        /// Detection against Previous Baselines in SageMaker Pipelines</a> in the <i>Amazon SageMaker
        /// Developer Guide</i>. 
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
        /// Details about inference jobs that you can run with models based on this model package.
        /// </para>
        /// </summary>
        public InferenceSpecification InferenceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSpecification property is set.
        /// </summary>
        internal bool IsSetInferenceSpecification() => this.InferenceSpecification != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the model package was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedStorageType. 
        /// <para>
        /// The storage type of the model package.
        /// </para>
        /// </summary>
        public ManagedStorageType ManagedStorageType { get; set; }

        /// <summary>
        /// Checks to see if the ManagedStorageType property is set.
        /// </summary>
        internal bool IsSetManagedStorageType() => this.ManagedStorageType != null;

        /// <summary>
        /// Gets and sets the property MetadataProperties.
        /// </summary>
        public MetadataProperties MetadataProperties { get; set; }

        /// <summary>
        /// Checks to see if the MetadataProperties property is set.
        /// </summary>
        internal bool IsSetMetadataProperties() => this.MetadataProperties != null;

        /// <summary>
        /// Gets and sets the property ModelApprovalStatus. 
        /// <para>
        /// The approval status of the model package.
        /// </para>
        /// </summary>
        public ModelApprovalStatus ModelApprovalStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelApprovalStatus property is set.
        /// </summary>
        internal bool IsSetModelApprovalStatus() => this.ModelApprovalStatus != null;

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
        ///  
        /// <para>
        /// When you set <c>IncludedData</c> to <c>MetadataOnly</c> in the request, <c>ModelCardStatus</c>
        /// is preserved and <c>ModelCardContent</c> is sanitized to include only the following
        /// JSON paths, when present in the model card:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>model_overview.model_id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>model_overview.model_name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>intended_uses.risk_rating</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>model_package_details.model_package_group_name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>model_package_details.model_package_arn</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Because the <c>ModelPackageModelCard</c> schema does not include <c>model_package_details</c>
        /// and limits <c>model_overview</c> to <c>model_creator</c> and <c>model_artifact</c>,
        /// the sanitized <c>ModelCardContent</c> for a model package typically contains only
        /// <c>intended_uses.risk_rating</c> if it was provided when the model card was created.
        /// To retrieve the complete <c>ModelCardContent</c>, set <c>IncludedData</c> to <c>AllData</c>
        /// or omit the parameter.
        /// </para>
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
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ModelPackageArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageArn property is set.
        /// </summary>
        internal bool IsSetModelPackageArn() => this.ModelPackageArn != null;

        /// <summary>
        /// Gets and sets the property ModelPackageDescription. 
        /// <para>
        /// A brief summary of the model package.
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
        /// If the model is a versioned model, the name of the model group that the versioned
        /// model belongs to.
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
        /// The name of the model package being described.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelPackageName { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageName property is set.
        /// </summary>
        internal bool IsSetModelPackageName() => this.ModelPackageName != null;

        /// <summary>
        /// Gets and sets the property ModelPackageRegistrationType. 
        /// <para>
        ///  The package registration type of the model package output. 
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
        /// The current status of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelPackageStatus ModelPackageStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageStatus property is set.
        /// </summary>
        internal bool IsSetModelPackageStatus() => this.ModelPackageStatus != null;

        /// <summary>
        /// Gets and sets the property ModelPackageStatusDetails. 
        /// <para>
        /// Details about the current status of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelPackageStatusDetails ModelPackageStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageStatusDetails property is set.
        /// </summary>
        internal bool IsSetModelPackageStatusDetails() => this.ModelPackageStatusDetails != null;

        /// <summary>
        /// Gets and sets the property ModelPackageVersion. 
        /// <para>
        /// The version of the model package.
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
        /// The Amazon Simple Storage Service (Amazon S3) path where the sample payload are stored.
        /// This path points to a single gzip compressed tar archive (.tar.gz suffix).
        /// </para>
        /// </summary>
        public string SamplePayloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the SamplePayloadUrl property is set.
        /// </summary>
        internal bool IsSetSamplePayloadUrl() => this.SamplePayloadUrl != null;

        /// <summary>
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// The KMS Key ID (<c>KMSKeyId</c>) used for encryption of model package information.
        /// </para>
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
        /// Details about the algorithm that was used to create the model package.
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
        /// Gets and sets the property Task. 
        /// <para>
        /// The machine learning task you specified that your model package accomplishes. Common
        /// machine learning tasks include object detection and image classification.
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
        /// Configurations for one or more transform jobs that SageMaker runs to test the model
        /// package.
        /// </para>
        /// </summary>
        public ModelPackageValidationSpecification ValidationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ValidationSpecification property is set.
        /// </summary>
        internal bool IsSetValidationSpecification() => this.ValidationSpecification != null;
    }
}
