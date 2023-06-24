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
    /// Container for the parameters to the UpdateAuthEventFeedback operation.
    /// Provides the feedback for an authentication event, whether it was from a valid user
    /// or not. This feedback is used for improving the risk evaluation decision for the user
    /// pool as part of Amazon Cognito advanced security.
    /// </summary>
    public partial class UpdateAuthEventFeedbackRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _eventId;
        private string _feedbackToken;
        private FeedbackValueType _feedbackValue;
        private string _username;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The event ID.
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
        /// Gets and sets the property FeedbackToken. 
        /// <para>
        /// The feedback token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string FeedbackToken
        {
            get { return this._feedbackToken; }
            set { this._feedbackToken = value; }
        }

        // Check to see if FeedbackToken property is set
        internal bool IsSetFeedbackToken()
        {
            return this._feedbackToken != null;
        }

        /// <summary>
        /// Gets and sets the property FeedbackValue. 
        /// <para>
        /// The authentication event feedback value.
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