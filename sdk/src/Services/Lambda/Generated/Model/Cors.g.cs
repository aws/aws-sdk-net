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
        /// <summary>
        /// Gets and sets the property AllowCredentials. 
        /// <para>
        /// Whether to allow cookies or other credentials in requests to your function URL. The
        /// default is <c>false</c>.
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
        /// The HTTP headers that origins can include in requests to your function URL. For example:
        /// <c>Date</c>, <c>Keep-Alive</c>, <c>X-Custom-Header</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> AllowHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowHeaders property is set.
        /// </summary>
        internal bool IsSetAllowHeaders() => this.AllowHeaders != null && (this.AllowHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowMethods. 
        /// <para>
        /// The HTTP methods that are allowed when calling your function URL. For example: <c>GET</c>,
        /// <c>POST</c>, <c>DELETE</c>, or the wildcard character (<c>*</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 6)]
        public List<string> AllowMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowMethods property is set.
        /// </summary>
        internal bool IsSetAllowMethods() => this.AllowMethods != null && (this.AllowMethods.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> AllowOrigins { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowOrigins property is set.
        /// </summary>
        internal bool IsSetAllowOrigins() => this.AllowOrigins != null && (this.AllowOrigins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExposeHeaders. 
        /// <para>
        /// The HTTP headers in your function response that you want to expose to origins that
        /// call your function URL. For example: <c>Date</c>, <c>Keep-Alive</c>, <c>X-Custom-Header</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> ExposeHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExposeHeaders property is set.
        /// </summary>
        internal bool IsSetExposeHeaders() => this.ExposeHeaders != null && (this.ExposeHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxAge. 
        /// <para>
        /// The maximum amount of time, in seconds, that web browsers can cache results of a preflight
        /// request. By default, this is set to <c>0</c>, which means that the browser doesn't
        /// cache results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 86400)]
        public int? MaxAge { get; set; }

        /// <summary>
        /// Checks to see if the MaxAge property is set.
        /// </summary>
        internal bool IsSetMaxAge() => this.MaxAge.HasValue;
    }
}
