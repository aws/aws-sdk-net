/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Specifies the configuration for AWS Lambda triggers.
    /// </summary>
    public partial class LambdaConfigType
    {
        private string _createAuthChallenge;
        private string _customMessage;
        private string _defineAuthChallenge;
        private string _postAuthentication;
        private string _postConfirmation;
        private string _preAuthentication;
        private string _preSignUp;
        private string _preTokenGeneration;
        private string _userMigration;
        private string _verifyAuthChallengeResponse;

        /// <summary>
        /// Gets and sets the property CreateAuthChallenge. 
        /// <para>
        /// Creates an authentication challenge.
        /// </para>
        /// </summary>
        public string CreateAuthChallenge
        {
            get { return this._createAuthChallenge; }
            set { this._createAuthChallenge = value; }
        }

        // Check to see if CreateAuthChallenge property is set
        internal bool IsSetCreateAuthChallenge()
        {
            return this._createAuthChallenge != null;
        }

        /// <summary>
        /// Gets and sets the property CustomMessage. 
        /// <para>
        /// A custom Message AWS Lambda trigger.
        /// </para>
        /// </summary>
        public string CustomMessage
        {
            get { return this._customMessage; }
            set { this._customMessage = value; }
        }

        // Check to see if CustomMessage property is set
        internal bool IsSetCustomMessage()
        {
            return this._customMessage != null;
        }

        /// <summary>
        /// Gets and sets the property DefineAuthChallenge. 
        /// <para>
        /// Defines the authentication challenge.
        /// </para>
        /// </summary>
        public string DefineAuthChallenge
        {
            get { return this._defineAuthChallenge; }
            set { this._defineAuthChallenge = value; }
        }

        // Check to see if DefineAuthChallenge property is set
        internal bool IsSetDefineAuthChallenge()
        {
            return this._defineAuthChallenge != null;
        }

        /// <summary>
        /// Gets and sets the property PostAuthentication. 
        /// <para>
        /// A post-authentication AWS Lambda trigger.
        /// </para>
        /// </summary>
        public string PostAuthentication
        {
            get { return this._postAuthentication; }
            set { this._postAuthentication = value; }
        }

        // Check to see if PostAuthentication property is set
        internal bool IsSetPostAuthentication()
        {
            return this._postAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property PostConfirmation. 
        /// <para>
        /// A post-confirmation AWS Lambda trigger.
        /// </para>
        /// </summary>
        public string PostConfirmation
        {
            get { return this._postConfirmation; }
            set { this._postConfirmation = value; }
        }

        // Check to see if PostConfirmation property is set
        internal bool IsSetPostConfirmation()
        {
            return this._postConfirmation != null;
        }

        /// <summary>
        /// Gets and sets the property PreAuthentication. 
        /// <para>
        /// A pre-authentication AWS Lambda trigger.
        /// </para>
        /// </summary>
        public string PreAuthentication
        {
            get { return this._preAuthentication; }
            set { this._preAuthentication = value; }
        }

        // Check to see if PreAuthentication property is set
        internal bool IsSetPreAuthentication()
        {
            return this._preAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property PreSignUp. 
        /// <para>
        /// A pre-registration AWS Lambda trigger.
        /// </para>
        /// </summary>
        public string PreSignUp
        {
            get { return this._preSignUp; }
            set { this._preSignUp = value; }
        }

        // Check to see if PreSignUp property is set
        internal bool IsSetPreSignUp()
        {
            return this._preSignUp != null;
        }

        /// <summary>
        /// Gets and sets the property PreTokenGeneration. 
        /// <para>
        /// A Lambda trigger that is invoked before token generation.
        /// </para>
        /// </summary>
        public string PreTokenGeneration
        {
            get { return this._preTokenGeneration; }
            set { this._preTokenGeneration = value; }
        }

        // Check to see if PreTokenGeneration property is set
        internal bool IsSetPreTokenGeneration()
        {
            return this._preTokenGeneration != null;
        }

        /// <summary>
        /// Gets and sets the property UserMigration. 
        /// <para>
        /// The user migration Lambda config type.
        /// </para>
        /// </summary>
        public string UserMigration
        {
            get { return this._userMigration; }
            set { this._userMigration = value; }
        }

        // Check to see if UserMigration property is set
        internal bool IsSetUserMigration()
        {
            return this._userMigration != null;
        }

        /// <summary>
        /// Gets and sets the property VerifyAuthChallengeResponse. 
        /// <para>
        /// Verifies the authentication challenge response.
        /// </para>
        /// </summary>
        public string VerifyAuthChallengeResponse
        {
            get { return this._verifyAuthChallengeResponse; }
            set { this._verifyAuthChallengeResponse = value; }
        }

        // Check to see if VerifyAuthChallengeResponse property is set
        internal bool IsSetVerifyAuthChallengeResponse()
        {
            return this._verifyAuthChallengeResponse != null;
        }

    }
}