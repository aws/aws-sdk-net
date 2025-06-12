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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccessToken operation.
    /// Gets a temporary access token to use with AssumeRoleWithWebIdentity. Access tokens
    /// are valid for one hour.
    /// </summary>
    public partial class GetAccessTokenRequest : AmazonLicenseManagerRequest
    {
        private string _token;
        private List<string> _tokenProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// Refresh token, encoded as a JWT token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4096)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property TokenProperties. 
        /// <para>
        /// Token properties to validate against those present in the JWT token.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=3)]
        public List<string> TokenProperties
        {
            get { return this._tokenProperties; }
            set { this._tokenProperties = value; }
        }

        // Check to see if TokenProperties property is set
        internal bool IsSetTokenProperties()
        {
            return this._tokenProperties != null && (this._tokenProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}