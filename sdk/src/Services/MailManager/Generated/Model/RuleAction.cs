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
    /// The action for a rule to take. Only one of the contained actions can be set.
    /// </summary>
    public partial class RuleAction
    {
        private AddHeaderAction _addHeader;
        private ArchiveAction _archive;
        private DeliverToMailboxAction _deliverToMailbox;
        private DeliverToQBusinessAction _deliverToQBusiness;
        private DropAction _drop;
        private SnsAction _publishToSns;
        private RelayAction _relay;
        private ReplaceRecipientAction _replaceRecipient;
        private SendAction _send;
        private S3Action _writeToS3;

        /// <summary>
        /// Gets and sets the property AddHeader. 
        /// <para>
        /// This action adds a header. This can be used to add arbitrary email headers.
        /// </para>
        /// </summary>
        public AddHeaderAction AddHeader
        {
            get { return this._addHeader; }
            set { this._addHeader = value; }
        }

        // Check to see if AddHeader property is set
        internal bool IsSetAddHeader()
        {
            return this._addHeader != null;
        }

        /// <summary>
        /// Gets and sets the property Archive. 
        /// <para>
        /// This action archives the email. This can be used to deliver an email to an archive.
        /// </para>
        /// </summary>
        public ArchiveAction Archive
        {
            get { return this._archive; }
            set { this._archive = value; }
        }

        // Check to see if Archive property is set
        internal bool IsSetArchive()
        {
            return this._archive != null;
        }

        /// <summary>
        /// Gets and sets the property DeliverToMailbox. 
        /// <para>
        /// This action delivers an email to a WorkMail mailbox.
        /// </para>
        /// </summary>
        public DeliverToMailboxAction DeliverToMailbox
        {
            get { return this._deliverToMailbox; }
            set { this._deliverToMailbox = value; }
        }

        // Check to see if DeliverToMailbox property is set
        internal bool IsSetDeliverToMailbox()
        {
            return this._deliverToMailbox != null;
        }

        /// <summary>
        /// Gets and sets the property DeliverToQBusiness. 
        /// <para>
        /// This action delivers an email to an Amazon Q Business application for ingestion into
        /// its knowledge base.
        /// </para>
        /// </summary>
        public DeliverToQBusinessAction DeliverToQBusiness
        {
            get { return this._deliverToQBusiness; }
            set { this._deliverToQBusiness = value; }
        }

        // Check to see if DeliverToQBusiness property is set
        internal bool IsSetDeliverToQBusiness()
        {
            return this._deliverToQBusiness != null;
        }

        /// <summary>
        /// Gets and sets the property Drop. 
        /// <para>
        /// This action terminates the evaluation of rules in the rule set.
        /// </para>
        /// </summary>
        public DropAction Drop
        {
            get { return this._drop; }
            set { this._drop = value; }
        }

        // Check to see if Drop property is set
        internal bool IsSetDrop()
        {
            return this._drop != null;
        }

        /// <summary>
        /// Gets and sets the property PublishToSns. 
        /// <para>
        /// This action publishes the email content to an Amazon SNS topic.
        /// </para>
        /// </summary>
        public SnsAction PublishToSns
        {
            get { return this._publishToSns; }
            set { this._publishToSns = value; }
        }

        // Check to see if PublishToSns property is set
        internal bool IsSetPublishToSns()
        {
            return this._publishToSns != null;
        }

        /// <summary>
        /// Gets and sets the property Relay. 
        /// <para>
        /// This action relays the email to another SMTP server.
        /// </para>
        /// </summary>
        public RelayAction Relay
        {
            get { return this._relay; }
            set { this._relay = value; }
        }

        // Check to see if Relay property is set
        internal bool IsSetRelay()
        {
            return this._relay != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceRecipient. 
        /// <para>
        /// The action replaces certain or all recipients with a different set of recipients.
        /// </para>
        /// </summary>
        public ReplaceRecipientAction ReplaceRecipient
        {
            get { return this._replaceRecipient; }
            set { this._replaceRecipient = value; }
        }

        // Check to see if ReplaceRecipient property is set
        internal bool IsSetReplaceRecipient()
        {
            return this._replaceRecipient != null;
        }

        /// <summary>
        /// Gets and sets the property Send. 
        /// <para>
        /// This action sends the email to the internet.
        /// </para>
        /// </summary>
        public SendAction Send
        {
            get { return this._send; }
            set { this._send = value; }
        }

        // Check to see if Send property is set
        internal bool IsSetSend()
        {
            return this._send != null;
        }

        /// <summary>
        /// Gets and sets the property WriteToS3. 
        /// <para>
        /// This action writes the MIME content of the email to an S3 bucket.
        /// </para>
        /// </summary>
        public S3Action WriteToS3
        {
            get { return this._writeToS3; }
            set { this._writeToS3 = value; }
        }

        // Check to see if WriteToS3 property is set
        internal bool IsSetWriteToS3()
        {
            return this._writeToS3 != null;
        }

    }
}