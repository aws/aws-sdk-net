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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Ebu Tt DDestination Settings
    /// </summary>
    public partial class EbuTtDDestinationSettings
    {
        private string _copyrightHolder;
        private int? _defaultFontSize;
        private int? _defaultLineHeight;
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
        /// Gets and sets the property DefaultFontSize. Specifies the default font size as a percentage
        /// of the computed cell size. Valid only if the defaultLineHeight is also set. If you
        /// leave this field empty, the default font size is 80% of the cell size.
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
        public int? DefaultFontSize
        {
            get { return this._defaultFontSize; }
            set { this._defaultFontSize = value; }
        }

        // Check to see if DefaultFontSize property is set
        internal bool IsSetDefaultFontSize()
        {
            return this._defaultFontSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultLineHeight. Documentation update needed
        /// </summary>
        [AWSProperty(Min=80, Max=800)]
        public int? DefaultLineHeight
        {
            get { return this._defaultLineHeight; }
            set { this._defaultLineHeight = value; }
        }

        // Check to see if DefaultLineHeight property is set
        internal bool IsSetDefaultLineHeight()
        {
            return this._defaultLineHeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FillLineGap. Specifies how to handle the gap between the
        /// lines (in multi-line captions). ENABLED: Fill with the captions background color (as
        /// specified in the input captions). DISABLED: Leave the gap unfilled
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
        /// font data attached to the EBU-TT captions. Valid only if style_control is set to include.
        /// (If style_control is set to exclude, the font family is always set to monospaced.)
        /// Enter a list of font families, as a comma-separated list of font names, in order of
        /// preference. The name can be a font family (such as Arial), or a generic font family
        /// (such as serif), or default (to let the downstream player choose the font). Or leave
        /// blank to set the family to monospace. Note that you can specify only the font family.
        /// All other style information (color, bold, position and so on) is copied from the input
        /// captions. The size is always set to 100% to allow the downstream player to choose
        /// the size.
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
        /// Gets and sets the property StyleControl. Specifies the style information to include
        /// in the font data that is attached to the EBU-TT captions. INCLUDE: Take the style
        /// information from the source captions and include that information in the font data
        /// attached to the EBU-TT captions. This option is valid only if the source captions
        /// are Embedded or Teletext. EXCLUDE: Set the font family to monospaced. Do not include
        /// any other style information.
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