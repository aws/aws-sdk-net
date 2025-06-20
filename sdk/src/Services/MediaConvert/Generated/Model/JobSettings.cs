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
    /// JobSettings contains all the transcode settings for a job.
    /// </summary>
    public partial class JobSettings
    {
        private int? _adAvailOffset;
        private AvailBlanking _availBlanking;
        private List<ColorConversion3DLUTSetting> _colorConversion3DLUTSettings = AWSConfigs.InitializeCollections ? new List<ColorConversion3DLUTSetting>() : null;
        private EsamSettings _esam;
        private ExtendedDataServices _extendedDataServices;
        private int? _followSource;
        private List<Input> _inputs = AWSConfigs.InitializeCollections ? new List<Input>() : null;
        private KantarWatermarkSettings _kantarWatermark;
        private MotionImageInserter _motionImageInserter;
        private NielsenConfiguration _nielsenConfiguration;
        private NielsenNonLinearWatermarkSettings _nielsenNonLinearWatermark;
        private List<OutputGroup> _outputGroups = AWSConfigs.InitializeCollections ? new List<OutputGroup>() : null;
        private TimecodeConfig _timecodeConfig;
        private TimedMetadataInsertion _timedMetadataInsertion;

        /// <summary>
        /// Gets and sets the property AdAvailOffset. When specified, this offset (in milliseconds)
        /// is added to the input Ad Avail PTS time.
        /// </summary>
        [AWSProperty(Min=-1000, Max=1000)]
        public int? AdAvailOffset
        {
            get { return this._adAvailOffset; }
            set { this._adAvailOffset = value; }
        }

        // Check to see if AdAvailOffset property is set
        internal bool IsSetAdAvailOffset()
        {
            return this._adAvailOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailBlanking. Settings for ad avail blanking. Video can
        /// be blanked or overlaid with an image, and audio muted during SCTE-35 triggered ad
        /// avails.
        /// </summary>
        public AvailBlanking AvailBlanking
        {
            get { return this._availBlanking; }
            set { this._availBlanking = value; }
        }

        // Check to see if AvailBlanking property is set
        internal bool IsSetAvailBlanking()
        {
            return this._availBlanking != null;
        }

        /// <summary>
        /// Gets and sets the property ColorConversion3DLUTSettings. Use 3D LUTs to specify custom
        /// color mapping behavior when you convert from one color space into another. You can
        /// include up to 8 different 3D LUTs. For more information, see: https://docs.aws.amazon.com/mediaconvert/latest/ug/3d-luts.html
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ColorConversion3DLUTSetting> ColorConversion3DLUTSettings
        {
            get { return this._colorConversion3DLUTSettings; }
            set { this._colorConversion3DLUTSettings = value; }
        }

        // Check to see if ColorConversion3DLUTSettings property is set
        internal bool IsSetColorConversion3DLUTSettings()
        {
            return this._colorConversion3DLUTSettings != null && (this._colorConversion3DLUTSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Esam. Settings for Event Signaling And Messaging (ESAM).
        /// If you don't do ad insertion, you can ignore these settings.
        /// </summary>
        public EsamSettings Esam
        {
            get { return this._esam; }
            set { this._esam = value; }
        }

        // Check to see if Esam property is set
        internal bool IsSetEsam()
        {
            return this._esam != null;
        }

        /// <summary>
        /// Gets and sets the property ExtendedDataServices. If your source content has EIA-608
        /// Line 21 Data Services, enable this feature to specify what MediaConvert does with
        /// the Extended Data Services (XDS) packets. You can choose to pass through XDS packets,
        /// or remove them from the output. For more information about XDS, see EIA-608 Line Data
        /// Services, section 9.5.1.5 05h Content Advisory.
        /// </summary>
        public ExtendedDataServices ExtendedDataServices
        {
            get { return this._extendedDataServices; }
            set { this._extendedDataServices = value; }
        }

        // Check to see if ExtendedDataServices property is set
        internal bool IsSetExtendedDataServices()
        {
            return this._extendedDataServices != null;
        }

        /// <summary>
        /// Gets and sets the property FollowSource. Specify the input that MediaConvert references
        /// for your default output settings.  MediaConvert uses this input's Resolution, Frame
        /// rate, and Pixel aspect ratio for all  outputs that you don't manually specify different
        /// output settings for. Enabling this setting will disable "Follow source" for all other
        /// inputs.  If MediaConvert cannot follow your source, for example if you specify an
        /// audio-only input,  MediaConvert uses the first followable input instead. In your JSON
        /// job specification, enter an integer from 1 to 150 corresponding  to the order of your
        /// inputs.
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public int? FollowSource
        {
            get { return this._followSource; }
            set { this._followSource = value; }
        }

        // Check to see if FollowSource property is set
        internal bool IsSetFollowSource()
        {
            return this._followSource.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Inputs. Use Inputs to define source file used in the transcode
        /// job. There can be multiple inputs add in a job. These inputs will be concantenated
        /// together to create the output.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Input> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KantarWatermark. Use these settings only when you use Kantar
        /// watermarking. Specify the values that MediaConvert uses to generate and place Kantar
        /// watermarks in your output audio. These settings apply to every output in your job.
        /// In addition to specifying these values, you also need to store your Kantar credentials
        /// in AWS Secrets Manager. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/kantar-watermarking.html.
        /// </summary>
        public KantarWatermarkSettings KantarWatermark
        {
            get { return this._kantarWatermark; }
            set { this._kantarWatermark = value; }
        }

        // Check to see if KantarWatermark property is set
        internal bool IsSetKantarWatermark()
        {
            return this._kantarWatermark != null;
        }

        /// <summary>
        /// Gets and sets the property MotionImageInserter. Overlay motion graphics on top of
        /// your video. The motion graphics that you specify here appear on all outputs in all
        /// output groups. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/motion-graphic-overlay.html.
        /// </summary>
        public MotionImageInserter MotionImageInserter
        {
            get { return this._motionImageInserter; }
            set { this._motionImageInserter = value; }
        }

        // Check to see if MotionImageInserter property is set
        internal bool IsSetMotionImageInserter()
        {
            return this._motionImageInserter != null;
        }

        /// <summary>
        /// Gets and sets the property NielsenConfiguration. Settings for your Nielsen configuration.
        /// If you don't do Nielsen measurement and analytics, ignore these settings. When you
        /// enable Nielsen configuration, MediaConvert enables PCM to ID3 tagging for all outputs
        /// in the job.
        /// </summary>
        public NielsenConfiguration NielsenConfiguration
        {
            get { return this._nielsenConfiguration; }
            set { this._nielsenConfiguration = value; }
        }

        // Check to see if NielsenConfiguration property is set
        internal bool IsSetNielsenConfiguration()
        {
            return this._nielsenConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NielsenNonLinearWatermark. Ignore these settings unless
        /// you are using Nielsen non-linear watermarking. Specify the values that MediaConvert
        /// uses to generate and place Nielsen watermarks in your output audio. In addition to
        /// specifying these values, you also need to set up your cloud TIC server. These settings
        /// apply to every output in your job. The MediaConvert implementation is currently with
        /// the following Nielsen versions: Nielsen Watermark SDK Version 6.0.13 Nielsen NLM Watermark
        /// Engine Version 1.3.3 Nielsen Watermark Authenticator [SID_TIC] Version [7.0.0]
        /// </summary>
        public NielsenNonLinearWatermarkSettings NielsenNonLinearWatermark
        {
            get { return this._nielsenNonLinearWatermark; }
            set { this._nielsenNonLinearWatermark = value; }
        }

        // Check to see if NielsenNonLinearWatermark property is set
        internal bool IsSetNielsenNonLinearWatermark()
        {
            return this._nielsenNonLinearWatermark != null;
        }

        /// <summary>
        /// Gets and sets the property OutputGroups. Contains one group of settings for each set
        /// of outputs that share a common package type. All unpackaged files (MPEG-4, MPEG-2
        /// TS, Quicktime, MXF, and no container) are grouped in a single output group as well.
        /// Required in is a group of settings that apply to the whole group. This required object
        /// depends on the value you set for Type. Type, settings object pairs are as follows.
        /// * FILE_GROUP_SETTINGS, FileGroupSettings * HLS_GROUP_SETTINGS, HlsGroupSettings *
        /// DASH_ISO_GROUP_SETTINGS, DashIsoGroupSettings * MS_SMOOTH_GROUP_SETTINGS, MsSmoothGroupSettings
        /// * CMAF_GROUP_SETTINGS, CmafGroupSettings
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputGroup> OutputGroups
        {
            get { return this._outputGroups; }
            set { this._outputGroups = value; }
        }

        // Check to see if OutputGroups property is set
        internal bool IsSetOutputGroups()
        {
            return this._outputGroups != null && (this._outputGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimecodeConfig. These settings control how the service
        /// handles timecodes throughout the job. These settings don't affect input clipping.
        /// </summary>
        public TimecodeConfig TimecodeConfig
        {
            get { return this._timecodeConfig; }
            set { this._timecodeConfig = value; }
        }

        // Check to see if TimecodeConfig property is set
        internal bool IsSetTimecodeConfig()
        {
            return this._timecodeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TimedMetadataInsertion. Insert user-defined custom ID3
        /// metadata at timecodes that you specify. In each output that you want to include this
        /// metadata, you must set ID3 metadata to Passthrough.
        /// </summary>
        public TimedMetadataInsertion TimedMetadataInsertion
        {
            get { return this._timedMetadataInsertion; }
            set { this._timedMetadataInsertion = value; }
        }

        // Check to see if TimedMetadataInsertion property is set
        internal bool IsSetTimedMetadataInsertion()
        {
            return this._timedMetadataInsertion != null;
        }

    }
}