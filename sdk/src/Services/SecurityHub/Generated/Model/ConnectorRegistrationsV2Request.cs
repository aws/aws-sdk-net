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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// Container for the parameters to the ConnectorRegistrationsV2 operation.
    /// Grants permission to complete the authorization based on input parameters. This API
    /// is in preview release and subject to change.
    /// </summary>
    public partial class ConnectorRegistrationsV2Request : AmazonSecurityHubRequest
    {
        private string _authCode;
        private string _authState;

        /// <summary>
        /// Gets and sets the property AuthCode. 
        /// <para>
        /// The authCode retrieved from authUrl to complete the OAuth 2.0 authorization code flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AuthState. 
        /// <para>
        /// The authState retrieved from authUrl to complete the OAuth 2.0 authorization code
        /// flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AuthState
        {
            get { return this._authState; }
            set { this._authState = value; }
        }

        // Check to see if AuthState property is set
        internal bool IsSetAuthState()
        {
            return this._authState != null;
        }

    }
}