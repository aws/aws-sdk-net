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
    /// Contains information about why a flow completed.
    /// </summary>
    public partial class FlowCompletionEvent
        : IEventStreamEvent
    {
        private FlowCompletionReason _completionReason;

        /// <summary>
        /// Gets and sets the property CompletionReason. 
        /// <para>
        /// The reason that the flow completed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowCompletionReason CompletionReason
        {
            get { return this._completionReason; }
            set { this._completionReason = value; }
        }

        // Check to see if CompletionReason property is set
        internal bool IsSetCompletionReason()
        {
            return this._completionReason != null;
        }

    }
}