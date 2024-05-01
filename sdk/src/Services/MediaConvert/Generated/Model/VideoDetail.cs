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
    /// Contains details about the output's video stream
    /// </summary>
    public partial class VideoDetail
    {
        private int? _heightInPx;
        private int? _widthInPx;

        /// <summary>
        /// Gets and sets the property HeightInPx. Height in pixels for the output
        /// </summary>
        public int? HeightInPx
        {
            get { return this._heightInPx; }
            set { this._heightInPx = value; }
        }

        // Check to see if HeightInPx property is set
        internal bool IsSetHeightInPx()
        {
            return this._heightInPx.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WidthInPx. Width in pixels for the output
        /// </summary>
        public int? WidthInPx
        {
            get { return this._widthInPx; }
            set { this._widthInPx = value; }
        }

        // Check to see if WidthInPx property is set
        internal bool IsSetWidthInPx()
        {
            return this._widthInPx.HasValue; 
        }

    }
}