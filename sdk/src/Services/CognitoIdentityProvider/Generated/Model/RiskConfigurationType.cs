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
    /// The risk configuration type.
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
        /// The account takeover risk configuration object, including the <code>NotifyConfiguration</code>
        /// object and <code>Actions</code> to take if there is an account takeover.
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
        /// The app client ID.
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
        /// The compromised credentials risk configuration object, including the <code>EventFilter</code>
        /// and the <code>EventAction</code>.
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
        /// The last modified date.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
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
        /// The configuration to override the risk decision.
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
        /// The user pool ID.
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