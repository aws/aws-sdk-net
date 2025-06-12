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
    /// A tool result block that contains the results for a tool request that the model previously
    /// made.
    /// </summary>
    public partial class ToolResultBlock
    {
        private List<ToolResultContentBlock> _content = AWSConfigs.InitializeCollections ? new List<ToolResultContentBlock>() : null;
        private ToolResultStatus _status;
        private string _toolUseId;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content for tool result content block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ToolResultContentBlock> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && (this._content.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for the tool result content block.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is only supported Anthropic Claude 3 models.
        /// </para>
        ///  </note>
        /// </summary>
        public ToolResultStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ToolUseId. 
        /// <para>
        /// The ID of the tool request that this is the result for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ToolUseId
        {
            get { return this._toolUseId; }
            set { this._toolUseId = value; }
        }

        // Check to see if ToolUseId property is set
        internal bool IsSetToolUseId()
        {
            return this._toolUseId != null;
        }

    }
}