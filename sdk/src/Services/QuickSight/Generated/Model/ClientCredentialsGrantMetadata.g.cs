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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Configuration for OAuth 2.0 client credentials grant authentication, including client
    /// ID, client secret, token endpoint, and optional scopes.
    /// </summary>
    public partial class ClientCredentialsGrantMetadata
    {
        /// <summary>
        /// Gets and sets the property BaseEndpoint. 
        /// <para>
        /// The base endpoint URL for the external service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string BaseEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the BaseEndpoint property is set.
        /// </summary>
        internal bool IsSetBaseEndpoint() => this.BaseEndpoint != null;

        /// <summary>
        /// Gets and sets the property ClientCredentialsDetails. 
        /// <para>
        /// The detailed client credentials configuration including client ID, client secret,
        /// and token endpoint.
        /// </para>
        /// </summary>
        public ClientCredentialsDetails ClientCredentialsDetails { get; set; }

        /// <summary>
        /// Checks to see if the ClientCredentialsDetails property is set.
        /// </summary>
        internal bool IsSetClientCredentialsDetails() => this.ClientCredentialsDetails != null;

        /// <summary>
        /// Gets and sets the property ClientCredentialsSource. 
        /// <para>
        /// The source of the client credentials configuration.
        /// </para>
        /// </summary>
        public ClientCredentialsSource ClientCredentialsSource { get; set; }

        /// <summary>
        /// Checks to see if the ClientCredentialsSource property is set.
        /// </summary>
        internal bool IsSetClientCredentialsSource() => this.ClientCredentialsSource != null;
    }
}
