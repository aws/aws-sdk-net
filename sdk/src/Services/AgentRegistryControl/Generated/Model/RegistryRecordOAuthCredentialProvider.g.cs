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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// The configuration for an OAuth 2.0 credential provider that authenticates requests
    /// to a registry record's source.
    /// </summary>
    public partial class RegistryRecordOAuthCredentialProvider
    {
        /// <summary>
        /// Gets and sets the property CustomParameters. 
        /// <para>
        /// Additional parameters to include in the OAuth 2.0 token request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> CustomParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomParameters property is set.
        /// </summary>
        internal bool IsSetCustomParameters() => this.CustomParameters != null && (this.CustomParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// The OAuth 2.0 grant type used to obtain access tokens.
        /// </para>
        /// </summary>
        public RegistryRecordOAuthGrantType GrantType { get; set; }

        /// <summary>
        /// Checks to see if the GrantType property is set.
        /// </summary>
        internal bool IsSetGrantType() => this.GrantType != null;

        /// <summary>
        /// Gets and sets the property ProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OAuth 2.0 credential provider resource in Amazon
        /// Bedrock AgentCore Identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the ProviderArn property is set.
        /// </summary>
        internal bool IsSetProviderArn() => this.ProviderArn != null;

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth 2.0 scopes to request when obtaining access tokens.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Scopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null && (this.Scopes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
