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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
    /// Container for the parameters to the GetInferenceProfile operation.
    /// Gets information about an inference profile. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
    /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
    /// Amazon Bedrock User Guide.
    /// </summary>
    public partial class GetInferenceProfileRequest : AmazonBedrockRequest
    {
        private string _inferenceProfileIdentifier;

        /// <summary>
        /// Gets and sets the property InferenceProfileIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string InferenceProfileIdentifier
        {
            get { return this._inferenceProfileIdentifier; }
            set { this._inferenceProfileIdentifier = value; }
        }

        // Check to see if InferenceProfileIdentifier property is set
        internal bool IsSetInferenceProfileIdentifier()
        {
            return this._inferenceProfileIdentifier != null;
        }

    }
}