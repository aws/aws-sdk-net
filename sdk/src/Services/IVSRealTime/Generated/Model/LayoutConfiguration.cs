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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Configuration information of supported layouts for server-side composition.
    /// </summary>
    public partial class LayoutConfiguration
    {
        private GridConfiguration _grid;
        private PipConfiguration _pip;

        /// <summary>
        /// Gets and sets the property Grid. 
        /// <para>
        /// Configuration related to grid layout. Default: Grid layout.
        /// </para>
        /// </summary>
        public GridConfiguration Grid
        {
            get { return this._grid; }
            set { this._grid = value; }
        }

        // Check to see if Grid property is set
        internal bool IsSetGrid()
        {
            return this._grid != null;
        }

        /// <summary>
        /// Gets and sets the property Pip. 
        /// <para>
        /// Configuration related to PiP layout.
        /// </para>
        /// </summary>
        public PipConfiguration Pip
        {
            get { return this._pip; }
            set { this._pip = value; }
        }

        // Check to see if Pip property is set
        internal bool IsSetPip()
        {
            return this._pip != null;
        }

    }
}