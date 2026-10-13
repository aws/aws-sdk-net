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
    /// Container for the parameters to the UpdateModelPackage operation. Updates a versioned
    /// model.
    /// </summary>
    public partial class UpdateModelPackageRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalInferenceSpecificationsToAdd. 
        /// <para>
        /// An array of additional Inference Specification objects to be added to the existing
        /// array additional Inference Specification. Total number of additional Inference Specifications
        /// can not exceed 15. Each additional Inference Specification specifies artifacts based
        /// on this model package that can be used on inference endpoints. Generally used with
        /// SageMaker Neo to store the compiled artifacts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public List<AdditionalInferenceSpecificationDefinition> AdditionalInferenceSpecificationsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalInferenceSpecificationDefinition>() : null;

        /// <summary>
        /// Checks to see if the AdditionalInferenceSpecificationsToAdd property is set.
        /// </summary>
        internal bool IsSetAdditionalInferenceSpecificationsToAdd() => this.AdditionalInferenceSpecificationsToAdd != null && (this.AdditionalInferenceSpecificationsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApprovalDescription. 
        /// <para>
        /// A description for the approval status of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ApprovalDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalDescription property is set.
        /// </summary>
        internal bool IsSetApprovalDescription() => this.ApprovalDescription != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique token that guarantees that the call to this API is idempotent. 
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
        /// Gets and sets the property CustomerMetadataPropertiesToRemove. 
        /// <para>
        /// The metadata properties associated with the model package versions to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomerMetadataPropertiesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomerMetadataPropertiesToRemove property is set.
        /// </summary>
        internal bool IsSetCustomerMetadataPropertiesToRemove() => this.CustomerMetadataPropertiesToRemove != null && (this.CustomerMetadataPropertiesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property ModelApprovalStatus. 
        /// <para>
        /// The approval status of the model.
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
    }
}
