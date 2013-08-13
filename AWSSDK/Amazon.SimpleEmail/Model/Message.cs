/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents the message to be sent, composed of a subject and a body.</para>
    /// </summary>
    public class Message  
    {
        
        private Content subject;
        private Body body;
        /// <summary>
        /// Default constructor for a new Message object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public Message() {}
    
        /// <summary>
        /// Constructs a new Message object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="subject"> The subject of the message: A short summary of the content, which will appear in the recipient's inbox. </param>
        /// <param name="body"> The message body. </param>
        public Message(Content subject, Body body) 
        {
            this.subject = subject;
            this.body = body;
        }
    

        /// <summary>
        /// The subject of the message: A short summary of the content, which will appear in the recipient's inbox.
        ///  
        /// </summary>
        public Content Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        /// <summary>
        /// Sets the Subject property
        /// </summary>
        /// <param name="subject">The value to set for the Subject property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Message WithSubject(Content subject)
        {
            this.subject = subject;
            return this;
        }
            

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this.subject != null;       
        }

        /// <summary>
        /// The message body.
        ///  
        /// </summary>
        public Body Body
        {
            get { return this.body; }
            set { this.body = value; }
        }

        /// <summary>
        /// Sets the Body property
        /// </summary>
        /// <param name="body">The value to set for the Body property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Message WithBody(Body body)
        {
            this.body = body;
            return this;
        }
            

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this.body != null;       
        }
    }
}
