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
    /// Container for the parameters to the UpdateInferenceComponentRuntimeConfig operation.
    /// Runtime settings for a model that is deployed with an inference component.
    /// </summary>
    public partial class UpdateInferenceComponentRuntimeConfigRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property DesiredRuntimeConfig. 
        /// <para>
        /// Runtime settings for a model that is deployed with an inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceComponentRuntimeConfig DesiredRuntimeConfig { get; set; }

        /// <summary>
        /// Checks to see if the DesiredRuntimeConfig property is set.
        /// </summary>
        internal bool IsSetDesiredRuntimeConfig() => this.DesiredRuntimeConfig != null;

        /// <summary>
        /// Gets and sets the property InferenceComponentName. 
        /// <para>
        /// The name of the inference component to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string InferenceComponentName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceComponentName property is set.
        /// </summary>
        internal bool IsSetInferenceComponentName() => this.InferenceComponentName != null;
    }
}
