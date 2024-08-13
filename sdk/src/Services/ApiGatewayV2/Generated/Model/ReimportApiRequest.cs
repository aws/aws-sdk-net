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
    /// Container for the parameters to the ReimportApi operation.
    /// Puts an Api resource.
    /// </summary>
    public partial class ReimportApiRequest : AmazonApiGatewayV2Request
    {
        private string _apiId;
        private string _basepath;
        private string _body;
        private bool? _failOnWarnings;

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
        /// Gets and sets the property Basepath. 
        /// <para>
        /// Specifies how to interpret the base path of the API during import. Valid values are
        /// ignore, prepend, and split. The default value is ignore. To learn more, see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-import-api-basePath.html">Set
        /// the OpenAPI basePath Property</a>. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        public string Basepath
        {
            get { return this._basepath; }
            set { this._basepath = value; }
        }

        // Check to see if Basepath property is set
        internal bool IsSetBasepath()
        {
            return this._basepath != null;
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The OpenAPI definition. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property FailOnWarnings. 
        /// <para>
        /// Specifies whether to rollback the API creation when a warning is encountered. By default,
        /// API creation continues if a warning is encountered.
        /// </para>
        /// </summary>
        public bool? FailOnWarnings
        {
            get { return this._failOnWarnings; }
            set { this._failOnWarnings = value; }
        }

        // Check to see if FailOnWarnings property is set
        internal bool IsSetFailOnWarnings()
        {
            return this._failOnWarnings.HasValue; 
        }

    }
}