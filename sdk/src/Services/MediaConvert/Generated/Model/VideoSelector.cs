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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Selector for video.
    /// </summary>
    public partial class VideoSelector
    {
        private ColorSpace _colorSpace;
        private ColorSpaceUsage _colorSpaceUsage;
        private Hdr10Metadata _hdr10Metadata;
        private int? _pid;
        private int? _programNumber;
        private InputRotate _rotate;

        /// <summary>
        /// Gets and sets the property ColorSpace. If your input video has accurate color space
        /// metadata, or if you don't know about color space, leave this set to the default value
        /// FOLLOW. The service will automatically detect your input color space. If your input
        /// video has metadata indicating the wrong color space, or if your input video is missing
        /// color space metadata that should be there, specify the accurate color space here.
        /// If you choose HDR10, you can also correct inaccurate color space coefficients, using
        /// the HDR master display information controls. You must also set Color space usage (ColorSpaceUsage)
        /// to FORCE for the service to use these values.
        /// </summary>
        public ColorSpace ColorSpace
        {
            get { return this._colorSpace; }
            set { this._colorSpace = value; }
        }

        // Check to see if ColorSpace property is set
        internal bool IsSetColorSpace()
        {
            return this._colorSpace != null;
        }

        /// <summary>
        /// Gets and sets the property ColorSpaceUsage. There are two sources for color metadata,
        /// the input file and the job configuration (in the Color space and HDR master display
        /// informaiton settings). The Color space usage setting controls which takes precedence.
        /// FORCE: The system will use color metadata supplied by user, if any. If the user does
        /// not supply color metadata, the system will use data from the source. FALLBACK: The
        /// system will use color metadata from the source. If source has no color metadata, the
        /// system will use user-supplied color metadata values if available.
        /// </summary>
        public ColorSpaceUsage ColorSpaceUsage
        {
            get { return this._colorSpaceUsage; }
            set { this._colorSpaceUsage = value; }
        }

        // Check to see if ColorSpaceUsage property is set
        internal bool IsSetColorSpaceUsage()
        {
            return this._colorSpaceUsage != null;
        }

        /// <summary>
        /// Gets and sets the property Hdr10Metadata. Use the "HDR master display information"
        /// (Hdr10Metadata) settings to correct HDR metadata or to provide missing metadata. These
        /// values vary depending on the input video and must be provided by a color grader. Range
        /// is 0 to 50,000; each increment represents 0.00002 in CIE1931 color coordinate. Note
        /// that these settings are not color correction. Note that if you are creating HDR outputs
        /// inside of an HLS CMAF package, to comply with the Apple specification, you must use
        /// the following settings. Set "MP4 packaging type" (writeMp4PackagingType) to HVC1 (HVC1).
        /// Set "Profile" (H265Settings > codecProfile) to Main10/High (MAIN10_HIGH). Set "Level"
        /// (H265Settings > codecLevel) to 5 (LEVEL_5).
        /// </summary>
        public Hdr10Metadata Hdr10Metadata
        {
            get { return this._hdr10Metadata; }
            set { this._hdr10Metadata = value; }
        }

        // Check to see if Hdr10Metadata property is set
        internal bool IsSetHdr10Metadata()
        {
            return this._hdr10Metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Pid. Use PID (Pid) to select specific video data from an
        /// input file. Specify this value as an integer; the system automatically converts it
        /// to the hexidecimal value. For example, 257 selects PID 0x101. A PID, or packet identifier,
        /// is an identifier for a set of data in an MPEG-2 transport stream container.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int Pid
        {
            get { return this._pid.GetValueOrDefault(); }
            set { this._pid = value; }
        }

        // Check to see if Pid property is set
        internal bool IsSetPid()
        {
            return this._pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgramNumber. Selects a specific program from within a
        /// multi-program transport stream. Note that Quad 4K is not currently supported.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
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
        /// Gets and sets the property Rotate. Use Rotate (InputRotate) to specify how the service
        /// rotates your video. You can choose automatic rotation or specify a rotation. You can
        /// specify a clockwise rotation of 0, 90, 180, or 270 degrees. If your input video container
        /// is .mov or .mp4 and your input has rotation metadata, you can choose Automatic to
        /// have the service rotate your video according to the rotation specified in the metadata.
        /// The rotation must be within one degree of 90, 180, or 270 degrees. If the rotation
        /// metadata specifies any other rotation, the service will default to no rotation. By
        /// default, the service does no rotation, even if your input video has rotation metadata.
        /// The service doesn't pass through rotation metadata.
        /// </summary>
        public InputRotate Rotate
        {
            get { return this._rotate; }
            set { this._rotate = value; }
        }

        // Check to see if Rotate property is set
        internal bool IsSetRotate()
        {
            return this._rotate != null;
        }

    }
}