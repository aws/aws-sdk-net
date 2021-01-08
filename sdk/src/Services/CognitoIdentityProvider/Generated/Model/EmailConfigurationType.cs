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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The email configuration type. 
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Cognito has specific regions for use with Amazon SES. For more information
    /// on the supported regions, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-email.html">Email
    /// Settings for Amazon Cognito User Pools</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class EmailConfigurationType
    {
        private string _configurationSet;
        private EmailSendingAccountType _emailSendingAccount;
        private string _from;
        private string _replyToEmailAddress;
        private string _sourceArn;

        /// <summary>
        /// Gets and sets the property ConfigurationSet. 
        /// <para>
        /// The set of configuration rules that can be applied to emails sent using Amazon SES.
        /// A configuration set is applied to an email by including a reference to the configuration
        /// set in the headers of the email. Once applied, all of the rules in that configuration
        /// set are applied to the email. Configuration sets can be used to apply the following
        /// types of rules to emails: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Event publishing – Amazon SES can track the number of send, delivery, open, click,
        /// bounce, and complaint events for each email sent. Use event publishing to send information
        /// about these events to other AWS services such as SNS and CloudWatch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IP pool management – When leasing dedicated IP addresses with Amazon SES, you can
        /// create groups of IP addresses, called dedicated IP pools. You can then associate the
        /// dedicated IP pools with configuration sets.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ConfigurationSet
        {
            get { return this._configurationSet; }
            set { this._configurationSet = value; }
        }

        // Check to see if ConfigurationSet property is set
        internal bool IsSetConfigurationSet()
        {
            return this._configurationSet != null;
        }

        /// <summary>
        /// Gets and sets the property EmailSendingAccount. 
        /// <para>
        /// Specifies whether Amazon Cognito emails your users by using its built-in email functionality
        /// or your Amazon SES email configuration. Specify one of the following values:
        /// </para>
        ///  <dl> <dt>COGNITO_DEFAULT</dt> <dd> 
        /// <para>
        /// When Amazon Cognito emails your users, it uses its built-in email functionality. When
        /// you use the default option, Amazon Cognito allows only a limited number of emails
        /// each day for your user pool. For typical production environments, the default email
        /// limit is below the required delivery volume. To achieve a higher delivery volume,
        /// specify DEVELOPER to use your Amazon SES email configuration.
        /// </para>
        ///  
        /// <para>
        /// To look up the email delivery limit for the default option, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/limits.html">Limits
        /// in Amazon Cognito</a> in the <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The default FROM address is no-reply@verificationemail.com. To customize the FROM
        /// address, provide the ARN of an Amazon SES verified email address for the <code>SourceArn</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  If EmailSendingAccount is COGNITO_DEFAULT, the following parameters aren't allowed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// EmailVerificationMessage
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EmailVerificationSubject
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InviteMessageTemplate.EmailMessage
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InviteMessageTemplate.EmailSubject
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VerificationMessageTemplate.EmailMessage
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VerificationMessageTemplate.EmailMessageByLink
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VerificationMessageTemplate.EmailSubject,
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VerificationMessageTemplate.EmailSubjectByLink
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// DEVELOPER EmailSendingAccount is required.
        /// </para>
        ///  </note> </dd> <dt>DEVELOPER</dt> <dd> 
        /// <para>
        /// When Amazon Cognito emails your users, it uses your Amazon SES configuration. Amazon
        /// Cognito calls Amazon SES on your behalf to send email from your verified email address.
        /// When you use this option, the email delivery limits are the same limits that apply
        /// to your Amazon SES verified email address in your AWS account.
        /// </para>
        ///  
        /// <para>
        /// If you use this option, you must provide the ARN of an Amazon SES verified email address
        /// for the <code>SourceArn</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// Before Amazon Cognito can email your users, it requires additional permissions to
        /// call Amazon SES on your behalf. When you update your user pool with this option, Amazon
        /// Cognito creates a <i>service-linked role</i>, which is a type of IAM role, in your
        /// AWS account. This role contains the permissions that allow Amazon Cognito to access
        /// Amazon SES and send email messages with your address. For more information about the
        /// service-linked role that Amazon Cognito creates, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/using-service-linked-roles.html">Using
        /// Service-Linked Roles for Amazon Cognito</a> in the <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public EmailSendingAccountType EmailSendingAccount
        {
            get { return this._emailSendingAccount; }
            set { this._emailSendingAccount = value; }
        }

        // Check to see if EmailSendingAccount property is set
        internal bool IsSetEmailSendingAccount()
        {
            return this._emailSendingAccount != null;
        }

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// Identifies either the sender’s email address or the sender’s name with their email
        /// address. For example, <code>testuser@example.com</code> or <code>Test User &lt;testuser@example.com&gt;</code>.
        /// This address will appear before the body of the email.
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
        /// Gets and sets the property ReplyToEmailAddress. 
        /// <para>
        /// The destination to which the receiver of the email should reply to.
        /// </para>
        /// </summary>
        public string ReplyToEmailAddress
        {
            get { return this._replyToEmailAddress; }
            set { this._replyToEmailAddress = value; }
        }

        // Check to see if ReplyToEmailAddress property is set
        internal bool IsSetReplyToEmailAddress()
        {
            return this._replyToEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a verified email address in Amazon SES. This email
        /// address is used in one of the following ways, depending on the value that you specify
        /// for the <code>EmailSendingAccount</code> parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify <code>COGNITO_DEFAULT</code>, Amazon Cognito uses this address as the
        /// custom FROM address when it emails your users by using its built-in email account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <code>DEVELOPER</code>, Amazon Cognito emails your users with this
        /// address by calling Amazon SES on your behalf.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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

    }
}