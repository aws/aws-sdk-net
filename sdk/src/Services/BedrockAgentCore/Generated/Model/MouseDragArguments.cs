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
    /// Arguments for a mouse drag action.
    /// </summary>
    public partial class MouseDragArguments
    {
        private MouseButton _button;
        private int? _endx;
        private int? _endy;
        private int? _startx;
        private int? _starty;

        /// <summary>
        /// Gets and sets the property Button. 
        /// <para>
        /// The mouse button to use for the drag. Defaults to <c>LEFT</c>.
        /// </para>
        /// </summary>
        public MouseButton Button
        {
            get { return this._button; }
            set { this._button = value; }
        }

        // Check to see if Button property is set
        internal bool IsSetButton()
        {
            return this._button != null;
        }

        /// <summary>
        /// Gets and sets the property EndX. 
        /// <para>
        /// The ending X coordinate for the drag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EndX
        {
            get { return this._endx; }
            set { this._endx = value; }
        }

        // Check to see if EndX property is set
        internal bool IsSetEndX()
        {
            return this._endx.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndY. 
        /// <para>
        /// The ending Y coordinate for the drag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EndY
        {
            get { return this._endy; }
            set { this._endy = value; }
        }

        // Check to see if EndY property is set
        internal bool IsSetEndY()
        {
            return this._endy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartX. 
        /// <para>
        /// The starting X coordinate for the drag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? StartX
        {
            get { return this._startx; }
            set { this._startx = value; }
        }

        // Check to see if StartX property is set
        internal bool IsSetStartX()
        {
            return this._startx.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartY. 
        /// <para>
        /// The starting Y coordinate for the drag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? StartY
        {
            get { return this._starty; }
            set { this._starty = value; }
        }

        // Check to see if StartY property is set
        internal bool IsSetStartY()
        {
            return this._starty.HasValue; 
        }

    }
}