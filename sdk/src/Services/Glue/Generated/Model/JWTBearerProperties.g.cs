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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// JWT bearer token configuration that defines the properties needed for the JWT Bearer
    /// grant type flow.
    /// </summary>
    public partial class JWTBearerProperties
    {
        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type to use for JWT bearer token requests, such as application/x-www-form-urlencoded
        /// or application/json.
        /// </para>
        /// </summary>
        public ContentType ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property JwtToken. 
        /// <para>
        /// The JWT token to be used in the bearer token grant flow for authentication.
        /// </para>
        /// </summary>
        public ConnectorProperty JwtToken { get; set; }

        /// <summary>
        /// Checks to see if the JwtToken property is set.
        /// </summary>
        internal bool IsSetJwtToken() => this.JwtToken != null;

        /// <summary>
        /// Gets and sets the property RequestMethod. 
        /// <para>
        /// The HTTP method to use when making JWT bearer token requests, typically POST.
        /// </para>
        /// </summary>
        public HTTPMethod RequestMethod { get; set; }

        /// <summary>
        /// Checks to see if the RequestMethod property is set.
        /// </summary>
        internal bool IsSetRequestMethod() => this.RequestMethod != null;

        /// <summary>
        /// Gets and sets the property TokenUrl. 
        /// <para>
        /// The token endpoint URL where the JWT bearer token will be exchanged for an access
        /// token.
        /// </para>
        /// </summary>
        public ConnectorProperty TokenUrl { get; set; }

        /// <summary>
        /// Checks to see if the TokenUrl property is set.
        /// </summary>
        internal bool IsSetTokenUrl() => this.TokenUrl != null;

        /// <summary>
        /// Gets and sets the property TokenUrlParameters. 
        /// <para>
        /// Additional parameters to include in token URL requests as key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorProperty> TokenUrlParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectorProperty>() : null;

        /// <summary>
        /// Checks to see if the TokenUrlParameters property is set.
        /// </summary>
        internal bool IsSetTokenUrlParameters() => this.TokenUrlParameters != null && (this.TokenUrlParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
