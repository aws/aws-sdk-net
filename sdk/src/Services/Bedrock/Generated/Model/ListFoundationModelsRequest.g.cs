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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the ListFoundationModels operation. Lists Amazon Bedrock
    /// foundation models that you can use. You can filter the results with the request parameters.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/foundation-models.html">Foundation
    /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </summary>
    public partial class ListFoundationModelsRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property ByCustomizationType. 
        /// <para>
        /// Return models that support the customization type that you specify. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        public ModelCustomization ByCustomizationType { get; set; }

        /// <summary>
        /// Checks to see if the ByCustomizationType property is set.
        /// </summary>
        internal bool IsSetByCustomizationType() => this.ByCustomizationType != null;

        /// <summary>
        /// Gets and sets the property ByInferenceType. 
        /// <para>
        /// Return models that support the inference type that you specify. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        /// </summary>
        public InferenceType ByInferenceType { get; set; }

        /// <summary>
        /// Checks to see if the ByInferenceType property is set.
        /// </summary>
        internal bool IsSetByInferenceType() => this.ByInferenceType != null;

        /// <summary>
        /// Gets and sets the property ByOutputModality. 
        /// <para>
        /// Return models that support the output modality that you specify.
        /// </para>
        /// </summary>
        public ModelModality ByOutputModality { get; set; }

        /// <summary>
        /// Checks to see if the ByOutputModality property is set.
        /// </summary>
        internal bool IsSetByOutputModality() => this.ByOutputModality != null;

        /// <summary>
        /// Gets and sets the property ByProvider. 
        /// <para>
        /// Return models belonging to the model provider that you specify.
        /// </para>
        /// </summary>
        public string ByProvider { get; set; }

        /// <summary>
        /// Checks to see if the ByProvider property is set.
        /// </summary>
        internal bool IsSetByProvider() => this.ByProvider != null;
    }
}
