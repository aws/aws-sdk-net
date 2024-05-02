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
    /// The content of the email, composed of a subject line, an HTML part, and a text-only
    /// part.
    /// </summary>
    public partial class EmailTemplateContent
    {
        private string _html;
        private string _subject;
        private string _text;

        /// <summary>
        /// Gets and sets the property Html. 
        /// <para>
        /// The HTML body of the email.
        /// </para>
        /// </summary>
        public string Html
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
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line of the email.
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The email body that will be visible to recipients whose email clients do not display
        /// HTML.
        /// </para>
        /// </summary>
        public string Text
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