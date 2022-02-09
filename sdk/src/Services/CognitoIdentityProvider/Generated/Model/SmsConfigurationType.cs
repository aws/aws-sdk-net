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
    /// The SMS configuration type that includes the settings the Amazon Cognito User Pool
    /// must call for the Amazon Simple Notification Service service to send an SMS message
    /// from your Amazon Web Services account. The Amazon Cognito User Pool makes the request
    /// to the Amazon SNS Service by using an Identity and Access Management role that you
    /// provide for your Amazon Web Services account.
    /// </summary>
    public partial class SmsConfigurationType
    {
        private string _externalId;
        private string _snsCallerArn;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID is a value that you should use to add security to your IAM role that
        /// is used to call Amazon SNS to send SMS messages for your user pool. If you provide
        /// an <code>ExternalId</code>, the Amazon Cognito User Pool will include it when attempting
        /// to assume your IAM role so that you can set your roles trust policy to require the
        /// <code>ExternalID</code>. If you use the Amazon Cognito Management Console to create
        /// a role for SMS multi-factor authentication (MFA), Amazon Cognito will create a role
        /// with the required permissions and a trust policy that demonstrates use of the <code>ExternalId</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>ExternalId</code> of a role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-user_externalid.html">How
        /// to use an external ID when granting access to your Amazon Web Services resources to
        /// a third party</a> 
        /// </para>
        /// </summary>
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

    }
}