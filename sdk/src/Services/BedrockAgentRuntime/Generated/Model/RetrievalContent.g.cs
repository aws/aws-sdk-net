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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The content retrieved from a knowledge source.
    /// </summary>
    public partial class RetrievalContent
    {
        /// <summary>
        /// Gets and sets the property ByteContent. 
        /// <para>
        /// The binary content of the retrieved item.
        /// </para>
        /// </summary>
        public MemoryStream ByteContent { get; set; }

        /// <summary>
        /// Checks to see if the ByteContent property is set.
        /// </summary>
        internal bool IsSetByteContent() => this.ByteContent != null;

        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The MIME type of the retrieved content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MimeType { get; set; }

        /// <summary>
        /// Checks to see if the MimeType property is set.
        /// </summary>
        internal bool IsSetMimeType() => this.MimeType != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text content of the retrieved item.
        /// </para>
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
