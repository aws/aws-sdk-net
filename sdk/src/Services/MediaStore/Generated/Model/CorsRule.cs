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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// A rule for a CORS policy. You can add up to 100 rules to a CORS policy. If more than
    /// one rule applies, the service uses the first applicable rule listed.
    /// </summary>
    public partial class CorsRule
    {
        private List<string> _allowedHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedMethods = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedOrigins = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _exposeHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxAgeSeconds;

        /// <summary>
        /// Gets and sets the property AllowedHeaders. 
        /// <para>
        /// Specifies which headers are allowed in a preflight <c>OPTIONS</c> request through
        /// the <c>Access-Control-Request-Headers</c> header. Each header name that is specified
        /// in <c>Access-Control-Request-Headers</c> must have a corresponding entry in the rule.
        /// Only the headers that were requested are sent back. 
        /// </para>
        ///  
        /// <para>
        /// This element can contain only one wildcard character (*).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> AllowedHeaders
        {
            get { return this._allowedHeaders; }
            set { this._allowedHeaders = value; }
        }

        // Check to see if AllowedHeaders property is set
        internal bool IsSetAllowedHeaders()
        {
            return this._allowedHeaders != null && (this._allowedHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedMethods. 
        /// <para>
        /// Identifies an HTTP method that the origin that is specified in the rule is allowed
        /// to execute.
        /// </para>
        ///  
        /// <para>
        /// Each CORS rule must contain at least one <c>AllowedMethods</c> and one <c>AllowedOrigins</c>
        /// element.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> AllowedMethods
        {
            get { return this._allowedMethods; }
            set { this._allowedMethods = value; }
        }

        // Check to see if AllowedMethods property is set
        internal bool IsSetAllowedMethods()
        {
            return this._allowedMethods != null && (this._allowedMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedOrigins. 
        /// <para>
        /// One or more response headers that you want users to be able to access from their applications
        /// (for example, from a JavaScript <c>XMLHttpRequest</c> object).
        /// </para>
        ///  
        /// <para>
        /// Each CORS rule must have at least one <c>AllowedOrigins</c> element. The string value
        /// can include only one wildcard character (*), for example, http://*.example.com. Additionally,
        /// you can specify only one wildcard character to allow cross-origin access for all origins.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> AllowedOrigins
        {
            get { return this._allowedOrigins; }
            set { this._allowedOrigins = value; }
        }

        // Check to see if AllowedOrigins property is set
        internal bool IsSetAllowedOrigins()
        {
            return this._allowedOrigins != null && (this._allowedOrigins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExposeHeaders. 
        /// <para>
        /// One or more headers in the response that you want users to be able to access from
        /// their applications (for example, from a JavaScript <c>XMLHttpRequest</c> object).
        /// </para>
        ///  
        /// <para>
        /// This element is optional for each rule.
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
        /// Gets and sets the property MaxAgeSeconds. 
        /// <para>
        /// The time in seconds that your browser caches the preflight response for the specified
        /// resource.
        /// </para>
        ///  
        /// <para>
        /// A CORS rule can have only one <c>MaxAgeSeconds</c> element.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxAgeSeconds
        {
            get { return this._maxAgeSeconds; }
            set { this._maxAgeSeconds = value; }
        }

        // Check to see if MaxAgeSeconds property is set
        internal bool IsSetMaxAgeSeconds()
        {
            return this._maxAgeSeconds.HasValue; 
        }

    }
}