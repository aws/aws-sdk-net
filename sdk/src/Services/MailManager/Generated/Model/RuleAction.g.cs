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
    /// The action for a rule to take. Only one of the contained actions can be set.
    /// </summary>
    public partial class RuleAction
    {
        /// <summary>
        /// Gets and sets the property AddHeader. 
        /// <para>
        /// This action adds a header. This can be used to add arbitrary email headers.
        /// </para>
        /// </summary>
        public AddHeaderAction AddHeader { get; set; }

        /// <summary>
        /// Checks to see if the AddHeader property is set.
        /// </summary>
        internal bool IsSetAddHeader() => this.AddHeader != null;

        /// <summary>
        /// Gets and sets the property Archive. 
        /// <para>
        /// This action archives the email. This can be used to deliver an email to an archive.
        /// </para>
        /// </summary>
        public ArchiveAction Archive { get; set; }

        /// <summary>
        /// Checks to see if the Archive property is set.
        /// </summary>
        internal bool IsSetArchive() => this.Archive != null;

        /// <summary>
        /// Gets and sets the property Bounce. 
        /// <para>
        /// This action sends a bounce response for the email.
        /// </para>
        /// </summary>
        public BounceAction Bounce { get; set; }

        /// <summary>
        /// Checks to see if the Bounce property is set.
        /// </summary>
        internal bool IsSetBounce() => this.Bounce != null;

        /// <summary>
        /// Gets and sets the property DeliverToMailbox. 
        /// <para>
        /// This action delivers an email to a WorkMail mailbox.
        /// </para>
        /// </summary>
        public DeliverToMailboxAction DeliverToMailbox { get; set; }

        /// <summary>
        /// Checks to see if the DeliverToMailbox property is set.
        /// </summary>
        internal bool IsSetDeliverToMailbox() => this.DeliverToMailbox != null;

        /// <summary>
        /// Gets and sets the property DeliverToQBusiness. 
        /// <para>
        /// This action delivers an email to an Amazon Q Business application for ingestion into
        /// its knowledge base.
        /// </para>
        /// </summary>
        public DeliverToQBusinessAction DeliverToQBusiness { get; set; }

        /// <summary>
        /// Checks to see if the DeliverToQBusiness property is set.
        /// </summary>
        internal bool IsSetDeliverToQBusiness() => this.DeliverToQBusiness != null;

        /// <summary>
        /// Gets and sets the property Drop. 
        /// <para>
        /// This action terminates the evaluation of rules in the rule set.
        /// </para>
        /// </summary>
        public DropAction Drop { get; set; }

        /// <summary>
        /// Checks to see if the Drop property is set.
        /// </summary>
        internal bool IsSetDrop() => this.Drop != null;

        /// <summary>
        /// Gets and sets the property InvokeLambda. 
        /// <para>
        /// This action invokes an Amazon Web Services Lambda function to process the email.
        /// </para>
        /// </summary>
        public InvokeLambdaAction InvokeLambda { get; set; }

        /// <summary>
        /// Checks to see if the InvokeLambda property is set.
        /// </summary>
        internal bool IsSetInvokeLambda() => this.InvokeLambda != null;

        /// <summary>
        /// Gets and sets the property PublishToSns. 
        /// <para>
        /// This action publishes the email content to an Amazon SNS topic.
        /// </para>
        /// </summary>
        public SnsAction PublishToSns { get; set; }

        /// <summary>
        /// Checks to see if the PublishToSns property is set.
        /// </summary>
        internal bool IsSetPublishToSns() => this.PublishToSns != null;

        /// <summary>
        /// Gets and sets the property Relay. 
        /// <para>
        /// This action relays the email to another SMTP server.
        /// </para>
        /// </summary>
        public RelayAction Relay { get; set; }

        /// <summary>
        /// Checks to see if the Relay property is set.
        /// </summary>
        internal bool IsSetRelay() => this.Relay != null;

        /// <summary>
        /// Gets and sets the property ReplaceRecipient. 
        /// <para>
        /// The action replaces certain or all recipients with a different set of recipients.
        /// </para>
        /// </summary>
        public ReplaceRecipientAction ReplaceRecipient { get; set; }

        /// <summary>
        /// Checks to see if the ReplaceRecipient property is set.
        /// </summary>
        internal bool IsSetReplaceRecipient() => this.ReplaceRecipient != null;

        /// <summary>
        /// Gets and sets the property Send. 
        /// <para>
        /// This action sends the email to the internet.
        /// </para>
        /// </summary>
        public SendAction Send { get; set; }

        /// <summary>
        /// Checks to see if the Send property is set.
        /// </summary>
        internal bool IsSetSend() => this.Send != null;

        /// <summary>
        /// Gets and sets the property WriteToS3. 
        /// <para>
        /// This action writes the MIME content of the email to an S3 bucket.
        /// </para>
        /// </summary>
        public S3Action WriteToS3 { get; set; }

        /// <summary>
        /// Checks to see if the WriteToS3 property is set.
        /// </summary>
        internal bool IsSetWriteToS3() => this.WriteToS3 != null;
    }
}
