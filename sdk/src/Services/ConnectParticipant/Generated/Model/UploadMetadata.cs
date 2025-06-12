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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
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
namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Fields to be used while uploading the attachment.
    /// </summary>
    public partial class UploadMetadata
    {
        private Dictionary<string, string> _headersToInclude = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _url;
        private string _urlExpiry;

        /// <summary>
        /// Gets and sets the property HeadersToInclude. 
        /// <para>
        /// The headers to be provided while uploading the file to the URL.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> HeadersToInclude
        {
            get { return this._headersToInclude; }
            set { this._headersToInclude = value; }
        }

        // Check to see if HeadersToInclude property is set
        internal bool IsSetHeadersToInclude()
        {
            return this._headersToInclude != null && (this._headersToInclude.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// This is the pre-signed URL that can be used for uploading the file to Amazon S3 when
        /// used in response to <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_StartAttachmentUpload.html">StartAttachmentUpload</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// The expiration time of the URL in ISO timestamp. It's specified in ISO 8601 format:
        /// yyyy-MM-ddThh:mm:ss.SSSZ. For example, 2019-11-08T02:41:28.172Z.
        /// </para>
        /// </summary>
        public string UrlExpiry
        {
            get { return this._urlExpiry; }
            set { this._urlExpiry = value; }
        }

        // Check to see if UrlExpiry property is set
        internal bool IsSetUrlExpiry()
        {
            return this._urlExpiry != null;
        }

    }
}