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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The message data.
    /// </summary>
    public partial class MessageData
    {
        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The message data as a structured JSON document. This is the payload for a message
        /// of type <c>DATA</c>, and must be a JSON object at the root level.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => !this.Data.IsNull();

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The message data in text type.
        /// </para>
        /// </summary>
        public TextMessage Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property ToolUseResult. 
        /// <para>
        /// The result of tool usage in the message.
        /// </para>
        /// </summary>
        public ToolUseResultData ToolUseResult { get; set; }

        /// <summary>
        /// Checks to see if the ToolUseResult property is set.
        /// </summary>
        internal bool IsSetToolUseResult() => this.ToolUseResult != null;
    }
}
