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
    /// Read-only authentication metadata union containing non-sensitive configuration details
    /// for different authentication types.
    /// </summary>
    public partial class ReadAuthenticationMetadata
    {
        /// <summary>
        /// Gets and sets the property ApiKeyConnectionMetadata. 
        /// <para>
        /// Read-only metadata for API key authentication configuration.
        /// </para>
        /// </summary>
        public ReadAPIKeyConnectionMetadata ApiKeyConnectionMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeyConnectionMetadata property is set.
        /// </summary>
        internal bool IsSetApiKeyConnectionMetadata() => this.ApiKeyConnectionMetadata != null;

        /// <summary>
        /// Gets and sets the property AuthorizationCodeGrantMetadata. 
        /// <para>
        /// Read-only metadata for OAuth2 authorization code grant flow configuration.
        /// </para>
        /// </summary>
        public ReadAuthorizationCodeGrantMetadata AuthorizationCodeGrantMetadata { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationCodeGrantMetadata property is set.
        /// </summary>
        internal bool IsSetAuthorizationCodeGrantMetadata() => this.AuthorizationCodeGrantMetadata != null;

        /// <summary>
        /// Gets and sets the property BasicAuthConnectionMetadata. 
        /// <para>
        /// Read-only metadata for basic authentication configuration.
        /// </para>
        /// </summary>
        public ReadBasicAuthConnectionMetadata BasicAuthConnectionMetadata { get; set; }

        /// <summary>
        /// Checks to see if the BasicAuthConnectionMetadata property is set.
        /// </summary>
        internal bool IsSetBasicAuthConnectionMetadata() => this.BasicAuthConnectionMetadata != null;

        /// <summary>
        /// Gets and sets the property ClientCredentialsGrantMetadata. 
        /// <para>
        /// Read-only metadata for OAuth2 client credentials grant flow configuration.
        /// </para>
        /// </summary>
        public ReadClientCredentialsGrantMetadata ClientCredentialsGrantMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ClientCredentialsGrantMetadata property is set.
        /// </summary>
        internal bool IsSetClientCredentialsGrantMetadata() => this.ClientCredentialsGrantMetadata != null;

        /// <summary>
        /// Gets and sets the property IamConnectionMetadata. 
        /// <para>
        /// Read-only metadata for IAM-based authentication configuration.
        /// </para>
        /// </summary>
        public ReadIamConnectionMetadata IamConnectionMetadata { get; set; }

        /// <summary>
        /// Checks to see if the IamConnectionMetadata property is set.
        /// </summary>
        internal bool IsSetIamConnectionMetadata() => this.IamConnectionMetadata != null;

        /// <summary>
        /// Gets and sets the property NoneConnectionMetadata. 
        /// <para>
        /// Read-only metadata for connections that do not require authentication.
        /// </para>
        /// </summary>
        public ReadNoneConnectionMetadata NoneConnectionMetadata { get; set; }

        /// <summary>
        /// Checks to see if the NoneConnectionMetadata property is set.
        /// </summary>
        internal bool IsSetNoneConnectionMetadata() => this.NoneConnectionMetadata != null;
    }
}
