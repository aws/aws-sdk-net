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
    /// User pool configuration for delivery of SMS messages with Amazon Simple Notification
    /// Service. To send SMS messages with Amazon SNS in the Amazon Web Services Region that
    /// you want, the Amazon Cognito user pool uses an Identity and Access Management (IAM)
    /// role in your Amazon Web Services account.
    /// </summary>
    public partial class SmsConfigurationType
    {
        private string _externalId;
        private string _snsCallerArn;
        private string _snsRegion;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID provides additional security for your IAM role. You can use an <c>ExternalId</c>
        /// with the IAM role that you use with Amazon SNS to send SMS messages for your user
        /// pool. If you provide an <c>ExternalId</c>, your Amazon Cognito user pool includes
        /// it in the request to assume your IAM role. You can configure the role trust policy
        /// to require that Amazon Cognito, and any principal, provide the <c>ExternalID</c>.
        /// If you use the Amazon Cognito Management Console to create a role for SMS multi-factor
        /// authentication (MFA), Amazon Cognito creates a role with the required permissions
        /// and a trust policy that demonstrates use of the <c>ExternalId</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>ExternalId</c> of a role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-user_externalid.html">How
        /// to use an external ID when granting access to your Amazon Web Services resources to
        /// a third party</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property SnsCallerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS caller. This is the ARN of the IAM
        /// role in your Amazon Web Services account that Amazon Cognito will use to send SMS
        /// messages. SMS messages are subject to a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-email-phone-verification.html">spending
        /// limit</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string SnsCallerArn
        {
            get { return this._snsCallerArn; }
            set { this._snsCallerArn = value; }
        }

        // Check to see if SnsCallerArn property is set
        internal bool IsSetSnsCallerArn()
        {
            return this._snsCallerArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnsRegion. 
        /// <para>
        /// The Amazon Web Services Region to use with Amazon SNS integration. You can choose
        /// the same Region as your user pool, or a supported <b>Legacy Amazon SNS alternate Region</b>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Amazon Cognito resources in the Asia Pacific (Seoul) Amazon Web Services Region must
        /// use your Amazon SNS configuration in the Asia Pacific (Tokyo) Region. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-sms-settings.html">SMS
        /// message settings for Amazon Cognito user pools</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=32)]
        public string SnsRegion
        {
            get { return this._snsRegion; }
            set { this._snsRegion = value; }
        }

        // Check to see if SnsRegion property is set
        internal bool IsSetSnsRegion()
        {
            return this._snsRegion != null;
        }

    }
}