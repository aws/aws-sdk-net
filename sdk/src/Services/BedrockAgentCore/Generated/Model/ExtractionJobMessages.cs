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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The list of messages that compose this extraction job.
    /// </summary>
    public partial class ExtractionJobMessages
    {
        private List<MessageMetadata> _messagesList = AWSConfigs.InitializeCollections ? new List<MessageMetadata>() : null;

        /// <summary>
        /// Gets and sets the property MessagesList. 
        /// <para>
        /// The list of messages that compose this extraction job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageMetadata> MessagesList
        {
            get { return this._messagesList; }
            set { this._messagesList = value; }
        }

        // Check to see if MessagesList property is set
        internal bool IsSetMessagesList()
        {
            return this._messagesList != null && (this._messagesList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}