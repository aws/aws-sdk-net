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
    /// Container for the parameters to the CreateModelPackage operation. Creates a model
    /// package that you can use to create SageMaker models or list on Amazon Web Services
    /// Marketplace, or a versioned model that is part of a model group. Buyers can subscribe
    /// to model packages listed on Amazon Web Services Marketplace to create models in SageMaker.
    /// <para> To create a model package by specifying a Docker container that contains your
    /// inference code and the Amazon S3 location of your model artifacts, provide values
    /// for <c>InferenceSpecification</c>. To create a model from an algorithm resource that
    /// you created or subscribed to in Amazon Web Services Marketplace, provide a value for
    /// <c>SourceAlgorithmSpecification</c>. </para> <note> <para> There are two types of
    /// model packages: </para> <ul> <li> <para> Versioned - a model that is part of a model
    /// group in the model registry. </para> </li> <li> <para> Unversioned - a model package
    /// that is not part of a model group. </para> </li> </ul> </note>
    /// </summary>
    public partial class CreateModelPackageRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalInferenceSpecifications. 
        /// <para>
        /// An array of additional Inference Specification objects. Each additional Inference
        /// Specification specifies artifacts based on this model package that can be used on
        /// inference endpoints. Generally used with SageMaker Neo to store the compiled artifacts.
        /// 
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
        public bool? CertifyForMarketplace { get; set; }

        /// <summary>
        /// Checks to see if the CertifyForMarketplace property is set.
        /// </summary>
        internal bool IsSetCertifyForMarketplace() => this.CertifyForMarketplace.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token that guarantees that the call to this API is idempotent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        /// Specifies details about inference jobs that you can run with models based on this
        /// model package, including the following information:
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
        public InferenceSpecification InferenceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSpecification property is set.
        /// </summary>
        internal bool IsSetInferenceSpecification() => this.InferenceSpecification != null;

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
        /// Whether the model is approved for deployment.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional for versioned models, and does not apply to unversioned
        /// models.
        /// </para>
        ///  
        /// <para>
        /// For versioned models, the value of this parameter must be set to <c>Approved</c> to
        /// deploy the model.
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
        /// A structure that contains model metrics reports.
        /// </para>
        /// </summary>
        public ModelMetrics ModelMetrics { get; set; }

        /// <summary>
        /// Checks to see if the ModelMetrics property is set.
        /// </summary>
        internal bool IsSetModelMetrics() => this.ModelMetrics != null;

        /// <summary>
        /// Gets and sets the property ModelPackageDescription. 
        /// <para>
        /// A description of the model package.
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
        /// The name or Amazon Resource Name (ARN) of the model package group that this model
        /// version belongs to.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for versioned models, and does not apply to unversioned
        /// models.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 170)]
        public string ModelPackageGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageGroupName property is set.
        /// </summary>
        internal bool IsSetModelPackageGroupName() => this.ModelPackageGroupName != null;

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
        [AWSProperty(Min = 1, Max = 63)]
        public string ModelPackageName { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageName property is set.
        /// </summary>
        internal bool IsSetModelPackageName() => this.ModelPackageName != null;

        /// <summary>
        /// Gets and sets the property ModelPackageRegistrationType. 
        /// <para>
        ///  The package registration type of the model package input. 
        /// </para>
        /// </summary>
        public ModelPackageRegistrationType ModelPackageRegistrationType { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageRegistrationType property is set.
        /// </summary>
        internal bool IsSetModelPackageRegistrationType() => this.ModelPackageRegistrationType != null;

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
        [AWSProperty(Min = 0, Max = 1024)]
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
        /// The URI of the source for the model package. If you want to clone a model package,
        /// set it to the model package Amazon Resource Name (ARN). If you want to register a
        /// model, set it to the model ARN.
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
        /// A list of key value pairs associated with the model. For more information, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you supply <c>ModelPackageGroupName</c>, your model package belongs to the model
        /// group you specify and uses the tags associated with the model group. In this case,
        /// you cannot supply a <c>tag</c> argument. 
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
        /// tasks include object detection and image classification. The following tasks are supported
        /// by Inference Recommender: <c>"IMAGE_CLASSIFICATION"</c> | <c>"OBJECT_DETECTION"</c>
        /// | <c>"TEXT_GENERATION"</c> |<c>"IMAGE_SEGMENTATION"</c> | <c>"FILL_MASK"</c> | <c>"CLASSIFICATION"</c>
        /// | <c>"REGRESSION"</c> | <c>"OTHER"</c>.
        /// </para>
        ///  
        /// <para>
        /// Specify "OTHER" if none of the tasks listed fit your use case.
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
        /// Specifies configurations for one or more transform jobs that SageMaker runs to test
        /// the model package.
        /// </para>
        /// </summary>
        public ModelPackageValidationSpecification ValidationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ValidationSpecification property is set.
        /// </summary>
        internal bool IsSetValidationSpecification() => this.ValidationSpecification != null;
    }
}
