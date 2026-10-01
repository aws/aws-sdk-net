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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Read-only authentication configuration containing non-sensitive authentication details
    /// for action connectors.
    /// </summary>
    public partial class ReadAuthConfig
    {
        /// <summary>
        /// Gets and sets the property AuthenticationMetadata. 
        /// <para>
        /// The authentication metadata containing configuration details specific to the authentication
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReadAuthenticationMetadata AuthenticationMetadata { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMetadata property is set.
        /// </summary>
        internal bool IsSetAuthenticationMetadata() => this.AuthenticationMetadata != null;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The type of authentication being used (BASIC, API_KEY, OAUTH2_CLIENT_CREDENTIALS,
        /// or OAUTH2_AUTHORIZATION_CODE).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectionAuthType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;
    }
}
