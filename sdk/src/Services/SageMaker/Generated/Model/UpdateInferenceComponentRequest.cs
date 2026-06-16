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
    /// Container for the parameters to the UpdateInferenceComponent operation.
    /// Updates an inference component.
    /// </summary>
    public partial class UpdateInferenceComponentRequest : AmazonSageMakerRequest
    {
        private InferenceComponentDeploymentConfig _deploymentConfig;
        private string _inferenceComponentName;
        private InferenceComponentRuntimeConfig _runtimeConfig;
        private InferenceComponentSpecification _specification;
        private List<InferenceComponentSpecification> _specifications = AWSConfigs.InitializeCollections ? new List<InferenceComponentSpecification>() : null;

        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The deployment configuration for the inference component. The configuration contains
        /// the desired deployment strategy and rollback settings.
        /// </para>
        /// </summary>
        public InferenceComponentDeploymentConfig DeploymentConfig
        {
            get { return this._deploymentConfig; }
            set { this._deploymentConfig = value; }
        }

        // Check to see if DeploymentConfig property is set
        internal bool IsSetDeploymentConfig()
        {
            return this._deploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceComponentName. 
        /// <para>
        /// The name of the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string InferenceComponentName
        {
            get { return this._inferenceComponentName; }
            set { this._inferenceComponentName = value; }
        }

        // Check to see if InferenceComponentName property is set
        internal bool IsSetInferenceComponentName()
        {
            return this._inferenceComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeConfig. 
        /// <para>
        /// Runtime settings for a model that is deployed with an inference component.
        /// </para>
        /// </summary>
        public InferenceComponentRuntimeConfig RuntimeConfig
        {
            get { return this._runtimeConfig; }
            set { this._runtimeConfig = value; }
        }

        // Check to see if RuntimeConfig property is set
        internal bool IsSetRuntimeConfig()
        {
            return this._runtimeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Specification. 
        /// <para>
        /// Details about the resources to deploy with this inference component, including the
        /// model, container, and compute resources.
        /// </para>
        /// </summary>
        public InferenceComponentSpecification Specification
        {
            get { return this._specification; }
            set { this._specification = value; }
        }

        // Check to see if Specification property is set
        internal bool IsSetSpecification()
        {
            return this._specification != null;
        }

        /// <summary>
        /// Gets and sets the property Specifications. 
        /// <para>
        /// A list of specification objects for the inference component, one per instance type.
        /// Use this parameter when you want to specify different model or resource configurations
        /// for the inference component on each instance type. You can use either this parameter
        /// or the singular <c>Specification</c> parameter, but not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<InferenceComponentSpecification> Specifications
        {
            get { return this._specifications; }
            set { this._specifications = value; }
        }

        // Check to see if Specifications property is set
        internal bool IsSetSpecifications()
        {
            return this._specifications != null && (this._specifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}