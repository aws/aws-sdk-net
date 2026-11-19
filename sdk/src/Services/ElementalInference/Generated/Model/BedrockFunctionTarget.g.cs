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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// An Amazon Bedrock model to invoke. Elemental Inference invokes the model in your account
    /// by assuming the feed's access role, so a feed that runs this function must specify
    /// an accessRoleArn. The invocation is subject to your Amazon Bedrock quotas and appears
    /// on your bill.
    /// </summary>
    public partial class BedrockFunctionTarget
    {
        /// <summary>
        /// Gets and sets the property Api. 
        /// <para>
        /// The Amazon Bedrock API to call. The only valid value is INVOKE_MODEL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BedrockApi Api { get; set; }

        /// <summary>
        /// Checks to see if the Api property is set.
        /// </summary>
        internal bool IsSetApi() => this.Api != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model to invoke. Specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A model ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An inference profile ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of a custom model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of a provisioned model.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Elemental Inference invokes the model in the Region of the feed. To use a model in
        /// other Regions, specify a cross-Region inference profile ID. A custom or provisioned
        /// model must be in the Region of the feed. 
        /// </para>
        ///  
        /// <para>
        /// The request expression must produce a request body that this model accepts, and the
        /// model must accept the kind of media that the request expression references. For example,
        /// a text-only model can't accept a request that references media.frames. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;
    }
}
