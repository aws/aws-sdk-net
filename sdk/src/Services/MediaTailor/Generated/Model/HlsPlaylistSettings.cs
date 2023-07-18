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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// HLS playlist configuration parameters.
    /// </summary>
    public partial class HlsPlaylistSettings
    {
        private List<string> _adMarkupType = new List<string>();
        private int? _manifestWindowSeconds;

        /// <summary>
        /// Gets and sets the property AdMarkupType. 
        /// <para>
        /// Determines the type of SCTE 35 tags to use in ad markup. Specify <code>DATERANGE</code>
        /// to use <code>DATERANGE</code> tags (for live or VOD content). Specify <code>SCTE35_ENHANCED</code>
        /// to use <code>EXT-X-CUE-OUT</code> and <code>EXT-X-CUE-IN</code> tags (for VOD content
        /// only).
        /// </para>
        /// </summary>
        public List<string> AdMarkupType
        {
            get { return this._adMarkupType; }
            set { this._adMarkupType = value; }
        }

        // Check to see if AdMarkupType property is set
        internal bool IsSetAdMarkupType()
        {
            return this._adMarkupType != null && this._adMarkupType.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. 
        /// <para>
        /// The total duration (in seconds) of each manifest. Minimum value: <code>30</code> seconds.
        /// Maximum value: <code>3600</code> seconds.
        /// </para>
        /// </summary>
        public int ManifestWindowSeconds
        {
            get { return this._manifestWindowSeconds.GetValueOrDefault(); }
            set { this._manifestWindowSeconds = value; }
        }

        // Check to see if ManifestWindowSeconds property is set
        internal bool IsSetManifestWindowSeconds()
        {
            return this._manifestWindowSeconds.HasValue; 
        }

    }
}