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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies a cross-origin access rule for an Amazon S3 bucket.
    /// </summary>
    public partial class CORSRule
    {
        private List<string> _allowedHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedMethods = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedOrigins = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _exposeHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private int? _maxAgeSeconds;

        /// <summary>
        /// Gets and sets the property AllowedHeaders. 
        /// <para>
        /// Headers that are specified in the <c>Access-Control-Request-Headers</c> header. These
        /// headers are allowed in a preflight OPTIONS request. In response to any preflight OPTIONS
        /// request, Amazon S3 returns any requested headers that are allowed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// An HTTP method that you allow the origin to execute. Valid values are <c>GET</c>,
        /// <c>PUT</c>, <c>HEAD</c>, <c>POST</c>, and <c>DELETE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// One or more origins you want customers to be able to access the bucket from.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// One or more headers in the response that you want customers to be able to access from
        /// their applications (for example, from a JavaScript <c>XMLHttpRequest</c> object).
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
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique identifier for the rule. The value cannot be longer than 255 characters.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MaxAgeSeconds. 
        /// <para>
        /// The time in seconds that your browser is to cache the preflight response for the specified
        /// resource.
        /// </para>
        /// </summary>
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