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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A structure representing a response chunk that contains exactly one of the possible
    /// event types: <c>contentStart</c>, <c>contentDelta</c>, or <c>contentStop</c>.
    /// </summary>
    public partial class ResponseChunk : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property ContentDelta. 
        /// <para>
        /// An event containing incremental output (stdout or stderr) from the command execution.
        /// These are the middle chunks.
        /// </para>
        /// </summary>
        public ContentDeltaEvent ContentDelta { get; set; }

        /// <summary>
        /// Checks to see if the ContentDelta property is set.
        /// </summary>
        internal bool IsSetContentDelta() => this.ContentDelta != null;

        /// <summary>
        /// Gets and sets the property ContentStart. 
        /// <para>
        /// An event indicating the start of content streaming from the command execution. This
        /// is the first chunk received.
        /// </para>
        /// </summary>
        public ContentStartEvent ContentStart { get; set; }

        /// <summary>
        /// Checks to see if the ContentStart property is set.
        /// </summary>
        internal bool IsSetContentStart() => this.ContentStart != null;

        /// <summary>
        /// Gets and sets the property ContentStop. 
        /// <para>
        /// An event indicating the completion of the command execution, including the exit code
        /// and final status. This is the last chunk received.
        /// </para>
        /// </summary>
        public ContentStopEvent ContentStop { get; set; }

        /// <summary>
        /// Checks to see if the ContentStop property is set.
        /// </summary>
        internal bool IsSetContentStop() => this.ContentStop != null;
    }
}
