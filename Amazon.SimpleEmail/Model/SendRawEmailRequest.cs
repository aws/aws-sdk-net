/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the SendRawEmail operation.
    /// <para>Sends an email message, with header and content specified by the
    /// client. The <c>SendRawEmail</c> action is useful for sending multipart
    /// MIME emails, with attachments or inline content.</para> <para>The raw
    /// text of the message must comply with Internet email standards;
    /// otherwise, the message cannot be sent. For more information, go to
    /// the Amazon SES Developer Guide.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SendRawEmail"/>
    public class SendRawEmailRequest : AmazonWebServiceRequest
    {
        private string source;
        private List<string> destinations = new List<string>();
        private RawMessage rawMessage;
        /// <summary>
        /// Default constructor for a new SendRawEmailRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public SendRawEmailRequest() {}
    
        /// <summary>
        /// Constructs a new SendRawEmailRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="rawMessage"> The raw text of the message. The client is responsible for ensuring the following: <ul> <li>Message must contain a
        /// header and a body, separated by a blank line.</li> <li>All required header fields must be present.</li> <li>Each part of a multipart MIME
        /// message must be formatted properly.</li> <li>MIME content types must be among those supported by Amazon SES. Refer to the <a
        /// href="http://docs.amazonwebservices.com/ses/latest/DeveloperGuide">Amazon SES Developer Guide</a> for more details.</li> <li>Content must be
        /// base64-encoded, if MIME requires it.</li> </ul> </param>
        public SendRawEmailRequest(RawMessage rawMessage) 
        {
            this.rawMessage = rawMessage;
        }
    

        /// <summary>
        /// The sender's email address.
        ///  
        /// </summary>
        public string Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        /// <summary>
        /// Sets the Source property
        /// </summary>
        /// <param name="source">The value to set for the Source property </param>
        /// <returns>this instance</returns>
        public SendRawEmailRequest WithSource(string source)
        {
            this.source = source;
            return this;
        }
            

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this.source != null;       
        }

        /// <summary>
        /// A list of destinations for the message.
        ///  
        /// </summary>
        public List<string> Destinations
        {
            get { return this.destinations; }
            set { this.destinations = value; }
        }
        /// <summary>
        /// Adds elements to the Destinations collection
        /// </summary>
        /// <param name="destinations">The values to add to the Destinations collection </param>
        /// <returns>this instance</returns>
        public SendRawEmailRequest WithDestinations(params string[] destinations)
        {
            foreach (string element in destinations)
            {
                this.destinations.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Destinations collection
        /// </summary>
        /// <param name="destinations">The values to add to the Destinations collection </param>
        /// <returns>this instance</returns>
        public SendRawEmailRequest WithDestinations(IEnumerable<string> destinations)
        {
            foreach (string element in destinations)
            {
                this.destinations.Add(element);
            }

            return this;
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this.destinations.Count > 0;       
        }

        /// <summary>
        /// The raw text of the message. The client is responsible for ensuring the following: <ul> <li>Message must contain a header and a body,
        /// separated by a blank line.</li> <li>All required header fields must be present.</li> <li>Each part of a multipart MIME message must be
        /// formatted properly.</li> <li>MIME content types must be among those supported by Amazon SES. Refer to the <a
        /// href="http://docs.amazonwebservices.com/ses/latest/DeveloperGuide">Amazon SES Developer Guide</a> for more details.</li> <li>Content must be
        /// base64-encoded, if MIME requires it.</li> </ul>
        ///  
        /// </summary>
        public RawMessage RawMessage
        {
            get { return this.rawMessage; }
            set { this.rawMessage = value; }
        }

        /// <summary>
        /// Sets the RawMessage property
        /// </summary>
        /// <param name="rawMessage">The value to set for the RawMessage property </param>
        /// <returns>this instance</returns>
        public SendRawEmailRequest WithRawMessage(RawMessage rawMessage)
        {
            this.rawMessage = rawMessage;
            return this;
        }
            

        // Check to see if RawMessage property is set
        internal bool IsSetRawMessage()
        {
            return this.rawMessage != null;       
        }
    }
}
    
