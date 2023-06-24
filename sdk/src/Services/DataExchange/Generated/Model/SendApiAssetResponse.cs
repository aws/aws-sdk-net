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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// This is the response object from the SendApiAsset operation.
    /// </summary>
    public partial class SendApiAssetResponse : AmazonWebServiceResponse
    {
        private string _body;
        private Dictionary<string, string> _responseHeaders = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The response body from the underlying API tracked by the API asset.
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
        /// Gets and sets the property ResponseHeaders. 
        /// <para>
        /// The response headers from the underlying API tracked by the API asset.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ResponseHeaders
        {
            get { return this._responseHeaders; }
            set { this._responseHeaders = value; }
        }

        // Check to see if ResponseHeaders property is set
        internal bool IsSetResponseHeaders()
        {
            return this._responseHeaders != null && this._responseHeaders.Count > 0; 
        }

    }
}