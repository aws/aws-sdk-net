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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Button. 
        /// <para>
        /// The mouse button to use for the drag. Defaults to <c>LEFT</c>.
        /// </para>
        /// </summary>
        public MouseButton Button { get; set; }

        /// <summary>
        /// Checks to see if the Button property is set.
        /// </summary>
        internal bool IsSetButton() => this.Button != null;

        /// <summary>
        /// Gets and sets the property EndX. 
        /// <para>
        /// The ending X coordinate for the drag.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EndX { get; set; }

        /// <summary>
        /// Checks to see if the EndX property is set.
        /// </summary>
        internal bool IsSetEndX() => this.EndX.HasValue;

        /// <summary>
        /// Gets and sets the property EndY. 
        /// <para>
        /// The ending Y coordinate for the drag.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EndY { get; set; }

        /// <summary>
        /// Checks to see if the EndY property is set.
        /// </summary>
        internal bool IsSetEndY() => this.EndY.HasValue;

        /// <summary>
        /// Gets and sets the property StartX. 
        /// <para>
        /// The starting X coordinate for the drag.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? StartX { get; set; }

        /// <summary>
        /// Checks to see if the StartX property is set.
        /// </summary>
        internal bool IsSetStartX() => this.StartX.HasValue;

        /// <summary>
        /// Gets and sets the property StartY. 
        /// <para>
        /// The starting Y coordinate for the drag.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? StartY { get; set; }

        /// <summary>
        /// Checks to see if the StartY property is set.
        /// </summary>
        internal bool IsSetStartY() => this.StartY.HasValue;
    }
}
