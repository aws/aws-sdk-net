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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the requirements for a route to match HTTP requests for
    /// a virtual router.
    /// </summary>
    public partial class HttpRouteMatch
    {
        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// The client request headers to match on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<HttpRouteHeader> Headers { get; set; } = AWSConfigs.InitializeCollections ? new List<HttpRouteHeader>() : null;

        /// <summary>
        /// Checks to see if the Headers property is set.
        /// </summary>
        internal bool IsSetHeaders() => this.Headers != null && (this.Headers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The client request method to match on. Specify only one.
        /// </para>
        /// </summary>
        public HttpMethod Method { get; set; }

        /// <summary>
        /// Checks to see if the Method property is set.
        /// </summary>
        internal bool IsSetMethod() => this.Method != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The client request path to match on.
        /// </para>
        /// </summary>
        public HttpPathMatch Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number to match on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Specifies the path to match requests with. This parameter must always start with <c>/</c>,
        /// which by itself matches all requests to the virtual service name. You can also match
        /// for path-based routing of requests. For example, if your virtual service name is <c>my-service.local</c>
        /// and you want the route to match requests to <c>my-service.local/metrics</c>, your
        /// prefix should be <c>/metrics</c>.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        /// The client request query parameters to match on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<HttpQueryParameter> QueryParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<HttpQueryParameter>() : null;

        /// <summary>
        /// Checks to see if the QueryParameters property is set.
        /// </summary>
        internal bool IsSetQueryParameters() => this.QueryParameters != null && (this.QueryParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scheme. 
        /// <para>
        /// The client request scheme to match on. Specify only one. Applicable only for HTTP2
        /// routes.
        /// </para>
        /// </summary>
        public HttpScheme Scheme { get; set; }

        /// <summary>
        /// Checks to see if the Scheme property is set.
        /// </summary>
        internal bool IsSetScheme() => this.Scheme != null;
    }
}
