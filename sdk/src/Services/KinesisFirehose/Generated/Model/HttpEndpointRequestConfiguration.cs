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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The configuration of the HTTP endpoint request.
    /// </summary>
    public partial class HttpEndpointRequestConfiguration
    {
        private List<HttpEndpointCommonAttribute> _commonAttributes = new List<HttpEndpointCommonAttribute>();
        private ContentEncoding _contentEncoding;

        /// <summary>
        /// Gets and sets the property CommonAttributes. 
        /// <para>
        /// Describes the metadata sent to the HTTP endpoint destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<HttpEndpointCommonAttribute> CommonAttributes
        {
            get { return this._commonAttributes; }
            set { this._commonAttributes = value; }
        }

        // Check to see if CommonAttributes property is set
        internal bool IsSetCommonAttributes()
        {
            return this._commonAttributes != null && this._commonAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContentEncoding. 
        /// <para>
        /// Kinesis Data Firehose uses the content encoding to compress the body of a request
        /// before sending the request to the destination. For more information, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Encoding">Content-Encoding</a>
        /// in MDN Web Docs, the official Mozilla documentation.
        /// </para>
        /// </summary>
        public ContentEncoding ContentEncoding
        {
            get { return this._contentEncoding; }
            set { this._contentEncoding = value; }
        }

        // Check to see if ContentEncoding property is set
        internal bool IsSetContentEncoding()
        {
            return this._contentEncoding != null;
        }

    }
}