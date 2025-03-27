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
    /// A collection of user pool Lambda triggers. Amazon Cognito invokes triggers at several
    /// possible stages of user pool operations. Triggers can modify the outcome of the operations
    /// that invoked them.
    /// </summary>
    public partial class LambdaConfigType
    {
        private string _createAuthChallenge;
        private CustomEmailLambdaVersionConfigType _customEmailSender;
        private string _customMessage;
        private CustomSMSLambdaVersionConfigType _customSMSSender;
        private string _defineAuthChallenge;
        private string _kmsKeyID;
        private string _postAuthentication;
        private string _postConfirmation;
        private string _preAuthentication;
        private string _preSignUp;
        private string _preTokenGeneration;
        private PreTokenGenerationVersionConfigType _preTokenGenerationConfig;
        private string _userMigration;
        private string _verifyAuthChallengeResponse;

        /// <summary>
        /// Gets and sets the property CreateAuthChallenge. 
        /// <para>
        /// The configuration of a create auth challenge Lambda trigger, one of three triggers
        /// in the sequence of the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">custom
        /// authentication challenge triggers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property CustomEmailSender. 
        /// <para>
        /// The configuration of a custom email sender Lambda trigger. This trigger routes all
        /// email notifications from a user pool to a Lambda function that delivers the message
        /// using custom logic.
        /// </para>
        /// </summary>
        public CustomEmailLambdaVersionConfigType CustomEmailSender
        {
            get { return this._customEmailSender; }
            set { this._customEmailSender = value; }
        }

        // Check to see if CustomEmailSender property is set
        internal bool IsSetCustomEmailSender()
        {
            return this._customEmailSender != null;
        }

        /// <summary>
        /// Gets and sets the property CustomMessage. 
        /// <para>
        /// A custom message Lambda trigger. This trigger is an opportunity to customize all SMS
        /// and email messages from your user pool. When a custom message trigger is active, your
        /// user pool routes all messages to a Lambda function that returns a runtime-customized
        /// message subject and body for your user pool to deliver to a user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property CustomSMSSender. 
        /// <para>
        /// The configuration of a custom SMS sender Lambda trigger. This trigger routes all SMS
        /// notifications from a user pool to a Lambda function that delivers the message using
        /// custom logic.
        /// </para>
        /// </summary>
        public CustomSMSLambdaVersionConfigType CustomSMSSender
        {
            get { return this._customSMSSender; }
            set { this._customSMSSender = value; }
        }

        // Check to see if CustomSMSSender property is set
        internal bool IsSetCustomSMSSender()
        {
            return this._customSMSSender != null;
        }

        /// <summary>
        /// Gets and sets the property DefineAuthChallenge. 
        /// <para>
        /// The configuration of a define auth challenge Lambda trigger, one of three triggers
        /// in the sequence of the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">custom
        /// authentication challenge triggers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property KMSKeyID. 
        /// <para>
        /// The ARN of an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">KMS
        /// key</a>. Amazon Cognito uses the key to encrypt codes and temporary passwords sent
        /// to custom sender Lambda triggers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KMSKeyID
        {
            get { return this._kmsKeyID; }
            set { this._kmsKeyID = value; }
        }

        // Check to see if KMSKeyID property is set
        internal bool IsSetKMSKeyID()
        {
            return this._kmsKeyID != null;
        }

        /// <summary>
        /// Gets and sets the property PostAuthentication. 
        /// <para>
        /// The configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-post-authentication.html">post
        /// authentication Lambda trigger</a> in a user pool. This trigger can take custom actions
        /// after a user signs in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-post-confirmation.html">post
        /// confirmation Lambda trigger</a> in a user pool. This trigger can take custom actions
        /// after a user confirms their user account and their email address or phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-pre-authentication.html">pre
        /// authentication trigger</a> in a user pool. This trigger can evaluate and modify user
        /// sign-in events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-pre-sign-up.html">pre
        /// sign-up Lambda trigger</a> in a user pool. This trigger evaluates new users and can
        /// bypass confirmation, <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation-consolidate-users.html">link
        /// a federated user profile</a>, or block sign-up requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The legacy configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-pre-token-generation.html">pre
        /// token generation Lambda trigger</a> in a user pool.
        /// </para>
        ///  
        /// <para>
        /// Set this parameter for legacy purposes. If you also set an ARN in <c>PreTokenGenerationConfig</c>,
        /// its value must be identical to <c>PreTokenGeneration</c>. For new instances of pre
        /// token generation triggers, set the <c>LambdaArn</c> of <c>PreTokenGenerationConfig</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property PreTokenGenerationConfig. 
        /// <para>
        /// The detailed configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-pre-token-generation.html">pre
        /// token generation Lambda trigger</a> in a user pool. If you also set an ARN in <c>PreTokenGeneration</c>,
        /// its value must be identical to <c>PreTokenGenerationConfig</c>.
        /// </para>
        /// </summary>
        public PreTokenGenerationVersionConfigType PreTokenGenerationConfig
        {
            get { return this._preTokenGenerationConfig; }
            set { this._preTokenGenerationConfig = value; }
        }

        // Check to see if PreTokenGenerationConfig property is set
        internal bool IsSetPreTokenGenerationConfig()
        {
            return this._preTokenGenerationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property UserMigration. 
        /// <para>
        /// The configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-migrate-user.html">migrate
        /// user Lambda trigger</a> in a user pool. This trigger can create user profiles when
        /// users sign in or attempt to reset their password with credentials that don't exist
        /// yet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The configuration of a verify auth challenge Lambda trigger, one of three triggers
        /// in the sequence of the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">custom
        /// authentication challenge triggers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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