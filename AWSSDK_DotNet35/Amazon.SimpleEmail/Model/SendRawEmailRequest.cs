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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SendRawEmail operation.
    /// <para>Sends an email message, with header and content specified by the client. The <c>SendRawEmail</c> action is useful for sending
    /// multipart MIME emails. The raw text of the message must comply with Internet email standards; otherwise, the message cannot be sent. </para>
    /// <para><b>IMPORTANT:</b> You can only send email from verified email addresses and domains. If you have not requested production access to
    /// Amazon SES, you must also verify every recipient email address except for the recipients provided by the Amazon SES mailbox simulator. For
    /// more information, go to the Amazon SES Developer Guide. </para> <para>The total size of the message cannot exceed 10 MB. This includes any
    /// attachments that are part of the message.</para> <para>Amazon SES has a limit on the total number of recipients per message: The combined
    /// number of To:, CC: and BCC: email addresses cannot exceed 50. If you need to send an email message to a larger audience, you can divide your
    /// recipient list into groups of 50 or fewer, and then call Amazon SES repeatedly to send the message to each group. </para> <para>For every
    /// message that you send, the total number of recipients (To:, CC: and BCC:) is counted against your <i>sending quota</i> - the maximum number
    /// of emails you can send in a 24-hour period. For information about your sending quota, go to the <a
    /// href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html" >Amazon SES Developer Guide</a> .
    /// </para>
    /// </summary>
    public partial class SendRawEmailRequest : AmazonSimpleEmailServiceRequest
    {
        private string source;
        private List<string> destinations = new List<string>();
        private RawMessage rawMessage;

        /// <summary>
        /// Default constructor for a new SendRawEmailRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public SendRawEmailRequest() {}
    
        /// <summary>
        /// Constructs a new SendRawEmailRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="rawMessage"> The raw text of the message. The client is responsible for ensuring the following: <ul> <li>Message must contain a
        /// header and a body, separated by a blank line.</li> <li>All required header fields must be present.</li> <li>Each part of a multipart MIME
        /// message must be formatted properly.</li> <li>MIME content types must be among those supported by Amazon SES. For more information, go to the
        /// <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types.html">Amazon SES Developer Guide</a>. </li> <li>Content must be
        /// base64-encoded, if MIME requires it.</li> </ul> </param>
        public SendRawEmailRequest(RawMessage rawMessage)
        {
            this.rawMessage = rawMessage;
        }
    

        /// <summary>
        /// The identity's email address. By default, the string must be 7-bit ASCII. If the text must contain any other characters, then you must use
        /// MIME encoded-word syntax (RFC 2047) instead of a literal string. MIME encoded-word syntax uses the following form:
        /// <c>=?charset?encoding?encoded-text?=</c>. For more information, see <a href="http://tools.ietf.org/html/rfc2047">RFC 2047</a>. <note>If you
        /// specify the <c>Source</c> parameter, then bounce notifications and complaints will be sent to this email address. This takes precedence over
        /// any <i>Return-Path</i> header that you might include in the raw text of the message. </note>
        ///  
        /// </summary>
        public string Source
        {
            get { return this.source; }
            set { this.source = value; }
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

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this.destinations.Count > 0;
        }

        /// <summary>
        /// The raw text of the message. The client is responsible for ensuring the following: <ul> <li>Message must contain a header and a body,
        /// separated by a blank line.</li> <li>All required header fields must be present.</li> <li>Each part of a multipart MIME message must be
        /// formatted properly.</li> <li>MIME content types must be among those supported by Amazon SES. For more information, go to the <a
        /// href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types.html">Amazon SES Developer Guide</a>. </li> <li>Content must be
        /// base64-encoded, if MIME requires it.</li> </ul>
        ///  
        /// </summary>
        public RawMessage RawMessage
        {
            get { return this.rawMessage; }
            set { this.rawMessage = value; }
        }

        // Check to see if RawMessage property is set
        internal bool IsSetRawMessage()
        {
            return this.rawMessage != null;
        }

    }
}
    
