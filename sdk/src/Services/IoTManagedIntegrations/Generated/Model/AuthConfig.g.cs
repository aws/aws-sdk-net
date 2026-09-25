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
    /// The authentication configuration details for a connector destination, including OAuth
    /// settings and other authentication parameters.
    /// </summary>
    public partial class AuthConfig
    {
        /// <summary>
        /// Gets and sets the property GeneralAuthorization. 
        /// <para>
        /// The authorization materials for General Authorization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3)]
        public List<AuthMaterial> GeneralAuthorization { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthMaterial>() : null;

        /// <summary>
        /// Checks to see if the GeneralAuthorization property is set.
        /// </summary>
        internal bool IsSetGeneralAuthorization() => this.GeneralAuthorization != null && (this.GeneralAuthorization.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OAuth. 
        /// <para>
        /// The OAuth configuration settings used for authentication with the third-party service.
        /// </para>
        /// </summary>
        public OAuthConfig OAuth { get; set; }

        /// <summary>
        /// Checks to see if the OAuth property is set.
        /// </summary>
        internal bool IsSetOAuth() => this.OAuth != null;
    }
}
