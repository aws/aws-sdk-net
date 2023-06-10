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
    /// If your input captions are SCC, SMI, SRT, STL, TTML, WebVTT, or IMSC 1.1 in an xml
    /// file, specify the URI of the input caption source file. If your caption source is
    /// IMSC in an IMF package, use TrackSourceSettings instead of FileSoureSettings.
    /// </summary>
    public partial class FileSourceSettings
    {
        private FileSourceConvert608To708 _convert608To708;
        private CaptionSourceConvertPaintOnToPopOn _convertPaintToPop;
        private CaptionSourceFramerate _framerate;
        private string _sourceFile;
        private int? _timeDelta;
        private FileSourceTimeDeltaUnits _timeDeltaUnits;

        /// <summary>
        /// Gets and sets the property Convert608To708. Specify whether this set of input captions
        /// appears in your outputs in both 608 and 708 format. If you choose Upconvert (UPCONVERT),
        /// MediaConvert includes the captions data in two ways: it passes the 608 data through
        /// using the 608 compatibility bytes fields of the 708 wrapper, and it also translates
        /// the 608 data into 708.
        /// </summary>
        public FileSourceConvert608To708 Convert608To708
        {
            get { return this._convert608To708; }
            set { this._convert608To708 = value; }
        }

        // Check to see if Convert608To708 property is set
        internal bool IsSetConvert608To708()
        {
            return this._convert608To708 != null;
        }

        /// <summary>
        /// Gets and sets the property ConvertPaintToPop. Choose the presentation style of your
        /// input SCC captions. To use the same presentation style as your input: Keep the default
        /// value, Disabled. To convert paint-on captions to pop-on: Choose Enabled. We also recommend
        /// that you choose Enabled if you notice additional repeated lines in your output captions.
        /// </summary>
        public CaptionSourceConvertPaintOnToPopOn ConvertPaintToPop
        {
            get { return this._convertPaintToPop; }
            set { this._convertPaintToPop = value; }
        }

        // Check to see if ConvertPaintToPop property is set
        internal bool IsSetConvertPaintToPop()
        {
            return this._convertPaintToPop != null;
        }

        /// <summary>
        /// Gets and sets the property Framerate. Ignore this setting unless your input captions
        /// format is SCC. To have the service compensate for differing frame rates between your
        /// input captions and input video, specify the frame rate of the captions file. Specify
        /// this value as a fraction. When you work directly in your JSON job specification, use
        /// the settings framerateNumerator and framerateDenominator. For example, you might specify
        /// 24 / 1 for 24 fps, 25 / 1 for 25 fps, 24000 / 1001 for 23.976 fps, or 30000 / 1001
        /// for 29.97 fps.
        /// </summary>
        public CaptionSourceFramerate Framerate
        {
            get { return this._framerate; }
            set { this._framerate = value; }
        }

        // Check to see if Framerate property is set
        internal bool IsSetFramerate()
        {
            return this._framerate != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFile. External caption file used for loading captions.
        /// Accepted file extensions are 'scc', 'ttml', 'dfxp', 'stl', 'srt', 'xml', 'smi', 'webvtt',
        /// and 'vtt'.
        /// </summary>
        [AWSProperty(Min=14)]
        public string SourceFile
        {
            get { return this._sourceFile; }
            set { this._sourceFile = value; }
        }

        // Check to see if SourceFile property is set
        internal bool IsSetSourceFile()
        {
            return this._sourceFile != null;
        }

        /// <summary>
        /// Gets and sets the property TimeDelta. Optional. Use this setting when you need to
        /// adjust the sync between your sidecar captions and your video. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/time-delta-use-cases.html.
        /// Enter a positive or negative number to modify the times in the captions file. For
        /// example, type 15 to add 15 seconds to all the times in the captions file. Type -5
        /// to subtract 5 seconds from the times in the captions file. You can optionally specify
        /// your time delta in milliseconds instead of seconds. When you do so, set the related
        /// setting, Time delta units (TimeDeltaUnits) to Milliseconds (MILLISECONDS). Note that,
        /// when you specify a time delta for timecode-based caption sources, such as SCC and
        /// STL, and your time delta isn't a multiple of the input frame rate, MediaConvert snaps
        /// the captions to the nearest frame. For example, when your input video frame rate is
        /// 25 fps and you specify 1010ms for time delta, MediaConvert delays your captions by
        /// 1000 ms.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int TimeDelta
        {
            get { return this._timeDelta.GetValueOrDefault(); }
            set { this._timeDelta = value; }
        }

        // Check to see if TimeDelta property is set
        internal bool IsSetTimeDelta()
        {
            return this._timeDelta.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeDeltaUnits. When you use the setting Time delta (TimeDelta)
        /// to adjust the sync between your sidecar captions and your video, use this setting
        /// to specify the units for the delta that you specify. When you don't specify a value
        /// for Time delta units (TimeDeltaUnits), MediaConvert uses seconds by default.
        /// </summary>
        public FileSourceTimeDeltaUnits TimeDeltaUnits
        {
            get { return this._timeDeltaUnits; }
            set { this._timeDeltaUnits = value; }
        }

        // Check to see if TimeDeltaUnits property is set
        internal bool IsSetTimeDeltaUnits()
        {
            return this._timeDeltaUnits != null;
        }

    }
}