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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that defines the entire content of the email, including the message headers,
    /// body content, and attachments. For a simple email message, you specify the subject
    /// and provide both text and HTML versions of the message body. You can also add attachments
    /// to simple and templated messages. For a raw message, you provide a complete MIME-formatted
    /// message, which can include custom headers and attachments.
    /// </summary>
    public partial class EmailContent
    {
        private RawMessage _raw;
        private Message _simple;
        private Template _template;

        /// <summary>
        /// Gets and sets the property Raw. 
        /// <para>
        /// The raw email message. The message has to meet the following criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The message has to contain a header and a body, separated by one blank line.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All of the required header fields must be present in the message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each part of a multipart MIME message must be formatted properly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you include attachments, they must be in a file format that the Amazon SES API
        /// v2 supports. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The raw data of the message needs to base64-encoded if you are accessing Amazon SES
        /// directly through the HTTPS interface. If you are accessing Amazon SES using an Amazon
        /// Web Services SDK, the SDK takes care of the base 64-encoding for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If any of the MIME parts in your message contain content that is outside of the 7-bit
        /// ASCII character range, you should encode that content to ensure that recipients' email
        /// clients render the message properly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The length of any single line of text in the message can't exceed 1,000 characters.
        /// This restriction is defined in <a href="https://tools.ietf.org/html/rfc5321">RFC 5321</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RawMessage Raw
        {
            get { return this._raw; }
            set { this._raw = value; }
        }

        // Check to see if Raw property is set
        internal bool IsSetRaw()
        {
            return this._raw != null;
        }

        /// <summary>
        /// Gets and sets the property Simple. 
        /// <para>
        /// The simple email message. The message consists of a subject, message body and attachments
        /// list.
        /// </para>
        /// </summary>
        public Message Simple
        {
            get { return this._simple; }
            set { this._simple = value; }
        }

        // Check to see if Simple property is set
        internal bool IsSetSimple()
        {
            return this._simple != null;
        }

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The template to use for the email message.
        /// </para>
        /// </summary>
        public Template Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

    }
}