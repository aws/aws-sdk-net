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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// Container for the parameters to the CreateOAuthClientApplication operation.
    /// Creates an OAuthClientApplication.
    /// </summary>
    public partial class CreateOAuthClientApplicationRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _clientId;
        private string _clientSecret;
        private DataSourceType _dataSourceType;
        private VpcConnectionProperties _identityProviderVpcConnectionProperties;
        private string _name;
        private string _oAuthAuthorizationEndpointUrl;
        private string _oAuthClientApplicationId;
        private OAuthClientAuthenticationType _oAuthClientAuthenticationType;
        private string _oAuthScopes;
        private string _oAuthTokenEndpointUrl;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID of the OAuth application that is registered with the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The client secret of the OAuth application that is registered with the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// The type of data source that the OAuthClientApplication is used with. Valid values
        /// are <c>SNOWFLAKE</c>.
        /// </para>
        /// </summary>
        public DataSourceType DataSourceType
        {
            get { return this._dataSourceType; }
            set { this._dataSourceType = value; }
        }

        // Check to see if DataSourceType property is set
        internal bool IsSetDataSourceType()
        {
            return this._dataSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderVpcConnectionProperties.
        /// </summary>
        public VpcConnectionProperties IdentityProviderVpcConnectionProperties
        {
            get { return this._identityProviderVpcConnectionProperties; }
            set { this._identityProviderVpcConnectionProperties = value; }
        }

        // Check to see if IdentityProviderVpcConnectionProperties property is set
        internal bool IsSetIdentityProviderVpcConnectionProperties()
        {
            return this._identityProviderVpcConnectionProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name for the OAuthClientApplication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthAuthorizationEndpointUrl. 
        /// <para>
        /// The authorization endpoint URL of the identity provider that is used to obtain authorization
        /// codes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string OAuthAuthorizationEndpointUrl
        {
            get { return this._oAuthAuthorizationEndpointUrl; }
            set { this._oAuthAuthorizationEndpointUrl = value; }
        }

        // Check to see if OAuthAuthorizationEndpointUrl property is set
        internal bool IsSetOAuthAuthorizationEndpointUrl()
        {
            return this._oAuthAuthorizationEndpointUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthClientApplicationId. 
        /// <para>
        /// An ID for the OAuthClientApplication that you want to create. This ID is unique per
        /// Amazon Web Services Region for each Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string OAuthClientApplicationId
        {
            get { return this._oAuthClientApplicationId; }
            set { this._oAuthClientApplicationId = value; }
        }

        // Check to see if OAuthClientApplicationId property is set
        internal bool IsSetOAuthClientApplicationId()
        {
            return this._oAuthClientApplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthClientAuthenticationType. 
        /// <para>
        /// The authentication type to use for the OAuthClientApplication. This determines the
        /// OAuth 2.0 grant flow that is used when the data source connects to the identity provider.
        /// Valid values are <c>TOKEN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OAuthClientAuthenticationType OAuthClientAuthenticationType
        {
            get { return this._oAuthClientAuthenticationType; }
            set { this._oAuthClientAuthenticationType = value; }
        }

        // Check to see if OAuthClientAuthenticationType property is set
        internal bool IsSetOAuthClientAuthenticationType()
        {
            return this._oAuthClientAuthenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthScopes. 
        /// <para>
        /// The OAuth scopes that are requested when the OAuthClientApplication obtains an access
        /// token from the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string OAuthScopes
        {
            get { return this._oAuthScopes; }
            set { this._oAuthScopes = value; }
        }

        // Check to see if OAuthScopes property is set
        internal bool IsSetOAuthScopes()
        {
            return this._oAuthScopes != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthTokenEndpointUrl. 
        /// <para>
        /// The token endpoint URL of the identity provider that is used to obtain access tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048)]
        public string OAuthTokenEndpointUrl
        {
            get { return this._oAuthTokenEndpointUrl; }
            set { this._oAuthTokenEndpointUrl = value; }
        }

        // Check to see if OAuthTokenEndpointUrl property is set
        internal bool IsSetOAuthTokenEndpointUrl()
        {
            return this._oAuthTokenEndpointUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// OAuthClientApplication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}