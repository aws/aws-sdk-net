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
    /// Container for the parameters to the CreateOAuthClientApplication operation. Creates
    /// an OAuthClientApplication.
    /// </summary>
    public partial class CreateOAuthClientApplicationRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID of the OAuth application that is registered with the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The client secret of the OAuth application that is registered with the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2048)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// The type of data source that the OAuthClientApplication is used with. Valid values
        /// are <c>SNOWFLAKE</c>.
        /// </para>
        /// </summary>
        public DataSourceType DataSourceType { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceType property is set.
        /// </summary>
        internal bool IsSetDataSourceType() => this.DataSourceType != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderVpcConnectionProperties.
        /// </summary>
        public VpcConnectionProperties IdentityProviderVpcConnectionProperties { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderVpcConnectionProperties property is set.
        /// </summary>
        internal bool IsSetIdentityProviderVpcConnectionProperties() => this.IdentityProviderVpcConnectionProperties != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name for the OAuthClientApplication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OAuthAuthorizationEndpointUrl. 
        /// <para>
        /// The authorization endpoint URL of the identity provider that is used to obtain authorization
        /// codes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string OAuthAuthorizationEndpointUrl { get; set; }

        /// <summary>
        /// Checks to see if the OAuthAuthorizationEndpointUrl property is set.
        /// </summary>
        internal bool IsSetOAuthAuthorizationEndpointUrl() => this.OAuthAuthorizationEndpointUrl != null;

        /// <summary>
        /// Gets and sets the property OAuthClientApplicationId. 
        /// <para>
        /// An ID for the OAuthClientApplication that you want to create. This ID is unique per
        /// Amazon Web Services Region for each Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OAuthClientApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the OAuthClientApplicationId property is set.
        /// </summary>
        internal bool IsSetOAuthClientApplicationId() => this.OAuthClientApplicationId != null;

        /// <summary>
        /// Gets and sets the property OAuthClientAuthenticationType. 
        /// <para>
        /// The authentication type to use for the OAuthClientApplication. This determines the
        /// OAuth 2.0 grant flow that is used when the data source connects to the identity provider.
        /// Valid values are <c>TOKEN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OAuthClientAuthenticationType OAuthClientAuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the OAuthClientAuthenticationType property is set.
        /// </summary>
        internal bool IsSetOAuthClientAuthenticationType() => this.OAuthClientAuthenticationType != null;

        /// <summary>
        /// Gets and sets the property OAuthScopes. 
        /// <para>
        /// The OAuth scopes that are requested when the OAuthClientApplication obtains an access
        /// token from the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string OAuthScopes { get; set; }

        /// <summary>
        /// Checks to see if the OAuthScopes property is set.
        /// </summary>
        internal bool IsSetOAuthScopes() => this.OAuthScopes != null;

        /// <summary>
        /// Gets and sets the property OAuthTokenEndpointUrl. 
        /// <para>
        /// The token endpoint URL of the identity provider that is used to obtain access tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2048)]
        public string OAuthTokenEndpointUrl { get; set; }

        /// <summary>
        /// Checks to see if the OAuthTokenEndpointUrl property is set.
        /// </summary>
        internal bool IsSetOAuthTokenEndpointUrl() => this.OAuthTokenEndpointUrl != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// OAuthClientApplication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
