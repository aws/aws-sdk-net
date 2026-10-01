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
    /// Webvtt Destination Settings
    /// </summary>
    public partial class WebvttDestinationSettings
    {
        private TextCaptionPositionSettings _position;
        private WebvttDestinationStyleControl _styleControl;

        /// <summary>
        /// Gets and sets the property Position. Specifies the position of the output captions.
        /// Applies only when styleControl is set to manual.
        /// </summary>
        public TextCaptionPositionSettings Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property StyleControl. Controls whether the color and position of
        /// the source captions is passed through to the WebVTT output captions.  PASSTHROUGH
        /// - Valid only if the source captions are EMBEDDED, TELETEXT, or SMART SUBTITLES.  NO_STYLE_DATA
        /// - Don't pass through the style. The output captions will not contain any font styling
        /// information. MANUAL - Applies the specified styling and positioning. All other styling
        /// and positioning is given default values.
        /// </summary>
        public WebvttDestinationStyleControl StyleControl
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