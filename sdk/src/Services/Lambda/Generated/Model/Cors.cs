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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS">cross-origin
    /// resource sharing (CORS)</a> settings for your Lambda function URL. Use CORS to grant
    /// access to your function URL from any origin. You can also use CORS to control access
    /// for specific HTTP headers and methods in requests to your function URL.
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
        /// Whether to allow cookies or other credentials in requests to your function URL. The
        /// default is <c>false</c>.
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
        /// The HTTP headers that origins can include in requests to your function URL. For example:
        /// <c>Date</c>, <c>Keep-Alive</c>, <c>X-Custom-Header</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// The HTTP methods that are allowed when calling your function URL. For example: <c>GET</c>,
        /// <c>POST</c>, <c>DELETE</c>, or the wildcard character (<c>*</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
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
        /// The origins that can access your function URL. You can list any number of specific
        /// origins, separated by a comma. For example: <c>https://www.example.com</c>, <c>http://localhost:60905</c>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can grant access to all origins using the wildcard character (<c>*</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// The HTTP headers in your function response that you want to expose to origins that
        /// call your function URL. For example: <c>Date</c>, <c>Keep-Alive</c>, <c>X-Custom-Header</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// The maximum amount of time, in seconds, that web browsers can cache results of a preflight
        /// request. By default, this is set to <c>0</c>, which means that the browser doesn't
        /// cache results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=86400)]
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