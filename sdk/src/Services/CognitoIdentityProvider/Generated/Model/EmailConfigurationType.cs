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
    /// The email configuration of your user pool. The email configuration type sets your
    /// preferred sending method, Amazon Web Services Region, and sender for messages from
    /// your user pool.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Cognito can send email messages with Amazon Simple Email Service resources
    /// in the Amazon Web Services Region where you created your user pool, and in alternate
    /// Regions in some cases. For more information on the supported Regions, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-email.html">Email
    /// settings for Amazon Cognito user pools</a>.
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
        /// The set of configuration rules that can be applied to emails sent using Amazon Simple
        /// Email Service. A configuration set is applied to an email by including a reference
        /// to the configuration set in the headers of the email. Once applied, all of the rules
        /// in that configuration set are applied to the email. Configuration sets can be used
        /// to apply the following types of rules to emails: 
        /// </para>
        ///  <dl> <dt>Event publishing</dt> <dd> 
        /// <para>
        /// Amazon Simple Email Service can track the number of send, delivery, open, click, bounce,
        /// and complaint events for each email sent. Use event publishing to send information
        /// about these events to other Amazon Web Services services such as and Amazon CloudWatch
        /// </para>
        ///  </dd> <dt>IP pool management</dt> <dd> 
        /// <para>
        /// When leasing dedicated IP addresses with Amazon Simple Email Service, you can create
        /// groups of IP addresses, called dedicated IP pools. You can then associate the dedicated
        /// IP pools with configuration sets.
        /// </para>
        ///  </dd> </dl>
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
        /// Specifies whether Amazon Cognito uses its built-in functionality to send your users
        /// email messages, or uses your Amazon Simple Email Service email configuration. Specify
        /// one of the following values:
        /// </para>
        ///  <dl> <dt>COGNITO_DEFAULT</dt> <dd> 
        /// <para>
        /// When Amazon Cognito emails your users, it uses its built-in email functionality. When
        /// you use the default option, Amazon Cognito allows only a limited number of emails
        /// each day for your user pool. For typical production environments, the default email
        /// limit is less than the required delivery volume. To achieve a higher delivery volume,
        /// specify DEVELOPER to use your Amazon SES email configuration.
        /// </para>
        ///  
        /// <para>
        /// To look up the email delivery limit for the default option, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/limits.html">Limits</a>
        /// in the <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The default FROM address is <c>no-reply@verificationemail.com</c>. To customize the
        /// FROM address, provide the Amazon Resource Name (ARN) of an Amazon SES verified email
        /// address for the <c>SourceArn</c> parameter.
        /// </para>
        ///  </dd> <dt>DEVELOPER</dt> <dd> 
        /// <para>
        /// When Amazon Cognito emails your users, it uses your Amazon SES configuration. Amazon
        /// Cognito calls Amazon SES on your behalf to send email from your verified email address.
        /// When you use this option, the email delivery limits are the same limits that apply
        /// to your Amazon SES verified email address in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// If you use this option, provide the ARN of an Amazon SES verified email address for
        /// the <c>SourceArn</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Before Amazon Cognito can email your users, it requires additional permissions to
        /// call Amazon SES on your behalf. When you update your user pool with this option, Amazon
        /// Cognito creates a <i>service-linked role</i>, which is a type of role in your Amazon
        /// Web Services account. This role contains the permissions that allow you to access
        /// Amazon SES and send email messages from your email address. For more information about
        /// the service-linked role that Amazon Cognito creates, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/using-service-linked-roles.html">Using
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
        /// Either the sender’s email address or the sender’s name with their email address. For
        /// example, <c>testuser@example.com</c> or <c>Test User &lt;testuser@example.com&gt;</c>.
        /// This address appears before the body of the email.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
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
        /// The destination to which the receiver of the email should reply.
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
        /// The ARN of a verified email address or an address from a verified domain in Amazon
        /// SES. You can set a <c>SourceArn</c> email from a verified domain only with an API
        /// request. You can set a verified email address, but not an address in a verified domain,
        /// in the Amazon Cognito console. Amazon Cognito uses the email address that you provide
        /// in one of the following ways, depending on the value that you specify for the <c>EmailSendingAccount</c>
        /// parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify <c>COGNITO_DEFAULT</c>, Amazon Cognito uses this address as the custom
        /// FROM address when it emails your users using its built-in email account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>DEVELOPER</c>, Amazon Cognito emails your users with this address
        /// by calling Amazon SES on your behalf.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The Region value of the <c>SourceArn</c> parameter must indicate a supported Amazon
        /// Web Services Region of your user pool. Typically, the Region in the <c>SourceArn</c>
        /// and the user pool Region are the same. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-email.html#user-pool-email-developer-region-mapping">Amazon
        /// SES email configuration regions</a> in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools.html">Amazon
        /// Cognito Developer Guide</a>.
        /// </para>
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