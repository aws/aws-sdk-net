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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// This is the response object from the StartContentUpload operation.
    /// </summary>
    public partial class StartContentUploadResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _headersToInclude = new Dictionary<string, string>();
        private string _uploadId;
        private string _url;
        private DateTime? _urlExpiry;

        /// <summary>
        /// Gets and sets the property HeadersToInclude. 
        /// <para>
        /// The headers to include in the upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> HeadersToInclude
        {
            get { return this._headersToInclude; }
            set { this._headersToInclude = value; }
        }

        // Check to see if HeadersToInclude property is set
        internal bool IsSetHeadersToInclude()
        {
            return this._headersToInclude != null && this._headersToInclude.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The identifier of the upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1200)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property UrlExpiry. 
        /// <para>
        /// The expiration time of the URL as an epoch timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UrlExpiry
        {
            get { return this._urlExpiry.GetValueOrDefault(); }
            set { this._urlExpiry = value; }
        }

        // Check to see if UrlExpiry property is set
        internal bool IsSetUrlExpiry()
        {
            return this._urlExpiry.HasValue; 
        }

    }
}