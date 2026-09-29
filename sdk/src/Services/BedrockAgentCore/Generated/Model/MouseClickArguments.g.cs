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
    /// Arguments for a mouse click action.
    /// </summary>
    public partial class MouseClickArguments
    {
        /// <summary>
        /// Gets and sets the property Button. 
        /// <para>
        /// The mouse button to use. Defaults to <c>LEFT</c>.
        /// </para>
        /// </summary>
        public MouseButton Button { get; set; }

        /// <summary>
        /// Checks to see if the Button property is set.
        /// </summary>
        internal bool IsSetButton() => this.Button != null;

        /// <summary>
        /// Gets and sets the property ClickCount. 
        /// <para>
        /// The number of clicks to perform. Valid range: 1–10. Defaults to 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? ClickCount { get; set; }

        /// <summary>
        /// Checks to see if the ClickCount property is set.
        /// </summary>
        internal bool IsSetClickCount() => this.ClickCount.HasValue;

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The X coordinate on screen where the click occurs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? X { get; set; }

        /// <summary>
        /// Checks to see if the X property is set.
        /// </summary>
        internal bool IsSetX() => this.X.HasValue;

        /// <summary>
        /// Gets and sets the property Y. 
        /// <para>
        /// The Y coordinate on screen where the click occurs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Y { get; set; }

        /// <summary>
        /// Checks to see if the Y property is set.
        /// </summary>
        internal bool IsSetY() => this.Y.HasValue;
    }
}
