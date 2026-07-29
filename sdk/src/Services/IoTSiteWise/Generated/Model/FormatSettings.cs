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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// &lt;p&gt;Contains the output format configuration for video processing.&lt;/p&gt;
    /// </summary>
    public partial class FormatSettings
    {
        private int? _framesPerSecond;
        private int? _heightInPixels;
        private int? _widthInPixels;

        /// <summary>
        /// Gets and sets the property FramesPerSecond. &lt;p&gt;The target frame rate for the
        /// output.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Min=1)]
        public int? FramesPerSecond
        {
            get { return this._framesPerSecond; }
            set { this._framesPerSecond = value; }
        }

        // Check to see if FramesPerSecond property is set
        internal bool IsSetFramesPerSecond()
        {
            return this._framesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeightInPixels. &lt;p&gt;The target height of the output,
        /// in pixels.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Min=1)]
        public int? HeightInPixels
        {
            get { return this._heightInPixels; }
            set { this._heightInPixels = value; }
        }

        // Check to see if HeightInPixels property is set
        internal bool IsSetHeightInPixels()
        {
            return this._heightInPixels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WidthInPixels. &lt;p&gt;The target width of the output,
        /// in pixels.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Min=1)]
        public int? WidthInPixels
        {
            get { return this._widthInPixels; }
            set { this._widthInPixels = value; }
        }

        // Check to see if WidthInPixels property is set
        internal bool IsSetWidthInPixels()
        {
            return this._widthInPixels.HasValue; 
        }

    }
}