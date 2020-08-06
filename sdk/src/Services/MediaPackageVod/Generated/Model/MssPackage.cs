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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// A Microsoft Smooth Streaming (MSS) PackagingConfiguration.
    /// </summary>
    public partial class MssPackage
    {
        private MssEncryption _encryption;
        private List<MssManifest> _mssManifests = new List<MssManifest>();
        private int? _segmentDurationSeconds;

        /// <summary>
        /// Gets and sets the property Encryption.
        /// </summary>
        public MssEncryption Encryption
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
        /// Gets and sets the property MssManifests. A list of MSS manifest configurations.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MssManifest> MssManifests
        {
            get { return this._mssManifests; }
            set { this._mssManifests = value; }
        }

        // Check to see if MssManifests property is set
        internal bool IsSetMssManifests()
        {
            return this._mssManifests != null && this._mssManifests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SegmentDurationSeconds. The duration (in seconds) of each
        /// segment.
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

    }
}