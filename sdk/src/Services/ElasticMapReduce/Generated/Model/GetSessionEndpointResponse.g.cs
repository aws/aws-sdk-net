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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the GetSessionEndpoint operation.
    /// </summary>
    public partial class GetSessionEndpointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// A time-limited authentication token used to connect to the Spark Connect endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthToken property is set.
        /// </summary>
        internal bool IsSetAuthToken() => this.AuthToken != null;

        /// <summary>
        /// Gets and sets the property AuthTokenExpirationTime. 
        /// <para>
        /// The time at which the authentication token expires. After this time, call <c>GetSessionEndpoint</c>
        /// again to obtain a new token.
        /// </para>
        /// </summary>
        public DateTime? AuthTokenExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the AuthTokenExpirationTime property is set.
        /// </summary>
        internal bool IsSetAuthTokenExpirationTime() => this.AuthTokenExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// Username and password used to authenticate with the Spark Connect server when connecting
        /// directly over VPC peering.
        /// </para>
        /// </summary>
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The Spark Connect endpoint URL to use in the PySpark client.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10280)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;
    }
}
