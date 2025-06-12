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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SendBounce operation.
    /// Generates and sends a bounce message to the sender of an email you received through
    /// Amazon SES. You can only use this operation on an email up to 24 hours after you receive
    /// it.
    /// 
    ///  <note> 
    /// <para>
    /// You cannot use this operation to send generic bounces for mail that was not received
    /// by Amazon SES.
    /// </para>
    ///  </note> 
    /// <para>
    /// For information about receiving email through Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class SendBounceRequest : AmazonSimpleEmailServiceRequest
    {
        private List<BouncedRecipientInfo> _bouncedRecipientInfoList = AWSConfigs.InitializeCollections ? new List<BouncedRecipientInfo>() : null;
        private string _bounceSender;
        private string _bounceSenderArn;
        private string _explanation;
        private MessageDsn _messageDsn;
        private string _originalMessageId;

        /// <summary>
        /// Gets and sets the property BouncedRecipientInfoList. 
        /// <para>
        /// A list of recipients of the bounced message, including the information required to
        /// create the Delivery Status Notifications (DSNs) for the recipients. You must specify
        /// at least one <c>BouncedRecipientInfo</c> in the list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BouncedRecipientInfo> BouncedRecipientInfoList
        {
            get { return this._bouncedRecipientInfoList; }
            set { this._bouncedRecipientInfoList = value; }
        }

        // Check to see if BouncedRecipientInfoList property is set
        internal bool IsSetBouncedRecipientInfoList()
        {
            return this._bouncedRecipientInfoList != null && (this._bouncedRecipientInfoList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BounceSender. 
        /// <para>
        /// The address to use in the "From" header of the bounce message. This must be an identity
        /// that you have verified with Amazon SES.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BounceSender
        {
            get { return this._bounceSender; }
            set { this._bounceSender = value; }
        }

        // Check to see if BounceSender property is set
        internal bool IsSetBounceSender()
        {
            return this._bounceSender != null;
        }

        /// <summary>
        /// Gets and sets the property BounceSenderArn. 
        /// <para>
        /// This parameter is used only for sending authorization. It is the ARN of the identity
        /// that is associated with the sending authorization policy that permits you to use the
        /// address in the "From" header of the bounce. For more information about sending authorization,
        /// see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        public string BounceSenderArn
        {
            get { return this._bounceSenderArn; }
            set { this._bounceSenderArn = value; }
        }

        // Check to see if BounceSenderArn property is set
        internal bool IsSetBounceSenderArn()
        {
            return this._bounceSenderArn != null;
        }

        /// <summary>
        /// Gets and sets the property Explanation. 
        /// <para>
        /// Human-readable text for the bounce message to explain the failure. If not specified,
        /// the text is auto-generated based on the bounced recipient information.
        /// </para>
        /// </summary>
        public string Explanation
        {
            get { return this._explanation; }
            set { this._explanation = value; }
        }

        // Check to see if Explanation property is set
        internal bool IsSetExplanation()
        {
            return this._explanation != null;
        }

        /// <summary>
        /// Gets and sets the property MessageDsn. 
        /// <para>
        /// Message-related DSN fields. If not specified, Amazon SES chooses the values.
        /// </para>
        /// </summary>
        public MessageDsn MessageDsn
        {
            get { return this._messageDsn; }
            set { this._messageDsn = value; }
        }

        // Check to see if MessageDsn property is set
        internal bool IsSetMessageDsn()
        {
            return this._messageDsn != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalMessageId. 
        /// <para>
        /// The message ID of the message to be bounced.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OriginalMessageId
        {
            get { return this._originalMessageId; }
            set { this._originalMessageId = value; }
        }

        // Check to see if OriginalMessageId property is set
        internal bool IsSetOriginalMessageId()
        {
            return this._originalMessageId != null;
        }

    }
}