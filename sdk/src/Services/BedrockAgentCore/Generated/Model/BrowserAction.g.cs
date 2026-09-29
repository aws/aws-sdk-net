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
    /// The browser action to perform. Exactly one member must be set per request.
    /// </summary>
    public partial class BrowserAction
    {
        /// <summary>
        /// Gets and sets the property KeyPress. 
        /// <para>
        /// Press a key one or more times.
        /// </para>
        /// </summary>
        public KeyPressArguments KeyPress { get; set; }

        /// <summary>
        /// Checks to see if the KeyPress property is set.
        /// </summary>
        internal bool IsSetKeyPress() => this.KeyPress != null;

        /// <summary>
        /// Gets and sets the property KeyShortcut. 
        /// <para>
        /// Press a key combination.
        /// </para>
        /// </summary>
        public KeyShortcutArguments KeyShortcut { get; set; }

        /// <summary>
        /// Checks to see if the KeyShortcut property is set.
        /// </summary>
        internal bool IsSetKeyShortcut() => this.KeyShortcut != null;

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        /// Type a string of text.
        /// </para>
        /// </summary>
        public KeyTypeArguments KeyType { get; set; }

        /// <summary>
        /// Checks to see if the KeyType property is set.
        /// </summary>
        internal bool IsSetKeyType() => this.KeyType != null;

        /// <summary>
        /// Gets and sets the property MouseClick. 
        /// <para>
        /// Click at the specified coordinates.
        /// </para>
        /// </summary>
        public MouseClickArguments MouseClick { get; set; }

        /// <summary>
        /// Checks to see if the MouseClick property is set.
        /// </summary>
        internal bool IsSetMouseClick() => this.MouseClick != null;

        /// <summary>
        /// Gets and sets the property MouseDrag. 
        /// <para>
        /// Drag from a start position to an end position.
        /// </para>
        /// </summary>
        public MouseDragArguments MouseDrag { get; set; }

        /// <summary>
        /// Checks to see if the MouseDrag property is set.
        /// </summary>
        internal bool IsSetMouseDrag() => this.MouseDrag != null;

        /// <summary>
        /// Gets and sets the property MouseMove. 
        /// <para>
        /// Move the cursor to the specified coordinates.
        /// </para>
        /// </summary>
        public MouseMoveArguments MouseMove { get; set; }

        /// <summary>
        /// Checks to see if the MouseMove property is set.
        /// </summary>
        internal bool IsSetMouseMove() => this.MouseMove != null;

        /// <summary>
        /// Gets and sets the property MouseScroll. 
        /// <para>
        /// Scroll at the specified position.
        /// </para>
        /// </summary>
        public MouseScrollArguments MouseScroll { get; set; }

        /// <summary>
        /// Checks to see if the MouseScroll property is set.
        /// </summary>
        internal bool IsSetMouseScroll() => this.MouseScroll != null;

        /// <summary>
        /// Gets and sets the property Screenshot. 
        /// <para>
        /// Capture a full-screen screenshot.
        /// </para>
        /// </summary>
        public ScreenshotArguments Screenshot { get; set; }

        /// <summary>
        /// Checks to see if the Screenshot property is set.
        /// </summary>
        internal bool IsSetScreenshot() => this.Screenshot != null;
    }
}
