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
    /// The updated authentication configuration details for a connector destination.
    /// </summary>
    public partial class AuthConfigUpdate
    {
        /// <summary>
        /// Gets and sets the property GeneralAuthorizationUpdate. 
        /// <para>
        /// The General Authorization update information containing authorization materials to
        /// add or update.
        /// </para>
        /// </summary>
        public GeneralAuthorizationUpdate GeneralAuthorizationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the GeneralAuthorizationUpdate property is set.
        /// </summary>
        internal bool IsSetGeneralAuthorizationUpdate() => this.GeneralAuthorizationUpdate != null;

        /// <summary>
        /// Gets and sets the property OAuthUpdate. 
        /// <para>
        /// The updated OAuth configuration settings for the authentication configuration.
        /// </para>
        /// </summary>
        public OAuthUpdate OAuthUpdate { get; set; }

        /// <summary>
        /// Checks to see if the OAuthUpdate property is set.
        /// </summary>
        internal bool IsSetOAuthUpdate() => this.OAuthUpdate != null;
    }
}
