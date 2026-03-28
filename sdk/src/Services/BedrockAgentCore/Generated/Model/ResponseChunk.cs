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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Response chunk containing exactly one of: contentStart, contentDelta, or contentStop
    /// </summary>
    public partial class ResponseChunk
        : IEventStreamEvent
    {
        private ContentDeltaEvent _contentDelta;
        private ContentStartEvent _contentStart;
        private ContentStopEvent _contentStop;

        /// <summary>
        /// Gets and sets the property ContentDelta. 
        /// <para>
        /// Middle chunks - stdout/stderr output
        /// </para>
        /// </summary>
        public ContentDeltaEvent ContentDelta
        {
            get { return this._contentDelta; }
            set { this._contentDelta = value; }
        }

        // Check to see if ContentDelta property is set
        internal bool IsSetContentDelta()
        {
            return this._contentDelta != null;
        }

        /// <summary>
        /// Gets and sets the property ContentStart. 
        /// <para>
        /// First chunk - indicates command execution has started
        /// </para>
        /// </summary>
        public ContentStartEvent ContentStart
        {
            get { return this._contentStart; }
            set { this._contentStart = value; }
        }

        // Check to see if ContentStart property is set
        internal bool IsSetContentStart()
        {
            return this._contentStart != null;
        }

        /// <summary>
        /// Gets and sets the property ContentStop. 
        /// <para>
        /// Last chunk - indicates command execution has completed
        /// </para>
        /// </summary>
        public ContentStopEvent ContentStop
        {
            get { return this._contentStop; }
            set { this._contentStop = value; }
        }

        // Check to see if ContentStop property is set
        internal bool IsSetContentStop()
        {
            return this._contentStop != null;
        }

    }
}