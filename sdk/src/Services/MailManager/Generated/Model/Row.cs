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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// A result row containing metadata for an archived email message.
    /// </summary>
    public partial class Row
    {
        private string _archivedMessageId;
        private string _cc;
        private string _date;
        private Envelope _envelope;
        private string _from;
        private bool? _hasAttachments;
        private string _ingressPointId;
        private string _inReplyTo;
        private string _messageId;
        private List<string> _receivedHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _receivedTimestamp;
        private string _senderHostname;
        private string _senderIpAddress;
        private string _sourceArn;
        private string _subject;
        private string _to;
        private string _xMailer;
        private string _xOriginalMailer;
        private string _xPriority;

        /// <summary>
        /// Gets and sets the property ArchivedMessageId. 
        /// <para>
        /// The unique identifier of the archived message.
        /// </para>
        /// </summary>
        public string ArchivedMessageId
        {
            get { return this._archivedMessageId; }
            set { this._archivedMessageId = value; }
        }

        // Check to see if ArchivedMessageId property is set
        internal bool IsSetArchivedMessageId()
        {
            return this._archivedMessageId != null;
        }

        /// <summary>
        /// Gets and sets the property Cc. 
        /// <para>
        /// The email addresses in the CC header.
        /// </para>
        /// </summary>
        public string Cc
        {
            get { return this._cc; }
            set { this._cc = value; }
        }

        // Check to see if Cc property is set
        internal bool IsSetCc()
        {
            return this._cc != null;
        }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date the email was sent.
        /// </para>
        /// </summary>
        public string Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date != null;
        }

        /// <summary>
        /// Gets and sets the property Envelope. 
        /// <para>
        /// The SMTP envelope information of the email.
        /// </para>
        /// </summary>
        public Envelope Envelope
        {
            get { return this._envelope; }
            set { this._envelope = value; }
        }

        // Check to see if Envelope property is set
        internal bool IsSetEnvelope()
        {
            return this._envelope != null;
        }

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The email address of the sender.
        /// </para>
        /// </summary>
        public string From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property HasAttachments. 
        /// <para>
        /// A flag indicating if the email has attachments.
        /// </para>
        /// </summary>
        public bool? HasAttachments
        {
            get { return this._hasAttachments; }
            set { this._hasAttachments = value; }
        }

        // Check to see if HasAttachments property is set
        internal bool IsSetHasAttachments()
        {
            return this._hasAttachments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngressPointId. 
        /// <para>
        /// The ID of the ingress endpoint through which the email was received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string IngressPointId
        {
            get { return this._ingressPointId; }
            set { this._ingressPointId = value; }
        }

        // Check to see if IngressPointId property is set
        internal bool IsSetIngressPointId()
        {
            return this._ingressPointId != null;
        }

        /// <summary>
        /// Gets and sets the property InReplyTo. 
        /// <para>
        /// The email message ID this is a reply to.
        /// </para>
        /// </summary>
        public string InReplyTo
        {
            get { return this._inReplyTo; }
            set { this._inReplyTo = value; }
        }

        // Check to see if InReplyTo property is set
        internal bool IsSetInReplyTo()
        {
            return this._inReplyTo != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The unique message ID of the email.
        /// </para>
        /// </summary>
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

        /// <summary>
        /// Gets and sets the property ReceivedHeaders. 
        /// <para>
        /// The received headers from the email delivery path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReceivedHeaders
        {
            get { return this._receivedHeaders; }
            set { this._receivedHeaders = value; }
        }

        // Check to see if ReceivedHeaders property is set
        internal bool IsSetReceivedHeaders()
        {
            return this._receivedHeaders != null && (this._receivedHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReceivedTimestamp. 
        /// <para>
        /// The timestamp of when the email was received.
        /// </para>
        /// </summary>
        public DateTime? ReceivedTimestamp
        {
            get { return this._receivedTimestamp; }
            set { this._receivedTimestamp = value; }
        }

        // Check to see if ReceivedTimestamp property is set
        internal bool IsSetReceivedTimestamp()
        {
            return this._receivedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SenderHostname. 
        /// <para>
        /// The name of the host from which the email was received.
        /// </para>
        /// </summary>
        public string SenderHostname
        {
            get { return this._senderHostname; }
            set { this._senderHostname = value; }
        }

        // Check to see if SenderHostname property is set
        internal bool IsSetSenderHostname()
        {
            return this._senderHostname != null;
        }

        /// <summary>
        /// Gets and sets the property SenderIpAddress. <ul> <li> 
        /// <para>
        /// Mail archived with Mail Manager: The IP address of the client that connects to the
        /// ingress endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Mail sent through a configuration set with the archiving option enabled: The IP address
        /// of the client that makes the SendEmail API call.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SenderIpAddress
        {
            get { return this._senderIpAddress; }
            set { this._senderIpAddress = value; }
        }

        // Check to see if SenderIpAddress property is set
        internal bool IsSetSenderIpAddress()
        {
            return this._senderIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// Specifies the archived email source, identified by either a Rule Set's ARN with an
        /// Archive action, or a Configuration Set's Archive ARN.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject header value of the email.
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The email addresses in the To header.
        /// </para>
        /// </summary>
        public string To
        {
            get { return this._to; }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to != null;
        }

        /// <summary>
        /// Gets and sets the property XMailer. 
        /// <para>
        /// The user agent that sent the email.
        /// </para>
        /// </summary>
        public string XMailer
        {
            get { return this._xMailer; }
            set { this._xMailer = value; }
        }

        // Check to see if XMailer property is set
        internal bool IsSetXMailer()
        {
            return this._xMailer != null;
        }

        /// <summary>
        /// Gets and sets the property XOriginalMailer. 
        /// <para>
        /// The original user agent that sent the email.
        /// </para>
        /// </summary>
        public string XOriginalMailer
        {
            get { return this._xOriginalMailer; }
            set { this._xOriginalMailer = value; }
        }

        // Check to see if XOriginalMailer property is set
        internal bool IsSetXOriginalMailer()
        {
            return this._xOriginalMailer != null;
        }

        /// <summary>
        /// Gets and sets the property XPriority. 
        /// <para>
        /// The priority level of the email.
        /// </para>
        /// </summary>
        public string XPriority
        {
            get { return this._xPriority; }
            set { this._xPriority = value; }
        }

        // Check to see if XPriority property is set
        internal bool IsSetXPriority()
        {
            return this._xPriority != null;
        }

    }
}