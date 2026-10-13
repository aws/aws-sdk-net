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
    /// application endpoint.
    /// </summary>
    public partial class AuthConfig
    {
        /// <summary>
        /// Gets and sets the property AudienceOverride. 
        /// <para>
        /// The value that Connect Customer uses as the audience (<c>aud</c>) claim of the JSON
        /// Web Token (JWT) that it issues. You can specify this parameter only when <c>AuthType</c>
        /// is <c>CONNECT_JWT</c>. If you don't specify it, the audience is the <c>AccessUrl</c>
        /// of the application. The value can't contain <c>connect.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AudienceOverride { get; set; }

        /// <summary>
        /// Checks to see if the AudienceOverride property is set.
        /// </summary>
        internal bool IsSetAudienceOverride() => this.AudienceOverride != null;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The type of authentication that Connect Customer uses to call the external application
        /// endpoint. You must specify an authentication type for <c>A2A_SERVER</c> applications.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>API_KEY</c>: Connect Customer sends an API key that is stored in the Secrets Manager
        /// secret that you specify in <c>CredentialProviderIdentifier</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECT_JWT</c>: Connect Customer issues a short-lived, signed JSON Web Token
        /// (JWT). This authentication type doesn't require a stored credential.
        /// </para>
        ///  </li> </ul>
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
        ///  
        /// <para>
        /// You must specify this ARN when <c>AuthType</c> is <c>API_KEY</c>. Don't specify it
        /// when <c>AuthType</c> is <c>CONNECT_JWT</c>.
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
