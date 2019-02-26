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
        /// Gets and sets the property ColorSpace.
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
        /// Gets and sets the property ColorSpaceUsage.
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
        /// Gets and sets the property Hdr10Metadata.
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
        /// Gets and sets the property Rotate.
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