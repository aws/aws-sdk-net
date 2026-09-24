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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Used by select connectors for which the OAuth workflow is supported, such as Salesforce,
    /// Google Analytics, Marketo, Zendesk, and Slack.
    /// </summary>
    public partial class ConnectorOAuthRequest
    {
        /// <summary>
        /// Gets and sets the property AuthCode. 
        /// <para>
        ///  The code provided by the connector when it has been authenticated via the connected
        /// app. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Checks to see if the AuthCode property is set.
        /// </summary>
        internal bool IsSetAuthCode() => this.AuthCode != null;

        /// <summary>
        /// Gets and sets the property CodeVerifier. 
        /// <para>
        ///  The code verifier used in the PKCE (Proof Key for Code Exchange) OAuth flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 43, Max = 128)]
        public string CodeVerifier { get; set; }

        /// <summary>
        /// Checks to see if the CodeVerifier property is set.
        /// </summary>
        internal bool IsSetCodeVerifier() => this.CodeVerifier != null;

        /// <summary>
        /// Gets and sets the property RedirectUri. 
        /// <para>
        ///  The URL to which the authentication server redirects the browser after authorization
        /// has been granted. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUri property is set.
        /// </summary>
        internal bool IsSetRedirectUri() => this.RedirectUri != null;
    }
}
