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
    /// The risk evaluation by adaptive authentication, as displayed in an <c>AdminListUserAuthEvents</c>
    /// response. Contains evaluations of compromised-credentials detection and assessed risk
    /// level and action taken by adaptive authentication.
    /// </summary>
    public partial class EventRiskType
    {
        private bool? _compromisedCredentialsDetected;
        private RiskDecisionType _riskDecision;
        private RiskLevelType _riskLevel;

        /// <summary>
        /// Gets and sets the property CompromisedCredentialsDetected. 
        /// <para>
        /// Indicates whether compromised credentials were detected during an authentication event.
        /// </para>
        /// </summary>
        public bool? CompromisedCredentialsDetected
        {
            get { return this._compromisedCredentialsDetected; }
            set { this._compromisedCredentialsDetected = value; }
        }

        // Check to see if CompromisedCredentialsDetected property is set
        internal bool IsSetCompromisedCredentialsDetected()
        {
            return this._compromisedCredentialsDetected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RiskDecision. 
        /// <para>
        /// The action taken by adaptive authentication. If <c>NoRisk</c>, your user pool took
        /// no action. If <c>AccountTakeover</c>, your user pool applied the adaptive authentication
        /// automated response that you configured. If <c>Block</c>, your user pool prevented
        /// the attempt.
        /// </para>
        /// </summary>
        public RiskDecisionType RiskDecision
        {
            get { return this._riskDecision; }
            set { this._riskDecision = value; }
        }

        // Check to see if RiskDecision property is set
        internal bool IsSetRiskDecision()
        {
            return this._riskDecision != null;
        }

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// The risk level that adaptive authentication assessed for the authentication event.
        /// </para>
        /// </summary>
        public RiskLevelType RiskLevel
        {
            get { return this._riskLevel; }
            set { this._riskLevel = value; }
        }

        // Check to see if RiskLevel property is set
        internal bool IsSetRiskLevel()
        {
            return this._riskLevel != null;
        }

    }
}