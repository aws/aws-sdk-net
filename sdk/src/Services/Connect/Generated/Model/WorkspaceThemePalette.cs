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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains color palette configuration for different areas of a workspace.
    /// </summary>
    public partial class WorkspaceThemePalette
    {
        private PaletteCanvas _canvas;
        private PaletteHeader _header;
        private PaletteNavigation _navigation;
        private PalettePrimary _primary;

        /// <summary>
        /// Gets and sets the property Canvas. 
        /// <para>
        /// The color configuration for the canvas area.
        /// </para>
        /// </summary>
        public PaletteCanvas Canvas
        {
            get { return this._canvas; }
            set { this._canvas = value; }
        }

        // Check to see if Canvas property is set
        internal bool IsSetCanvas()
        {
            return this._canvas != null;
        }

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// The color configuration for the header area.
        /// </para>
        /// </summary>
        public PaletteHeader Header
        {
            get { return this._header; }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header != null;
        }

        /// <summary>
        /// Gets and sets the property Navigation. 
        /// <para>
        /// The color configuration for the navigation area.
        /// </para>
        /// </summary>
        public PaletteNavigation Navigation
        {
            get { return this._navigation; }
            set { this._navigation = value; }
        }

        // Check to see if Navigation property is set
        internal bool IsSetNavigation()
        {
            return this._navigation != null;
        }

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// The primary color configuration used throughout the workspace.
        /// </para>
        /// </summary>
        public PalettePrimary Primary
        {
            get { return this._primary; }
            set { this._primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this._primary != null;
        }

    }
}