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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains a part of an agent response and citations for it.
    /// </summary>
    public partial class InlineAgentPayloadPart
        : IEventStreamEvent
    {
        private Attribution _attribution;
        private MemoryStream _bytes;

        /// <summary>
        /// Gets and sets the property Attribution. 
        /// <para>
        /// Contains citations for a part of an agent response.
        /// </para>
        /// </summary>
        public Attribution Attribution
        {
            get { return this._attribution; }
            set { this._attribution = value; }
        }

        // Check to see if Attribution property is set
        internal bool IsSetAttribution()
        {
            return this._attribution != null;
        }

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// A part of the agent response in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000000)]
        public MemoryStream Bytes
        {
            get { return this._bytes; }
            set { this._bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this._bytes != null;
        }

    }
}