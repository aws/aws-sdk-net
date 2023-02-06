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
    /// Specified video input in a template.
    /// </summary>
    public partial class InputTemplate
    {
        private Dictionary<string, AudioSelectorGroup> _audioSelectorGroups = new Dictionary<string, AudioSelectorGroup>();
        private Dictionary<string, AudioSelector> _audioSelectors = new Dictionary<string, AudioSelector>();
        private Dictionary<string, CaptionSelector> _captionSelectors = new Dictionary<string, CaptionSelector>();
        private Rectangle _crop;
        private InputDeblockFilter _deblockFilter;
        private InputDenoiseFilter _denoiseFilter;
        private string _dolbyVisionMetadataXml;
        private InputFilterEnable _filterEnable;
        private int? _filterStrength;
        private ImageInserter _imageInserter;
        private List<InputClipping> _inputClippings = new List<InputClipping>();
        private InputScanType _inputScanType;
        private Rectangle _position;
        private int? _programNumber;
        private InputPsiControl _psiControl;
        private InputTimecodeSource _timecodeSource;
        private string _timecodeStart;
        private VideoSelector _videoSelector;

        /// <summary>
        /// Gets and sets the property AudioSelectorGroups. Use audio selector groups to combine
        /// multiple sidecar audio inputs so that you can assign them to a single output audio
        /// tab (AudioDescription). Note that, if you're working with embedded audio, it's simpler
        /// to assign multiple input tracks into a single audio selector rather than use an audio
        /// selector group.
        /// </summary>
        public Dictionary<string, AudioSelectorGroup> AudioSelectorGroups
        {
            get { return this._audioSelectorGroups; }
            set { this._audioSelectorGroups = value; }
        }

        // Check to see if AudioSelectorGroups property is set
        internal bool IsSetAudioSelectorGroups()
        {
            return this._audioSelectorGroups != null && this._audioSelectorGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AudioSelectors. Use Audio selectors (AudioSelectors) to
        /// specify a track or set of tracks from the input that you will use in your outputs.
        /// You can use multiple Audio selectors per input.
        /// </summary>
        public Dictionary<string, AudioSelector> AudioSelectors
        {
            get { return this._audioSelectors; }
            set { this._audioSelectors = value; }
        }

        // Check to see if AudioSelectors property is set
        internal bool IsSetAudioSelectors()
        {
            return this._audioSelectors != null && this._audioSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CaptionSelectors. Use captions selectors to specify the
        /// captions data from your input that you use in your outputs. You can use up to 20 captions
        /// selectors per input.
        /// </summary>
        public Dictionary<string, CaptionSelector> CaptionSelectors
        {
            get { return this._captionSelectors; }
            set { this._captionSelectors = value; }
        }

        // Check to see if CaptionSelectors property is set
        internal bool IsSetCaptionSelectors()
        {
            return this._captionSelectors != null && this._captionSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Crop. Use Cropping selection (crop) to specify the video
        /// area that the service will include in the output video frame. If you specify a value
        /// here, it will override any value that you specify in the output setting Cropping selection
        /// (crop).
        /// </summary>
        public Rectangle Crop
        {
            get { return this._crop; }
            set { this._crop = value; }
        }

        // Check to see if Crop property is set
        internal bool IsSetCrop()
        {
            return this._crop != null;
        }

        /// <summary>
        /// Gets and sets the property DeblockFilter. Enable Deblock (InputDeblockFilter) to produce
        /// smoother motion in the output. Default is disabled. Only manually controllable for
        /// MPEG2 and uncompressed video inputs.
        /// </summary>
        public InputDeblockFilter DeblockFilter
        {
            get { return this._deblockFilter; }
            set { this._deblockFilter = value; }
        }

        // Check to see if DeblockFilter property is set
        internal bool IsSetDeblockFilter()
        {
            return this._deblockFilter != null;
        }

        /// <summary>
        /// Gets and sets the property DenoiseFilter. Enable Denoise (InputDenoiseFilter) to filter
        /// noise from the input. Default is disabled. Only applicable to MPEG2, H.264, H.265,
        /// and uncompressed video inputs.
        /// </summary>
        public InputDenoiseFilter DenoiseFilter
        {
            get { return this._denoiseFilter; }
            set { this._denoiseFilter = value; }
        }

        // Check to see if DenoiseFilter property is set
        internal bool IsSetDenoiseFilter()
        {
            return this._denoiseFilter != null;
        }

        /// <summary>
        /// Gets and sets the property DolbyVisionMetadataXml. Use this setting only when your
        /// video source has Dolby Vision studio mastering metadata that is carried in a separate
        /// XML file. Specify the Amazon S3 location for the metadata XML file. MediaConvert uses
        /// this file to provide global and frame-level metadata for Dolby Vision preprocessing.
        /// When you specify a file here and your input also has interleaved global and frame
        /// level metadata, MediaConvert ignores the interleaved metadata and uses only the the
        /// metadata from this external XML file. Note that your IAM service role must grant MediaConvert
        /// read permissions to this file. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/iam-role.html.
        /// </summary>
        [AWSProperty(Min=14)]
        public string DolbyVisionMetadataXml
        {
            get { return this._dolbyVisionMetadataXml; }
            set { this._dolbyVisionMetadataXml = value; }
        }

        // Check to see if DolbyVisionMetadataXml property is set
        internal bool IsSetDolbyVisionMetadataXml()
        {
            return this._dolbyVisionMetadataXml != null;
        }

        /// <summary>
        /// Gets and sets the property FilterEnable. Specify how the transcoding service applies
        /// the denoise and deblock filters. You must also enable the filters separately, with
        /// Denoise (InputDenoiseFilter) and Deblock (InputDeblockFilter). * Auto - The transcoding
        /// service determines whether to apply filtering, depending on input type and quality.
        /// * Disable - The input is not filtered. This is true even if you use the API to enable
        /// them in (InputDeblockFilter) and (InputDeblockFilter). * Force - The input is filtered
        /// regardless of input type.
        /// </summary>
        public InputFilterEnable FilterEnable
        {
            get { return this._filterEnable; }
            set { this._filterEnable = value; }
        }

        // Check to see if FilterEnable property is set
        internal bool IsSetFilterEnable()
        {
            return this._filterEnable != null;
        }

        /// <summary>
        /// Gets and sets the property FilterStrength. Use Filter strength (FilterStrength) to
        /// adjust the magnitude the input filter settings (Deblock and Denoise). The range is
        /// 0 to 5. Default is 0.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public int FilterStrength
        {
            get { return this._filterStrength.GetValueOrDefault(); }
            set { this._filterStrength = value; }
        }

        // Check to see if FilterStrength property is set
        internal bool IsSetFilterStrength()
        {
            return this._filterStrength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageInserter. Enable the image inserter feature to include
        /// a graphic overlay on your video. Enable or disable this feature for each input individually.
        /// This setting is disabled by default.
        /// </summary>
        public ImageInserter ImageInserter
        {
            get { return this._imageInserter; }
            set { this._imageInserter = value; }
        }

        // Check to see if ImageInserter property is set
        internal bool IsSetImageInserter()
        {
            return this._imageInserter != null;
        }

        /// <summary>
        /// Gets and sets the property InputClippings. (InputClippings) contains sets of start
        /// and end times that together specify a portion of the input to be used in the outputs.
        /// If you provide only a start time, the clip will be the entire input from that point
        /// to the end. If you provide only an end time, it will be the entire input up to that
        /// point. When you specify more than one input clip, the transcoding service creates
        /// the job outputs by stringing the clips together in the order you specify them.
        /// </summary>
        public List<InputClipping> InputClippings
        {
            get { return this._inputClippings; }
            set { this._inputClippings = value; }
        }

        // Check to see if InputClippings property is set
        internal bool IsSetInputClippings()
        {
            return this._inputClippings != null && this._inputClippings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputScanType. When you have a progressive segmented frame
        /// (PsF) input, use this setting to flag the input as PsF. MediaConvert doesn't automatically
        /// detect PsF. Therefore, flagging your input as PsF results in better preservation of
        /// video quality when you do deinterlacing and frame rate conversion. If you don't specify,
        /// the default value is Auto (AUTO). Auto is the correct setting for all inputs that
        /// are not PsF. Don't set this value to PsF when your input is interlaced. Doing so creates
        /// horizontal interlacing artifacts.
        /// </summary>
        public InputScanType InputScanType
        {
            get { return this._inputScanType; }
            set { this._inputScanType = value; }
        }

        // Check to see if InputScanType property is set
        internal bool IsSetInputScanType()
        {
            return this._inputScanType != null;
        }

        /// <summary>
        /// Gets and sets the property Position. Use Selection placement (position) to define
        /// the video area in your output frame. The area outside of the rectangle that you specify
        /// here is black. If you specify a value here, it will override any value that you specify
        /// in the output setting Selection placement (position). If you specify a value here,
        /// this will override any AFD values in your input, even if you set Respond to AFD (RespondToAfd)
        /// to Respond (RESPOND). If you specify a value here, this will ignore anything that
        /// you specify for the setting Scaling Behavior (scalingBehavior).
        /// </summary>
        public Rectangle Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramNumber. Use Program (programNumber) to select a
        /// specific program from within a multi-program transport stream. Note that Quad 4K is
        /// not currently supported. Default is the first program within the transport stream.
        /// If the program you specify doesn't exist, the transcoding service will use this default.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int ProgramNumber
        {
            get { return this._programNumber.GetValueOrDefault(); }
            set { this._programNumber = value; }
        }

        // Check to see if ProgramNumber property is set
        internal bool IsSetProgramNumber()
        {
            return this._programNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PsiControl. Set PSI control (InputPsiControl) for transport
        /// stream inputs to specify which data the demux process to scans. * Ignore PSI - Scan
        /// all PIDs for audio and video. * Use PSI - Scan only PSI data.
        /// </summary>
        public InputPsiControl PsiControl
        {
            get { return this._psiControl; }
            set { this._psiControl = value; }
        }

        // Check to see if PsiControl property is set
        internal bool IsSetPsiControl()
        {
            return this._psiControl != null;
        }

        /// <summary>
        /// Gets and sets the property TimecodeSource. Use this Timecode source setting, located
        /// under the input settings (InputTimecodeSource), to specify how the service counts
        /// input video frames. This input frame count affects only the behavior of features that
        /// apply to a single input at a time, such as input clipping and synchronizing some captions
        /// formats. Choose Embedded (EMBEDDED) to use the timecodes in your input video. Choose
        /// Start at zero (ZEROBASED) to start the first frame at zero. Choose Specified start
        /// (SPECIFIEDSTART) to start the first frame at the timecode that you specify in the
        /// setting Start timecode (timecodeStart). If you don't specify a value for Timecode
        /// source, the service will use Embedded by default. For more information about timecodes,
        /// see https://docs.aws.amazon.com/console/mediaconvert/timecode.
        /// </summary>
        public InputTimecodeSource TimecodeSource
        {
            get { return this._timecodeSource; }
            set { this._timecodeSource = value; }
        }

        // Check to see if TimecodeSource property is set
        internal bool IsSetTimecodeSource()
        {
            return this._timecodeSource != null;
        }

        /// <summary>
        /// Gets and sets the property TimecodeStart. Specify the timecode that you want the service
        /// to use for this input's initial frame. To use this setting, you must set the Timecode
        /// source setting, located under the input settings (InputTimecodeSource), to Specified
        /// start (SPECIFIEDSTART). For more information about timecodes, see https://docs.aws.amazon.com/console/mediaconvert/timecode.
        /// </summary>
        [AWSProperty(Min=11, Max=11)]
        public string TimecodeStart
        {
            get { return this._timecodeStart; }
            set { this._timecodeStart = value; }
        }

        // Check to see if TimecodeStart property is set
        internal bool IsSetTimecodeStart()
        {
            return this._timecodeStart != null;
        }

        /// <summary>
        /// Gets and sets the property VideoSelector. Input video selectors contain the video
        /// settings for the input. Each of your inputs can have up to one video selector.
        /// </summary>
        public VideoSelector VideoSelector
        {
            get { return this._videoSelector; }
            set { this._videoSelector = value; }
        }

        // Check to see if VideoSelector property is set
        internal bool IsSetVideoSelector()
        {
            return this._videoSelector != null;
        }

    }
}