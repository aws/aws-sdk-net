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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Credentials for an OAuth 2.0 client-credentials grant used to authenticate an integration
    /// with its external system.
    /// </summary>
    public partial class OAuthClientCredential
    {
        /// <summary>
        /// Gets and sets the property ClientId. The OAuth 2.0 client identifier registered with
        /// the external system.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. The OAuth 2.0 client secret that pairs with
        /// the client identifier.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property ProviderId. The identifier of the OAuth provider that issued
        /// the client credentials.
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// Checks to see if the ProviderId property is set.
        /// </summary>
        internal bool IsSetProviderId() => this.ProviderId != null;
    }
}
