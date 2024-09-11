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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Network source to transcode. Must be accessible to the Elemental Live node that is
    /// running the live event through a network connection.
    /// </summary>
    public partial class NetworkInputSettings
    {
        private HlsInputSettings _hlsInputSettings;
        private MulticastInputSettings _multicastInputSettings;
        private NetworkInputServerValidation _serverValidation;

        /// <summary>
        /// Gets and sets the property HlsInputSettings. Specifies HLS input settings when the
        /// uri is for a HLS manifest.
        /// </summary>
        public HlsInputSettings HlsInputSettings
        {
            get { return this._hlsInputSettings; }
            set { this._hlsInputSettings = value; }
        }

        // Check to see if HlsInputSettings property is set
        internal bool IsSetHlsInputSettings()
        {
            return this._hlsInputSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MulticastInputSettings. Specifies multicast input settings
        /// when the uri is for a multicast event.
        /// </summary>
        public MulticastInputSettings MulticastInputSettings
        {
            get { return this._multicastInputSettings; }
            set { this._multicastInputSettings = value; }
        }

        // Check to see if MulticastInputSettings property is set
        internal bool IsSetMulticastInputSettings()
        {
            return this._multicastInputSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ServerValidation. Check HTTPS server certificates. When
        /// set to checkCryptographyOnly, cryptography in the certificate will be checked, but
        /// not the server's name. Certain subdomains (notably S3 buckets that use dots in the
        /// bucket name) do not strictly match the corresponding certificate's wildcard pattern
        /// and would otherwise cause the event to error. This setting is ignored for protocols
        /// that do not use https.
        /// </summary>
        public NetworkInputServerValidation ServerValidation
        {
            get { return this._serverValidation; }
            set { this._serverValidation = value; }
        }

        // Check to see if ServerValidation property is set
        internal bool IsSetServerValidation()
        {
            return this._serverValidation != null;
        }

    }
}