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
    /// The settings of risk configuration for threat protection with threat protection in
    /// a user pool.
    /// </summary>
    public partial class RiskConfigurationType
    {
        /// <summary>
        /// Gets and sets the property AccountTakeoverRiskConfiguration. 
        /// <para>
        /// The settings for automated responses and notification templates for adaptive authentication
        /// with threat protection.
        /// </para>
        /// </summary>
        public AccountTakeoverRiskConfigurationType AccountTakeoverRiskConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AccountTakeoverRiskConfiguration property is set.
        /// </summary>
        internal bool IsSetAccountTakeoverRiskConfiguration() => this.AccountTakeoverRiskConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The app client where this configuration is applied. When this parameter isn't present,
        /// the risk configuration applies to all user pool app clients that don't have client-level
        /// settings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property CompromisedCredentialsRiskConfiguration. 
        /// <para>
        /// Settings for compromised-credentials actions and authentication types with threat
        /// protection in full-function <c>ENFORCED</c> mode.
        /// </para>
        /// </summary>
        public CompromisedCredentialsRiskConfigurationType CompromisedCredentialsRiskConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CompromisedCredentialsRiskConfiguration property is set.
        /// </summary>
        internal bool IsSetCompromisedCredentialsRiskConfiguration() => this.CompromisedCredentialsRiskConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property RiskExceptionConfiguration. 
        /// <para>
        /// Exceptions to the risk evaluation configuration, including always-allow and always-block
        /// IP address ranges. 
        /// </para>
        /// </summary>
        public RiskExceptionConfigurationType RiskExceptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RiskExceptionConfiguration property is set.
        /// </summary>
        internal bool IsSetRiskExceptionConfiguration() => this.RiskExceptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that has the risk configuration applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
