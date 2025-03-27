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
    /// The settings of risk configuration for threat protection with threat protection in
    /// a user pool.
    /// </summary>
    public partial class RiskConfigurationType
    {
        private AccountTakeoverRiskConfigurationType _accountTakeoverRiskConfiguration;
        private string _clientId;
        private CompromisedCredentialsRiskConfigurationType _compromisedCredentialsRiskConfiguration;
        private DateTime? _lastModifiedDate;
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
        /// The app client where this configuration is applied. When this parameter isn't present,
        /// the risk configuration applies to all user pool app clients that don't have client-level
        /// settings.
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
        /// Settings for compromised-credentials actions and authentication types with threat
        /// protection in full-function <c>ENFORCED</c> mode.
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RiskExceptionConfiguration. 
        /// <para>
        /// Exceptions to the risk evaluation configuration, including always-allow and always-block
        /// IP address ranges. 
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
        /// The ID of the user pool that has the risk configuration applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
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