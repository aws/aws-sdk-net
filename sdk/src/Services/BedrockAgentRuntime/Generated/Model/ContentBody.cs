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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains the body of the API response.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// In the <c>returnControlInvocationResults</c> field of the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html#API_agent-runtime_InvokeAgent_RequestSyntax">InvokeAgent
    /// request</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ContentBody
    {
        private string _body;
        private List<ImageInput> _images = AWSConfigs.InitializeCollections ? new List<ImageInput>() : null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the API response.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property Images. 
        /// <para>
        /// Lists details, including format and source, for the image in the response from the
        /// function call. You can specify only one image and the function in the <c>returnControlInvocationResults</c>
        /// must be a computer use action. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agent-computer-use.html">Configure
        /// an Amazon Bedrock Agent to complete tasks with computer use tools</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImageInput> Images
        {
            get { return this._images; }
            set { this._images = value; }
        }

        // Check to see if Images property is set
        internal bool IsSetImages()
        {
            return this._images != null && (this._images.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}