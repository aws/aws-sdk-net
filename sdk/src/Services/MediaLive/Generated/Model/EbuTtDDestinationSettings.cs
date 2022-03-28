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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Ebu Tt DDestination Settings
    /// </summary>
    public partial class EbuTtDDestinationSettings
    {
        private string _copyrightHolder;
        private EbuTtDFillLineGapControl _fillLineGap;
        private string _fontFamily;
        private EbuTtDDestinationStyleControl _styleControl;

        /// <summary>
        /// Gets and sets the property CopyrightHolder. Complete this field if you want to include
        /// the name of the copyright holder in the copyright tag in the captions metadata.
        /// </summary>
        [AWSProperty(Max=1000)]
        public string CopyrightHolder
        {
            get { return this._copyrightHolder; }
            set { this._copyrightHolder = value; }
        }

        // Check to see if CopyrightHolder property is set
        internal bool IsSetCopyrightHolder()
        {
            return this._copyrightHolder != null;
        }

        /// <summary>
        /// Gets and sets the property FillLineGap. Specifies how to handle the gap between the
        /// lines (in multi-line captions).- enabled: Fill with the captions background color
        /// (as specified in the input captions).- disabled: Leave the gap unfilled.
        /// </summary>
        public EbuTtDFillLineGapControl FillLineGap
        {
            get { return this._fillLineGap; }
            set { this._fillLineGap = value; }
        }

        // Check to see if FillLineGap property is set
        internal bool IsSetFillLineGap()
        {
            return this._fillLineGap != null;
        }

        /// <summary>
        /// Gets and sets the property FontFamily. Specifies the font family to include in the
        /// font data attached to the EBU-TT captions. Valid only if styleControl is set to include.
        /// If you leave this field empty, the font family is set to "monospaced". (If styleControl
        /// is set to exclude, the font family is always set to "monospaced".)You specify only
        /// the font family. All other style information (color, bold, position and so on) is
        /// copied from the input captions. The size is always set to 100% to allow the downstream
        /// player to choose the size.- Enter a list of font families, as a comma-separated list
        /// of font names, in order of preference. The name can be a font family (such as “Arial”),
        /// or a generic font family (such as “serif”), or “default” (to let the downstream player
        /// choose the font).- Leave blank to set the family to “monospace”.
        /// </summary>
        public string FontFamily
        {
            get { return this._fontFamily; }
            set { this._fontFamily = value; }
        }

        // Check to see if FontFamily property is set
        internal bool IsSetFontFamily()
        {
            return this._fontFamily != null;
        }

        /// <summary>
        /// Gets and sets the property StyleControl. Specifies the style information (font color,
        /// font position, and so on) to include in the font data that is attached to the EBU-TT
        /// captions.- include: Take the style information (font color, font position, and so
        /// on) from the source captions and include that information in the font data attached
        /// to the EBU-TT captions. This option is valid only if the source captions are Embedded
        /// or Teletext.- exclude: In the font data attached to the EBU-TT captions, set the font
        /// family to "monospaced". Do not include any other style information.
        /// </summary>
        public EbuTtDDestinationStyleControl StyleControl
        {
            get { return this._styleControl; }
            set { this._styleControl = value; }
        }

        // Check to see if StyleControl property is set
        internal bool IsSetStyleControl()
        {
            return this._styleControl != null;
        }

    }
}