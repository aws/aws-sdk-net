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
    /// Container for the parameters to the DescribeRiskConfiguration operation. Given an
    /// app client or user pool ID where threat protection is configured, describes the risk
    /// configuration. This operation returns details about adaptive authentication, compromised
    /// credentials, and IP-address allow- and denylists. For more information about threat
    /// protection, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-threat-protection.html">Threat
    /// protection</a>.
    /// </summary>
    public partial class DescribeRiskConfigurationRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client with the risk configuration that you want to inspect. You
        /// can apply default risk configuration at the user pool level and further customize
        /// it from user pool defaults at the app-client level. Specify <c>ClientId</c> to inspect
        /// client-level configuration, or <c>UserPoolId</c> to inspect pool-level configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool with the risk configuration that you want to inspect. You
        /// can apply default risk configuration at the user pool level and further customize
        /// it from user pool defaults at the app-client level. Specify <c>ClientId</c> to inspect
        /// client-level configuration, or <c>UserPoolId</c> to inspect pool-level configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
