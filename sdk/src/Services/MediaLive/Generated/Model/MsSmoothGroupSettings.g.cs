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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AcquisitionPointId. The ID to include in each message in
        /// the sparse track. Ignored if sparseTrackType is NONE.
        /// </summary>
        public string AcquisitionPointId { get; set; }

        /// <summary>
        /// Checks to see if the AcquisitionPointId property is set.
        /// </summary>
        internal bool IsSetAcquisitionPointId() => this.AcquisitionPointId != null;

        /// <summary>
        /// Gets and sets the property AudioOnlyTimecodeControl. If set to passthrough for an
        /// audio-only MS Smooth output, the fragment absolute time will be set to the current
        /// timecode. This option does not write timecodes to the audio elementary stream.
        /// </summary>
        public SmoothGroupAudioOnlyTimecodeControl AudioOnlyTimecodeControl { get; set; }

        /// <summary>
        /// Checks to see if the AudioOnlyTimecodeControl property is set.
        /// </summary>
        internal bool IsSetAudioOnlyTimecodeControl() => this.AudioOnlyTimecodeControl != null;

        /// <summary>
        /// Gets and sets the property CertificateMode. If set to verifyAuthenticity, verify the
        /// https certificate chain to a trusted Certificate Authority (CA). This will cause https
        /// outputs to self-signed certificates to fail.
        /// </summary>
        public SmoothGroupCertificateMode CertificateMode { get; set; }

        /// <summary>
        /// Checks to see if the CertificateMode property is set.
        /// </summary>
        internal bool IsSetCertificateMode() => this.CertificateMode != null;

        /// <summary>
        /// Gets and sets the property ConnectionRetryInterval. Number of seconds to wait before
        /// retrying connection to the IIS server if the connection is lost. Content will be cached
        /// during this time and the cache will be be delivered to the IIS server once the connection
        /// is re-established.
        /// </summary>
        public int? ConnectionRetryInterval { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionRetryInterval property is set.
        /// </summary>
        internal bool IsSetConnectionRetryInterval() => this.ConnectionRetryInterval.HasValue;

        /// <summary>
        /// Gets and sets the property Destination. Smooth Streaming publish point on an IIS server.
        /// Elemental Live acts as a "Push" encoder to IIS.
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputLocationRef Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property EventId. MS Smooth event ID to be sent to the IIS server.
        /// Should only be specified if eventIdMode is set to useConfigured.
        /// </summary>
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventIdMode. Specifies whether or not to send an event
        /// ID to the IIS server. If no event ID is sent and the same Live Event is used without
        /// changing the publishing point, clients might see cached video from the previous run.
        /// Options: - "useConfigured" - use the value provided in eventId - "useTimestamp" -
        /// generate and send an event ID based on the current timestamp - "noEventId" - do not
        /// send an event ID to the IIS server.
        /// </summary>
        public SmoothGroupEventIdMode EventIdMode { get; set; }

        /// <summary>
        /// Checks to see if the EventIdMode property is set.
        /// </summary>
        internal bool IsSetEventIdMode() => this.EventIdMode != null;

        /// <summary>
        /// Gets and sets the property EventStopBehavior. When set to sendEos, send EOS signal
        /// to IIS server when stopping the event
        /// </summary>
        public SmoothGroupEventStopBehavior EventStopBehavior { get; set; }

        /// <summary>
        /// Checks to see if the EventStopBehavior property is set.
        /// </summary>
        internal bool IsSetEventStopBehavior() => this.EventStopBehavior != null;

        /// <summary>
        /// Gets and sets the property FilecacheDuration. Size in seconds of file cache for streaming
        /// outputs.
        /// </summary>
        public int? FilecacheDuration { get; set; }

        /// <summary>
        /// Checks to see if the FilecacheDuration property is set.
        /// </summary>
        internal bool IsSetFilecacheDuration() => this.FilecacheDuration.HasValue;

        /// <summary>
        /// Gets and sets the property FragmentLength. Length of mp4 fragments to generate (in
        /// seconds). Fragment length must be compatible with GOP size and framerate.
        /// </summary>
        public int? FragmentLength { get; set; }

        /// <summary>
        /// Checks to see if the FragmentLength property is set.
        /// </summary>
        internal bool IsSetFragmentLength() => this.FragmentLength.HasValue;

        /// <summary>
        /// Gets and sets the property InputLossAction. Parameter that control output group behavior
        /// on input loss.
        /// </summary>
        public InputLossActionForMsSmoothOut InputLossAction { get; set; }

        /// <summary>
        /// Checks to see if the InputLossAction property is set.
        /// </summary>
        internal bool IsSetInputLossAction() => this.InputLossAction != null;

        /// <summary>
        /// Gets and sets the property NumRetries. Number of retry attempts.
        /// </summary>
        public int? NumRetries { get; set; }

        /// <summary>
        /// Checks to see if the NumRetries property is set.
        /// </summary>
        internal bool IsSetNumRetries() => this.NumRetries.HasValue;

        /// <summary>
        /// Gets and sets the property RestartDelay. Number of seconds before initiating a restart
        /// due to output failure, due to exhausting the numRetries on one segment, or exceeding
        /// filecacheDuration.
        /// </summary>
        public int? RestartDelay { get; set; }

        /// <summary>
        /// Checks to see if the RestartDelay property is set.
        /// </summary>
        internal bool IsSetRestartDelay() => this.RestartDelay.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentationMode. useInputSegmentation has been deprecated.
        /// The configured segment size is always used.
        /// </summary>
        public SmoothGroupSegmentationMode SegmentationMode { get; set; }

        /// <summary>
        /// Checks to see if the SegmentationMode property is set.
        /// </summary>
        internal bool IsSetSegmentationMode() => this.SegmentationMode != null;

        /// <summary>
        /// Gets and sets the property SendDelayMs. Number of milliseconds to delay the output
        /// from the second pipeline.
        /// </summary>
        public int? SendDelayMs { get; set; }

        /// <summary>
        /// Checks to see if the SendDelayMs property is set.
        /// </summary>
        internal bool IsSetSendDelayMs() => this.SendDelayMs.HasValue;

        /// <summary>
        /// Gets and sets the property SparseTrackType. Identifies the type of data to place in
        /// the sparse track: - SCTE35: Insert SCTE-35 messages from the source content. With
        /// each message, insert an IDR frame to start a new segment. - SCTE35_WITHOUT_SEGMENTATION:
        /// Insert SCTE-35 messages from the source content. With each message, insert an IDR
        /// frame but don't start a new segment. - NONE: Don't generate a sparse track for any
        /// outputs in this output group.
        /// </summary>
        public SmoothGroupSparseTrackType SparseTrackType { get; set; }

        /// <summary>
        /// Checks to see if the SparseTrackType property is set.
        /// </summary>
        internal bool IsSetSparseTrackType() => this.SparseTrackType != null;

        /// <summary>
        /// Gets and sets the property StreamManifestBehavior. When set to send, send stream manifest
        /// so publishing point doesn't start until all streams start.
        /// </summary>
        public SmoothGroupStreamManifestBehavior StreamManifestBehavior { get; set; }

        /// <summary>
        /// Checks to see if the StreamManifestBehavior property is set.
        /// </summary>
        internal bool IsSetStreamManifestBehavior() => this.StreamManifestBehavior != null;

        /// <summary>
        /// Gets and sets the property TimestampOffset. Timestamp offset for the event. Only used
        /// if timestampOffsetMode is set to useConfiguredOffset.
        /// </summary>
        public string TimestampOffset { get; set; }

        /// <summary>
        /// Checks to see if the TimestampOffset property is set.
        /// </summary>
        internal bool IsSetTimestampOffset() => this.TimestampOffset != null;

        /// <summary>
        /// Gets and sets the property TimestampOffsetMode. Type of timestamp date offset to use.
        /// - useEventStartDate: Use the date the event was started as the offset - useConfiguredOffset:
        /// Use an explicitly configured date as the offset
        /// </summary>
        public SmoothGroupTimestampOffsetMode TimestampOffsetMode { get; set; }

        /// <summary>
        /// Checks to see if the TimestampOffsetMode property is set.
        /// </summary>
        internal bool IsSetTimestampOffsetMode() => this.TimestampOffsetMode != null;
    }
}
