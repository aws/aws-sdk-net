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
    /// Container for the parameters to the UpdateModelPackage operation.
    /// Updates a versioned model.
    /// </summary>
    public partial class UpdateModelPackageRequest : AmazonSageMakerRequest
    {
        private List<AdditionalInferenceSpecificationDefinition> _additionalInferenceSpecificationsToAdd = new List<AdditionalInferenceSpecificationDefinition>();
        private string _approvalDescription;
        private Dictionary<string, string> _customerMetadataProperties = new Dictionary<string, string>();
        private List<string> _customerMetadataPropertiesToRemove = new List<string>();
        private ModelApprovalStatus _modelApprovalStatus;
        private string _modelPackageArn;

        /// <summary>
        /// Gets and sets the property AdditionalInferenceSpecificationsToAdd. 
        /// <para>
        /// An array of additional Inference Specification objects to be added to the existing
        /// array additional Inference Specification. Total number of additional Inference Specifications
        /// can not exceed 15. Each additional Inference Specification specifies artifacts based
        /// on this model package that can be used on inference endpoints. Generally used with
        /// SageMaker Neo to store the compiled artifacts.
        /// </para>
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
            return this._additionalInferenceSpecificationsToAdd != null && this._additionalInferenceSpecificationsToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ApprovalDescription. 
        /// <para>
        /// A description for the approval status of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property CustomerMetadataPropertiesToRemove. 
        /// <para>
        /// The metadata properties associated with the model package versions to remove.
        /// </para>
        /// </summary>
        public List<string> CustomerMetadataPropertiesToRemove
        {
            get { return this._customerMetadataPropertiesToRemove; }
            set { this._customerMetadataPropertiesToRemove = value; }
        }

        // Check to see if CustomerMetadataPropertiesToRemove property is set
        internal bool IsSetCustomerMetadataPropertiesToRemove()
        {
            return this._customerMetadataPropertiesToRemove != null && this._customerMetadataPropertiesToRemove.Count > 0; 
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

    }
}