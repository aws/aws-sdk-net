/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// If your output group type is CMAF, use these settings when doing DRM encryption with
    /// a SPEKE-compliant key provider. If your output group type is HLS, DASH, or Microsoft
    /// Smooth, use the SpekeKeyProvider settings instead.
    /// </summary>
    public partial class SpekeKeyProviderCmaf
    {
        private string _certificateArn;
        private List<string> _dashSignaledSystemIds = new List<string>();
        private List<string> _hlsSignaledSystemIds = new List<string>();
        private string _resourceId;
        private string _url;

        /// <summary>
        /// Gets and sets the property CertificateArn. If you want your key provider to encrypt
        /// the content keys that it provides to MediaConvert, set up a certificate with a master
        /// key using AWS Certificate Manager. Specify the certificate's Amazon Resource Name
        /// (ARN) here.
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property DashSignaledSystemIds. Specify the DRM system IDs that
        /// you want signaled in the DASH manifest that MediaConvert creates as part of this CMAF
        /// package. The DASH manifest can currently signal up to three system IDs. For more information,
        /// see https://dashif.org/identifiers/content_protection/.
        /// </summary>
        public List<string> DashSignaledSystemIds
        {
            get { return this._dashSignaledSystemIds; }
            set { this._dashSignaledSystemIds = value; }
        }

        // Check to see if DashSignaledSystemIds property is set
        internal bool IsSetDashSignaledSystemIds()
        {
            return this._dashSignaledSystemIds != null && this._dashSignaledSystemIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HlsSignaledSystemIds. Specify the DRM system ID that you
        /// want signaled in the HLS manifest that MediaConvert creates as part of this CMAF package.
        /// The HLS manifest can currently signal only one system ID. For more information, see
        /// https://dashif.org/identifiers/content_protection/.
        /// </summary>
        public List<string> HlsSignaledSystemIds
        {
            get { return this._hlsSignaledSystemIds; }
            set { this._hlsSignaledSystemIds = value; }
        }

        // Check to see if HlsSignaledSystemIds property is set
        internal bool IsSetHlsSignaledSystemIds()
        {
            return this._hlsSignaledSystemIds != null && this._hlsSignaledSystemIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. Specify the resource ID that your SPEKE-compliant
        /// key provider uses to identify this content.
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Url. Specify the URL to the key server that your SPEKE-compliant
        /// DRM key provider uses to provide keys for encrypting your content.
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