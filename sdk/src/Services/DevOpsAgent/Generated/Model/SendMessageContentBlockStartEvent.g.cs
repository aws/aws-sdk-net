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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Event emitted when a new content block starts
    /// </summary>
    public partial class SendMessageContentBlockStartEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Block identifier
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// Zero-based index of the content block
        /// </para>
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// Checks to see if the Index property is set.
        /// </summary>
        internal bool IsSetIndex() => this.Index.HasValue;

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// Optional parent block ID for nested content blocks (e.g. subagent tool calls)
        /// </para>
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// Checks to see if the ParentId property is set.
        /// </summary>
        internal bool IsSetParentId() => this.ParentId != null;

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// Event sequence number
        /// </para>
        /// </summary>
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of content in this block
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
