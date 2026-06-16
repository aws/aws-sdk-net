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
    /// Container for the parameters to the UpdateOAuthClientApplication operation.
    /// Updates an OAuthClientApplication.
    /// </summary>
    public partial class UpdateOAuthClientApplicationRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _clientId;
        private string _clientSecret;
        private DataSourceType _dataSourceType;
        private VpcConnectionProperties _identityProviderVpcConnectionProperties;
        private string _name;
        private string _oAuthAuthorizationEndpointUrl;
        private string _oAuthClientApplicationId;
        private string _oAuthScopes;
        private string _oAuthTokenEndpointUrl;

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
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
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
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
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
        /// The ID of the OAuthClientApplication that you want to update.
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
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
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

    }
}