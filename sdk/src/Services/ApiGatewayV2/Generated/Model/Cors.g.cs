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
    /// Represents a CORS configuration. Supported only for HTTP APIs. See <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-cors.html">Configuring
    /// CORS</a> for more information.
    /// </summary>
    public partial class Cors
    {
        /// <summary>
        /// Gets and sets the property AllowCredentials. 
        /// <para>
        /// Specifies whether credentials are included in the CORS request. Supported only for
        /// HTTP APIs.
        /// </para>
        /// </summary>
        public bool? AllowCredentials { get; set; }

        /// <summary>
        /// Checks to see if the AllowCredentials property is set.
        /// </summary>
        internal bool IsSetAllowCredentials() => this.AllowCredentials.HasValue;

        /// <summary>
        /// Gets and sets the property AllowHeaders. 
        /// <para>
        /// Represents a collection of allowed headers. Supported only for HTTP APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowHeaders property is set.
        /// </summary>
        internal bool IsSetAllowHeaders() => this.AllowHeaders != null && (this.AllowHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowMethods. 
        /// <para>
        /// Represents a collection of allowed HTTP methods. Supported only for HTTP APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowMethods property is set.
        /// </summary>
        internal bool IsSetAllowMethods() => this.AllowMethods != null && (this.AllowMethods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowOrigins. 
        /// <para>
        /// Represents a collection of allowed origins. Supported only for HTTP APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowOrigins { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowOrigins property is set.
        /// </summary>
        internal bool IsSetAllowOrigins() => this.AllowOrigins != null && (this.AllowOrigins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExposeHeaders. 
        /// <para>
        /// Represents a collection of exposed headers. Supported only for HTTP APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExposeHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExposeHeaders property is set.
        /// </summary>
        internal bool IsSetExposeHeaders() => this.ExposeHeaders != null && (this.ExposeHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxAge. 
        /// <para>
        /// The number of seconds that the browser should cache preflight request results. Supported
        /// only for HTTP APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -1, Max = 86400)]
        public int? MaxAge { get; set; }

        /// <summary>
        /// Checks to see if the MaxAge property is set.
        /// </summary>
        internal bool IsSetMaxAge() => this.MaxAge.HasValue;
    }
}
