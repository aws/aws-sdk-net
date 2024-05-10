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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRouteRequestParameter operation.
    /// Deletes a route request parameter. Supported only for WebSocket APIs.
    /// </summary>
    public partial class DeleteRouteRequestParameterRequest : AmazonApiGatewayV2Request
    {
        private string _apiId;
        private string _requestParameterKey;
        private string _routeId;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestParameterKey. 
        /// <para>
        /// The route request parameter key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RequestParameterKey
        {
            get { return this._requestParameterKey; }
            set { this._requestParameterKey = value; }
        }

        // Check to see if RequestParameterKey property is set
        internal bool IsSetRequestParameterKey()
        {
            return this._requestParameterKey != null;
        }

        /// <summary>
        /// Gets and sets the property RouteId. 
        /// <para>
        /// The route ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouteId
        {
            get { return this._routeId; }
            set { this._routeId = value; }
        }

        // Check to see if RouteId property is set
        internal bool IsSetRouteId()
        {
            return this._routeId != null;
        }

    }
}