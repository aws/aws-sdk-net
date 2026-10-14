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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ArchivedMessageId. 
        /// <para>
        /// The unique identifier of the archived message.
        /// </para>
        /// </summary>
        public string ArchivedMessageId { get; set; }

        /// <summary>
        /// Checks to see if the ArchivedMessageId property is set.
        /// </summary>
        internal bool IsSetArchivedMessageId() => this.ArchivedMessageId != null;

        /// <summary>
        /// Gets and sets the property Cc. 
        /// <para>
        /// The email addresses in the CC header.
        /// </para>
        /// </summary>
        public string Cc { get; set; }

        /// <summary>
        /// Checks to see if the Cc property is set.
        /// </summary>
        internal bool IsSetCc() => this.Cc != null;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date the email was sent.
        /// </para>
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date != null;

        /// <summary>
        /// Gets and sets the property Envelope. 
        /// <para>
        /// The SMTP envelope information of the email.
        /// </para>
        /// </summary>
        public Envelope Envelope { get; set; }

        /// <summary>
        /// Checks to see if the Envelope property is set.
        /// </summary>
        internal bool IsSetEnvelope() => this.Envelope != null;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The email address of the sender.
        /// </para>
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From != null;

        /// <summary>
        /// Gets and sets the property HasAttachments. 
        /// <para>
        /// A flag indicating if the email has attachments.
        /// </para>
        /// </summary>
        public bool? HasAttachments { get; set; }

        /// <summary>
        /// Checks to see if the HasAttachments property is set.
        /// </summary>
        internal bool IsSetHasAttachments() => this.HasAttachments.HasValue;

        /// <summary>
        /// Gets and sets the property InReplyTo. 
        /// <para>
        /// The email message ID this is a reply to.
        /// </para>
        /// </summary>
        public string InReplyTo { get; set; }

        /// <summary>
        /// Checks to see if the InReplyTo property is set.
        /// </summary>
        internal bool IsSetInReplyTo() => this.InReplyTo != null;

        /// <summary>
        /// Gets and sets the property IngressPointId. 
        /// <para>
        /// The ID of the ingress endpoint through which the email was received.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string IngressPointId { get; set; }

        /// <summary>
        /// Checks to see if the IngressPointId property is set.
        /// </summary>
        internal bool IsSetIngressPointId() => this.IngressPointId != null;

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The unique message ID of the email.
        /// </para>
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property ReceivedHeaders. 
        /// <para>
        /// The received headers from the email delivery path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReceivedHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReceivedHeaders property is set.
        /// </summary>
        internal bool IsSetReceivedHeaders() => this.ReceivedHeaders != null && (this.ReceivedHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReceivedTimestamp. 
        /// <para>
        /// The timestamp of when the email was received.
        /// </para>
        /// </summary>
        public DateTime? ReceivedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ReceivedTimestamp property is set.
        /// </summary>
        internal bool IsSetReceivedTimestamp() => this.ReceivedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SenderHostname. 
        /// <para>
        /// The name of the host from which the email was received.
        /// </para>
        /// </summary>
        public string SenderHostname { get; set; }

        /// <summary>
        /// Checks to see if the SenderHostname property is set.
        /// </summary>
        internal bool IsSetSenderHostname() => this.SenderHostname != null;

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
        [AWSProperty(Sensitive = true)]
        public string SenderIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the SenderIpAddress property is set.
        /// </summary>
        internal bool IsSetSenderIpAddress() => this.SenderIpAddress != null;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// Specifies the archived email source, identified by either a Rule Set's ARN with an
        /// Archive action, or a Configuration Set's Archive ARN.
        /// </para>
        /// </summary>
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject header value of the email.
        /// </para>
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The email addresses in the To header.
        /// </para>
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To != null;

        /// <summary>
        /// Gets and sets the property XMailer. 
        /// <para>
        /// The user agent that sent the email.
        /// </para>
        /// </summary>
        public string XMailer { get; set; }

        /// <summary>
        /// Checks to see if the XMailer property is set.
        /// </summary>
        internal bool IsSetXMailer() => this.XMailer != null;

        /// <summary>
        /// Gets and sets the property XOriginalMailer. 
        /// <para>
        /// The original user agent that sent the email.
        /// </para>
        /// </summary>
        public string XOriginalMailer { get; set; }

        /// <summary>
        /// Checks to see if the XOriginalMailer property is set.
        /// </summary>
        internal bool IsSetXOriginalMailer() => this.XOriginalMailer != null;

        /// <summary>
        /// Gets and sets the property XPriority. 
        /// <para>
        /// The priority level of the email.
        /// </para>
        /// </summary>
        public string XPriority { get; set; }

        /// <summary>
        /// Checks to see if the XPriority property is set.
        /// </summary>
        internal bool IsSetXPriority() => this.XPriority != null;
    }
}
