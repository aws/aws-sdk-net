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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The template for the verification message that your user pool delivers to users who
    /// set an email address or phone number attribute.
    /// </summary>
    public partial class VerificationMessageTemplateType
    {
        private DefaultEmailOptionType _defaultEmailOption;
        private string _emailMessage;
        private string _emailMessageByLink;
        private string _emailSubject;
        private string _emailSubjectByLink;
        private string _smsMessage;

        /// <summary>
        /// Gets and sets the property DefaultEmailOption. 
        /// <para>
        /// The configuration of verification emails to contain a clickable link or a verification
        /// code.
        /// </para>
        ///  
        /// <para>
        /// For link, your template body must contain link text in the format <c>{##Click here##}</c>.
        /// "Click here" in the example is a customizable string. For code, your template body
        /// must contain a code placeholder in the format <c>{####}</c>.
        /// </para>
        /// </summary>
        public DefaultEmailOptionType DefaultEmailOption
        {
            get { return this._defaultEmailOption; }
            set { this._defaultEmailOption = value; }
        }

        // Check to see if DefaultEmailOption property is set
        internal bool IsSetDefaultEmailOption()
        {
            return this._defaultEmailOption != null;
        }

        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// The template for email messages that Amazon Cognito sends to your users. You can set
        /// an <c>EmailMessage</c> template only if the value of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_EmailConfigurationType.html#CognitoUserPools-Type-EmailConfigurationType-EmailSendingAccount">
        /// EmailSendingAccount</a> is <c>DEVELOPER</c>. When your <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_EmailConfigurationType.html#CognitoUserPools-Type-EmailConfigurationType-EmailSendingAccount">EmailSendingAccount</a>
        /// is <c>DEVELOPER</c>, your user pool sends email messages with your own Amazon SES
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=20000)]
        public string EmailMessage
        {
            get { return this._emailMessage; }
            set { this._emailMessage = value; }
        }

        // Check to see if EmailMessage property is set
        internal bool IsSetEmailMessage()
        {
            return this._emailMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EmailMessageByLink. 
        /// <para>
        /// The email message template for sending a confirmation link to the user. You can set
        /// an <c>EmailMessageByLink</c> template only if the value of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_EmailConfigurationType.html#CognitoUserPools-Type-EmailConfigurationType-EmailSendingAccount">
        /// EmailSendingAccount</a> is <c>DEVELOPER</c>. When your <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_EmailConfigurationType.html#CognitoUserPools-Type-EmailConfigurationType-EmailSendingAccount">EmailSendingAccount</a>
        /// is <c>DEVELOPER</c>, your user pool sends email messages with your own Amazon SES
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=20000)]
        public string EmailMessageByLink
        {
            get { return this._emailMessageByLink; }
            set { this._emailMessageByLink = value; }
        }

        // Check to see if EmailMessageByLink property is set
        internal bool IsSetEmailMessageByLink()
        {
            return this._emailMessageByLink != null;
        }

        /// <summary>
        /// Gets and sets the property EmailSubject. 
        /// <para>
        /// The subject line for the email message template. You can set an <c>EmailSubject</c>
        /// template only if the value of <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_EmailConfigurationType.html#CognitoUserPools-Type-EmailConfigurationType-EmailSendingAccount">
        /// EmailSendingAccount</a> is <c>DEVELOPER</c>. When your <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_EmailConfigurationType.html#CognitoUserPools-Type-EmailConfigurationType-EmailSendingAccount">EmailSendingAccount</a>
        /// is <c>DEVELOPER</c>, your user pool sends email messages with your own Amazon SES
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=140)]
        public string EmailSubject
        {
            get { return this._emailSubject; }
            set { this._emailSubject = value; }
        }

        // Check to see if EmailSubject property is set
        internal bool IsSetEmailSubject()
        {
            return this._emailSubject != null;
        }

        /// <summary>
        /// Gets and sets the property EmailSubjectByLink. 
        /// <para>
        /// The subject line for the email message template for sending a confirmation link to
        /// the user. You can set an <c>EmailSubjectByLink</c> template only if the value of <a
        /// href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_EmailConfigurationType.html#CognitoUserPools-Type-EmailConfigurationType-EmailSendingAccount">
        /// EmailSendingAccount</a> is <c>DEVELOPER</c>. When your <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_EmailConfigurationType.html#CognitoUserPools-Type-EmailConfigurationType-EmailSendingAccount">EmailSendingAccount</a>
        /// is <c>DEVELOPER</c>, your user pool sends email messages with your own Amazon SES
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=140)]
        public string EmailSubjectByLink
        {
            get { return this._emailSubjectByLink; }
            set { this._emailSubjectByLink = value; }
        }

        // Check to see if EmailSubjectByLink property is set
        internal bool IsSetEmailSubjectByLink()
        {
            return this._emailSubjectByLink != null;
        }

        /// <summary>
        /// Gets and sets the property SmsMessage. 
        /// <para>
        /// The template for SMS messages that Amazon Cognito sends to your users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=140)]
        public string SmsMessage
        {
            get { return this._smsMessage; }
            set { this._smsMessage = value; }
        }

        // Check to see if SmsMessage property is set
        internal bool IsSetSmsMessage()
        {
            return this._smsMessage != null;
        }

    }
}