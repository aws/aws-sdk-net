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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// The authentication configuration details for a connector destination, including OAuth
    /// settings and other authentication parameters.
    /// </summary>
    public partial class AuthConfig
    {
        private OAuthConfig _oAuth;

        /// <summary>
        /// Gets and sets the property OAuth. 
        /// <para>
        /// The OAuth configuration settings used for authentication with the third-party service.
        /// </para>
        /// </summary>
        public OAuthConfig OAuth
        {
            get { return this._oAuth; }
            set { this._oAuth = value; }
        }

        // Check to see if OAuth property is set
        internal bool IsSetOAuth()
        {
            return this._oAuth != null;
        }

    }
}