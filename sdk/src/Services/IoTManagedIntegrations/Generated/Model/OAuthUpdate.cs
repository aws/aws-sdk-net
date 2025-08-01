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
    /// Structure containing updated OAuth configuration settings.
    /// </summary>
    public partial class OAuthUpdate
    {
        private string _oAuthCompleteRedirectUrl;
        private ProactiveRefreshTokenRenewal _proactiveRefreshTokenRenewal;

        /// <summary>
        /// Gets and sets the property OAuthCompleteRedirectUrl. 
        /// <para>
        /// The updated URL where users are redirected after completing the OAuth authorization
        /// process.
        /// </para>
        /// </summary>
        public string OAuthCompleteRedirectUrl
        {
            get { return this._oAuthCompleteRedirectUrl; }
            set { this._oAuthCompleteRedirectUrl = value; }
        }

        // Check to see if OAuthCompleteRedirectUrl property is set
        internal bool IsSetOAuthCompleteRedirectUrl()
        {
            return this._oAuthCompleteRedirectUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ProactiveRefreshTokenRenewal. 
        /// <para>
        /// Updated configuration for proactively refreshing OAuth tokens before they expire.
        /// </para>
        /// </summary>
        public ProactiveRefreshTokenRenewal ProactiveRefreshTokenRenewal
        {
            get { return this._proactiveRefreshTokenRenewal; }
            set { this._proactiveRefreshTokenRenewal = value; }
        }

        // Check to see if ProactiveRefreshTokenRenewal property is set
        internal bool IsSetProactiveRefreshTokenRenewal()
        {
            return this._proactiveRefreshTokenRenewal != null;
        }

    }
}