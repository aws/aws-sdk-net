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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains information about content defined inline to ingest into a data source. Choose
    /// a <c>type</c> and include the field that corresponds to it.
    /// </summary>
    public partial class InlineContent
    {
        /// <summary>
        /// Gets and sets the property ByteContent. 
        /// <para>
        /// Contains information about content defined inline in bytes.
        /// </para>
        /// </summary>
        public ByteContentDoc ByteContent { get; set; }

        /// <summary>
        /// Checks to see if the ByteContent property is set.
        /// </summary>
        internal bool IsSetByteContent() => this.ByteContent != null;

        /// <summary>
        /// Gets and sets the property TextContent. 
        /// <para>
        /// Contains information about content defined inline in text.
        /// </para>
        /// </summary>
        public TextContentDoc TextContent { get; set; }

        /// <summary>
        /// Checks to see if the TextContent property is set.
        /// </summary>
        internal bool IsSetTextContent() => this.TextContent != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of inline content to define.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InlineContentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
