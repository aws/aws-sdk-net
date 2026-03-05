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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// JWT bearer token configuration that defines the properties needed for the JWT Bearer
    /// grant type flow.
    /// </summary>
    public partial class JWTBearerProperties
    {
        private ContentType _contentType;
        private ConnectorProperty _jwtToken;
        private HTTPMethod _requestMethod;
        private ConnectorProperty _tokenUrl;
        private List<ConnectorProperty> _tokenUrlParameters = AWSConfigs.InitializeCollections ? new List<ConnectorProperty>() : null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type to use for JWT bearer token requests, such as application/x-www-form-urlencoded
        /// or application/json.
        /// </para>
        /// </summary>
        public ContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property JwtToken. 
        /// <para>
        /// The JWT token to be used in the bearer token grant flow for authentication.
        /// </para>
        /// </summary>
        public ConnectorProperty JwtToken
        {
            get { return this._jwtToken; }
            set { this._jwtToken = value; }
        }

        // Check to see if JwtToken property is set
        internal bool IsSetJwtToken()
        {
            return this._jwtToken != null;
        }

        /// <summary>
        /// Gets and sets the property RequestMethod. 
        /// <para>
        /// The HTTP method to use when making JWT bearer token requests, typically POST.
        /// </para>
        /// </summary>
        public HTTPMethod RequestMethod
        {
            get { return this._requestMethod; }
            set { this._requestMethod = value; }
        }

        // Check to see if RequestMethod property is set
        internal bool IsSetRequestMethod()
        {
            return this._requestMethod != null;
        }

        /// <summary>
        /// Gets and sets the property TokenUrl. 
        /// <para>
        /// The token endpoint URL where the JWT bearer token will be exchanged for an access
        /// token.
        /// </para>
        /// </summary>
        public ConnectorProperty TokenUrl
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
        /// Gets and sets the property TokenUrlParameters. 
        /// <para>
        /// Additional parameters to include in token URL requests as key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorProperty> TokenUrlParameters
        {
            get { return this._tokenUrlParameters; }
            set { this._tokenUrlParameters = value; }
        }

        // Check to see if TokenUrlParameters property is set
        internal bool IsSetTokenUrlParameters()
        {
            return this._tokenUrlParameters != null && (this._tokenUrlParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}