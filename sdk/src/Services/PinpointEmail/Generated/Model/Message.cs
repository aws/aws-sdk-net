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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
    /// Represents the email message that you're sending. The <c>Message</c> object consists
    /// of a subject line and a message body.
    /// </summary>
    public partial class Message
    {
        private Body _body;
        private Content _subject;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the message. You can specify an HTML version of the message, a text-only
        /// version of the message, or both.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Body Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line of the email. The subject line can only contain 7-bit ASCII characters.
        /// However, you can specify non-ASCII characters in the subject line by using encoded-word
        /// syntax, as described in <a href="https://tools.ietf.org/html/rfc2047">RFC 2047</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Content Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}