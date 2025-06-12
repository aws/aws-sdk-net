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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector metadata specific to Salesforce.
    /// </summary>
    public partial class SalesforceMetadata
    {
        private List<string> _dataTransferApis = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _oauth2GrantTypesSupported = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _oAuthScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DataTransferApis. 
        /// <para>
        /// The Salesforce APIs that you can have Amazon AppFlow use when your flows transfers
        /// data to or from Salesforce.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DataTransferApis
        {
            get { return this._dataTransferApis; }
            set { this._dataTransferApis = value; }
        }

        // Check to see if DataTransferApis property is set
        internal bool IsSetDataTransferApis()
        {
            return this._dataTransferApis != null && (this._dataTransferApis.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Oauth2GrantTypesSupported. 
        /// <para>
        /// The OAuth 2.0 grant types that Amazon AppFlow can use when it requests an access token
        /// from Salesforce. Amazon AppFlow requires an access token each time it attempts to
        /// access your Salesforce records.
        /// </para>
        ///  <dl> <dt>AUTHORIZATION_CODE</dt> <dd> 
        /// <para>
        /// Amazon AppFlow passes an authorization code when it requests the access token from
        /// Salesforce. Amazon AppFlow receives the authorization code from Salesforce after you
        /// log in to your Salesforce account and authorize Amazon AppFlow to access your records.
        /// </para>
        ///  </dd> <dt>JWT_BEARER</dt> <dd> 
        /// <para>
        /// Amazon AppFlow passes a JSON web token (JWT) when it requests the access token from
        /// Salesforce. You provide the JWT to Amazon AppFlow when you define the connection to
        /// your Salesforce account. When you use this grant type, you don't need to log in to
        /// your Salesforce account to authorize Amazon AppFlow to access your records.
        /// </para>
        ///  </dd> </dl> <note> 
        /// <para>
        /// The CLIENT_CREDENTIALS value is not supported for Salesforce.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Oauth2GrantTypesSupported
        {
            get { return this._oauth2GrantTypesSupported; }
            set { this._oauth2GrantTypesSupported = value; }
        }

        // Check to see if Oauth2GrantTypesSupported property is set
        internal bool IsSetOauth2GrantTypesSupported()
        {
            return this._oauth2GrantTypesSupported != null && (this._oauth2GrantTypesSupported.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OAuthScopes. 
        /// <para>
        ///  The desired authorization scope for the Salesforce account. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OAuthScopes
        {
            get { return this._oAuthScopes; }
            set { this._oAuthScopes = value; }
        }

        // Check to see if OAuthScopes property is set
        internal bool IsSetOAuthScopes()
        {
            return this._oAuthScopes != null && (this._oAuthScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}