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
    /// Container for the parameters to the UpdateModelPackage operation.
    /// Updates a versioned model.
    /// </summary>
    public partial class UpdateModelPackageRequest : AmazonSageMakerRequest
    {
        private List<AdditionalInferenceSpecificationDefinition> _additionalInferenceSpecificationsToAdd = AWSConfigs.InitializeCollections ? new List<AdditionalInferenceSpecificationDefinition>() : null;
        private string _approvalDescription;
        private string _clientToken;
        private Dictionary<string, string> _customerMetadataProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _customerMetadataPropertiesToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private InferenceSpecification _inferenceSpecification;
        private ModelApprovalStatus _modelApprovalStatus;
        private ModelPackageModelCard _modelCard;
        private ModelLifeCycle _modelLifeCycle;
        private string _modelPackageArn;
        private string _sourceUri;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public List<AdditionalInferenceSpecificationDefinition> AdditionalInferenceSpecificationsToAdd
        {
            get { return this._additionalInferenceSpecificationsToAdd; }
            set { this._additionalInferenceSpecificationsToAdd = value; }
        }

        // Check to see if AdditionalInferenceSpecificationsToAdd property is set
        internal bool IsSetAdditionalInferenceSpecificationsToAdd()
        {
            return this._additionalInferenceSpecificationsToAdd != null && (this._additionalInferenceSpecificationsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApprovalDescription. 
        /// <para>
        /// A description for the approval status of the model.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique token that guarantees that the call to this API is idempotent. 
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
        /// Gets and sets the property CustomerMetadataPropertiesToRemove. 
        /// <para>
        /// The metadata properties associated with the model package versions to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomerMetadataPropertiesToRemove
        {
            get { return this._customerMetadataPropertiesToRemove; }
            set { this._customerMetadataPropertiesToRemove = value; }
        }

        // Check to see if CustomerMetadataPropertiesToRemove property is set
        internal bool IsSetCustomerMetadataPropertiesToRemove()
        {
            return this._customerMetadataPropertiesToRemove != null && (this._customerMetadataPropertiesToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Gets and sets the property ModelApprovalStatus. 
        /// <para>
        /// The approval status of the model.
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

    }
}