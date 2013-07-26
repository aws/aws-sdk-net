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
    /// <para>Represents the body of the message. You can specify text, HTML, or both. If you use both, then the message should display correctly in
    /// the widest variety of email clients. </para>
    /// </summary>
    public class Body
    {
        
        private Content text;
        private Content html;
        /// <summary>
        /// Default constructor for a new Body object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public Body() {}
    
        /// <summary>
        /// Constructs a new Body object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="text"> The content of the message, in text format. Use this for text-based email clients, or clients on high-latency networks
        /// (such as mobile devices). </param>
        public Body(Content text)
        {
            this.text = text;
        }
    

        /// <summary>
        /// The content of the message, in text format. Use this for text-based email clients, or clients on high-latency networks (such as mobile
        /// devices).
        ///  
        /// </summary>
        public Content Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this.text != null;
        }

        /// <summary>
        /// The content of the message, in HTML format. Use this for email clients that can process HTML. You can include clickable links, formatted
        /// text, and much more in an HTML message.
        ///  
        /// </summary>
        public Content Html
        {
            get { return this.html; }
            set { this.html = value; }
        }

        // Check to see if Html property is set
        internal bool IsSetHtml()
        {
            return this.html != null;
        }
    }
}
