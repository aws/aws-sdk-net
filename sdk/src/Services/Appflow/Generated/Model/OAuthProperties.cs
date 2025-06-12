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
    /// The OAuth properties required for OAuth type authentication.
    /// </summary>
    public partial class OAuthProperties
    {
        private string _authCodeUrl;
        private List<string> _oAuthScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tokenUrl;

        /// <summary>
        /// Gets and sets the property AuthCodeUrl. 
        /// <para>
        ///  The authorization code url required to redirect to SAP Login Page to fetch authorization
        /// code for OAuth type authentication. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string AuthCodeUrl
        {
            get { return this._authCodeUrl; }
            set { this._authCodeUrl = value; }
        }

        // Check to see if AuthCodeUrl property is set
        internal bool IsSetAuthCodeUrl()
        {
            return this._authCodeUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthScopes. 
        /// <para>
        ///  The OAuth scopes required for OAuth type authentication. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property TokenUrl. 
        /// <para>
        ///  The token url required to fetch access/refresh tokens using authorization code and
        /// also to refresh expired access token using refresh token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string TokenUrl
        {
            get { return this._tokenUrl; }
            set { this._tokenUrl = value; }
        }

        // Check to see if TokenUrl property is set
        internal bool IsSetTokenUrl()
        {
            return this._tokenUrl != null;
        }

    }
}