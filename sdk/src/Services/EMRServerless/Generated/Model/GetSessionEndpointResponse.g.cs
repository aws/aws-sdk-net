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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// This is the response object from the GetSessionEndpoint operation.
    /// </summary>
    public partial class GetSessionEndpointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The output contains the ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// The authentication token for connecting to the session endpoint. Call <c>GetSessionEndpoint</c>
        /// again to obtain a new token before it expires.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 8000)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthToken property is set.
        /// </summary>
        internal bool IsSetAuthToken() => this.AuthToken != null;

        /// <summary>
        /// Gets and sets the property AuthTokenExpiresAt. 
        /// <para>
        /// The expiration time of the authentication token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AuthTokenExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the AuthTokenExpiresAt property is set.
        /// </summary>
        internal bool IsSetAuthTokenExpiresAt() => this.AuthTokenExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint URL for connecting to the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The output contains the ID of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
