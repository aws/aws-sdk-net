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
    /// The body to use in email messages.
    /// </summary>
    public partial class EmailMessageTemplateContentBody
    {
        /// <summary>
        /// Gets and sets the property Html. 
        /// <para>
        /// The message body, in HTML format, to use in email messages that are based on the message
        /// template. We recommend using HTML format for email clients that render HTML content.
        /// You can include links, formatted text, and more in an HTML message.
        /// </para>
        /// </summary>
        public MessageTemplateBodyContentProvider Html { get; set; }

        /// <summary>
        /// Checks to see if the Html property is set.
        /// </summary>
        internal bool IsSetHtml() => this.Html != null;

        /// <summary>
        /// Gets and sets the property PlainText. 
        /// <para>
        /// The message body, in plain text format, to use in email messages that are based on
        /// the message template. We recommend using plain text format for email clients that
        /// don't render HTML content and clients that are connected to high-latency networks,
        /// such as mobile devices.
        /// </para>
        /// </summary>
        public MessageTemplateBodyContentProvider PlainText { get; set; }

        /// <summary>
        /// Checks to see if the PlainText property is set.
        /// </summary>
        internal bool IsSetPlainText() => this.PlainText != null;
    }
}
