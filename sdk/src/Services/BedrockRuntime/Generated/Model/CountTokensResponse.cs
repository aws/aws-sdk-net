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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// This is the response object from the CountTokens operation.
    /// </summary>
    public partial class CountTokensResponse : AmazonWebServiceResponse
    {
        private int? _inputTokens;

        /// <summary>
        /// Gets and sets the property InputTokens. 
        /// <para>
        /// The number of tokens in the provided input according to the specified model's tokenization
        /// rules. This count represents the number of input tokens that would be processed if
        /// the same input were sent to the model in an inference request. Use this value to estimate
        /// costs and ensure your inputs stay within model token limits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? InputTokens
        {
            get { return this._inputTokens; }
            set { this._inputTokens = value; }
        }

        // Check to see if InputTokens property is set
        internal bool IsSetInputTokens()
        {
            return this._inputTokens.HasValue; 
        }

    }
}