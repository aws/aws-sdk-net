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
    /// The result of a browser action execution. Exactly one member is set, matching the
    /// action that was performed.
    /// </summary>
    public partial class BrowserActionResult
    {
        private KeyPressResult _keyPress;
        private KeyShortcutResult _keyShortcut;
        private KeyTypeResult _keyType;
        private MouseClickResult _mouseClick;
        private MouseDragResult _mouseDrag;
        private MouseMoveResult _mouseMove;
        private MouseScrollResult _mouseScroll;
        private ScreenshotResult _screenshot;

        /// <summary>
        /// Gets and sets the property KeyPress. 
        /// <para>
        /// The result of a key press action.
        /// </para>
        /// </summary>
        public KeyPressResult KeyPress
        {
            get { return this._keyPress; }
            set { this._keyPress = value; }
        }

        // Check to see if KeyPress property is set
        internal bool IsSetKeyPress()
        {
            return this._keyPress != null;
        }

        /// <summary>
        /// Gets and sets the property KeyShortcut. 
        /// <para>
        /// The result of a key shortcut action.
        /// </para>
        /// </summary>
        public KeyShortcutResult KeyShortcut
        {
            get { return this._keyShortcut; }
            set { this._keyShortcut = value; }
        }

        // Check to see if KeyShortcut property is set
        internal bool IsSetKeyShortcut()
        {
            return this._keyShortcut != null;
        }

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        /// The result of a key type action.
        /// </para>
        /// </summary>
        public KeyTypeResult KeyType
        {
            get { return this._keyType; }
            set { this._keyType = value; }
        }

        // Check to see if KeyType property is set
        internal bool IsSetKeyType()
        {
            return this._keyType != null;
        }

        /// <summary>
        /// Gets and sets the property MouseClick. 
        /// <para>
        /// The result of a mouse click action.
        /// </para>
        /// </summary>
        public MouseClickResult MouseClick
        {
            get { return this._mouseClick; }
            set { this._mouseClick = value; }
        }

        // Check to see if MouseClick property is set
        internal bool IsSetMouseClick()
        {
            return this._mouseClick != null;
        }

        /// <summary>
        /// Gets and sets the property MouseDrag. 
        /// <para>
        /// The result of a mouse drag action.
        /// </para>
        /// </summary>
        public MouseDragResult MouseDrag
        {
            get { return this._mouseDrag; }
            set { this._mouseDrag = value; }
        }

        // Check to see if MouseDrag property is set
        internal bool IsSetMouseDrag()
        {
            return this._mouseDrag != null;
        }

        /// <summary>
        /// Gets and sets the property MouseMove. 
        /// <para>
        /// The result of a mouse move action.
        /// </para>
        /// </summary>
        public MouseMoveResult MouseMove
        {
            get { return this._mouseMove; }
            set { this._mouseMove = value; }
        }

        // Check to see if MouseMove property is set
        internal bool IsSetMouseMove()
        {
            return this._mouseMove != null;
        }

        /// <summary>
        /// Gets and sets the property MouseScroll. 
        /// <para>
        /// The result of a mouse scroll action.
        /// </para>
        /// </summary>
        public MouseScrollResult MouseScroll
        {
            get { return this._mouseScroll; }
            set { this._mouseScroll = value; }
        }

        // Check to see if MouseScroll property is set
        internal bool IsSetMouseScroll()
        {
            return this._mouseScroll != null;
        }

        /// <summary>
        /// Gets and sets the property Screenshot. 
        /// <para>
        /// The result of a screenshot action.
        /// </para>
        /// </summary>
        public ScreenshotResult Screenshot
        {
            get { return this._screenshot; }
            set { this._screenshot = value; }
        }

        // Check to see if Screenshot property is set
        internal bool IsSetScreenshot()
        {
            return this._screenshot != null;
        }

    }
}