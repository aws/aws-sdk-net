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
    /// Container for the parameters to the GetInferenceProfile operation. Gets information
    /// about an inference profile. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
    /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
    /// Amazon Bedrock User Guide.
    /// </summary>
    public partial class GetInferenceProfileRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property InferenceProfileIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string InferenceProfileIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the InferenceProfileIdentifier property is set.
        /// </summary>
        internal bool IsSetInferenceProfileIdentifier() => this.InferenceProfileIdentifier != null;

        /// <summary>
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of a project. Amazon Bedrock uses the project's
        /// trusted access program participation when determining whether to return a system-defined
        /// inference profile. The project must belong to your account in the same AWS Region
        /// and partition as the request.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter or specify <c>default</c>, Amazon Bedrock uses your account's
        /// participation, including organization inheritance.
        /// </para>
        ///  
        /// <para>
        /// A project that doesn't exist or is archived causes a <c>ValidationException</c>. Specifying
        /// a project other than <c>default</c> for an application inference profile also causes
        /// a <c>ValidationException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetProjectIdentifier() => this.ProjectIdentifier != null;
    }
}
