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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that represents the content of the email, and optionally a character set
    /// specification.
    /// </summary>
    public partial class Content
    {
        /// <summary>
        /// Gets and sets the property Charset. 
        /// <para>
        /// The character set for the content. Because of the constraints of the SMTP protocol,
        /// Amazon Pinpoint uses 7-bit ASCII by default. If the text includes characters outside
        /// of the ASCII range, you have to specify a character set. For example, you could specify
        /// <c>UTF-8</c>, <c>ISO-8859-1</c>, or <c>Shift_JIS</c>.
        /// </para>
        /// </summary>
        public string Charset { get; set; }

        /// <summary>
        /// Checks to see if the Charset property is set.
        /// </summary>
        internal bool IsSetCharset() => this.Charset != null;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The content of the message itself.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;
    }
}
