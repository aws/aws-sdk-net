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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// This is the response object from the SignUp operation.
    /// </summary>
    public partial class SignUpResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CodeDeliveryDetails. 
        /// <para>
        /// In user pools that automatically verify and confirm new users, Amazon Cognito sends
        /// users a message with a code or link that confirms ownership of the phone number or
        /// email address that they entered. The <c>CodeDeliveryDetails</c> object is information
        /// about the delivery destination for that link or code.
        /// </para>
        /// </summary>
        public CodeDeliveryDetailsType CodeDeliveryDetails { get; set; }

        /// <summary>
        /// Checks to see if the CodeDeliveryDetails property is set.
        /// </summary>
        internal bool IsSetCodeDeliveryDetails() => this.CodeDeliveryDetails != null;

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// A session Id that you can pass to <c>ConfirmSignUp</c> when you want to immediately
        /// sign in your user with the <c>USER_AUTH</c> flow after they complete sign-up.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 20, Max = 4096)]
        public string Session { get; set; }

        /// <summary>
        /// Checks to see if the Session property is set.
        /// </summary>
        internal bool IsSetSession() => this.Session != null;

        /// <summary>
        /// Gets and sets the property UserConfirmed. 
        /// <para>
        /// Indicates whether the user was automatically confirmed. You can auto-confirm users
        /// with a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-pre-sign-up.html">pre
        /// sign-up Lambda trigger</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? UserConfirmed { get; set; }

        /// <summary>
        /// Checks to see if the UserConfirmed property is set.
        /// </summary>
        internal bool IsSetUserConfirmed() => this.UserConfirmed.HasValue;

        /// <summary>
        /// Gets and sets the property UserSub. 
        /// <para>
        /// The unique identifier of the new user, for example <c>a1b2c3d4-5678-90ab-cdef-EXAMPLE11111</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 131072)]
        public string UserSub { get; set; }

        /// <summary>
        /// Checks to see if the UserSub property is set.
        /// </summary>
        internal bool IsSetUserSub() => this.UserSub != null;
    }
}
