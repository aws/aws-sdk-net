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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// This is the response object from the GetSessionEndpoint operation.
    /// </summary>
    public partial class GetSessionEndpointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// Authentication token for the connection
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthToken property is set.
        /// </summary>
        internal bool IsSetAuthToken() => this.AuthToken != null;

        /// <summary>
        /// Gets and sets the property AuthTokenExpirationTime. 
        /// <para>
        /// Expiration time of the auth token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AuthTokenExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the AuthTokenExpirationTime property is set.
        /// </summary>
        internal bool IsSetAuthTokenExpirationTime() => this.AuthTokenExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointUrl. 
        /// <para>
        /// The endpoint for connecting to the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Checks to see if the EndpointUrl property is set.
        /// </summary>
        internal bool IsSetEndpointUrl() => this.EndpointUrl != null;
    }
}
