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
    /// Embedded Caption Position Settings
    /// </summary>
    public partial class EmbeddedCaptionPositionSettings
    {
        private int? _yPositionLine;

        /// <summary>
        /// Gets and sets the property YPositionLine. Specifies the vertical position of the caption
        /// as a row counted from the top of the output. Row 1 is the topmost row. Acceptable
        /// values are 1 through 15.
        /// </summary>
        public int? YPositionLine
        {
            get { return this._yPositionLine; }
            set { this._yPositionLine = value; }
        }

        // Check to see if YPositionLine property is set
        internal bool IsSetYPositionLine()
        {
            return this._yPositionLine.HasValue; 
        }

    }
}