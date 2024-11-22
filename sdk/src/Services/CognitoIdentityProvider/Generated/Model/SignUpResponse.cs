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
    /// The response from the server for a registration request.
    /// </summary>
    public partial class SignUpResponse : AmazonWebServiceResponse
    {
        private CodeDeliveryDetailsType _codeDeliveryDetails;
        private string _session;
        private bool? _userConfirmed;
        private string _userSub;

        /// <summary>
        /// Gets and sets the property CodeDeliveryDetails. 
        /// <para>
        /// The code delivery details returned by the server response to the user registration
        /// request.
        /// </para>
        /// </summary>
        public CodeDeliveryDetailsType CodeDeliveryDetails
        {
            get { return this._codeDeliveryDetails; }
            set { this._codeDeliveryDetails = value; }
        }

        // Check to see if CodeDeliveryDetails property is set
        internal bool IsSetCodeDeliveryDetails()
        {
            return this._codeDeliveryDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// A session Id that you can pass to <c>ConfirmSignUp</c> when you want to immediately
        /// sign in your user with the <c>USER_AUTH</c> flow after they complete sign-up.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=20, Max=2048)]
        public string Session
        {
            get { return this._session; }
            set { this._session = value; }
        }

        // Check to see if Session property is set
        internal bool IsSetSession()
        {
            return this._session != null;
        }

        /// <summary>
        /// Gets and sets the property UserConfirmed. 
        /// <para>
        /// A response from the server indicating that a user registration has been confirmed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool UserConfirmed
        {
            get { return this._userConfirmed.GetValueOrDefault(); }
            set { this._userConfirmed = value; }
        }

        // Check to see if UserConfirmed property is set
        internal bool IsSetUserConfirmed()
        {
            return this._userConfirmed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserSub. 
        /// <para>
        /// The 128-bit ID of the authenticated user. This isn't the same as <c>username</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=131072)]
        public string UserSub
        {
            get { return this._userSub; }
            set { this._userSub = value; }
        }

        // Check to see if UserSub property is set
        internal bool IsSetUserSub()
        {
            return this._userSub != null;
        }

    }
}