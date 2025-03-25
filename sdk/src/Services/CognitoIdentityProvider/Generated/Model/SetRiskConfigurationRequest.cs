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
    /// Container for the parameters to the SetRiskConfiguration operation.
    /// Configures threat protection for a user pool or app client. Sets configuration for
    /// the following.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Responses to risks with adaptive authentication
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Responses to vulnerable passwords with compromised-credentials detection
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Notifications to users who have had risky activity detected
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IP-address denylist and allowlist
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To set the risk configuration for the user pool to defaults, send this request with
    /// only the <c>UserPoolId</c> parameter. To reset the threat protection settings of an
    /// app client to be inherited from the user pool, send <c>UserPoolId</c> and <c>ClientId</c>
    /// parameters only. To change threat protection to audit-only or off, update the value
    /// of <c>UserPoolAddOns</c> in an <c>UpdateUserPool</c> request. To activate this setting,
    /// your user pool must be on the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-plus.html">
    /// Plus tier</a>.
    /// </para>
    /// </summary>
    public partial class SetRiskConfigurationRequest : AmazonCognitoIdentityProviderRequest
    {
        private AccountTakeoverRiskConfigurationType _accountTakeoverRiskConfiguration;
        private string _clientId;
        private CompromisedCredentialsRiskConfigurationType _compromisedCredentialsRiskConfiguration;
        private RiskExceptionConfigurationType _riskExceptionConfiguration;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property AccountTakeoverRiskConfiguration. 
        /// <para>
        /// The settings for automated responses and notification templates for adaptive authentication
        /// with threat protection.
        /// </para>
        /// </summary>
        public AccountTakeoverRiskConfigurationType AccountTakeoverRiskConfiguration
        {
            get { return this._accountTakeoverRiskConfiguration; }
            set { this._accountTakeoverRiskConfiguration = value; }
        }

        // Check to see if AccountTakeoverRiskConfiguration property is set
        internal bool IsSetAccountTakeoverRiskConfiguration()
        {
            return this._accountTakeoverRiskConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client where you want to set a risk configuration. If <c>ClientId</c>
        /// is null, then the risk configuration is mapped to <c>UserPoolId</c>. When the client
        /// ID is null, the same risk configuration is applied to all the clients in the userPool.
        /// </para>
        ///  
        /// <para>
        /// When you include a <c>ClientId</c> parameter, Amazon Cognito maps the configuration
        /// to the app client. When you include both <c>ClientId</c> and <c>UserPoolId</c>, Amazon
        /// Cognito maps the configuration to the app client only.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property CompromisedCredentialsRiskConfiguration. 
        /// <para>
        /// The configuration of automated reactions to detected compromised credentials. Includes
        /// settings for blocking future sign-in requests and for the types of password-submission
        /// events you want to monitor.
        /// </para>
        /// </summary>
        public CompromisedCredentialsRiskConfigurationType CompromisedCredentialsRiskConfiguration
        {
            get { return this._compromisedCredentialsRiskConfiguration; }
            set { this._compromisedCredentialsRiskConfiguration = value; }
        }

        // Check to see if CompromisedCredentialsRiskConfiguration property is set
        internal bool IsSetCompromisedCredentialsRiskConfiguration()
        {
            return this._compromisedCredentialsRiskConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RiskExceptionConfiguration. 
        /// <para>
        /// A set of IP-address overrides to threat protection. You can set up IP-address always-block
        /// and always-allow lists.
        /// </para>
        /// </summary>
        public RiskExceptionConfigurationType RiskExceptionConfiguration
        {
            get { return this._riskExceptionConfiguration; }
            set { this._riskExceptionConfiguration = value; }
        }

        // Check to see if RiskExceptionConfiguration property is set
        internal bool IsSetRiskExceptionConfiguration()
        {
            return this._riskExceptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to set a risk configuration. If you include
        /// <c>UserPoolId</c> in your request, don't include <c>ClientId</c>. When the client
        /// ID is null, the same risk configuration is applied to all the clients in the userPool.
        /// When you include both <c>ClientId</c> and <c>UserPoolId</c>, Amazon Cognito maps the
        /// configuration to the app client only.
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