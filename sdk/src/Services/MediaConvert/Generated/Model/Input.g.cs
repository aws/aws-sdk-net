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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Use inputs to define the source files used in your transcoding job. For more information,
    /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/specify-input-settings.html.
    /// You can use multiple video inputs to do input stitching. For more information, see
    /// https://docs.aws.amazon.com/mediaconvert/latest/ug/assembling-multiple-inputs-and-input-clips.html
    /// </summary>
    public partial class Input
    {
        /// <summary>
        /// Gets and sets the property AdvancedInputFilter. Use to remove noise, blocking, blurriness,
        /// or ringing from your input as a pre-filter step before encoding. The Advanced input
        /// filter removes more types of compression artifacts and is an improvement when compared
        /// to basic Deblock and Denoise filters. To remove video compression artifacts from your
        /// input and improve the video quality: Choose Enabled. Additionally, this filter can
        /// help increase the video quality of your output relative to its bitrate, since noisy
        /// inputs are more complex and require more bits to encode. To help restore loss of detail
        /// after applying the filter, you can optionally add texture or sharpening as an additional
        /// step. Jobs that use this feature incur pro-tier pricing. To not apply advanced input
        /// filtering: Choose Disabled. Note that you can still apply basic filtering with Deblock
        /// and Denoise.
        /// </summary>
        public AdvancedInputFilter AdvancedInputFilter { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedInputFilter property is set.
        /// </summary>
        internal bool IsSetAdvancedInputFilter() => this.AdvancedInputFilter != null;

        /// <summary>
        /// Gets and sets the property AdvancedInputFilterSettings. Optional settings for Advanced
        /// input filter when you set Advanced input filter to Enabled.
        /// </summary>
        public AdvancedInputFilterSettings AdvancedInputFilterSettings { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedInputFilterSettings property is set.
        /// </summary>
        internal bool IsSetAdvancedInputFilterSettings() => this.AdvancedInputFilterSettings != null;

        /// <summary>
        /// Gets and sets the property AudioSelectorGroups. Use audio selector groups to combine
        /// multiple sidecar audio inputs so that you can assign them to a single output audio
        /// tab. Note that, if you're working with embedded audio, it's simpler to assign multiple
        /// input tracks into a single audio selector rather than use an audio selector group.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AudioSelectorGroup> AudioSelectorGroups { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AudioSelectorGroup>() : null;

        /// <summary>
        /// Checks to see if the AudioSelectorGroups property is set.
        /// </summary>
        internal bool IsSetAudioSelectorGroups() => this.AudioSelectorGroups != null && (this.AudioSelectorGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AudioSelectors. Use Audio selectors to specify a track
        /// or set of tracks from the input that you will use in your outputs. You can use multiple
        /// Audio selectors per input.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AudioSelector> AudioSelectors { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AudioSelector>() : null;

        /// <summary>
        /// Checks to see if the AudioSelectors property is set.
        /// </summary>
        internal bool IsSetAudioSelectors() => this.AudioSelectors != null && (this.AudioSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaptionSelectors. Use captions selectors to specify the
        /// captions data from your input that you use in your outputs. You can use up to 100
        /// captions selectors per input.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, CaptionSelector> CaptionSelectors { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CaptionSelector>() : null;

        /// <summary>
        /// Checks to see if the CaptionSelectors property is set.
        /// </summary>
        internal bool IsSetCaptionSelectors() => this.CaptionSelectors != null && (this.CaptionSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Crop. Use Cropping selection to specify the video area
        /// that the service will include in the output video frame. If you specify a value here,
        /// it will override any value that you specify in the output setting Cropping selection.
        /// </summary>
        public Rectangle Crop { get; set; }

        /// <summary>
        /// Checks to see if the Crop property is set.
        /// </summary>
        internal bool IsSetCrop() => this.Crop != null;

        /// <summary>
        /// Gets and sets the property DeblockFilter. Enable Deblock to produce smoother motion
        /// in the output. Default is disabled. Only manually controllable for MPEG2 and uncompressed
        /// video inputs.
        /// </summary>
        public InputDeblockFilter DeblockFilter { get; set; }

        /// <summary>
        /// Checks to see if the DeblockFilter property is set.
        /// </summary>
        internal bool IsSetDeblockFilter() => this.DeblockFilter != null;

        /// <summary>
        /// Gets and sets the property DecryptionSettings. Settings for decrypting any input files
        /// that you encrypt before you upload them to Amazon S3. MediaConvert can decrypt files
        /// only when you use AWS Key Management Service (KMS) to encrypt the data key that you
        /// use to encrypt your content.
        /// </summary>
        public InputDecryptionSettings DecryptionSettings { get; set; }

        /// <summary>
        /// Checks to see if the DecryptionSettings property is set.
        /// </summary>
        internal bool IsSetDecryptionSettings() => this.DecryptionSettings != null;

        /// <summary>
        /// Gets and sets the property DenoiseFilter. Enable Denoise to filter noise from the
        /// input. Default is disabled. Only applicable to MPEG2, H.264, H.265, and uncompressed
        /// video inputs.
        /// </summary>
        public InputDenoiseFilter DenoiseFilter { get; set; }

        /// <summary>
        /// Checks to see if the DenoiseFilter property is set.
        /// </summary>
        internal bool IsSetDenoiseFilter() => this.DenoiseFilter != null;

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
        [AWSProperty(Min = 14)]
        public string DolbyVisionMetadataXml { get; set; }

        /// <summary>
        /// Checks to see if the DolbyVisionMetadataXml property is set.
        /// </summary>
        internal bool IsSetDolbyVisionMetadataXml() => this.DolbyVisionMetadataXml != null;

        /// <summary>
        /// Gets and sets the property DynamicAudioSelectors. Use Dynamic audio selectors when
        /// you do not know the track layout of your source when you submit your job, but want
        /// to select multiple audio tracks. When you include an audio track in your output and
        /// specify this Dynamic audio selector as the Audio source, MediaConvert creates an output
        /// audio track for each dynamically selected track. Note that when you include a Dynamic
        /// audio selector for two or more inputs, each input must have the same number of audio
        /// tracks and audio channels.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DynamicAudioSelector> DynamicAudioSelectors { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DynamicAudioSelector>() : null;

        /// <summary>
        /// Checks to see if the DynamicAudioSelectors property is set.
        /// </summary>
        internal bool IsSetDynamicAudioSelectors() => this.DynamicAudioSelectors != null && (this.DynamicAudioSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FileInput. Specify the source file for your transcoding
        /// job. You can use multiple inputs in a single job. The service concatenates these inputs,
        /// in the order that you specify them in the job, to create the outputs. For standard
        /// inputs, provide the path to your S3, HTTP, or HTTPS source file. For example, s3://amzn-s3-demo-bucket/input.mp4
        /// for an Amazon S3 input or https://example.com/input.mp4 for an HTTPS input. For TAMS
        /// inputs, specify the HTTPS endpoint of your TAMS server. For example, https://tams-server.example.com
        /// . When you do, also specify Source ID, Timerange, GAP handling, and the Authorization
        /// connection ARN under TAMS settings. (Don't include these parameters in the Input file
        /// URL.) For IMF inputs, specify your input by providing the path to your CPL. For example,
        /// s3://amzn-s3-demo-bucket/vf/cpl.xml . If the CPL is in an incomplete IMP, make sure
        /// to use Supplemental IMPsto specify any supplemental IMPs that contain assets referenced
        /// by the CPL.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string FileInput { get; set; }

        /// <summary>
        /// Checks to see if the FileInput property is set.
        /// </summary>
        internal bool IsSetFileInput() => this.FileInput != null;

        /// <summary>
        /// Gets and sets the property FilterEnable. Specify whether to apply input filtering
        /// to improve the video quality of your input. To apply filtering depending on your input
        /// type and quality: Choose Auto. To apply no filtering: Choose Disable. To apply filtering
        /// regardless of your input type and quality: Choose Force. When you do, you must also
        /// specify a value for Filter strength.
        /// </summary>
        public InputFilterEnable FilterEnable { get; set; }

        /// <summary>
        /// Checks to see if the FilterEnable property is set.
        /// </summary>
        internal bool IsSetFilterEnable() => this.FilterEnable != null;

        /// <summary>
        /// Gets and sets the property FilterStrength. Specify the strength of the input filter.
        /// To apply an automatic amount of filtering based the compression artifacts measured
        /// in your input: We recommend that you leave Filter strength blank and set Filter enable
        /// to Auto. To manually apply filtering: Enter a value from 1 to 5, where 1 is the least
        /// amount of filtering and 5 is the most. The value that you enter applies to the strength
        /// of the Deblock or Denoise filters, or to the strength of the Advanced input filter.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public int? FilterStrength { get; set; }

        /// <summary>
        /// Checks to see if the FilterStrength property is set.
        /// </summary>
        internal bool IsSetFilterStrength() => this.FilterStrength.HasValue;

        /// <summary>
        /// Gets and sets the property ImageInserter. Enable the image inserter feature to include
        /// a graphic overlay on your video. Enable or disable this feature for each input individually.
        /// This setting is disabled by default.
        /// </summary>
        public ImageInserter ImageInserter { get; set; }

        /// <summary>
        /// Checks to see if the ImageInserter property is set.
        /// </summary>
        internal bool IsSetImageInserter() => this.ImageInserter != null;

        /// <summary>
        /// Gets and sets the property InputClippings. Contains sets of start and end times that
        /// together specify a portion of the input to be used in the outputs. If you provide
        /// only a start time, the clip will be the entire input from that point to the end. If
        /// you provide only an end time, it will be the entire input up to that point. When you
        /// specify more than one input clip, the transcoding service creates the job outputs
        /// by stringing the clips together in the order you specify them.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputClipping> InputClippings { get; set; } = AWSConfigs.InitializeCollections ? new List<InputClipping>() : null;

        /// <summary>
        /// Checks to see if the InputClippings property is set.
        /// </summary>
        internal bool IsSetInputClippings() => this.InputClippings != null && (this.InputClippings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InputScanType. When you have a progressive segmented frame
        /// (PsF) input, use this setting to flag the input as PsF. MediaConvert doesn't automatically
        /// detect PsF. Therefore, flagging your input as PsF results in better preservation of
        /// video quality when you do deinterlacing and frame rate conversion. If you don't specify,
        /// the default value is Auto. Auto is the correct setting for all inputs that are not
        /// PsF. Don't set this value to PsF when your input is interlaced. Doing so creates horizontal
        /// interlacing artifacts.
        /// </summary>
        public InputScanType InputScanType { get; set; }

        /// <summary>
        /// Checks to see if the InputScanType property is set.
        /// </summary>
        internal bool IsSetInputScanType() => this.InputScanType != null;

        /// <summary>
        /// Gets and sets the property MultiViewSettings. Specify the enhancement layer input
        /// video file path for Multi View outputs. The base layer input is treated as the left
        /// eye and this Multi View input is treated as the right eye. Only one Multi View input
        /// is currently supported. MediaConvert encodes both views into a single MV-HEVC output
        /// codec. When you add MultiViewSettings to your job, you can only produce Multi View
        /// outputs. Adding any other codec output to the same job is not supported.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MultiViewSettings> MultiViewSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<MultiViewSettings>() : null;

        /// <summary>
        /// Checks to see if the MultiViewSettings property is set.
        /// </summary>
        internal bool IsSetMultiViewSettings() => this.MultiViewSettings != null && (this.MultiViewSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Position. Use Selection placement to define the video area
        /// in your output frame. The area outside of the rectangle that you specify here is black.
        /// If you specify a value here, it will override any value that you specify in the output
        /// setting Selection placement. If you specify a value here, this will override any AFD
        /// values in your input, even if you set Respond to AFD to Respond. If you specify a
        /// value here, this will ignore anything that you specify for the setting Scaling Behavior.
        /// </summary>
        public Rectangle Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

        /// <summary>
        /// Gets and sets the property ProgramNumber. Use Program to select a specific program
        /// from within a multi-program transport stream. Note that Quad 4K is not currently supported.
        /// Default is the first program within the transport stream. If the program you specify
        /// doesn't exist, the transcoding service will use this default.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? ProgramNumber { get; set; }

        /// <summary>
        /// Checks to see if the ProgramNumber property is set.
        /// </summary>
        internal bool IsSetProgramNumber() => this.ProgramNumber.HasValue;

        /// <summary>
        /// Gets and sets the property PsiControl. Set PSI control for transport stream inputs
        /// to specify which data the demux process to scans. * Ignore PSI - Scan all PIDs for
        /// audio and video. * Use PSI - Scan only PSI data.
        /// </summary>
        public InputPsiControl PsiControl { get; set; }

        /// <summary>
        /// Checks to see if the PsiControl property is set.
        /// </summary>
        internal bool IsSetPsiControl() => this.PsiControl != null;

        /// <summary>
        /// Gets and sets the property SupplementalImps. Provide a list of any necessary supplemental
        /// IMPs. You need supplemental IMPs if the CPL that you're using for your input is in
        /// an incomplete IMP. Specify either the supplemental IMP directories with a trailing
        /// slash or the ASSETMAP.xml files. For example ["s3://bucket/ov/", "s3://bucket/vf2/ASSETMAP.xml"].
        /// You don't need to specify the IMP that contains your input CPL, because the service
        /// automatically detects it.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupplementalImps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupplementalImps property is set.
        /// </summary>
        internal bool IsSetSupplementalImps() => this.SupplementalImps != null && (this.SupplementalImps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TamsSettings. Specify a Time Addressable Media Store (TAMS)
        /// server as an input source. TAMS is an open-source API specification that provides
        /// access to time-segmented media content. Use TAMS to retrieve specific time ranges
        /// from live or archived media streams. When you specify TAMS settings, MediaConvert
        /// connects to your TAMS server, retrieves the media segments for your specified time
        /// range, and processes them as a single input. This enables workflows like extracting
        /// clips from live streams or processing specific portions of archived content. To use
        /// TAMS, you must: 1. Have access to a TAMS-compliant server 2. Specify the server URL
        /// in the Input file URL field 3. Provide the required SourceId and Timerange parameters
        /// 4. Configure authentication, if your TAMS server requires it
        /// </summary>
        public InputTamsSettings TamsSettings { get; set; }

        /// <summary>
        /// Checks to see if the TamsSettings property is set.
        /// </summary>
        internal bool IsSetTamsSettings() => this.TamsSettings != null;

        /// <summary>
        /// Gets and sets the property TimecodeSource. Use this Timecode source setting, located
        /// under the input settings, to specify how the service counts input video frames. This
        /// input frame count affects only the behavior of features that apply to a single input
        /// at a time, such as input clipping and synchronizing some captions formats. Choose
        /// Embedded to use the timecodes in your input video. Choose Start at zero to start the
        /// first frame at zero. Choose Specified start to start the first frame at the timecode
        /// that you specify in the setting Start timecode. If you don't specify a value for Timecode
        /// source, the service will use Embedded by default. For more information about timecodes,
        /// see https://docs.aws.amazon.com/console/mediaconvert/timecode.
        /// </summary>
        public InputTimecodeSource TimecodeSource { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeSource property is set.
        /// </summary>
        internal bool IsSetTimecodeSource() => this.TimecodeSource != null;

        /// <summary>
        /// Gets and sets the property TimecodeStart. Specify the timecode that you want the service
        /// to use for this input's initial frame. To use this setting, you must set the Timecode
        /// source setting, located under the input settings, to Specified start. For more information
        /// about timecodes, see https://docs.aws.amazon.com/console/mediaconvert/timecode.
        /// </summary>
        [AWSProperty(Min = 11, Max = 11)]
        public string TimecodeStart { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeStart property is set.
        /// </summary>
        internal bool IsSetTimecodeStart() => this.TimecodeStart != null;

        /// <summary>
        /// Gets and sets the property VideoGenerator. When you include Video generator, MediaConvert
        /// creates a video input with black frames. Use this setting if you do not have a video
        /// input or if you want to add black video frames before, or after, other inputs. You
        /// can specify Video generator, or you can specify an Input file, but you cannot specify
        /// both. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/video-generator.html
        /// </summary>
        public InputVideoGenerator VideoGenerator { get; set; }

        /// <summary>
        /// Checks to see if the VideoGenerator property is set.
        /// </summary>
        internal bool IsSetVideoGenerator() => this.VideoGenerator != null;

        /// <summary>
        /// Gets and sets the property VideoOverlays. Contains an array of video overlays.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VideoOverlay> VideoOverlays { get; set; } = AWSConfigs.InitializeCollections ? new List<VideoOverlay>() : null;

        /// <summary>
        /// Checks to see if the VideoOverlays property is set.
        /// </summary>
        internal bool IsSetVideoOverlays() => this.VideoOverlays != null && (this.VideoOverlays.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VideoSelector. Input video selectors contain the video
        /// settings for the input. Each of your inputs can have up to one video selector.
        /// </summary>
        public VideoSelector VideoSelector { get; set; }

        /// <summary>
        /// Checks to see if the VideoSelector property is set.
        /// </summary>
        internal bool IsSetVideoSelector() => this.VideoSelector != null;
    }
}
