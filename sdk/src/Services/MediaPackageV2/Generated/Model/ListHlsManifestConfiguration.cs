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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// List the HTTP live streaming (HLS) manifest configuration.
    /// </summary>
    public partial class ListHlsManifestConfiguration
    {
        private string _childManifestName;
        private string _manifestName;
        private string _url;

        /// <summary>
        /// Gets and sets the property ChildManifestName. 
        /// <para>
        /// A short string that's appended to the endpoint URL. The child manifest name creates
        /// a unique path to this endpoint. If you don't enter a value, MediaPackage uses the
        /// default child manifest name, index_1. The manifestName on the HLSManifest object overrides
        /// the manifestName you provided on the originEndpoint object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ChildManifestName
        {
            get { return this._childManifestName; }
            set { this._childManifestName = value; }
        }

        // Check to see if ChildManifestName property is set
        internal bool IsSetChildManifestName()
        {
            return this._childManifestName != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestName. 
        /// <para>
        /// A short short string that's appended to the endpoint URL. The manifest name creates
        /// a unique path to this endpoint. If you don't enter a value, MediaPackage uses the
        /// default manifest name, index. MediaPackage automatically inserts the format extension,
        /// such as .m3u8. You can't use the same manifest name if you use HLS manifest and low-latency
        /// HLS manifest. The manifestName on the HLSManifest object overrides the manifestName
        /// you provided on the originEndpoint object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ManifestName
        {
            get { return this._manifestName; }
            set { this._manifestName = value; }
        }

        // Check to see if ManifestName property is set
        internal bool IsSetManifestName()
        {
            return this._manifestName != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The egress domain URL for stream delivery from MediaPackage.
        /// </para>
        /// </summary>
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

    }
}