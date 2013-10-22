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
    /// <para>Represents the raw data of the message.</para>
    /// </summary>
    public class RawMessage
    {
        
        private MemoryStream data;
        /// <summary>
        /// Default constructor for a new RawMessage object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public RawMessage() {}
    
        /// <summary>
        /// Constructs a new RawMessage object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="data"> The raw data of the message. The client must ensure that the message format complies with Internet email standards
        /// regarding email header fields, MIME types, MIME encoding, and base64 encoding (if necessary). For more information, go to the <a
        /// href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-raw.html">Amazon SES Developer Guide</a>. </param>
        public RawMessage(MemoryStream data)
        {
            this.data = data;
        }
    

        /// <summary>
        /// The raw data of the message. The client must ensure that the message format complies with Internet email standards regarding email header
        /// fields, MIME types, MIME encoding, and base64 encoding (if necessary). For more information, go to the <a
        /// href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-raw.html">Amazon SES Developer Guide</a>.
        ///  
        /// </summary>
        public MemoryStream Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this.data != null;
        }
    }
}
