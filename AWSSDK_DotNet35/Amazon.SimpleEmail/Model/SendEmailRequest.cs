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
    /// Container for the parameters to the SendEmail operation.
    /// <para>Composes an email message based on input data, and then immediately queues the message for sending. </para> <para><b>IMPORTANT:</b>
    /// You can only send email from verified email addresses and domains. If you have not requested production access to Amazon SES, you must also
    /// verify every recipient email address except for the recipients provided by the Amazon SES mailbox simulator. For more information, go to the
    /// Amazon SES Developer Guide. </para> <para>The total size of the message cannot exceed 10 MB.</para> <para>Amazon SES has a limit on the
    /// total number of recipients per message: The combined number of To:, CC: and BCC: email addresses cannot exceed 50. If you need to send an
    /// email message to a larger audience, you can divide your recipient list into groups of 50 or fewer, and then call Amazon SES repeatedly to
    /// send the message to each group. </para> <para>For every message that you send, the total number of recipients (To:, CC: and BCC:) is counted
    /// against your <i>sending quota</i> - the maximum number of emails you can send in a 24-hour period. For information about your sending quota,
    /// go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html" >Amazon SES Developer Guide</a> .
    /// </para>
    /// </summary>
    public partial class SendEmailRequest : AmazonWebServiceRequest
    {
        private string source;
        private Destination destination;
        private Message message;
        private List<string> replyToAddresses = new List<string>();
        private string returnPath;
        /// <summary>
        /// Default constructor for a new SendEmailRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public SendEmailRequest() {}
    
        /// <summary>
        /// Constructs a new SendEmailRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="source"> The identity's email address. By default, the string must be 7-bit ASCII. If the text must contain any other
        /// characters, then you must use MIME encoded-word syntax (RFC 2047) instead of a literal string. MIME encoded-word syntax uses the following
        /// form: <c>=?charset?encoding?encoded-text?=</c>. For more information, see <a href="http://tools.ietf.org/html/rfc2047">RFC 2047</a>.
        /// </param>
        /// <param name="destination"> The destination for this email, composed of To:, CC:, and BCC: fields. </param>
        /// <param name="message"> The message to be sent. </param>
        public SendEmailRequest(string source, Destination destination, Message message)
        {
            this.source = source;
            this.destination = destination;
            this.message = message;
        }
    

        /// <summary>
        /// The identity's email address. By default, the string must be 7-bit ASCII. If the text must contain any other characters, then you must use
        /// MIME encoded-word syntax (RFC 2047) instead of a literal string. MIME encoded-word syntax uses the following form:
        /// <c>=?charset?encoding?encoded-text?=</c>. For more information, see <a href="http://tools.ietf.org/html/rfc2047">RFC 2047</a>.
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
        /// The destination for this email, composed of To:, CC:, and BCC: fields.
        ///  
        /// </summary>
        public Destination Destination
        {
            get { return this.destination; }
            set { this.destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this.destination != null;
        }

        /// <summary>
        /// The message to be sent.
        ///  
        /// </summary>
        public Message Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;
        }

        /// <summary>
        /// The reply-to email address(es) for the message. If the recipient replies to the message, each reply-to address will receive the reply.
        ///  
        /// </summary>
        public List<string> ReplyToAddresses
        {
            get { return this.replyToAddresses; }
            set { this.replyToAddresses = value; }
        }

        // Check to see if ReplyToAddresses property is set
        internal bool IsSetReplyToAddresses()
        {
            return this.replyToAddresses.Count > 0;
        }

        /// <summary>
        /// The email address to which bounce notifications are to be forwarded. If the message cannot be delivered to the recipient, then an error
        /// message will be returned from the recipient's ISP; this message will then be forwarded to the email address specified by the
        /// <c>ReturnPath</c> parameter.
        ///  
        /// </summary>
        public string ReturnPath
        {
            get { return this.returnPath; }
            set { this.returnPath = value; }
        }

        // Check to see if ReturnPath property is set
        internal bool IsSetReturnPath()
        {
            return this.returnPath != null;
        }

    }
}
    
