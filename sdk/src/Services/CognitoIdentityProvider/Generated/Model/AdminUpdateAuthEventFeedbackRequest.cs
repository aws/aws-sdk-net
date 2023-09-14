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
    /// Container for the parameters to the AdminUpdateAuthEventFeedback operation.
    /// Provides feedback for an authentication event indicating if it was from a valid user.
    /// This feedback is used for improving the risk evaluation decision for the user pool
    /// as part of Amazon Cognito advanced security.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AdminUpdateAuthEventFeedbackRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _eventId;
        private FeedbackValueType _feedbackValue;
        private string _username;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The authentication event ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property FeedbackValue. 
        /// <para>
        /// The authentication event feedback value. When you provide a <code>FeedbackValue</code>
        /// value of <code>valid</code>, you tell Amazon Cognito that you trust a user session
        /// where Amazon Cognito has evaluated some level of risk. When you provide a <code>FeedbackValue</code>
        /// value of <code>invalid</code>, you tell Amazon Cognito that you don't trust a user
        /// session, or you don't believe that Amazon Cognito evaluated a high-enough risk level.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeedbackValueType FeedbackValue
        {
            get { return this._feedbackValue; }
            set { this._feedbackValue = value; }
        }

        // Check to see if FeedbackValue property is set
        internal bool IsSetFeedbackValue()
        {
            return this._feedbackValue != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user pool username.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}