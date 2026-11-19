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
    /// Container for the parameters to the SetUserPoolClientSessionConfiguration operation.
    /// Sets the session configuration for a user pool app client. The configurable client-level
    /// setting is the maximum validity period for silent reuse of an SSO session. This operation
    /// performs a full replacement of the client-level session configuration; every request
    /// parameter is required, and session tracking must be enabled for the user pool. The
    /// user pool must be in the Essentials or Plus tier. Otherwise, this operation returns
    /// a <c>FeatureUnavailableInTierException</c>.
    /// </summary>
    public partial class SetUserPoolClientSessionConfigurationRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client that you want to configure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property SSOSession. 
        /// <para>
        /// The SSO session settings for the app client.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClientSSOSessionConfigType SSOSession { get; set; }

        /// <summary>
        /// Checks to see if the SSOSession property is set.
        /// </summary>
        internal bool IsSetSSOSession() => this.SSOSession != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that contains the app client.
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
