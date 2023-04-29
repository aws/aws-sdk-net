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
    /// These settings relate to your QuickTime MOV output container.
    /// </summary>
    public partial class MovSettings
    {
        private MovClapAtom _clapAtom;
        private MovCslgAtom _cslgAtom;
        private MovMpeg2FourCCControl _mpeg2FourCCControl;
        private MovPaddingControl _paddingControl;
        private MovReference _reference;

        /// <summary>
        /// Gets and sets the property ClapAtom. When enabled, include 'clap' atom if appropriate
        /// for the video output settings.
        /// </summary>
        public MovClapAtom ClapAtom
        {
            get { return this._clapAtom; }
            set { this._clapAtom = value; }
        }

        // Check to see if ClapAtom property is set
        internal bool IsSetClapAtom()
        {
            return this._clapAtom != null;
        }

        /// <summary>
        /// Gets and sets the property CslgAtom. When enabled, file composition times will start
        /// at zero, composition times in the 'ctts' (composition time to sample) box for B-frames
        /// will be negative, and a 'cslg' (composition shift least greatest) box will be included
        /// per 14496-1 amendment 1. This improves compatibility with Apple players and tools.
        /// </summary>
        public MovCslgAtom CslgAtom
        {
            get { return this._cslgAtom; }
            set { this._cslgAtom = value; }
        }

        // Check to see if CslgAtom property is set
        internal bool IsSetCslgAtom()
        {
            return this._cslgAtom != null;
        }

        /// <summary>
        /// Gets and sets the property Mpeg2FourCCControl. When set to XDCAM, writes MPEG2 video
        /// streams into the QuickTime file using XDCAM fourcc codes. This increases compatibility
        /// with Apple editors and players, but may decrease compatibility with other players.
        /// Only applicable when the video codec is MPEG2.
        /// </summary>
        public MovMpeg2FourCCControl Mpeg2FourCCControl
        {
            get { return this._mpeg2FourCCControl; }
            set { this._mpeg2FourCCControl = value; }
        }

        // Check to see if Mpeg2FourCCControl property is set
        internal bool IsSetMpeg2FourCCControl()
        {
            return this._mpeg2FourCCControl != null;
        }

        /// <summary>
        /// Gets and sets the property PaddingControl. Unless you need Omneon compatibility: Keep
        /// the default value, None. To make this output compatible with Omneon: Choose Omneon.
        /// When you do, MediaConvert increases the length of the 'elst' edit list atom. Note
        /// that this might cause file rejections when a recipient of the output file doesn't
        /// expect this extra padding.
        /// </summary>
        public MovPaddingControl PaddingControl
        {
            get { return this._paddingControl; }
            set { this._paddingControl = value; }
        }

        // Check to see if PaddingControl property is set
        internal bool IsSetPaddingControl()
        {
            return this._paddingControl != null;
        }

        /// <summary>
        /// Gets and sets the property Reference. Always keep the default value (SELF_CONTAINED)
        /// for this setting.
        /// </summary>
        public MovReference Reference
        {
            get { return this._reference; }
            set { this._reference = value; }
        }

        // Check to see if Reference property is set
        internal bool IsSetReference()
        {
            return this._reference != null;
        }

    }
}