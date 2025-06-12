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
    /// Represents a CORS configuration. Supported only for HTTP APIs. See <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-cors.html">Configuring
    /// CORS</a> for more information.
    /// </summary>
    public partial class Cors
    {
        private bool? _allowCredentials;
        private List<string> _allowHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowMethods = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowOrigins = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _exposeHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxAge;

        /// <summary>
        /// Gets and sets the property AllowCredentials. 
        /// <para>
        /// Specifies whether credentials are included in the CORS request. Supported only for
        /// HTTP APIs.
        /// </para>
        /// </summary>
        public bool? AllowCredentials
        {
            get { return this._allowCredentials; }
            set { this._allowCredentials = value; }
        }

        // Check to see if AllowCredentials property is set
        internal bool IsSetAllowCredentials()
        {
            return this._allowCredentials.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowHeaders. 
        /// <para>
        /// Represents a collection of allowed headers. Supported only for HTTP APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowHeaders
        {
            get { return this._allowHeaders; }
            set { this._allowHeaders = value; }
        }

        // Check to see if AllowHeaders property is set
        internal bool IsSetAllowHeaders()
        {
            return this._allowHeaders != null && (this._allowHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowMethods. 
        /// <para>
        /// Represents a collection of allowed HTTP methods. Supported only for HTTP APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowMethods
        {
            get { return this._allowMethods; }
            set { this._allowMethods = value; }
        }

        // Check to see if AllowMethods property is set
        internal bool IsSetAllowMethods()
        {
            return this._allowMethods != null && (this._allowMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowOrigins. 
        /// <para>
        /// Represents a collection of allowed origins. Supported only for HTTP APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowOrigins
        {
            get { return this._allowOrigins; }
            set { this._allowOrigins = value; }
        }

        // Check to see if AllowOrigins property is set
        internal bool IsSetAllowOrigins()
        {
            return this._allowOrigins != null && (this._allowOrigins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExposeHeaders. 
        /// <para>
        /// Represents a collection of exposed headers. Supported only for HTTP APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExposeHeaders
        {
            get { return this._exposeHeaders; }
            set { this._exposeHeaders = value; }
        }

        // Check to see if ExposeHeaders property is set
        internal bool IsSetExposeHeaders()
        {
            return this._exposeHeaders != null && (this._exposeHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxAge. 
        /// <para>
        /// The number of seconds that the browser should cache preflight request results. Supported
        /// only for HTTP APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=86400)]
        public int? MaxAge
        {
            get { return this._maxAge; }
            set { this._maxAge = value; }
        }

        // Check to see if MaxAge property is set
        internal bool IsSetMaxAge()
        {
            return this._maxAge.HasValue; 
        }

    }
}