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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// HTTP request configuration parameters that define how MediaTailor communicates with
    /// the ad decision server.
    /// </summary>
    public partial class HttpRequest
    {
        private string _body;
        private CompressionMethod _compressRequest;
        private Dictionary<string, string> _headers = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Method _method;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The request body content to send with HTTP requests to the ad decision server. This
        /// value is only eligible for <c>POST</c> requests.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CompressRequest. 
        /// <para>
        /// The compression method to apply to requests sent to the ad decision server. Supported
        /// values are <c>NONE</c> and <c>GZIP</c>. This value is only eligible for <c>POST</c>
        /// requests.
        /// </para>
        /// </summary>
        public CompressionMethod CompressRequest
        {
            get { return this._compressRequest; }
            set { this._compressRequest = value; }
        }

        // Check to see if CompressRequest property is set
        internal bool IsSetCompressRequest()
        {
            return this._compressRequest != null;
        }

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// Custom HTTP headers to include in requests to the ad decision server. Specify headers
        /// as key-value pairs. This value is only eligible for <c>POST</c> requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && (this._headers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The HTTP method to use when making requests to the ad decision server. Supported values
        /// are <c>GET</c> and <c>POST</c>.
        /// </para>
        /// </summary>
        public Method Method
        {
            get { return this._method; }
            set { this._method = value; }
        }

        // Check to see if Method property is set
        internal bool IsSetMethod()
        {
            return this._method != null;
        }

    }
}