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
    /// The configuration parameters for the SageMaker Clarify explainer.
    /// </summary>
    public partial class ClarifyExplainerConfig
    {
        /// <summary>
        /// Gets and sets the property EnableExplanations. 
        /// <para>
        /// A JMESPath boolean expression used to filter which records to explain. Explanations
        /// are activated by default. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-create-endpoint.html#clarify-online-explainability-create-endpoint-enable">
        /// <c>EnableExplanations</c> </a>for additional information.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EnableExplanations { get; set; }

        /// <summary>
        /// Checks to see if the EnableExplanations property is set.
        /// </summary>
        internal bool IsSetEnableExplanations() => this.EnableExplanations != null;

        /// <summary>
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        /// The inference configuration parameter for the model container.
        /// </para>
        /// </summary>
        public ClarifyInferenceConfig InferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the InferenceConfig property is set.
        /// </summary>
        internal bool IsSetInferenceConfig() => this.InferenceConfig != null;

        /// <summary>
        /// Gets and sets the property ShapConfig. 
        /// <para>
        /// The configuration for SHAP analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClarifyShapConfig ShapConfig { get; set; }

        /// <summary>
        /// Checks to see if the ShapConfig property is set.
        /// </summary>
        internal bool IsSetShapConfig() => this.ShapConfig != null;
    }
}
