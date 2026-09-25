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

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Contains the authentication settings that Connect Customer uses to call an external
    /// application endpoint. The configuration includes the authentication type and credential
    /// location.
    /// </summary>
    public partial class AuthConfig
    {
        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The type of authentication used when calling the external application.
        /// </para>
        /// </summary>
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property CredentialProviderIdentifier. 
        /// <para>
        /// The ARN of the Secrets Manager secret that stores the credentials. The secret must
        /// be accessible to Connect Customer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CredentialProviderIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CredentialProviderIdentifier property is set.
        /// </summary>
        internal bool IsSetCredentialProviderIdentifier() => this.CredentialProviderIdentifier != null;
    }
}
