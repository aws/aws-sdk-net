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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
        private string _authCode;
        private string _redirectUri;

        /// <summary>
        /// Gets and sets the property AuthCode. 
        /// <para>
        ///  The code provided by the connector when it has been authenticated via the connected
        /// app. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string AuthCode
        {
            get { return this._authCode; }
            set { this._authCode = value; }
        }

        // Check to see if AuthCode property is set
        internal bool IsSetAuthCode()
        {
            return this._authCode != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectUri. 
        /// <para>
        ///  The URL to which the authentication server redirects the browser after authorization
        /// has been granted. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string RedirectUri
        {
            get { return this._redirectUri; }
            set { this._redirectUri = value; }
        }

        // Check to see if RedirectUri property is set
        internal bool IsSetRedirectUri()
        {
            return this._redirectUri != null;
        }

    }
}