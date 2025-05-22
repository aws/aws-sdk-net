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

    }
}