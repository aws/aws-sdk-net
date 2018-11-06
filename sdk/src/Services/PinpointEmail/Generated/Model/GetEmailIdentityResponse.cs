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

/*
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Details about an email identity.
    /// </summary>
    public partial class GetEmailIdentityResponse : AmazonWebServiceResponse
    {
        private DkimAttributes _dkimAttributes;
        private bool? _feedbackForwardingStatus;
        private IdentityType _identityType;
        private MailFromAttributes _mailFromAttributes;
        private bool? _verifiedForSendingStatus;

        /// <summary>
        /// Gets and sets the property DkimAttributes. 
        /// <para>
        /// An object that contains information about the DKIM attributes for the identity. This
        /// object includes the tokens that you use to create the CNAME records that are required
        /// to complete the DKIM verification process.
        /// </para>
        /// </summary>
        public DkimAttributes DkimAttributes
        {
            get { return this._dkimAttributes; }
            set { this._dkimAttributes = value; }
        }

        // Check to see if DkimAttributes property is set
        internal bool IsSetDkimAttributes()
        {
            return this._dkimAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property FeedbackForwardingStatus. 
        /// <para>
        /// The feedback forwarding configuration for the identity.
        /// </para>
        ///  
        /// <para>
        /// If the value is <code>true</code>, Amazon Pinpoint sends you email notifications when
        /// bounce or complaint events occur. Amazon Pinpoint sends this notification to the address
        /// that you specified in the Return-Path header of the original email.
        /// </para>
        ///  
        /// <para>
        /// When you set this value to <code>false</code>, Amazon Pinpoint sends notifications
        /// through other mechanisms, such as by notifying an Amazon SNS topic or another event
        /// destination. You're required to have a method of tracking bounces and complaints.
        /// If you haven't set up another mechanism for receiving bounce or complaint notifications,
        /// Amazon Pinpoint sends an email notification when these events occur (even if this
        /// setting is disabled).
        /// </para>
        /// </summary>
        public bool FeedbackForwardingStatus
        {
            get { return this._feedbackForwardingStatus.GetValueOrDefault(); }
            set { this._feedbackForwardingStatus = value; }
        }

        // Check to see if FeedbackForwardingStatus property is set
        internal bool IsSetFeedbackForwardingStatus()
        {
            return this._feedbackForwardingStatus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The email identity type.
        /// </para>
        /// </summary>
        public IdentityType IdentityType
        {
            get { return this._identityType; }
            set { this._identityType = value; }
        }

        // Check to see if IdentityType property is set
        internal bool IsSetIdentityType()
        {
            return this._identityType != null;
        }

        /// <summary>
        /// Gets and sets the property MailFromAttributes. 
        /// <para>
        /// An object that contains information about the Mail-From attributes for the email identity.
        /// </para>
        /// </summary>
        public MailFromAttributes MailFromAttributes
        {
            get { return this._mailFromAttributes; }
            set { this._mailFromAttributes = value; }
        }

        // Check to see if MailFromAttributes property is set
        internal bool IsSetMailFromAttributes()
        {
            return this._mailFromAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedForSendingStatus. 
        /// <para>
        /// Specifies whether or not the identity is verified. In Amazon Pinpoint, you can only
        /// send email from verified email addresses or domains. For more information about verifying
        /// identities, see the <a href="http://docs.aws.amazon.com/pinpoint/latest/userguide/channels-email-manage-verify.html">Amazon
        /// Pinpoint User Guide</a>.
        /// </para>
        /// </summary>
        public bool VerifiedForSendingStatus
        {
            get { return this._verifiedForSendingStatus.GetValueOrDefault(); }
            set { this._verifiedForSendingStatus = value; }
        }

        // Check to see if VerifiedForSendingStatus property is set
        internal bool IsSetVerifiedForSendingStatus()
        {
            return this._verifiedForSendingStatus.HasValue; 
        }

    }
}