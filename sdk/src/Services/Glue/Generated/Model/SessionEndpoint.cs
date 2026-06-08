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
    /// Contains the Spark Connect endpoint details for an interactive session, including
    /// the URL and authentication credentials.
    /// </summary>
    public partial class SessionEndpoint
    {
        private string _authToken;
        private DateTime? _authTokenExpirationTime;
        private string _url;

        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// The authentication token to include in requests to the Spark Connect endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=16384)]
        public string AuthToken
        {
            get { return this._authToken; }
            set { this._authToken = value; }
        }

        // Check to see if AuthToken property is set
        internal bool IsSetAuthToken()
        {
            return this._authToken != null;
        }

        /// <summary>
        /// Gets and sets the property AuthTokenExpirationTime. 
        /// <para>
        /// The time at which the authentication token expires.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AuthTokenExpirationTime
        {
            get { return this._authTokenExpirationTime; }
            set { this._authTokenExpirationTime = value; }
        }

        // Check to see if AuthTokenExpirationTime property is set
        internal bool IsSetAuthTokenExpirationTime()
        {
            return this._authTokenExpirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The Spark Connect endpoint URL for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}