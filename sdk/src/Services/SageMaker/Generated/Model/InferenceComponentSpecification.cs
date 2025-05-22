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
    /// Details about the resources to deploy with this inference component, including the
    /// model, container, and compute resources.
    /// </summary>
    public partial class InferenceComponentSpecification
    {
        private string _baseInferenceComponentName;
        private InferenceComponentComputeResourceRequirements _computeResourceRequirements;
        private InferenceComponentContainerSpecification _container;
        private string _modelName;
        private InferenceComponentStartupParameters _startupParameters;

        /// <summary>
        /// Gets and sets the property BaseInferenceComponentName. 
        /// <para>
        /// The name of an existing inference component that is to contain the inference component
        /// that you're creating with your request.
        /// </para>
        ///  
        /// <para>
        /// Specify this parameter only if your request is meant to create an adapter inference
        /// component. An adapter inference component contains the path to an adapter model. The
        /// purpose of the adapter model is to tailor the inference output of a base foundation
        /// model, which is hosted by the base inference component. The adapter inference component
        /// uses the compute resources that you assigned to the base inference component.
        /// </para>
        ///  
        /// <para>
        /// When you create an adapter inference component, use the <c>Container</c> parameter
        /// to specify the location of the adapter artifacts. In the parameter value, use the
        /// <c>ArtifactUrl</c> parameter of the <c>InferenceComponentContainerSpecification</c>
        /// data type.
        /// </para>
        ///  
        /// <para>
        /// Before you can create an adapter inference component, you must have an existing inference
        /// component that contains the foundation model that you want to adapt.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string BaseInferenceComponentName
        {
            get { return this._baseInferenceComponentName; }
            set { this._baseInferenceComponentName = value; }
        }

        // Check to see if BaseInferenceComponentName property is set
        internal bool IsSetBaseInferenceComponentName()
        {
            return this._baseInferenceComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeResourceRequirements. 
        /// <para>
        /// The compute resources allocated to run the model, plus any adapter models, that you
        /// assign to the inference component.
        /// </para>
        ///  
        /// <para>
        /// Omit this parameter if your request is meant to create an adapter inference component.
        /// An adapter inference component is loaded by a base inference component, and it uses
        /// the compute resources of the base inference component.
        /// </para>
        /// </summary>
        public InferenceComponentComputeResourceRequirements ComputeResourceRequirements
        {
            get { return this._computeResourceRequirements; }
            set { this._computeResourceRequirements = value; }
        }

        // Check to see if ComputeResourceRequirements property is set
        internal bool IsSetComputeResourceRequirements()
        {
            return this._computeResourceRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// Defines a container that provides the runtime environment for a model that you deploy
        /// with an inference component.
        /// </para>
        /// </summary>
        public InferenceComponentContainerSpecification Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of an existing SageMaker AI model object in your account that you want to
        /// deploy with the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property StartupParameters. 
        /// <para>
        /// Settings that take effect while the model container starts up.
        /// </para>
        /// </summary>
        public InferenceComponentStartupParameters StartupParameters
        {
            get { return this._startupParameters; }
            set { this._startupParameters = value; }
        }

        // Check to see if StartupParameters property is set
        internal bool IsSetStartupParameters()
        {
            return this._startupParameters != null;
        }

    }
}