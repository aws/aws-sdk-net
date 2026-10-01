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
    /// Tool invocation message content
    /// </summary>
    public partial class SpanToolUseValue
    {
        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// The tool input arguments
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Amazon.Runtime.Documents.Document Arguments { get; set; }

        /// <summary>
        /// Checks to see if the Arguments property is set.
        /// </summary>
        internal bool IsSetArguments() => !this.Arguments.IsNull();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The tool name
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ToolUseId. 
        /// <para>
        /// Unique ID for this tool invocation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ToolUseId { get; set; }

        /// <summary>
        /// Checks to see if the ToolUseId property is set.
        /// </summary>
        internal bool IsSetToolUseId() => this.ToolUseId != null;
    }
}
