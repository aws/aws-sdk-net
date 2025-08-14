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
    /// Cmaf Ingest Group Settings
    /// </summary>
    public partial class CmafIngestGroupSettings
    {
        private List<AdditionalDestinations> _additionalDestinations = AWSConfigs.InitializeCollections ? new List<AdditionalDestinations>() : null;
        private List<CmafIngestCaptionLanguageMapping> _captionLanguageMappings = AWSConfigs.InitializeCollections ? new List<CmafIngestCaptionLanguageMapping>() : null;
        private OutputLocationRef _destination;
        private CmafId3Behavior _id3Behavior;
        private string _id3NameModifier;
        private CmafKLVBehavior _klvBehavior;
        private string _klvNameModifier;
        private CmafNielsenId3Behavior _nielsenId3Behavior;
        private string _nielsenId3NameModifier;
        private string _scte35NameModifier;
        private Scte35Type _scte35Type;
        private int? _segmentLength;
        private CmafIngestSegmentLengthUnits _segmentLengthUnits;
        private int? _sendDelayMs;
        private CmafTimedMetadataId3Frame _timedMetadataId3Frame;
        private int? _timedMetadataId3Period;
        private CmafTimedMetadataPassthrough _timedMetadataPassthrough;

        /// <summary>
        /// Gets and sets the property AdditionalDestinations. Optional an array of additional
        /// destinational HTTP destinations for the OutputGroup outputs
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalDestinations> AdditionalDestinations
        {
            get { return this._additionalDestinations; }
            set { this._additionalDestinations = value; }
        }

        // Check to see if AdditionalDestinations property is set
        internal bool IsSetAdditionalDestinations()
        {
            return this._additionalDestinations != null && (this._additionalDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CaptionLanguageMappings. An array that identifies the languages
        /// in the four caption channels in the embedded captions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CmafIngestCaptionLanguageMapping> CaptionLanguageMappings
        {
            get { return this._captionLanguageMappings; }
            set { this._captionLanguageMappings = value; }
        }

        // Check to see if CaptionLanguageMappings property is set
        internal bool IsSetCaptionLanguageMappings()
        {
            return this._captionLanguageMappings != null && (this._captionLanguageMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Destination. A HTTP destination for the tracks
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
        /// Gets and sets the property Id3Behavior. Set to ENABLED to enable ID3 metadata insertion.
        /// To include metadata, you configure other parameters in the output group, or you add
        /// an ID3 action to the channel schedule.
        /// </summary>
        public CmafId3Behavior Id3Behavior
        {
            get { return this._id3Behavior; }
            set { this._id3Behavior = value; }
        }

        // Check to see if Id3Behavior property is set
        internal bool IsSetId3Behavior()
        {
            return this._id3Behavior != null;
        }

        /// <summary>
        /// Gets and sets the property Id3NameModifier. Change the modifier that MediaLive automatically
        /// adds to the Streams() name that identifies an ID3 track. The default is "id3", which
        /// means the default name will be Streams(id3.cmfm). Any string you enter here will replace
        /// the "id3" string.\nThe modifier can only contain: numbers, letters, plus (+), minus
        /// (-), underscore (_) and period (.) and has a maximum length of 100 characters.
        /// </summary>
        [AWSProperty(Max=100)]
        public string Id3NameModifier
        {
            get { return this._id3NameModifier; }
            set { this._id3NameModifier = value; }
        }

        // Check to see if Id3NameModifier property is set
        internal bool IsSetId3NameModifier()
        {
            return this._id3NameModifier != null;
        }

        /// <summary>
        /// Gets and sets the property KlvBehavior. If set to passthrough, passes any KLV data
        /// from the input source to this output.
        /// </summary>
        public CmafKLVBehavior KlvBehavior
        {
            get { return this._klvBehavior; }
            set { this._klvBehavior = value; }
        }

        // Check to see if KlvBehavior property is set
        internal bool IsSetKlvBehavior()
        {
            return this._klvBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property KlvNameModifier. Change the modifier that MediaLive automatically
        /// adds to the Streams() name that identifies a KLV track. The default is "klv", which
        /// means the default name will be Streams(klv.cmfm). Any string you enter here will replace
        /// the "klv" string.\nThe modifier can only contain: numbers, letters, plus (+), minus
        /// (-), underscore (_) and period (.) and has a maximum length of 100 characters.
        /// </summary>
        [AWSProperty(Max=100)]
        public string KlvNameModifier
        {
            get { return this._klvNameModifier; }
            set { this._klvNameModifier = value; }
        }

        // Check to see if KlvNameModifier property is set
        internal bool IsSetKlvNameModifier()
        {
            return this._klvNameModifier != null;
        }

        /// <summary>
        /// Gets and sets the property NielsenId3Behavior. If set to passthrough, Nielsen inaudible
        /// tones for media tracking will be detected in the input audio and an equivalent ID3
        /// tag will be inserted in the output.
        /// </summary>
        public CmafNielsenId3Behavior NielsenId3Behavior
        {
            get { return this._nielsenId3Behavior; }
            set { this._nielsenId3Behavior = value; }
        }

        // Check to see if NielsenId3Behavior property is set
        internal bool IsSetNielsenId3Behavior()
        {
            return this._nielsenId3Behavior != null;
        }

        /// <summary>
        /// Gets and sets the property NielsenId3NameModifier. Change the modifier that MediaLive
        /// automatically adds to the Streams() name that identifies a Nielsen ID3 track. The
        /// default is "nid3", which means the default name will be Streams(nid3.cmfm). Any string
        /// you enter here will replace the "nid3" string.\nThe modifier can only contain: numbers,
        /// letters, plus (+), minus (-), underscore (_) and period (.) and has a maximum length
        /// of 100 characters.
        /// </summary>
        [AWSProperty(Max=100)]
        public string NielsenId3NameModifier
        {
            get { return this._nielsenId3NameModifier; }
            set { this._nielsenId3NameModifier = value; }
        }

        // Check to see if NielsenId3NameModifier property is set
        internal bool IsSetNielsenId3NameModifier()
        {
            return this._nielsenId3NameModifier != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35NameModifier. Change the modifier that MediaLive
        /// automatically adds to the Streams() name for a SCTE 35 track. The default is "scte",
        /// which means the default name will be Streams(scte.cmfm). Any string you enter here
        /// will replace the "scte" string.\nThe modifier can only contain: numbers, letters,
        /// plus (+), minus (-), underscore (_) and period (.) and has a maximum length of 100
        /// characters.
        /// </summary>
        [AWSProperty(Max=100)]
        public string Scte35NameModifier
        {
            get { return this._scte35NameModifier; }
            set { this._scte35NameModifier = value; }
        }

        // Check to see if Scte35NameModifier property is set
        internal bool IsSetScte35NameModifier()
        {
            return this._scte35NameModifier != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Type. Type of scte35 track to add. none or scte35WithoutSegmentation
        /// </summary>
        public Scte35Type Scte35Type
        {
            get { return this._scte35Type; }
            set { this._scte35Type = value; }
        }

        // Check to see if Scte35Type property is set
        internal bool IsSetScte35Type()
        {
            return this._scte35Type != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentLength. The nominal duration of segments. The units
        /// are specified in SegmentLengthUnits. The segments will end on the next keyframe after
        /// the specified duration, so the actual segment length might be longer, and it might
        /// be a fraction of the units.
        /// </summary>
        [AWSProperty(Min=1)]
        public int? SegmentLength
        {
            get { return this._segmentLength; }
            set { this._segmentLength = value; }
        }

        // Check to see if SegmentLength property is set
        internal bool IsSetSegmentLength()
        {
            return this._segmentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentLengthUnits. Time unit for segment length parameter.
        /// </summary>
        public CmafIngestSegmentLengthUnits SegmentLengthUnits
        {
            get { return this._segmentLengthUnits; }
            set { this._segmentLengthUnits = value; }
        }

        // Check to see if SegmentLengthUnits property is set
        internal bool IsSetSegmentLengthUnits()
        {
            return this._segmentLengthUnits != null;
        }

        /// <summary>
        /// Gets and sets the property SendDelayMs. Number of milliseconds to delay the output
        /// from the second pipeline.
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
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
        /// Gets and sets the property TimedMetadataId3Frame. Set to none if you don't want to
        /// insert a timecode in the output. Otherwise choose the frame type for the timecode.
        /// </summary>
        public CmafTimedMetadataId3Frame TimedMetadataId3Frame
        {
            get { return this._timedMetadataId3Frame; }
            set { this._timedMetadataId3Frame = value; }
        }

        // Check to see if TimedMetadataId3Frame property is set
        internal bool IsSetTimedMetadataId3Frame()
        {
            return this._timedMetadataId3Frame != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataId3Period. If you set up to insert a timecode
        /// in the output, specify the frequency for the frame, in seconds.
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public int? TimedMetadataId3Period
        {
            get { return this._timedMetadataId3Period; }
            set { this._timedMetadataId3Period = value; }
        }

        // Check to see if TimedMetadataId3Period property is set
        internal bool IsSetTimedMetadataId3Period()
        {
            return this._timedMetadataId3Period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataPassthrough. Set to enabled to pass through
        /// ID3 metadata from the input sources.
        /// </summary>
        public CmafTimedMetadataPassthrough TimedMetadataPassthrough
        {
            get { return this._timedMetadataPassthrough; }
            set { this._timedMetadataPassthrough = value; }
        }

        // Check to see if TimedMetadataPassthrough property is set
        internal bool IsSetTimedMetadataPassthrough()
        {
            return this._timedMetadataPassthrough != null;
        }

    }
}