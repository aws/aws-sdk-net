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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// An array containing track mapping information.
    /// </summary>
    public partial class TrackMapping
    {
        private List<int> _audioTrackIndexes = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _dataTrackIndexes = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _videoTrackIndexes = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Gets and sets the property AudioTrackIndexes. The index numbers of the audio tracks
        /// in your media file.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> AudioTrackIndexes
        {
            get { return this._audioTrackIndexes; }
            set { this._audioTrackIndexes = value; }
        }

        // Check to see if AudioTrackIndexes property is set
        internal bool IsSetAudioTrackIndexes()
        {
            return this._audioTrackIndexes != null && (this._audioTrackIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataTrackIndexes. The index numbers of the data tracks
        /// in your media file.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> DataTrackIndexes
        {
            get { return this._dataTrackIndexes; }
            set { this._dataTrackIndexes = value; }
        }

        // Check to see if DataTrackIndexes property is set
        internal bool IsSetDataTrackIndexes()
        {
            return this._dataTrackIndexes != null && (this._dataTrackIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VideoTrackIndexes. The index numbers of the video tracks
        /// in your media file.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> VideoTrackIndexes
        {
            get { return this._videoTrackIndexes; }
            set { this._videoTrackIndexes = value; }
        }

        // Check to see if VideoTrackIndexes property is set
        internal bool IsSetVideoTrackIndexes()
        {
            return this._videoTrackIndexes != null && (this._videoTrackIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}