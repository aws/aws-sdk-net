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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// A Common Media Application Format (CMAF) packaging configuration.
    /// </summary>
    public partial class CmafPackage
    {
        private CmafEncryption _encryption;
        private List<HlsManifest> _hlsManifests = new List<HlsManifest>();
        private int? _segmentDurationSeconds;
        private string _segmentPrefix;
        private StreamSelection _streamSelection;

        /// <summary>
        /// Gets and sets the property Encryption.
        /// </summary>
        public CmafEncryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property HlsManifests. A list of HLS manifest configurations
        /// </summary>
        public List<HlsManifest> HlsManifests
        {
            get { return this._hlsManifests; }
            set { this._hlsManifests = value; }
        }

        // Check to see if HlsManifests property is set
        internal bool IsSetHlsManifests()
        {
            return this._hlsManifests != null && this._hlsManifests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SegmentDurationSeconds. Duration (in seconds) of each segment.
        /// Actual segments will berounded to the nearest multiple of the source segment duration.
        /// </summary>
        public int SegmentDurationSeconds
        {
            get { return this._segmentDurationSeconds.GetValueOrDefault(); }
            set { this._segmentDurationSeconds = value; }
        }

        // Check to see if SegmentDurationSeconds property is set
        internal bool IsSetSegmentDurationSeconds()
        {
            return this._segmentDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentPrefix. An optional custom string that is prepended
        /// to the name of each segment. If not specified, it defaults to the ChannelId.
        /// </summary>
        public string SegmentPrefix
        {
            get { return this._segmentPrefix; }
            set { this._segmentPrefix = value; }
        }

        // Check to see if SegmentPrefix property is set
        internal bool IsSetSegmentPrefix()
        {
            return this._segmentPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property StreamSelection.
        /// </summary>
        public StreamSelection StreamSelection
        {
            get { return this._streamSelection; }
            set { this._streamSelection = value; }
        }

        // Check to see if StreamSelection property is set
        internal bool IsSetStreamSelection()
        {
            return this._streamSelection != null;
        }

    }
}