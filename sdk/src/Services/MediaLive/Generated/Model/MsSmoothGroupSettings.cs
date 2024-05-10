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
    /// Ms Smooth Group Settings
    /// </summary>
    public partial class MsSmoothGroupSettings
    {
        private string _acquisitionPointId;
        private SmoothGroupAudioOnlyTimecodeControl _audioOnlyTimecodeControl;
        private SmoothGroupCertificateMode _certificateMode;
        private int? _connectionRetryInterval;
        private OutputLocationRef _destination;
        private string _eventId;
        private SmoothGroupEventIdMode _eventIdMode;
        private SmoothGroupEventStopBehavior _eventStopBehavior;
        private int? _filecacheDuration;
        private int? _fragmentLength;
        private InputLossActionForMsSmoothOut _inputLossAction;
        private int? _numRetries;
        private int? _restartDelay;
        private SmoothGroupSegmentationMode _segmentationMode;
        private int? _sendDelayMs;
        private SmoothGroupSparseTrackType _sparseTrackType;
        private SmoothGroupStreamManifestBehavior _streamManifestBehavior;
        private string _timestampOffset;
        private SmoothGroupTimestampOffsetMode _timestampOffsetMode;

        /// <summary>
        /// Gets and sets the property AcquisitionPointId. The ID to include in each message in
        /// the sparse track. Ignored if sparseTrackType is NONE.
        /// </summary>
        public string AcquisitionPointId
        {
            get { return this._acquisitionPointId; }
            set { this._acquisitionPointId = value; }
        }

        // Check to see if AcquisitionPointId property is set
        internal bool IsSetAcquisitionPointId()
        {
            return this._acquisitionPointId != null;
        }

        /// <summary>
        /// Gets and sets the property AudioOnlyTimecodeControl. If set to passthrough for an
        /// audio-only MS Smooth output, the fragment absolute time will be set to the current
        /// timecode. This option does not write timecodes to the audio elementary stream.
        /// </summary>
        public SmoothGroupAudioOnlyTimecodeControl AudioOnlyTimecodeControl
        {
            get { return this._audioOnlyTimecodeControl; }
            set { this._audioOnlyTimecodeControl = value; }
        }

        // Check to see if AudioOnlyTimecodeControl property is set
        internal bool IsSetAudioOnlyTimecodeControl()
        {
            return this._audioOnlyTimecodeControl != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateMode. If set to verifyAuthenticity, verify the
        /// https certificate chain to a trusted Certificate Authority (CA).  This will cause
        /// https outputs to self-signed certificates to fail.
        /// </summary>
        public SmoothGroupCertificateMode CertificateMode
        {
            get { return this._certificateMode; }
            set { this._certificateMode = value; }
        }

        // Check to see if CertificateMode property is set
        internal bool IsSetCertificateMode()
        {
            return this._certificateMode != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionRetryInterval. Number of seconds to wait before
        /// retrying connection to the IIS server if the connection is lost. Content will be cached
        /// during this time and the cache will be be delivered to the IIS server once the connection
        /// is re-established.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ConnectionRetryInterval
        {
            get { return this._connectionRetryInterval; }
            set { this._connectionRetryInterval = value; }
        }

        // Check to see if ConnectionRetryInterval property is set
        internal bool IsSetConnectionRetryInterval()
        {
            return this._connectionRetryInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Destination. Smooth Streaming publish point on an IIS server.
        /// Elemental Live acts as a "Push" encoder to IIS.
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputLocationRef Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. MS Smooth event ID to be sent to the IIS server.Should
        /// only be specified if eventIdMode is set to useConfigured.
        /// </summary>
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventIdMode. Specifies whether or not to send an event
        /// ID to the IIS server. If no event ID is sent and the same Live Event is used without
        /// changing the publishing point, clients might see cached video from the previous run.Options:-
        /// "useConfigured" - use the value provided in eventId- "useTimestamp" - generate and
        /// send an event ID based on the current timestamp- "noEventId" - do not send an event
        /// ID to the IIS server.
        /// </summary>
        public SmoothGroupEventIdMode EventIdMode
        {
            get { return this._eventIdMode; }
            set { this._eventIdMode = value; }
        }

        // Check to see if EventIdMode property is set
        internal bool IsSetEventIdMode()
        {
            return this._eventIdMode != null;
        }

        /// <summary>
        /// Gets and sets the property EventStopBehavior. When set to sendEos, send EOS signal
        /// to IIS server when stopping the event
        /// </summary>
        public SmoothGroupEventStopBehavior EventStopBehavior
        {
            get { return this._eventStopBehavior; }
            set { this._eventStopBehavior = value; }
        }

        // Check to see if EventStopBehavior property is set
        internal bool IsSetEventStopBehavior()
        {
            return this._eventStopBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property FilecacheDuration. Size in seconds of file cache for streaming
        /// outputs.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? FilecacheDuration
        {
            get { return this._filecacheDuration; }
            set { this._filecacheDuration = value; }
        }

        // Check to see if FilecacheDuration property is set
        internal bool IsSetFilecacheDuration()
        {
            return this._filecacheDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FragmentLength. Length of mp4 fragments to generate (in
        /// seconds). Fragment length must be compatible with GOP size and framerate.
        /// </summary>
        [AWSProperty(Min=1)]
        public int? FragmentLength
        {
            get { return this._fragmentLength; }
            set { this._fragmentLength = value; }
        }

        // Check to see if FragmentLength property is set
        internal bool IsSetFragmentLength()
        {
            return this._fragmentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputLossAction. Parameter that control output group behavior
        /// on input loss.
        /// </summary>
        public InputLossActionForMsSmoothOut InputLossAction
        {
            get { return this._inputLossAction; }
            set { this._inputLossAction = value; }
        }

        // Check to see if InputLossAction property is set
        internal bool IsSetInputLossAction()
        {
            return this._inputLossAction != null;
        }

        /// <summary>
        /// Gets and sets the property NumRetries. Number of retry attempts.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? NumRetries
        {
            get { return this._numRetries; }
            set { this._numRetries = value; }
        }

        // Check to see if NumRetries property is set
        internal bool IsSetNumRetries()
        {
            return this._numRetries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestartDelay. Number of seconds before initiating a restart
        /// due to output failure, due to exhausting the numRetries on one segment, or exceeding
        /// filecacheDuration.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? RestartDelay
        {
            get { return this._restartDelay; }
            set { this._restartDelay = value; }
        }

        // Check to see if RestartDelay property is set
        internal bool IsSetRestartDelay()
        {
            return this._restartDelay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentationMode. useInputSegmentation has been deprecated.
        /// The configured segment size is always used.
        /// </summary>
        public SmoothGroupSegmentationMode SegmentationMode
        {
            get { return this._segmentationMode; }
            set { this._segmentationMode = value; }
        }

        // Check to see if SegmentationMode property is set
        internal bool IsSetSegmentationMode()
        {
            return this._segmentationMode != null;
        }

        /// <summary>
        /// Gets and sets the property SendDelayMs. Number of milliseconds to delay the output
        /// from the second pipeline.
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public int? SendDelayMs
        {
            get { return this._sendDelayMs; }
            set { this._sendDelayMs = value; }
        }

        // Check to see if SendDelayMs property is set
        internal bool IsSetSendDelayMs()
        {
            return this._sendDelayMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SparseTrackType. Identifies the type of data to place in
        /// the sparse track:- SCTE35: Insert SCTE-35 messages from the source content. With each
        /// message, insert an IDR frame to start a new segment.- SCTE35_WITHOUT_SEGMENTATION:
        /// Insert SCTE-35 messages from the source content. With each message, insert an IDR
        /// frame but don't start a new segment.- NONE: Don't generate a sparse track for any
        /// outputs in this output group.
        /// </summary>
        public SmoothGroupSparseTrackType SparseTrackType
        {
            get { return this._sparseTrackType; }
            set { this._sparseTrackType = value; }
        }

        // Check to see if SparseTrackType property is set
        internal bool IsSetSparseTrackType()
        {
            return this._sparseTrackType != null;
        }

        /// <summary>
        /// Gets and sets the property StreamManifestBehavior. When set to send, send stream manifest
        /// so publishing point doesn't start until all streams start.
        /// </summary>
        public SmoothGroupStreamManifestBehavior StreamManifestBehavior
        {
            get { return this._streamManifestBehavior; }
            set { this._streamManifestBehavior = value; }
        }

        // Check to see if StreamManifestBehavior property is set
        internal bool IsSetStreamManifestBehavior()
        {
            return this._streamManifestBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampOffset. Timestamp offset for the event.  Only
        /// used if timestampOffsetMode is set to useConfiguredOffset.
        /// </summary>
        public string TimestampOffset
        {
            get { return this._timestampOffset; }
            set { this._timestampOffset = value; }
        }

        // Check to see if TimestampOffset property is set
        internal bool IsSetTimestampOffset()
        {
            return this._timestampOffset != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampOffsetMode. Type of timestamp date offset to use.-
        /// useEventStartDate: Use the date the event was started as the offset- useConfiguredOffset:
        /// Use an explicitly configured date as the offset
        /// </summary>
        public SmoothGroupTimestampOffsetMode TimestampOffsetMode
        {
            get { return this._timestampOffsetMode; }
            set { this._timestampOffsetMode = value; }
        }

        // Check to see if TimestampOffsetMode property is set
        internal bool IsSetTimestampOffsetMode()
        {
            return this._timestampOffsetMode != null;
        }

    }
}