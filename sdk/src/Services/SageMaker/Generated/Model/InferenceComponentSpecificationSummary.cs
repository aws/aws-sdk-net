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
    /// Details about the resources that are deployed with this inference component.
    /// </summary>
    public partial class InferenceComponentSpecificationSummary
    {
        private string _baseInferenceComponentName;
        private InferenceComponentComputeResourceRequirements _computeResourceRequirements;
        private InferenceComponentContainerSpecificationSummary _container;
        private string _modelName;
        private InferenceComponentStartupParameters _startupParameters;

        /// <summary>
        /// Gets and sets the property BaseInferenceComponentName. 
        /// <para>
        /// The name of the base inference component that contains this inference component.
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
        /// Details about the container that provides the runtime environment for the model that
        /// is deployed with the inference component.
        /// </para>
        /// </summary>
        public InferenceComponentContainerSpecificationSummary Container
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
        /// The name of the SageMaker AI model object that is deployed with the inference component.
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