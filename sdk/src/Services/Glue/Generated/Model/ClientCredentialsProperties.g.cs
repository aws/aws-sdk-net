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
    /// OAuth2 client credentials configuration that defines the properties needed for the
    /// Client Credentials grant type flow.
    /// </summary>
    public partial class ClientCredentialsProperties
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OAuth2 client identifier provided by the authorization server.
        /// </para>
        /// </summary>
        public ConnectorProperty ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The OAuth2 client secret provided by the authorization server.
        /// </para>
        /// </summary>
        public ConnectorProperty ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type to use for token requests, such as application/x-www-form-urlencoded
        /// or application/json.
        /// </para>
        /// </summary>
        public ContentType ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property RequestMethod. 
        /// <para>
        /// The HTTP method to use when making token requests, typically POST.
        /// </para>
        /// </summary>
        public HTTPMethod RequestMethod { get; set; }

        /// <summary>
        /// Checks to see if the RequestMethod property is set.
        /// </summary>
        internal bool IsSetRequestMethod() => this.RequestMethod != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The OAuth2 scope that defines the level of access requested for the client credentials
        /// flow.
        /// </para>
        /// </summary>
        public ConnectorProperty Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property TokenUrl. 
        /// <para>
        /// The token endpoint URL where the client will request access tokens using client credentials.
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
