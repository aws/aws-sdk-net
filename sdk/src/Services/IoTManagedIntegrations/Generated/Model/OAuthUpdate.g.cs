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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure containing updated OAuth configuration settings.
    /// </summary>
    public partial class OAuthUpdate
    {
        /// <summary>
        /// Gets and sets the property OAuthCompleteRedirectUrl. 
        /// <para>
        /// The updated URL where users are redirected after completing the OAuth authorization
        /// process.
        /// </para>
        /// </summary>
        public string OAuthCompleteRedirectUrl { get; set; }

        /// <summary>
        /// Checks to see if the OAuthCompleteRedirectUrl property is set.
        /// </summary>
        internal bool IsSetOAuthCompleteRedirectUrl() => this.OAuthCompleteRedirectUrl != null;

        /// <summary>
        /// Gets and sets the property ProactiveRefreshTokenRenewal. 
        /// <para>
        /// Updated configuration for proactively refreshing OAuth tokens before they expire.
        /// </para>
        /// </summary>
        public ProactiveRefreshTokenRenewal ProactiveRefreshTokenRenewal { get; set; }

        /// <summary>
        /// Checks to see if the ProactiveRefreshTokenRenewal property is set.
        /// </summary>
        internal bool IsSetProactiveRefreshTokenRenewal() => this.ProactiveRefreshTokenRenewal != null;
    }
}
