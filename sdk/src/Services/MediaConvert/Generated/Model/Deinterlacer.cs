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
    /// Settings for deinterlacer
    /// </summary>
    public partial class Deinterlacer
    {
        private DeinterlaceAlgorithm _algorithm;
        private DeinterlacerControl _control;
        private DeinterlacerMode _mode;

        /// <summary>
        /// Gets and sets the property Algorithm. Only applies when you set Deinterlacer (DeinterlaceMode)
        /// to Deinterlace (DEINTERLACE) or Adaptive (ADAPTIVE). Motion adaptive interpolate (INTERPOLATE)
        /// produces sharper pictures, while blend (BLEND) produces smoother motion. Use (INTERPOLATE_TICKER)
        /// OR (BLEND_TICKER) if your source file includes a ticker, such as a scrolling headline
        /// at the bottom of the frame.
        /// </summary>
        public DeinterlaceAlgorithm Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Control. - When set to NORMAL (default), the deinterlacer
        /// does not convert frames that are tagged in metadata as progressive. It will only convert
        /// those that are tagged as some other type. - When set to FORCE_ALL_FRAMES, the deinterlacer
        /// converts every frame to progressive - even those that are already tagged as progressive.
        /// Turn Force mode on only if there is a good chance that the metadata has tagged frames
        /// as progressive when they are not progressive. Do not turn on otherwise; processing
        /// frames that are already progressive into progressive will probably result in lower
        /// quality video.
        /// </summary>
        public DeinterlacerControl Control
        {
            get { return this._control; }
            set { this._control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this._control != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. Use Deinterlacer (DeinterlaceMode) to choose how
        /// the service will do deinterlacing. Default is Deinterlace. - Deinterlace converts
        /// interlaced to progressive. - Inverse telecine converts Hard Telecine 29.97i to progressive
        /// 23.976p. - Adaptive auto-detects and converts to progressive.
        /// </summary>
        public DeinterlacerMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}