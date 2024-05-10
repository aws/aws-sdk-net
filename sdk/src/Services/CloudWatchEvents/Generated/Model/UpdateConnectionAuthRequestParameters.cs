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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
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
namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Contains the additional parameters to use for the connection.
    /// </summary>
    public partial class UpdateConnectionAuthRequestParameters
    {
        private UpdateConnectionApiKeyAuthRequestParameters _apiKeyAuthParameters;
        private UpdateConnectionBasicAuthRequestParameters _basicAuthParameters;
        private ConnectionHttpParameters _invocationHttpParameters;
        private UpdateConnectionOAuthRequestParameters _oAuthParameters;

        /// <summary>
        /// Gets and sets the property ApiKeyAuthParameters. 
        /// <para>
        /// A <c>UpdateConnectionApiKeyAuthRequestParameters</c> object that contains the authorization
        /// parameters for API key authorization.
        /// </para>
        /// </summary>
        public UpdateConnectionApiKeyAuthRequestParameters ApiKeyAuthParameters
        {
            get { return this._apiKeyAuthParameters; }
            set { this._apiKeyAuthParameters = value; }
        }

        // Check to see if ApiKeyAuthParameters property is set
        internal bool IsSetApiKeyAuthParameters()
        {
            return this._apiKeyAuthParameters != null;
        }

        /// <summary>
        /// Gets and sets the property BasicAuthParameters. 
        /// <para>
        /// A <c>UpdateConnectionBasicAuthRequestParameters</c> object that contains the authorization
        /// parameters for Basic authorization.
        /// </para>
        /// </summary>
        public UpdateConnectionBasicAuthRequestParameters BasicAuthParameters
        {
            get { return this._basicAuthParameters; }
            set { this._basicAuthParameters = value; }
        }

        // Check to see if BasicAuthParameters property is set
        internal bool IsSetBasicAuthParameters()
        {
            return this._basicAuthParameters != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationHttpParameters. 
        /// <para>
        /// A <c>ConnectionHttpParameters</c> object that contains the additional parameters to
        /// use for the connection.
        /// </para>
        /// </summary>
        public ConnectionHttpParameters InvocationHttpParameters
        {
            get { return this._invocationHttpParameters; }
            set { this._invocationHttpParameters = value; }
        }

        // Check to see if InvocationHttpParameters property is set
        internal bool IsSetInvocationHttpParameters()
        {
            return this._invocationHttpParameters != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthParameters. 
        /// <para>
        /// A <c>UpdateConnectionOAuthRequestParameters</c> object that contains the authorization
        /// parameters for OAuth authorization.
        /// </para>
        /// </summary>
        public UpdateConnectionOAuthRequestParameters OAuthParameters
        {
            get { return this._oAuthParameters; }
            set { this._oAuthParameters = value; }
        }

        // Check to see if OAuthParameters property is set
        internal bool IsSetOAuthParameters()
        {
            return this._oAuthParameters != null;
        }

    }
}