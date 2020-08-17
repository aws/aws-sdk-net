/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Required when you set (Codec) under (VideoDescription)>(CodecSettings) to the value
    /// PRORES.
    /// </summary>
    public partial class ProresSettings
    {
        private ProresCodecProfile _codecProfile;
        private ProresFramerateControl _framerateControl;
        private ProresFramerateConversionAlgorithm _framerateConversionAlgorithm;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private ProresInterlaceMode _interlaceMode;
        private ProresParControl _parControl;
        private int? _parDenominator;
        private int? _parNumerator;
        private ProresSlowPal _slowPal;
        private ProresTelecine _telecine;

        /// <summary>
        /// Gets and sets the property CodecProfile. Use Profile (ProResCodecProfile) to specifiy
        /// the type of Apple ProRes codec to use for this output.
        /// </summary>
        public ProresCodecProfile CodecProfile
        {
            get { return this._codecProfile; }
            set { this._codecProfile = value; }
        }

        // Check to see if CodecProfile property is set
        internal bool IsSetCodecProfile()
        {
            return this._codecProfile != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateControl. If you are using the console, use the
        /// Framerate setting to specify the frame rate for this output. If you want to keep the
        /// same frame rate as the input video, choose Follow source. If you want to do frame
        /// rate conversion, choose a frame rate from the dropdown list or choose Custom. The
        /// framerates shown in the dropdown list are decimal approximations of fractions. If
        /// you choose Custom, specify your frame rate as a fraction. If you are creating your
        /// transcoding job specification as a JSON file without the console, use FramerateControl
        /// to specify which value the service uses for the frame rate for this output. Choose
        /// INITIALIZE_FROM_SOURCE if you want the service to use the frame rate from the input.
        /// Choose SPECIFIED if you want the service to use the frame rate you specify in the
        /// settings FramerateNumerator and FramerateDenominator.
        /// </summary>
        public ProresFramerateControl FramerateControl
        {
            get { return this._framerateControl; }
            set { this._framerateControl = value; }
        }

        // Check to see if FramerateControl property is set
        internal bool IsSetFramerateControl()
        {
            return this._framerateControl != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateConversionAlgorithm. Optional. Specify how the
        /// transcoder performs framerate conversion. The default behavior is to use duplicate
        /// drop conversion.
        /// </summary>
        public ProresFramerateConversionAlgorithm FramerateConversionAlgorithm
        {
            get { return this._framerateConversionAlgorithm; }
            set { this._framerateConversionAlgorithm = value; }
        }

        // Check to see if FramerateConversionAlgorithm property is set
        internal bool IsSetFramerateConversionAlgorithm()
        {
            return this._framerateConversionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateDenominator. Frame rate denominator.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int FramerateDenominator
        {
            get { return this._framerateDenominator.GetValueOrDefault(); }
            set { this._framerateDenominator = value; }
        }

        // Check to see if FramerateDenominator property is set
        internal bool IsSetFramerateDenominator()
        {
            return this._framerateDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FramerateNumerator. When you use the API for transcode
        /// jobs that use frame rate conversion, specify the frame rate as a fraction. For example,
        ///  24000 / 1001 = 23.976 fps. Use FramerateNumerator to specify the numerator of this
        /// fraction. In this example, use 24000 for the value of FramerateNumerator.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int FramerateNumerator
        {
            get { return this._framerateNumerator.GetValueOrDefault(); }
            set { this._framerateNumerator = value; }
        }

        // Check to see if FramerateNumerator property is set
        internal bool IsSetFramerateNumerator()
        {
            return this._framerateNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InterlaceMode. Use Interlace mode (InterlaceMode) to choose
        /// the scan line type for the output. * Top Field First (TOP_FIELD) and Bottom Field
        /// First (BOTTOM_FIELD) produce interlaced output with the entire output having the same
        /// field polarity (top or bottom first). * Follow, Default Top (FOLLOW_TOP_FIELD) and
        /// Follow, Default Bottom (FOLLOW_BOTTOM_FIELD) use the same field polarity as the source.
        /// Therefore, behavior depends on the input scan type.  - If the source is interlaced,
        /// the output will be interlaced with the same polarity as the source (it will follow
        /// the source). The output could therefore be a mix of "top field first" and "bottom
        /// field first".  - If the source is progressive, the output will be interlaced with
        /// "top field first" or "bottom field first" polarity, depending on which of the Follow
        /// options you chose.
        /// </summary>
        public ProresInterlaceMode InterlaceMode
        {
            get { return this._interlaceMode; }
            set { this._interlaceMode = value; }
        }

        // Check to see if InterlaceMode property is set
        internal bool IsSetInterlaceMode()
        {
            return this._interlaceMode != null;
        }

        /// <summary>
        /// Gets and sets the property ParControl. Optional. Specify how the service determines
        /// the pixel aspect ratio (PAR) for this output. The default behavior, Follow source
        /// (INITIALIZE_FROM_SOURCE), uses the PAR from your input video for your output. To specify
        /// a different PAR in the console, choose any value other than Follow source. To specify
        /// a different PAR by editing the JSON job specification, choose SPECIFIED. When you
        /// choose SPECIFIED for this setting, you must also specify values for the parNumerator
        /// and parDenominator settings.
        /// </summary>
        public ProresParControl ParControl
        {
            get { return this._parControl; }
            set { this._parControl = value; }
        }

        // Check to see if ParControl property is set
        internal bool IsSetParControl()
        {
            return this._parControl != null;
        }

        /// <summary>
        /// Gets and sets the property ParDenominator. Required when you set Pixel aspect ratio
        /// (parControl) to SPECIFIED. On the console, this corresponds to any value other than
        /// Follow source. When you specify an output pixel aspect ratio (PAR) that is different
        /// from your input video PAR, provide your output PAR as a ratio. For example, for D1/DV
        /// NTSC widescreen, you would specify the ratio 40:33. In this example, the value for
        /// parDenominator is 33.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int ParDenominator
        {
            get { return this._parDenominator.GetValueOrDefault(); }
            set { this._parDenominator = value; }
        }

        // Check to see if ParDenominator property is set
        internal bool IsSetParDenominator()
        {
            return this._parDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParNumerator. Required when you set Pixel aspect ratio
        /// (parControl) to SPECIFIED. On the console, this corresponds to any value other than
        /// Follow source. When you specify an output pixel aspect ratio (PAR) that is different
        /// from your input video PAR, provide your output PAR as a ratio. For example, for D1/DV
        /// NTSC widescreen, you would specify the ratio 40:33. In this example, the value for
        /// parNumerator is 40.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int ParNumerator
        {
            get { return this._parNumerator.GetValueOrDefault(); }
            set { this._parNumerator = value; }
        }

        // Check to see if ParNumerator property is set
        internal bool IsSetParNumerator()
        {
            return this._parNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SlowPal. Enables Slow PAL rate conversion. 23.976fps and
        /// 24fps input is relabeled as 25fps, and audio is sped up correspondingly.
        /// </summary>
        public ProresSlowPal SlowPal
        {
            get { return this._slowPal; }
            set { this._slowPal = value; }
        }

        // Check to see if SlowPal property is set
        internal bool IsSetSlowPal()
        {
            return this._slowPal != null;
        }

        /// <summary>
        /// Gets and sets the property Telecine. Only use Telecine (ProresTelecine) when you set
        /// Framerate (Framerate) to 29.970. Set Telecine (ProresTelecine) to Hard (hard) to produce
        /// a 29.97i output from a 23.976 input. Set it to Soft (soft) to produce 23.976 output
        /// and leave converstion to the player.
        /// </summary>
        public ProresTelecine Telecine
        {
            get { return this._telecine; }
            set { this._telecine = value; }
        }

        // Check to see if Telecine property is set
        internal bool IsSetTelecine()
        {
            return this._telecine != null;
        }

    }
}