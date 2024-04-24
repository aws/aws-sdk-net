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
    /// These settings relate to your MXF output container.
    /// </summary>
    public partial class MxfSettings
    {
        private MxfAfdSignaling _afdSignaling;
        private MxfProfile _profile;
        private MxfXavcProfileSettings _xavcProfileSettings;

        /// <summary>
        /// Gets and sets the property AfdSignaling. Optional. When you have AFD signaling set
        /// up in your output video stream, use this setting to choose whether to also include
        /// it in the MXF wrapper. Choose Don't copy to exclude AFD signaling from the MXF wrapper.
        /// Choose Copy from video stream to copy the AFD values from the video stream for this
        /// output to the MXF wrapper. Regardless of which option you choose, the AFD values remain
        /// in the video stream. Related settings: To set up your output to include or exclude
        /// AFD values, see AfdSignaling, under VideoDescription. On the console, find AFD signaling
        /// under the output's video encoding settings.
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

        /// <summary>
        /// Gets and sets the property Profile. Specify the MXF profile, also called shim, for
        /// this output. To automatically select a profile according to your output video codec
        /// and resolution, leave blank. For a list of codecs supported with each MXF profile,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/codecs-supported-with-each-mxf-profile.html.
        /// For more information about the automatic selection behavior, see https://docs.aws.amazon.com/mediaconvert/latest/ug/default-automatic-selection-of-mxf-profiles.html.
        /// </summary>
        public MxfProfile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

        /// <summary>
        /// Gets and sets the property XavcProfileSettings. Specify the XAVC profile settings
        /// for MXF outputs when you set your MXF profile to XAVC.
        /// </summary>
        public MxfXavcProfileSettings XavcProfileSettings
        {
            get { return this._xavcProfileSettings; }
            set { this._xavcProfileSettings = value; }
        }

        // Check to see if XavcProfileSettings property is set
        internal bool IsSetXavcProfileSettings()
        {
            return this._xavcProfileSettings != null;
        }

    }
}