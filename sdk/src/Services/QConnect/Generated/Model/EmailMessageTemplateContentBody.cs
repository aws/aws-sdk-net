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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
        private MessageTemplateBodyContentProvider _html;
        private MessageTemplateBodyContentProvider _plainText;

        /// <summary>
        /// Gets and sets the property Html. 
        /// <para>
        /// The message body, in HTML format, to use in email messages that are based on the message
        /// template. We recommend using HTML format for email clients that render HTML content.
        /// You can include links, formatted text, and more in an HTML message.
        /// </para>
        /// </summary>
        public MessageTemplateBodyContentProvider Html
        {
            get { return this._html; }
            set { this._html = value; }
        }

        // Check to see if Html property is set
        internal bool IsSetHtml()
        {
            return this._html != null;
        }

        /// <summary>
        /// Gets and sets the property PlainText. 
        /// <para>
        /// The message body, in plain text format, to use in email messages that are based on
        /// the message template. We recommend using plain text format for email clients that
        /// don't render HTML content and clients that are connected to high-latency networks,
        /// such as mobile devices.
        /// </para>
        /// </summary>
        public MessageTemplateBodyContentProvider PlainText
        {
            get { return this._plainText; }
            set { this._plainText = value; }
        }

        // Check to see if PlainText property is set
        internal bool IsSetPlainText()
        {
            return this._plainText != null;
        }

    }
}