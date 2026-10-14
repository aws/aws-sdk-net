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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Contains the additional parameters to use for the connection.
    /// </summary>
    public partial class UpdateConnectionAuthRequestParameters
    {
        /// <summary>
        /// Gets and sets the property ApiKeyAuthParameters. 
        /// <para>
        /// The authorization parameters for API key authorization.
        /// </para>
        /// </summary>
        public UpdateConnectionApiKeyAuthRequestParameters ApiKeyAuthParameters { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeyAuthParameters property is set.
        /// </summary>
        internal bool IsSetApiKeyAuthParameters() => this.ApiKeyAuthParameters != null;

        /// <summary>
        /// Gets and sets the property BasicAuthParameters. 
        /// <para>
        /// The authorization parameters for Basic authorization.
        /// </para>
        /// </summary>
        public UpdateConnectionBasicAuthRequestParameters BasicAuthParameters { get; set; }

        /// <summary>
        /// Checks to see if the BasicAuthParameters property is set.
        /// </summary>
        internal bool IsSetBasicAuthParameters() => this.BasicAuthParameters != null;

        /// <summary>
        /// Gets and sets the property ConnectivityParameters. 
        /// <para>
        /// If you specify a private OAuth endpoint, the parameters for EventBridge to use when
        /// authenticating against the endpoint.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-target-connection-auth.html">Authorization
        /// methods for connections</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        /// </summary>
        public ConnectivityResourceParameters ConnectivityParameters { get; set; }

        /// <summary>
        /// Checks to see if the ConnectivityParameters property is set.
        /// </summary>
        internal bool IsSetConnectivityParameters() => this.ConnectivityParameters != null;

        /// <summary>
        /// Gets and sets the property InvocationHttpParameters. 
        /// <para>
        /// The additional parameters to use for the connection.
        /// </para>
        /// </summary>
        public ConnectionHttpParameters InvocationHttpParameters { get; set; }

        /// <summary>
        /// Checks to see if the InvocationHttpParameters property is set.
        /// </summary>
        internal bool IsSetInvocationHttpParameters() => this.InvocationHttpParameters != null;

        /// <summary>
        /// Gets and sets the property OAuthParameters. 
        /// <para>
        /// The authorization parameters for OAuth authorization.
        /// </para>
        /// </summary>
        public UpdateConnectionOAuthRequestParameters OAuthParameters { get; set; }

        /// <summary>
        /// Checks to see if the OAuthParameters property is set.
        /// </summary>
        internal bool IsSetOAuthParameters() => this.OAuthParameters != null;
    }
}
