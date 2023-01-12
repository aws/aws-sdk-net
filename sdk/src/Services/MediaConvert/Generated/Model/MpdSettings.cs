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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// These settings relate to the fragmented MP4 container for the segments in your DASH
    /// outputs.
    /// </summary>
    public partial class MpdSettings
    {
        private MpdAccessibilityCaptionHints _accessibilityCaptionHints;
        private MpdAudioDuration _audioDuration;
        private MpdCaptionContainerType _captionContainerType;
        private MpdKlvMetadata _klvMetadata;
        private MpdManifestMetadataSignaling _manifestMetadataSignaling;
        private MpdScte35Esam _scte35Esam;
        private MpdScte35Source _scte35Source;
        private MpdTimedMetadata _timedMetadata;
        private MpdTimedMetadataBoxVersion _timedMetadataBoxVersion;
        private string _timedMetadataSchemeIdUri;
        private string _timedMetadataValue;

        /// <summary>
        /// Gets and sets the property AccessibilityCaptionHints. Optional. Choose Include (INCLUDE)
        /// to have MediaConvert mark up your DASH manifest with <Accessibility> elements for
        /// embedded 608 captions. This markup isn't generally required, but some video players
        /// require it to discover and play embedded 608 captions. Keep the default value, Exclude
        /// (EXCLUDE), to leave these elements out. When you enable this setting, this is the
        /// markup that MediaConvert includes in your manifest: <Accessibility schemeIdUri="urn:scte:dash:cc:cea-608:2015"
        /// value="CC1=eng"/>
        /// </summary>
        public MpdAccessibilityCaptionHints AccessibilityCaptionHints
        {
            get { return this._accessibilityCaptionHints; }
            set { this._accessibilityCaptionHints = value; }
        }

        // Check to see if AccessibilityCaptionHints property is set
        internal bool IsSetAccessibilityCaptionHints()
        {
            return this._accessibilityCaptionHints != null;
        }

        /// <summary>
        /// Gets and sets the property AudioDuration. Specify this setting only when your output
        /// will be consumed by a downstream repackaging workflow that is sensitive to very small
        /// duration differences between video and audio. For this situation, choose Match video
        /// duration (MATCH_VIDEO_DURATION). In all other cases, keep the default value, Default
        /// codec duration (DEFAULT_CODEC_DURATION). When you choose Match video duration, MediaConvert
        /// pads the output audio streams with silence or trims them to ensure that the total
        /// duration of each audio stream is at least as long as the total duration of the video
        /// stream. After padding or trimming, the audio stream duration is no more than one frame
        /// longer than the video stream. MediaConvert applies audio padding or trimming only
        /// to the end of the last segment of the output. For unsegmented outputs, MediaConvert
        /// adds padding only to the end of the file. When you keep the default value, any minor
        /// discrepancies between audio and video duration will depend on your output audio codec.
        /// </summary>
        public MpdAudioDuration AudioDuration
        {
            get { return this._audioDuration; }
            set { this._audioDuration = value; }
        }

        // Check to see if AudioDuration property is set
        internal bool IsSetAudioDuration()
        {
            return this._audioDuration != null;
        }

        /// <summary>
        /// Gets and sets the property CaptionContainerType. Use this setting only in DASH output
        /// groups that include sidecar TTML or IMSC captions.  You specify sidecar captions in
        /// a separate output from your audio and video. Choose Raw (RAW) for captions in a single
        /// XML file in a raw container. Choose Fragmented MPEG-4 (FRAGMENTED_MP4) for captions
        /// in XML format contained within fragmented MP4 files. This set of fragmented MP4 files
        /// is separate from your video and audio fragmented MP4 files.
        /// </summary>
        public MpdCaptionContainerType CaptionContainerType
        {
            get { return this._captionContainerType; }
            set { this._captionContainerType = value; }
        }

        // Check to see if CaptionContainerType property is set
        internal bool IsSetCaptionContainerType()
        {
            return this._captionContainerType != null;
        }

        /// <summary>
        /// Gets and sets the property KlvMetadata. To include key-length-value metadata in this
        /// output: Set KLV metadata insertion to Passthrough. MediaConvert reads KLV metadata
        /// present in your input and writes each instance to a separate event message box in
        /// the output, according to MISB ST1910.1. To exclude this KLV metadata: Set KLV metadata
        /// insertion to None or leave blank.
        /// </summary>
        public MpdKlvMetadata KlvMetadata
        {
            get { return this._klvMetadata; }
            set { this._klvMetadata = value; }
        }

        // Check to see if KlvMetadata property is set
        internal bool IsSetKlvMetadata()
        {
            return this._klvMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestMetadataSignaling. To add an InbandEventStream
        /// element in your output MPD manifest for each type of event message, set Manifest metadata
        /// signaling to Enabled. For ID3 event messages, the InbandEventStream element schemeIdUri
        /// will be same value that you specify for ID3 metadata scheme ID URI. For SCTE35 event
        /// messages, the InbandEventStream element schemeIdUri will be "urn:scte:scte35:2013:bin".
        /// To leave these elements out of your output MPD manifest, set Manifest metadata signaling
        /// to Disabled. To enable Manifest metadata signaling, you must also set SCTE-35 source
        /// to Passthrough, ESAM SCTE-35 to insert, or ID3 metadata (TimedMetadata) to Passthrough.
        /// </summary>
        public MpdManifestMetadataSignaling ManifestMetadataSignaling
        {
            get { return this._manifestMetadataSignaling; }
            set { this._manifestMetadataSignaling = value; }
        }

        // Check to see if ManifestMetadataSignaling property is set
        internal bool IsSetManifestMetadataSignaling()
        {
            return this._manifestMetadataSignaling != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Esam. Use this setting only when you specify SCTE-35
        /// markers from ESAM. Choose INSERT to put SCTE-35 markers in this output at the insertion
        /// points that you specify in an ESAM XML document. Provide the document in the setting
        /// SCC XML (sccXml).
        /// </summary>
        public MpdScte35Esam Scte35Esam
        {
            get { return this._scte35Esam; }
            set { this._scte35Esam = value; }
        }

        // Check to see if Scte35Esam property is set
        internal bool IsSetScte35Esam()
        {
            return this._scte35Esam != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Source. Ignore this setting unless you have SCTE-35
        /// markers in your input video file. Choose Passthrough (PASSTHROUGH) if you want SCTE-35
        /// markers that appear in your input to also appear in this output. Choose None (NONE)
        /// if you don't want those SCTE-35 markers in this output.
        /// </summary>
        public MpdScte35Source Scte35Source
        {
            get { return this._scte35Source; }
            set { this._scte35Source = value; }
        }

        // Check to see if Scte35Source property is set
        internal bool IsSetScte35Source()
        {
            return this._scte35Source != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadata. To include ID3 metadata in this output:
        /// Set ID3 metadata (timedMetadata) to Passthrough (PASSTHROUGH). Specify this ID3 metadata
        /// in Custom ID3 metadata inserter (timedMetadataInsertion). MediaConvert writes each
        /// instance of ID3 metadata in a separate Event Message (eMSG) box. To exclude this ID3
        /// metadata: Set ID3 metadata to None (NONE) or leave blank.
        /// </summary>
        public MpdTimedMetadata TimedMetadata
        {
            get { return this._timedMetadata; }
            set { this._timedMetadata = value; }
        }

        // Check to see if TimedMetadata property is set
        internal bool IsSetTimedMetadata()
        {
            return this._timedMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataBoxVersion. Specify the event message box
        /// (eMSG) version for ID3 timed metadata in your output.For more information, see ISO/IEC
        /// 23009-1:2022 section 5.10.3.3.3 Syntax.Leave blank to use the default value Version
        /// 0.When you specify Version 1, you must also set ID3 metadata (timedMetadata) to Passthrough.
        /// </summary>
        public MpdTimedMetadataBoxVersion TimedMetadataBoxVersion
        {
            get { return this._timedMetadataBoxVersion; }
            set { this._timedMetadataBoxVersion = value; }
        }

        // Check to see if TimedMetadataBoxVersion property is set
        internal bool IsSetTimedMetadataBoxVersion()
        {
            return this._timedMetadataBoxVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataSchemeIdUri. Specify the event message box
        /// (eMSG) scheme ID URI (scheme_id_uri) for ID3 timed metadata in your output. For more
        /// informaiton, see ISO/IEC 23009-1:2022 section 5.10.3.3.4 Semantics. Leave blank to
        /// use the default value: https://aomedia.org/emsg/ID3 When you specify a value for ID3
        /// metadata scheme ID URI, you must also set ID3 metadata (timedMetadata) to Passthrough.
        /// </summary>
        [AWSProperty(Max=1000)]
        public string TimedMetadataSchemeIdUri
        {
            get { return this._timedMetadataSchemeIdUri; }
            set { this._timedMetadataSchemeIdUri = value; }
        }

        // Check to see if TimedMetadataSchemeIdUri property is set
        internal bool IsSetTimedMetadataSchemeIdUri()
        {
            return this._timedMetadataSchemeIdUri != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataValue. Specify the event message box (eMSG)
        /// value for ID3 timed metadata in your output. For more informaiton, see ISO/IEC 23009-1:2022
        /// section 5.10.3.3.4 Semantics. When you specify a value for ID3 Metadata Value, you
        /// must also set ID3 metadata (timedMetadata) to Passthrough.
        /// </summary>
        [AWSProperty(Max=1000)]
        public string TimedMetadataValue
        {
            get { return this._timedMetadataValue; }
            set { this._timedMetadataValue = value; }
        }

        // Check to see if TimedMetadataValue property is set
        internal bool IsSetTimedMetadataValue()
        {
            return this._timedMetadataValue != null;
        }

    }
}