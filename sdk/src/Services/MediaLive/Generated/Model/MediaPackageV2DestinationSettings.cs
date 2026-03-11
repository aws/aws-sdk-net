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
    /// Media Package V2 Destination Settings
    /// </summary>
    public partial class MediaPackageV2DestinationSettings
    {
        private string _audioGroupId;
        private string _audioRenditionSets;
        private HlsAutoSelect _hlsAutoSelect;
        private HlsDefault _hlsDefault;

        /// <summary>
        /// Gets and sets the property AudioGroupId. Applies only to an output that contains audio.
        /// If you want to put several audio encodes into one audio rendition group, decide on
        /// a name (ID) for the group. Then in every audio output that you want to belong to that
        /// group, enter that ID in this field. Note that this information is part of the HLS
        /// specification (not the CMAF specification), but if you include it then MediaPackage
        /// will include it in the manifest it creates for the video player.
        /// </summary>
        public string AudioGroupId
        {
            get { return this._audioGroupId; }
            set { this._audioGroupId = value; }
        }

        // Check to see if AudioGroupId property is set
        internal bool IsSetAudioGroupId()
        {
            return this._audioGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property AudioRenditionSets. Applies only to an output that contains
        /// video, and only if you want to associate one or more audio groups to this video. In
        /// this field you assign the groups that you create (in the Group ID fields in the various
        /// audio outputs). Enter one group ID, or enter a comma-separated list of group IDs.
        /// Note that this information is part of the HLS specification (not the CMAF specification),
        /// but if you include it then MediaPackage will include it in the manifest it creates
        /// for the video player.
        /// </summary>
        public string AudioRenditionSets
        {
            get { return this._audioRenditionSets; }
            set { this._audioRenditionSets = value; }
        }

        // Check to see if AudioRenditionSets property is set
        internal bool IsSetAudioRenditionSets()
        {
            return this._audioRenditionSets != null;
        }

        /// <summary>
        /// Gets and sets the property HlsAutoSelect. Specifies whether MediaPackage should set
        /// this output as the auto-select rendition in the HLS manifest. YES means this must
        /// be the auto-select. NO means this should never be the auto-select. OMIT means MediaPackage
        /// decides what to set on this rendition.When you consider all the renditions, follow
        /// these guidelines. You can set zero or one renditions to YES. You can set zero or more
        /// renditions to NO, but you can't set all renditions to NO. You can set zero, some,
        /// or all to OMIT.
        /// </summary>
        public HlsAutoSelect HlsAutoSelect
        {
            get { return this._hlsAutoSelect; }
            set { this._hlsAutoSelect = value; }
        }

        // Check to see if HlsAutoSelect property is set
        internal bool IsSetHlsAutoSelect()
        {
            return this._hlsAutoSelect != null;
        }

        /// <summary>
        /// Gets and sets the property HlsDefault. Specifies whether MediaPackage should set this
        /// output as the default rendition in the HLS manifest. YES means this must be the default.
        /// NO means this should never be the default. OMIT means MediaPackage decides what to
        /// set on this rendition.When you consider all the renditions, follow these guidelines.
        /// You can set zero or one renditions to YES. You can set zero or more renditions to
        /// NO, but you can't set all renditions to NO. You can set zero, some, or all to OMIT.
        /// </summary>
        public HlsDefault HlsDefault
        {
            get { return this._hlsDefault; }
            set { this._hlsDefault = value; }
        }

        // Check to see if HlsDefault property is set
        internal bool IsSetHlsDefault()
        {
            return this._hlsDefault != null;
        }

    }
}