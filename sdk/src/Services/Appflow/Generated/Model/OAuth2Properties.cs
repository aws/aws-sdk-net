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
    /// The OAuth 2.0 properties required for OAuth 2.0 authentication.
    /// </summary>
    public partial class OAuth2Properties
    {
        private OAuth2GrantType _oAuth2GrantType;
        private string _tokenUrl;
        private Dictionary<string, string> _tokenUrlCustomProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property OAuth2GrantType. 
        /// <para>
        /// The OAuth 2.0 grant type used by connector for OAuth 2.0 authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OAuth2GrantType OAuth2GrantType
        {
            get { return this._oAuth2GrantType; }
            set { this._oAuth2GrantType = value; }
        }

        // Check to see if OAuth2GrantType property is set
        internal bool IsSetOAuth2GrantType()
        {
            return this._oAuth2GrantType != null;
        }

        /// <summary>
        /// Gets and sets the property TokenUrl. 
        /// <para>
        /// The token URL required for OAuth 2.0 authentication.
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

        /// <summary>
        /// Gets and sets the property TokenUrlCustomProperties. 
        /// <para>
        /// Associates your token URL with a map of properties that you define. Use this parameter
        /// to provide any additional details that the connector requires to authenticate your
        /// request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> TokenUrlCustomProperties
        {
            get { return this._tokenUrlCustomProperties; }
            set { this._tokenUrlCustomProperties = value; }
        }

        // Check to see if TokenUrlCustomProperties property is set
        internal bool IsSetTokenUrlCustomProperties()
        {
            return this._tokenUrlCustomProperties != null && (this._tokenUrlCustomProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}