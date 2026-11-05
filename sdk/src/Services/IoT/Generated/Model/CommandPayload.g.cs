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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The command payload object that contains the instructions for the device to process.
    /// </summary>
    public partial class CommandPayload
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The static payload file for the command.
        /// </para>
        /// </summary>
        public MemoryStream Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type that specifies the format type of the payload file. This field must
        /// use a type/subtype format, such as <c>application/json</c>. For information about
        /// various content types, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/MIME_types/Common_types">Common
        /// MIME types</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;
    }
}
