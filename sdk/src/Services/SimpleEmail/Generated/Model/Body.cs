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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the body of the message. You can specify text, HTML, or both. If you use
    /// both, then the message should display correctly in the widest variety of email clients.
    /// </summary>
    public partial class Body
    {
        private Content _html;
        private Content _text;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Body() { }

        /// <summary>
        /// Instantiates Body with the parameterized properties
        /// </summary>
        /// <param name="text">The content of the message, in text format. Use this for text-based email clients, or clients on high-latency networks (such as mobile devices).</param>
        public Body(Content text)
        {
            _text = text;
        }

        /// <summary>
        /// Gets and sets the property Html. 
        /// <para>
        /// The content of the message, in HTML format. Use this for email clients that can process
        /// HTML. You can include clickable links, formatted text, and much more in an HTML message.
        /// </para>
        /// </summary>
        public Content Html
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
        /// Gets and sets the property Text. 
        /// <para>
        /// The content of the message, in text format. Use this for text-based email clients,
        /// or clients on high-latency networks (such as mobile devices).
        /// </para>
        /// </summary>
        public Content Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}