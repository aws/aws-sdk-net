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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterConnectorV2 operation. Grants permission
    /// to complete the authorization based on input parameters.
    /// </summary>
    public partial class RegisterConnectorV2Request : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property AuthCode. 
        /// <para>
        /// The authCode retrieved from authUrl to complete the OAuth 2.0 authorization code flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Checks to see if the AuthCode property is set.
        /// </summary>
        internal bool IsSetAuthCode() => this.AuthCode != null;

        /// <summary>
        /// Gets and sets the property AuthState. 
        /// <para>
        /// The authState retrieved from authUrl to complete the OAuth 2.0 authorization code
        /// flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AuthState { get; set; }

        /// <summary>
        /// Checks to see if the AuthState property is set.
        /// </summary>
        internal bool IsSetAuthState() => this.AuthState != null;
    }
}
