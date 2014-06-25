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
    /// Container for the parameters to the SendEmail operation.
    /// Composes an email message based on input data, and then immediately queues the message
    ///            for sending.        
    /// 
    ///         <important>            You can only send email from verified email addresses
    /// and domains.             If you have not requested production access to Amazon SES,
    /// you must also             verify every recipient email address except for the recipients
    /// provided             by the Amazon SES mailbox simulator. For more information, go
    /// to the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
    /// SES                Developer Guide</a>.        </important>        
    /// <para>
    /// The total size of the message cannot exceed 10 MB.
    /// </para>
    ///         
    /// <para>
    /// Amazon SES has a limit on the total number of recipients per message: The combined
    /// number            of To:, CC: and BCC: email addresses cannot exceed 50. If you need
    /// to send an email            message to a larger audience, you can divide your recipient
    /// list into groups of 50 or            fewer, and then call Amazon SES repeatedly to
    /// send the message to each group.        
    /// </para>
    ///         
    /// <para>
    /// For every message that you send, the total number of recipients (To:, CC: and BCC:)
    /// is            counted against your            <i>sending quota</i>            - the
    /// maximum number of emails you can send in            a 24-hour period. For information
    /// about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
    /// SES                Developer Guide</a>.        
    /// </para>
    /// </summary>
    public partial class SendEmailRequest : AmazonWebServiceRequest
    {
        private Destination _destination;
        private Message _message;
        private List<string> _replyToAddresses = new List<string>();
        private string _returnPath;
        private string _source;


        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination for this email, composed of To:, CC:, and BCC: fields.
        /// </para>
        /// </summary>
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }


        /// <summary>
        /// Sets the Destination property
        /// </summary>
        /// <param name="destination">The value to set for the Destination property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendEmailRequest WithDestination(Destination destination)
        {
            this._destination = destination;
            return this;
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }


        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message to be sent.
        /// </para>
        /// </summary>
        public Message Message
        {
            get { return this._message; }
            set { this._message = value; }
        }


        /// <summary>
        /// Sets the Message property
        /// </summary>
        /// <param name="message">The value to set for the Message property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendEmailRequest WithMessage(Message message)
        {
            this._message = message;
            return this;
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }


        /// <summary>
        /// Gets and sets the property ReplyToAddresses. 
        /// <para>
        /// The reply-to email address(es) for the message. If the recipient replies to the message,
        /// each reply-to address            will receive the reply.        
        /// </para>
        /// </summary>
        public List<string> ReplyToAddresses
        {
            get { return this._replyToAddresses; }
            set { this._replyToAddresses = value; }
        }

        /// <summary>
        /// Sets the ReplyToAddresses property
        /// </summary>
        /// <param name="replyToAddresses">The values to add to the ReplyToAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendEmailRequest WithReplyToAddresses(params string[] replyToAddresses)
        {
            foreach (var element in replyToAddresses)
            {
                this._replyToAddresses.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ReplyToAddresses property
        /// </summary>
        /// <param name="replyToAddresses">The values to add to the ReplyToAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendEmailRequest WithReplyToAddresses(IEnumerable<string> replyToAddresses)
        {
            foreach (var element in replyToAddresses)
            {
                this._replyToAddresses.Add(element);
            }
            return this;
        }
        // Check to see if ReplyToAddresses property is set
        internal bool IsSetReplyToAddresses()
        {
            return this._replyToAddresses != null && this._replyToAddresses.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ReturnPath. 
        /// <para>
        /// The email address to which bounce notifications are to be forwarded. If the message
        /// cannot be delivered to the            recipient, then an error message will be returned
        /// from the recipient's ISP; this message will then be forwarded            to the email
        /// address specified by the            <code>ReturnPath</code>            parameter.
        ///        
        /// </para>
        /// </summary>
        public string ReturnPath
        {
            get { return this._returnPath; }
            set { this._returnPath = value; }
        }


        /// <summary>
        /// Sets the ReturnPath property
        /// </summary>
        /// <param name="returnPath">The value to set for the ReturnPath property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendEmailRequest WithReturnPath(string returnPath)
        {
            this._returnPath = returnPath;
            return this;
        }

        // Check to see if ReturnPath property is set
        internal bool IsSetReturnPath()
        {
            return this._returnPath != null;
        }


        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The identity's email address.
        /// </para>
        ///         
        /// <para>
        ///             By default, the string must be 7-bit ASCII. If the text must contain any
        /// other characters,             then you must use MIME encoded-word syntax (RFC 2047)
        /// instead of a literal string.             MIME encoded-word syntax uses the following
        /// form: <code>=?charset?encoding?encoded-text?=</code>.             For more information,
        /// see <a href="http://tools.ietf.org/html/rfc2047">RFC 2047</a>.        
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }


        /// <summary>
        /// Sets the Source property
        /// </summary>
        /// <param name="source">The value to set for the Source property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendEmailRequest WithSource(string source)
        {
            this._source = source;
            return this;
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}