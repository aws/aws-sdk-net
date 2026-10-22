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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a cross-origin resource sharing (CORS) rule for a Lightsail bucket. CORS
    /// rules specify which origins are allowed to access the bucket, which HTTP methods are
    /// allowed, and other access control information. For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/configure-cors.html">Configuring
    /// cross-origin resource sharing (CORS)</a>.
    /// </summary>
    public partial class BucketCorsRule
    {
        /// <summary>
        /// Gets and sets the property AllowedHeaders. 
        /// <para>
        /// Headers that are specified in the <c>Access-Control-Request-Headers</c> header. These
        /// headers are allowed in a preflight <c>OPTIONS</c> request. In response to any preflight
        /// <c>OPTIONS</c> request, Amazon S3 returns any requested headers that are allowed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedHeaders property is set.
        /// </summary>
        internal bool IsSetAllowedHeaders() => this.AllowedHeaders != null && (this.AllowedHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedMethods. 
        /// <para>
        /// The HTTP methods that are allowed when accessing the bucket from the specified origin.
        /// Each CORS rule must identify at least one origin and one method.
        /// </para>
        ///  
        /// <para>
        /// You can use the following HTTP methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GET</c> - Retrieves data from the server, such as downloading files or viewing
        /// content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUT</c> - Uploads or replaces data on the server, such as uploading new files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>POST</c> - Sends data to the server for processing, such as submitting forms or
        /// creating new resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE</c> - Removes data from the server, such as deleting files or resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HEAD</c> - Retrieves only the headers from the server without the actual content,
        /// useful for checking if a resource exists.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AllowedMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedMethods property is set.
        /// </summary>
        internal bool IsSetAllowedMethods() => this.AllowedMethods != null && (this.AllowedMethods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedOrigins. 
        /// <para>
        /// One or more origins you want customers to be able to access the bucket from. Each
        /// CORS rule must identify at least one origin and one method.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AllowedOrigins { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedOrigins property is set.
        /// </summary>
        internal bool IsSetAllowedOrigins() => this.AllowedOrigins != null && (this.AllowedOrigins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExposeHeaders. 
        /// <para>
        /// One or more headers in the response that you want customers to be able to access from
        /// their applications (for example, from a JavaScript <c>XMLHttpRequest</c> object).
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
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the CORS rule. The ID value can be up to 255 characters long.
        /// The IDs help you find a rule in the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MaxAgeSeconds. 
        /// <para>
        /// The time in seconds that your browser is to cache the preflight response for the specified
        /// resource. A CORS rule can have only one <c>maxAgeSeconds</c> element.
        /// </para>
        /// </summary>
        public int? MaxAgeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxAgeSeconds property is set.
        /// </summary>
        internal bool IsSetMaxAgeSeconds() => this.MaxAgeSeconds.HasValue;
    }
}
