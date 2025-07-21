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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A tool schema for a gateway target. This structure defines the schema for a tool that
    /// the target exposes through the Model Context Protocol.
    /// </summary>
    public partial class ToolSchema
    {
        private List<ToolDefinition> _inlinePayload = AWSConfigs.InitializeCollections ? new List<ToolDefinition>() : null;
        private S3Configuration _s3;

        /// <summary>
        /// Gets and sets the property InlinePayload. 
        /// <para>
        /// The inline payload of the tool schema. This payload contains the schema definition
        /// directly in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ToolDefinition> InlinePayload
        {
            get { return this._inlinePayload; }
            set { this._inlinePayload = value; }
        }

        // Check to see if InlinePayload property is set
        internal bool IsSetInlinePayload()
        {
            return this._inlinePayload != null && (this._inlinePayload.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// The Amazon S3 location of the tool schema. This location contains the schema definition
        /// file.
        /// </para>
        /// </summary>
        public S3Configuration S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}