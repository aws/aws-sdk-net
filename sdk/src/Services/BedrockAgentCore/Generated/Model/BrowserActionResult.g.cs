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
    /// The result of a browser action execution. Exactly one member is set, matching the
    /// action that was performed.
    /// </summary>
    public partial class BrowserActionResult
    {
        /// <summary>
        /// Gets and sets the property KeyPress. 
        /// <para>
        /// The result of a key press action.
        /// </para>
        /// </summary>
        public KeyPressResult KeyPress { get; set; }

        /// <summary>
        /// Checks to see if the KeyPress property is set.
        /// </summary>
        internal bool IsSetKeyPress() => this.KeyPress != null;

        /// <summary>
        /// Gets and sets the property KeyShortcut. 
        /// <para>
        /// The result of a key shortcut action.
        /// </para>
        /// </summary>
        public KeyShortcutResult KeyShortcut { get; set; }

        /// <summary>
        /// Checks to see if the KeyShortcut property is set.
        /// </summary>
        internal bool IsSetKeyShortcut() => this.KeyShortcut != null;

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        /// The result of a key type action.
        /// </para>
        /// </summary>
        public KeyTypeResult KeyType { get; set; }

        /// <summary>
        /// Checks to see if the KeyType property is set.
        /// </summary>
        internal bool IsSetKeyType() => this.KeyType != null;

        /// <summary>
        /// Gets and sets the property MouseClick. 
        /// <para>
        /// The result of a mouse click action.
        /// </para>
        /// </summary>
        public MouseClickResult MouseClick { get; set; }

        /// <summary>
        /// Checks to see if the MouseClick property is set.
        /// </summary>
        internal bool IsSetMouseClick() => this.MouseClick != null;

        /// <summary>
        /// Gets and sets the property MouseDrag. 
        /// <para>
        /// The result of a mouse drag action.
        /// </para>
        /// </summary>
        public MouseDragResult MouseDrag { get; set; }

        /// <summary>
        /// Checks to see if the MouseDrag property is set.
        /// </summary>
        internal bool IsSetMouseDrag() => this.MouseDrag != null;

        /// <summary>
        /// Gets and sets the property MouseMove. 
        /// <para>
        /// The result of a mouse move action.
        /// </para>
        /// </summary>
        public MouseMoveResult MouseMove { get; set; }

        /// <summary>
        /// Checks to see if the MouseMove property is set.
        /// </summary>
        internal bool IsSetMouseMove() => this.MouseMove != null;

        /// <summary>
        /// Gets and sets the property MouseScroll. 
        /// <para>
        /// The result of a mouse scroll action.
        /// </para>
        /// </summary>
        public MouseScrollResult MouseScroll { get; set; }

        /// <summary>
        /// Checks to see if the MouseScroll property is set.
        /// </summary>
        internal bool IsSetMouseScroll() => this.MouseScroll != null;

        /// <summary>
        /// Gets and sets the property Screenshot. 
        /// <para>
        /// The result of a screenshot action.
        /// </para>
        /// </summary>
        public ScreenshotResult Screenshot { get; set; }

        /// <summary>
        /// Checks to see if the Screenshot property is set.
        /// </summary>
        internal bool IsSetScreenshot() => this.Screenshot != null;
    }
}
