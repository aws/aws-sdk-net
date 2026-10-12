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
    /// A collection of user pool Lambda triggers. Amazon Cognito invokes triggers at several
    /// possible stages of user pool operations. Triggers can modify the outcome of the operations
    /// that invoked them.
    /// </summary>
    public partial class LambdaConfigType
    {
        /// <summary>
        /// Gets and sets the property CreateAuthChallenge. 
        /// <para>
        /// The configuration of a create auth challenge Lambda trigger, one of three triggers
        /// in the sequence of the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">custom
        /// authentication challenge triggers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CreateAuthChallenge { get; set; }

        /// <summary>
        /// Checks to see if the CreateAuthChallenge property is set.
        /// </summary>
        internal bool IsSetCreateAuthChallenge() => this.CreateAuthChallenge != null;

        /// <summary>
        /// Gets and sets the property CustomEmailSender. 
        /// <para>
        /// The configuration of a custom email sender Lambda trigger. This trigger routes all
        /// email notifications from a user pool to a Lambda function that delivers the message
        /// using custom logic.
        /// </para>
        /// </summary>
        public CustomEmailLambdaVersionConfigType CustomEmailSender { get; set; }

        /// <summary>
        /// Checks to see if the CustomEmailSender property is set.
        /// </summary>
        internal bool IsSetCustomEmailSender() => this.CustomEmailSender != null;

        /// <summary>
        /// Gets and sets the property CustomMessage. 
        /// <para>
        /// A custom message Lambda trigger. This trigger is an opportunity to customize all SMS
        /// and email messages from your user pool. When a custom message trigger is active, your
        /// user pool routes all messages to a Lambda function that returns a runtime-customized
        /// message subject and body for your user pool to deliver to a user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CustomMessage { get; set; }

        /// <summary>
        /// Checks to see if the CustomMessage property is set.
        /// </summary>
        internal bool IsSetCustomMessage() => this.CustomMessage != null;

        /// <summary>
        /// Gets and sets the property CustomSMSSender. 
        /// <para>
        /// The configuration of a custom SMS sender Lambda trigger. This trigger routes all SMS
        /// notifications from a user pool to a Lambda function that delivers the message using
        /// custom logic.
        /// </para>
        /// </summary>
        public CustomSMSLambdaVersionConfigType CustomSMSSender { get; set; }

        /// <summary>
        /// Checks to see if the CustomSMSSender property is set.
        /// </summary>
        internal bool IsSetCustomSMSSender() => this.CustomSMSSender != null;

        /// <summary>
        /// Gets and sets the property DefineAuthChallenge. 
        /// <para>
        /// The configuration of a define auth challenge Lambda trigger, one of three triggers
        /// in the sequence of the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">custom
        /// authentication challenge triggers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DefineAuthChallenge { get; set; }

        /// <summary>
        /// Checks to see if the DefineAuthChallenge property is set.
        /// </summary>
        internal bool IsSetDefineAuthChallenge() => this.DefineAuthChallenge != null;

        /// <summary>
        /// Gets and sets the property InboundFederation. 
        /// <para>
        /// The configuration of an inbound federation Lambda trigger. This trigger can transform
        /// federated user attributes during the authentication with external identity providers.
        /// </para>
        /// </summary>
        public InboundFederationLambdaType InboundFederation { get; set; }

        /// <summary>
        /// Checks to see if the InboundFederation property is set.
        /// </summary>
        internal bool IsSetInboundFederation() => this.InboundFederation != null;

        /// <summary>
        /// Gets and sets the property KMSKeyID. 
        /// <para>
        /// The ARN of an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">KMS
        /// key</a>. Amazon Cognito uses the key to encrypt codes and temporary passwords sent
        /// to custom sender Lambda triggers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KMSKeyID { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyID property is set.
        /// </summary>
        internal bool IsSetKMSKeyID() => this.KMSKeyID != null;

        /// <summary>
        /// Gets and sets the property PostAuthentication. 
        /// <para>
        /// The configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-post-authentication.html">post
        /// authentication Lambda trigger</a> in a user pool. This trigger can take custom actions
        /// after a user signs in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PostAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the PostAuthentication property is set.
        /// </summary>
        internal bool IsSetPostAuthentication() => this.PostAuthentication != null;

        /// <summary>
        /// Gets and sets the property PostConfirmation. 
        /// <para>
        /// The configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-post-confirmation.html">post
        /// confirmation Lambda trigger</a> in a user pool. This trigger can take custom actions
        /// after a user confirms their user account and their email address or phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PostConfirmation { get; set; }

        /// <summary>
        /// Checks to see if the PostConfirmation property is set.
        /// </summary>
        internal bool IsSetPostConfirmation() => this.PostConfirmation != null;

        /// <summary>
        /// Gets and sets the property PreAuthentication. 
        /// <para>
        /// The configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-pre-authentication.html">pre
        /// authentication trigger</a> in a user pool. This trigger can evaluate and modify user
        /// sign-in events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PreAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the PreAuthentication property is set.
        /// </summary>
        internal bool IsSetPreAuthentication() => this.PreAuthentication != null;

        /// <summary>
        /// Gets and sets the property PreSignUp. 
        /// <para>
        /// The configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-pre-sign-up.html">pre
        /// sign-up Lambda trigger</a> in a user pool. This trigger evaluates new users and can
        /// bypass confirmation, <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation-consolidate-users.html">link
        /// a federated user profile</a>, or block sign-up requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PreSignUp { get; set; }

        /// <summary>
        /// Checks to see if the PreSignUp property is set.
        /// </summary>
        internal bool IsSetPreSignUp() => this.PreSignUp != null;

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
        [AWSProperty(Min = 20, Max = 2048)]
        public string PreTokenGeneration { get; set; }

        /// <summary>
        /// Checks to see if the PreTokenGeneration property is set.
        /// </summary>
        internal bool IsSetPreTokenGeneration() => this.PreTokenGeneration != null;

        /// <summary>
        /// Gets and sets the property PreTokenGenerationConfig. 
        /// <para>
        /// The detailed configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-pre-token-generation.html">pre
        /// token generation Lambda trigger</a> in a user pool. If you also set an ARN in <c>PreTokenGeneration</c>,
        /// its value must be identical to <c>PreTokenGenerationConfig</c>.
        /// </para>
        /// </summary>
        public PreTokenGenerationVersionConfigType PreTokenGenerationConfig { get; set; }

        /// <summary>
        /// Checks to see if the PreTokenGenerationConfig property is set.
        /// </summary>
        internal bool IsSetPreTokenGenerationConfig() => this.PreTokenGenerationConfig != null;

        /// <summary>
        /// Gets and sets the property UserMigration. 
        /// <para>
        /// The configuration of a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-migrate-user.html">migrate
        /// user Lambda trigger</a> in a user pool. This trigger can create user profiles when
        /// users sign in or attempt to reset their password with credentials that don't exist
        /// yet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string UserMigration { get; set; }

        /// <summary>
        /// Checks to see if the UserMigration property is set.
        /// </summary>
        internal bool IsSetUserMigration() => this.UserMigration != null;

        /// <summary>
        /// Gets and sets the property VerifyAuthChallengeResponse. 
        /// <para>
        /// The configuration of a verify auth challenge Lambda trigger, one of three triggers
        /// in the sequence of the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">custom
        /// authentication challenge triggers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string VerifyAuthChallengeResponse { get; set; }

        /// <summary>
        /// Checks to see if the VerifyAuthChallengeResponse property is set.
        /// </summary>
        internal bool IsSetVerifyAuthChallengeResponse() => this.VerifyAuthChallengeResponse != null;
    }
}
