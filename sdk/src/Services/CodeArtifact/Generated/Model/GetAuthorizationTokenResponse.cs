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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
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
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// This is the response object from the GetAuthorizationToken operation.
    /// </summary>
    public partial class GetAuthorizationTokenResponse : AmazonWebServiceResponse
    {
        private string _authorizationToken;
        private DateTime? _expiration;

        /// <summary>
        /// Gets and sets the property AuthorizationToken. 
        /// <para>
        ///  The returned authentication token. 
        /// </para>
        /// </summary>
        public string AuthorizationToken
        {
            get { return this._authorizationToken; }
            set { this._authorizationToken = value; }
        }

        // Check to see if AuthorizationToken property is set
        internal bool IsSetAuthorizationToken()
        {
            return this._authorizationToken != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        ///  A timestamp that specifies the date and time the authorization token expires. 
        /// </para>
        /// </summary>
        public DateTime? Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration.HasValue; 
        }

    }
}