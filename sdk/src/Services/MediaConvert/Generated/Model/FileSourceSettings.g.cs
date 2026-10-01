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
    /// If your input captions are SCC, SMI, SRT, STL, TTML, WebVTT, or IMSC 1.1 in an xml
    /// file, specify the URI of the input caption source file. If your caption source is
    /// IMSC in an IMF package, use TrackSourceSettings instead of FileSoureSettings.
    /// </summary>
    public partial class FileSourceSettings
    {
        /// <summary>
        /// Gets and sets the property ByteRateLimit. Choose whether to limit the byte rate at
        /// which your SCC input captions are inserted into your output. To not limit the caption
        /// rate: We recommend that you keep the default value, Disabled. MediaConvert inserts
        /// captions in your output according to the byte rates listed in the EIA-608 specification,
        /// typically 2 or 3 caption bytes per frame depending on your output frame rate. To limit
        /// your output caption rate: Choose Enabled. Choose this option if your downstream systems
        /// require a maximum of 2 caption bytes per frame. Note that this setting has no effect
        /// when your output frame rate is 30 or 60.
        /// </summary>
        public CaptionSourceByteRateLimit ByteRateLimit { get; set; }

        /// <summary>
        /// Checks to see if the ByteRateLimit property is set.
        /// </summary>
        internal bool IsSetByteRateLimit() => this.ByteRateLimit != null;

        /// <summary>
        /// Gets and sets the property Convert608To708. Specify whether this set of input captions
        /// appears in your outputs in both 608 and 708 format. If you choose Upconvert, MediaConvert
        /// includes the captions data in two ways: it passes the 608 data through using the 608
        /// compatibility bytes fields of the 708 wrapper, and it also translates the 608 data
        /// into 708.
        /// </summary>
        public FileSourceConvert608To708 Convert608To708 { get; set; }

        /// <summary>
        /// Checks to see if the Convert608To708 property is set.
        /// </summary>
        internal bool IsSetConvert608To708() => this.Convert608To708 != null;

        /// <summary>
        /// Gets and sets the property ConvertPaintToPop. Choose the presentation style of your
        /// input SCC captions. To use the same presentation style as your input: Keep the default
        /// value, Disabled. To convert paint-on captions to pop-on: Choose Enabled. We also recommend
        /// that you choose Enabled if you notice additional repeated lines in your output captions.
        /// </summary>
        public CaptionSourceConvertPaintOnToPopOn ConvertPaintToPop { get; set; }

        /// <summary>
        /// Checks to see if the ConvertPaintToPop property is set.
        /// </summary>
        internal bool IsSetConvertPaintToPop() => this.ConvertPaintToPop != null;

        /// <summary>
        /// Gets and sets the property Framerate. Ignore this setting unless your input captions
        /// format is SCC. To have the service compensate for differing frame rates between your
        /// input captions and input video, specify the frame rate of the captions file. Specify
        /// this value as a fraction. For example, you might specify 24 / 1 for 24 fps, 25 / 1
        /// for 25 fps, 24000 / 1001 for 23.976 fps, or 30000 / 1001 for 29.97 fps.
        /// </summary>
        public CaptionSourceFramerate Framerate { get; set; }

        /// <summary>
        /// Checks to see if the Framerate property is set.
        /// </summary>
        internal bool IsSetFramerate() => this.Framerate != null;

        /// <summary>
        /// Gets and sets the property SourceFile. External caption file used for loading captions.
        /// Accepted file extensions are 'scc', 'ttml', 'dfxp', 'stl', 'srt', 'xml', 'smi', 'webvtt',
        /// and 'vtt'.
        /// </summary>
        [AWSProperty(Min = 14)]
        public string SourceFile { get; set; }

        /// <summary>
        /// Checks to see if the SourceFile property is set.
        /// </summary>
        internal bool IsSetSourceFile() => this.SourceFile != null;

        /// <summary>
        /// Gets and sets the property TimeDelta. Optional. Use this setting when you need to
        /// adjust the sync between your sidecar captions and your video. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/time-delta-use-cases.html.
        /// Enter a positive or negative number to modify the times in the captions file. For
        /// example, type 15 to add 15 seconds to all the times in the captions file. Type -5
        /// to subtract 5 seconds from the times in the captions file. You can optionally specify
        /// your time delta in milliseconds instead of seconds. When you do so, set the related
        /// setting, Time delta units to Milliseconds. Note that, when you specify a time delta
        /// for timecode-based caption sources, such as SCC and STL, and your time delta isn't
        /// a multiple of the input frame rate, MediaConvert snaps the captions to the nearest
        /// frame. For example, when your input video frame rate is 25 fps and you specify 1010ms
        /// for time delta, MediaConvert delays your captions by 1000 ms.
        /// </summary>
        [AWSProperty(Min = -2147483648, Max = 2147483647)]
        public int? TimeDelta { get; set; }

        /// <summary>
        /// Checks to see if the TimeDelta property is set.
        /// </summary>
        internal bool IsSetTimeDelta() => this.TimeDelta.HasValue;

        /// <summary>
        /// Gets and sets the property TimeDeltaUnits. When you use the setting Time delta to
        /// adjust the sync between your sidecar captions and your video, use this setting to
        /// specify the units for the delta that you specify. When you don't specify a value for
        /// Time delta units, MediaConvert uses seconds by default.
        /// </summary>
        public FileSourceTimeDeltaUnits TimeDeltaUnits { get; set; }

        /// <summary>
        /// Checks to see if the TimeDeltaUnits property is set.
        /// </summary>
        internal bool IsSetTimeDeltaUnits() => this.TimeDeltaUnits != null;

        /// <summary>
        /// Gets and sets the property UpconvertSTLToTeletext. Specify whether this set of input
        /// captions appears in your outputs in both STL and Teletext format. If you choose Upconvert,
        /// MediaConvert includes the captions data in two ways: it passes the STL data through
        /// using the Teletext compatibility bytes fields of the Teletext wrapper, and it also
        /// translates the STL data into Teletext.
        /// </summary>
        public CaptionSourceUpconvertSTLToTeletext UpconvertSTLToTeletext { get; set; }

        /// <summary>
        /// Checks to see if the UpconvertSTLToTeletext property is set.
        /// </summary>
        internal bool IsSetUpconvertSTLToTeletext() => this.UpconvertSTLToTeletext != null;
    }
}
