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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Object specifying a configuration for individual participant recording.
    /// </summary>
    public partial class AutoParticipantRecordingConfiguration
    {
        private ParticipantRecordingHlsConfiguration _hlsConfiguration;
        private List<string> _mediaTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _recordingReconnectWindowSeconds;
        private bool? _recordParticipantReplicas;
        private string _storageConfigurationArn;
        private ParticipantThumbnailConfiguration _thumbnailConfiguration;

        /// <summary>
        /// Gets and sets the property HlsConfiguration. 
        /// <para>
        /// HLS configuration object for individual participant recording.
        /// </para>
        /// </summary>
        public ParticipantRecordingHlsConfiguration HlsConfiguration
        {
            get { return this._hlsConfiguration; }
            set { this._hlsConfiguration = value; }
        }

        // Check to see if HlsConfiguration property is set
        internal bool IsSetHlsConfiguration()
        {
            return this._hlsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MediaTypes. 
        /// <para>
        /// Types of media to be recorded. Default: <c>AUDIO_VIDEO</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> MediaTypes
        {
            get { return this._mediaTypes; }
            set { this._mediaTypes = value; }
        }

        // Check to see if MediaTypes property is set
        internal bool IsSetMediaTypes()
        {
            return this._mediaTypes != null && (this._mediaTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordingReconnectWindowSeconds. 
        /// <para>
        /// If a stage publisher disconnects and then reconnects within the specified interval,
        /// the multiple recordings will be considered a single recording and merged together.
        /// </para>
        ///  
        /// <para>
        /// The default value is 0, which disables merging.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public int? RecordingReconnectWindowSeconds
        {
            get { return this._recordingReconnectWindowSeconds; }
            set { this._recordingReconnectWindowSeconds = value; }
        }

        // Check to see if RecordingReconnectWindowSeconds property is set
        internal bool IsSetRecordingReconnectWindowSeconds()
        {
            return this._recordingReconnectWindowSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordParticipantReplicas. 
        /// <para>
        /// Optional field to disable replica participant recording. If this is set to <c>false</c>
        /// when a participant is a replica, replica participants are not recorded. Default: <c>true</c>.
        /// </para>
        /// </summary>
        public bool? RecordParticipantReplicas
        {
            get { return this._recordParticipantReplicas; }
            set { this._recordParticipantReplicas = value; }
        }

        // Check to see if RecordParticipantReplicas property is set
        internal bool IsSetRecordParticipantReplicas()
        {
            return this._recordParticipantReplicas.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageConfigurationArn. 
        /// <para>
        /// ARN of the <a>StorageConfiguration</a> resource to use for individual participant
        /// recording. Default: <c>""</c> (empty string, no storage configuration is specified).
        /// Individual participant recording cannot be started unless a storage configuration
        /// is specified, when a <a>Stage</a> is created or updated. To disable individual participant
        /// recording, set this to <c>""</c>; other fields in this object will get reset to their
        /// defaults when sending <c>""</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string StorageConfigurationArn
        {
            get { return this._storageConfigurationArn; }
            set { this._storageConfigurationArn = value; }
        }

        // Check to see if StorageConfigurationArn property is set
        internal bool IsSetStorageConfigurationArn()
        {
            return this._storageConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailConfiguration. 
        /// <para>
        /// A complex type that allows you to enable/disable the recording of thumbnails for individual
        /// participant recording and modify the interval at which thumbnails are generated for
        /// the live session.
        /// </para>
        /// </summary>
        public ParticipantThumbnailConfiguration ThumbnailConfiguration
        {
            get { return this._thumbnailConfiguration; }
            set { this._thumbnailConfiguration = value; }
        }

        // Check to see if ThumbnailConfiguration property is set
        internal bool IsSetThumbnailConfiguration()
        {
            return this._thumbnailConfiguration != null;
        }

    }
}