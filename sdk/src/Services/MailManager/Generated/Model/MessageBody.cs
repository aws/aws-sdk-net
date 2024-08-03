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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The textual body content of an email message.
    /// </summary>
    public partial class MessageBody
    {
        private string _html;
        private bool? _messageMalformed;
        private string _text;

        /// <summary>
        /// Gets and sets the property Html. 
        /// <para>
        /// The HTML body content of the message.
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
        /// Gets and sets the property MessageMalformed. 
        /// <para>
        /// A flag indicating if the email was malformed.
        /// </para>
        /// </summary>
        public bool? MessageMalformed
        {
            get { return this._messageMalformed; }
            set { this._messageMalformed = value; }
        }

        // Check to see if MessageMalformed property is set
        internal bool IsSetMessageMalformed()
        {
            return this._messageMalformed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The plain text body content of the message.
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