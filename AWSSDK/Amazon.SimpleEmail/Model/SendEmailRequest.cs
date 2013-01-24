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
    /// <para>Composes an email message based on input data, and then immediately queues the message for sending. </para> <para><b>IMPORTANT:</b>If
    /// you have not yet requested production access to Amazon SES, then you will only be able to send email to and from verified email addresses
    /// and domains. For more information, go to the Amazon SES Developer Guide. </para> <para>The total size of the message cannot exceed 10
    /// MB.</para> <para>Amazon SES has a limit on the total number of recipients per message: The combined number of To:, CC: and BCC: email
    /// addresses cannot exceed 50. If you need to send an email message to a larger audience, you can divide your recipient list into groups of 50
    /// or fewer, and then call Amazon SES repeatedly to send the message to each group. </para> <para>For every message that you send, the total
    /// number of recipients (To:, CC: and BCC:) is counted against your <i>sending quota</i> - the maximum number of emails you can send in a
    /// 24-hour period. For information about your sending quota, go to the "Managing Your Sending Activity" section of theAmazon SES Developer
    /// Guide. </para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.SendEmail"/>
    public class SendEmailRequest : AmazonWebServiceRequest
    {
        private string source;
        private Destination destination;
        private Message message;
        private List<string> replyToAddresses = new List<string>();
        private string returnPath;
        /// <summary>
        /// Default constructor for a new SendEmailRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public SendEmailRequest() {}
    
        /// <summary>
        /// Constructs a new SendEmailRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="source"> The identity's email address. </param>
        /// <param name="destination"> The destination for this email, composed of To:, CC:, and BCC: fields. </param>
        /// <param name="message"> The message to be sent. </param>
        public SendEmailRequest(string source, Destination destination, Message message) 
        {
            this.source = source;
            this.destination = destination;
            this.message = message;
        }
    

        /// <summary>
        /// The identity's email address.
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
        public SendEmailRequest WithSource(string source)
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
        /// The destination for this email, composed of To:, CC:, and BCC: fields.
        ///  
        /// </summary>
        public Destination Destination
        {
            get { return this.destination; }
            set { this.destination = value; }
        }

        /// <summary>
        /// Sets the Destination property
        /// </summary>
        /// <param name="destination">The value to set for the Destination property </param>
        /// <returns>this instance</returns>
        public SendEmailRequest WithDestination(Destination destination)
        {
            this.destination = destination;
            return this;
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

        /// <summary>
        /// Sets the Message property
        /// </summary>
        /// <param name="message">The value to set for the Message property </param>
        /// <returns>this instance</returns>
        public SendEmailRequest WithMessage(Message message)
        {
            this.message = message;
            return this;
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
        /// <summary>
        /// Adds elements to the ReplyToAddresses collection
        /// </summary>
        /// <param name="replyToAddresses">The values to add to the ReplyToAddresses collection </param>
        /// <returns>this instance</returns>
        public SendEmailRequest WithReplyToAddresses(params string[] replyToAddresses)
        {
            foreach (string element in replyToAddresses)
            {
                this.replyToAddresses.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ReplyToAddresses collection
        /// </summary>
        /// <param name="replyToAddresses">The values to add to the ReplyToAddresses collection </param>
        /// <returns>this instance</returns>
        public SendEmailRequest WithReplyToAddresses(IEnumerable<string> replyToAddresses)
        {
            foreach (string element in replyToAddresses)
            {
                this.replyToAddresses.Add(element);
            }

            return this;
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

        /// <summary>
        /// Sets the ReturnPath property
        /// </summary>
        /// <param name="returnPath">The value to set for the ReturnPath property </param>
        /// <returns>this instance</returns>
        public SendEmailRequest WithReturnPath(string returnPath)
        {
            this.returnPath = returnPath;
            return this;
        }
            

        // Check to see if ReturnPath property is set
        internal bool IsSetReturnPath()
        {
            return this.returnPath != null;       
        }
    }
}
    
