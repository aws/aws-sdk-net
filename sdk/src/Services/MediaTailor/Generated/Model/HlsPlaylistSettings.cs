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
    /// HLS playlist configuration parameters.
    /// </summary>
    public partial class HlsPlaylistSettings
    {
        private List<string> _adMarkupType = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _manifestWindowSeconds;

        /// <summary>
        /// Gets and sets the property AdMarkupType. 
        /// <para>
        /// Determines the type of SCTE 35 tags to use in ad markup. Specify <c>DATERANGE</c>
        /// to use <c>DATERANGE</c> tags (for live or VOD content). Specify <c>SCTE35_ENHANCED</c>
        /// to use <c>EXT-X-CUE-OUT</c> and <c>EXT-X-CUE-IN</c> tags (for VOD content only).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdMarkupType
        {
            get { return this._adMarkupType; }
            set { this._adMarkupType = value; }
        }

        // Check to see if AdMarkupType property is set
        internal bool IsSetAdMarkupType()
        {
            return this._adMarkupType != null && (this._adMarkupType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. 
        /// <para>
        /// The total duration (in seconds) of each manifest. Minimum value: <c>30</c> seconds.
        /// Maximum value: <c>3600</c> seconds.
        /// </para>
        /// </summary>
        public int? ManifestWindowSeconds
        {
            get { return this._manifestWindowSeconds; }
            set { this._manifestWindowSeconds = value; }
        }

        // Check to see if ManifestWindowSeconds property is set
        internal bool IsSetManifestWindowSeconds()
        {
            return this._manifestWindowSeconds.HasValue; 
        }

    }
}