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
    /// MXF settings
    /// </summary>
    public partial class MxfSettings
    {
        private MxfAfdSignaling _afdSignaling;

        /// <summary>
        /// Gets and sets the property AfdSignaling. Optional. When you have AFD signaling set
        /// up in your output video stream, use this setting to choose whether to also include
        /// it in the MXF wrapper. Choose Don't copy (NO_COPY) to exclude AFD signaling from the
        /// MXF wrapper. Choose Copy from video stream (COPY_FROM_VIDEO) to copy the AFD values
        /// from the video stream for this output to the MXF wrapper. Regardless of which option
        /// you choose, the AFD values remain in the video stream. Related settings: To set up
        /// your output to include or exclude AFD values, see AfdSignaling, under VideoDescription.
        /// On the console, find AFD signaling under the output's video encoding settings.
        /// </summary>
        public MxfAfdSignaling AfdSignaling
        {
            get { return this._afdSignaling; }
            set { this._afdSignaling = value; }
        }

        // Check to see if AfdSignaling property is set
        internal bool IsSetAfdSignaling()
        {
            return this._afdSignaling != null;
        }

    }
}