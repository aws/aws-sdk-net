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
    /// Represents the message to be sent, composed of a subject and a body.
    /// </summary>
    public partial class Message
    {
        private Body _body;
        private Content _subject;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Message() { }

        /// <summary>
        /// Instantiates Message with the parameterized properties
        /// </summary>
        /// <param name="subject">The subject of the message: A short summary of the content, which appears in the recipient's inbox.</param>
        /// <param name="body">The message body.</param>
        public Message(Content subject, Body body)
        {
            _subject = subject;
            _body = body;
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The message body.
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
        /// The subject of the message: A short summary of the content, which appears in the recipient's
        /// inbox.
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