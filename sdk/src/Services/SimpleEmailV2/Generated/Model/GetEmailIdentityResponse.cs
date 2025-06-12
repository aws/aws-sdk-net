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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Details about an email identity.
    /// </summary>
    public partial class GetEmailIdentityResponse : AmazonWebServiceResponse
    {
        private string _configurationSetName;
        private DkimAttributes _dkimAttributes;
        private bool? _feedbackForwardingStatus;
        private IdentityType _identityType;
        private MailFromAttributes _mailFromAttributes;
        private Dictionary<string, string> _policies = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private VerificationInfo _verificationInfo;
        private VerificationStatus _verificationStatus;
        private bool? _verifiedForSendingStatus;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The configuration set used by default when sending from this identity.
        /// </para>
        /// </summary>
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property DkimAttributes. 
        /// <para>
        /// An object that contains information about the DKIM attributes for the identity.
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
        /// If the value is <c>true</c>, you receive email notifications when bounce or complaint
        /// events occur. These notifications are sent to the address that you specified in the
        /// <c>Return-Path</c> header of the original email.
        /// </para>
        ///  
        /// <para>
        /// You're required to have a method of tracking bounces and complaints. If you haven't
        /// set up another mechanism for receiving bounce or complaint notifications (for example,
        /// by setting up an event destination), you receive an email notification when these
        /// events occur (even if this setting is disabled).
        /// </para>
        /// </summary>
        public bool? FeedbackForwardingStatus
        {
            get { return this._feedbackForwardingStatus; }
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
        /// The email identity type. Note: the <c>MANAGED_DOMAIN</c> identity type is not supported.
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
        /// Gets and sets the property Policies. 
        /// <para>
        /// A map of policy names to policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null && (this._policies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) that are associated with
        /// the email identity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VerificationInfo. 
        /// <para>
        /// An object that contains additional information about the verification status for the
        /// identity.
        /// </para>
        /// </summary>
        public VerificationInfo VerificationInfo
        {
            get { return this._verificationInfo; }
            set { this._verificationInfo = value; }
        }

        // Check to see if VerificationInfo property is set
        internal bool IsSetVerificationInfo()
        {
            return this._verificationInfo != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationStatus. 
        /// <para>
        /// The verification status of the identity. The status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – The verification process was initiated, but Amazon SES hasn't yet
        /// been able to verify the identity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – The verification process completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The verification process failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEMPORARY_FAILURE</c> – A temporary issue is preventing Amazon SES from determining
        /// the verification status of the identity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_STARTED</c> – The verification process hasn't been initiated for the identity.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VerificationStatus VerificationStatus
        {
            get { return this._verificationStatus; }
            set { this._verificationStatus = value; }
        }

        // Check to see if VerificationStatus property is set
        internal bool IsSetVerificationStatus()
        {
            return this._verificationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedForSendingStatus. 
        /// <para>
        /// Specifies whether or not the identity is verified. You can only send email from verified
        /// email addresses or domains. For more information about verifying identities, see the
        /// <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-email-manage-verify.html">Amazon
        /// Pinpoint User Guide</a>.
        /// </para>
        /// </summary>
        public bool? VerifiedForSendingStatus
        {
            get { return this._verifiedForSendingStatus; }
            set { this._verifiedForSendingStatus = value; }
        }

        // Check to see if VerifiedForSendingStatus property is set
        internal bool IsSetVerifiedForSendingStatus()
        {
            return this._verifiedForSendingStatus.HasValue; 
        }

    }
}