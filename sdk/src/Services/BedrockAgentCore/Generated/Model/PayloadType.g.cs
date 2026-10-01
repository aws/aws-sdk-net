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
    /// Contains the payload content for an event.
    /// </summary>
    public partial class PayloadType
    {
        /// <summary>
        /// Gets and sets the property Blob. 
        /// <para>
        /// The binary content of the payload.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document Blob { get; set; }

        /// <summary>
        /// Checks to see if the Blob property is set.
        /// </summary>
        internal bool IsSetBlob() => !this.Blob.IsNull();

        /// <summary>
        /// Gets and sets the property Conversational. 
        /// <para>
        /// The conversational content of the payload.
        /// </para>
        /// </summary>
        public Conversational Conversational { get; set; }

        /// <summary>
        /// Checks to see if the Conversational property is set.
        /// </summary>
        internal bool IsSetConversational() => this.Conversational != null;

        /// <summary>
        /// Gets and sets the property Json. 
        /// <para>
        /// The JSON content of the payload. Use this type to store non-conversational, JSON-formatted
        /// data, such as behavioral events, activity logs, or system events.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public MemoryJsonData Json { get; set; }

        /// <summary>
        /// Checks to see if the Json property is set.
        /// </summary>
        internal bool IsSetJson() => this.Json != null;
    }
}
