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

namespace Amazon.OpenSearchMemory.Model
{
    /// <summary>
    /// The event content. Exactly one member must be set.
    /// </summary>
    public partial class EventPayload
    {
        /// <summary>
        /// Gets and sets the property Blob. 
        /// <para>
        /// A document stored in Amazon S3, such as a PDF.
        /// </para>
        /// </summary>
        public BlobPayload Blob { get; set; }

        /// <summary>
        /// Checks to see if the Blob property is set.
        /// </summary>
        internal bool IsSetBlob() => this.Blob != null;

        /// <summary>
        /// Gets and sets the property Conversational. 
        /// <para>
        /// Conversation turns.
        /// </para>
        /// </summary>
        public ConversationalPayload Conversational { get; set; }

        /// <summary>
        /// Checks to see if the Conversational property is set.
        /// </summary>
        internal bool IsSetConversational() => this.Conversational != null;

        /// <summary>
        /// Gets and sets the property StructuredData. 
        /// <para>
        /// Structured (non-conversational) content, for example a deployment result that an agent
        /// should remember.
        /// </para>
        /// </summary>
        public StructuredDataPayload StructuredData { get; set; }

        /// <summary>
        /// Checks to see if the StructuredData property is set.
        /// </summary>
        internal bool IsSetStructuredData() => this.StructuredData != null;
    }
}
