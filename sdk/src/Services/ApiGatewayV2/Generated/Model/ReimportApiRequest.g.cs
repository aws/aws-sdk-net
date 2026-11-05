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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the ReimportApi operation. Puts an Api resource.
    /// </summary>
    public partial class ReimportApiRequest : AmazonApiGatewayV2Request
    {
        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property Basepath. 
        /// <para>
        /// Specifies how to interpret the base path of the API during import. Valid values are
        /// ignore, prepend, and split. The default value is ignore. To learn more, see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-import-api-basePath.html">Set
        /// the OpenAPI basePath Property</a>. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        public string Basepath { get; set; }

        /// <summary>
        /// Checks to see if the Basepath property is set.
        /// </summary>
        internal bool IsSetBasepath() => this.Basepath != null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The OpenAPI definition. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property FailOnWarnings. 
        /// <para>
        /// Specifies whether to rollback the API creation when a warning is encountered. By default,
        /// API creation continues if a warning is encountered.
        /// </para>
        /// </summary>
        public bool? FailOnWarnings { get; set; }

        /// <summary>
        /// Checks to see if the FailOnWarnings property is set.
        /// </summary>
        internal bool IsSetFailOnWarnings() => this.FailOnWarnings.HasValue;
    }
}
