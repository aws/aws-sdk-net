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
    /// Contains the Spark Connect endpoint details for an interactive session, including
    /// the URL and authentication credentials.
    /// </summary>
    public partial class SessionEndpoint
    {
        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// The authentication token to include in requests to the Spark Connect endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 16384)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthToken property is set.
        /// </summary>
        internal bool IsSetAuthToken() => this.AuthToken != null;

        /// <summary>
        /// Gets and sets the property AuthTokenExpirationTime. 
        /// <para>
        /// The time at which the authentication token expires.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AuthTokenExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the AuthTokenExpirationTime property is set.
        /// </summary>
        internal bool IsSetAuthTokenExpirationTime() => this.AuthTokenExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The Spark Connect endpoint URL for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
