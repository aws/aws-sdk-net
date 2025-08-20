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
    /// The body of an <c>InvokeModel</c> API request for token counting. This structure mirrors
    /// the input format for the <c>InvokeModel</c> operation, allowing you to count tokens
    /// for raw text inference requests.
    /// </summary>
    public partial class InvokeModelTokensRequest
    {
        private MemoryStream _body;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The request body to count tokens for, formatted according to the model's expected
        /// input format. To learn about the input format for different models, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Model
        /// inference parameters and responses</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=25000000)]
        public MemoryStream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

    }
}