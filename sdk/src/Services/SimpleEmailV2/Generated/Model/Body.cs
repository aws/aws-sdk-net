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
    /// Represents the body of the email message.
    /// </summary>
    public partial class Body
    {
        private Content _html;
        private Content _text;

        /// <summary>
        /// Gets and sets the property Html. 
        /// <para>
        /// An object that represents the version of the message that is displayed in email clients
        /// that support HTML. HTML messages can include formatted text, hyperlinks, images, and
        /// more. 
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
        /// An object that represents the version of the message that is displayed in email clients
        /// that don't support HTML, or clients where the recipient has disabled HTML rendering.
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