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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// This is the response object from the GetEmailIdentity operation.
    /// </summary>
    public partial class GetEmailIdentityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DkimAttributes. 
        /// <para>
        /// An object that contains information about the DKIM attributes for the identity. This
        /// object includes the tokens that you use to create the CNAME records that are required
        /// to complete the DKIM verification process.
        /// </para>
        /// </summary>
        public DkimAttributes DkimAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DkimAttributes property is set.
        /// </summary>
        internal bool IsSetDkimAttributes() => this.DkimAttributes != null;

        /// <summary>
        /// Gets and sets the property FeedbackForwardingStatus. 
        /// <para>
        /// The feedback forwarding configuration for the identity.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>true</c>, Amazon Pinpoint sends you email notifications when bounce
        /// or complaint events occur. Amazon Pinpoint sends this notification to the address
        /// that you specified in the Return-Path header of the original email.
        /// </para>
        ///  
        /// <para>
        /// When you set this value to <c>false</c>, Amazon Pinpoint sends notifications through
        /// other mechanisms, such as by notifying an Amazon SNS topic or another event destination.
        /// You're required to have a method of tracking bounces and complaints. If you haven't
        /// set up another mechanism for receiving bounce or complaint notifications, Amazon Pinpoint
        /// sends an email notification when these events occur (even if this setting is disabled).
        /// </para>
        /// </summary>
        public bool? FeedbackForwardingStatus { get; set; }

        /// <summary>
        /// Checks to see if the FeedbackForwardingStatus property is set.
        /// </summary>
        internal bool IsSetFeedbackForwardingStatus() => this.FeedbackForwardingStatus.HasValue;

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The email identity type.
        /// </para>
        /// </summary>
        public IdentityType IdentityType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityType property is set.
        /// </summary>
        internal bool IsSetIdentityType() => this.IdentityType != null;

        /// <summary>
        /// Gets and sets the property MailFromAttributes. 
        /// <para>
        /// An object that contains information about the Mail-From attributes for the email identity.
        /// </para>
        /// </summary>
        public MailFromAttributes MailFromAttributes { get; set; }

        /// <summary>
        /// Checks to see if the MailFromAttributes property is set.
        /// </summary>
        internal bool IsSetMailFromAttributes() => this.MailFromAttributes != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) that are associated with
        /// the email identity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VerifiedForSendingStatus. 
        /// <para>
        /// Specifies whether or not the identity is verified. In Amazon Pinpoint, you can only
        /// send email from verified email addresses or domains. For more information about verifying
        /// identities, see the <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-email-manage-verify.html">Amazon
        /// Pinpoint User Guide</a>.
        /// </para>
        /// </summary>
        public bool? VerifiedForSendingStatus { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedForSendingStatus property is set.
        /// </summary>
        internal bool IsSetVerifiedForSendingStatus() => this.VerifiedForSendingStatus.HasValue;
    }
}
