/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        /// Gets and sets the property Body. 
        /// <para>
        /// The message body.
        /// </para>
        /// </summary>
        public Body Body
        {
            get { return this._body; }
            set { this._body = value; }
        }


        /// <summary>
        /// Sets the Body property
        /// </summary>
        /// <param name="body">The value to set for the Body property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Message WithBody(Body body)
        {
            this._body = body;
            return this;
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }


        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject of the message: A short summary of the content, which will appear in the
        /// recipient's inbox.
        /// </para>
        /// </summary>
        public Content Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }


        /// <summary>
        /// Sets the Subject property
        /// </summary>
        /// <param name="subject">The value to set for the Subject property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Message WithSubject(Content subject)
        {
            this._subject = subject;
            return this;
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}