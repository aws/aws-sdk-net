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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The configuration that defines the dimensions of a browser viewport in a browser session.
    /// The viewport determines the visible area of web content and affects how web pages
    /// are rendered and displayed. Proper viewport configuration ensures that web content
    /// is displayed correctly for the agent's browsing tasks.
    /// </summary>
    public partial class ViewPort
    {
        private int? _height;
        private int? _width;

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of the viewport in pixels. This value determines the vertical dimension
        /// of the visible area. Valid values range from 600 to 1080 pixels.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=240, Max=2160)]
        public int? Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of the viewport in pixels. This value determines the horizontal dimension
        /// of the visible area. Valid values range from 800 to 1920 pixels.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=320, Max=3840)]
        public int? Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}