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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The options that determine the default settings for interactive layout configuration.
    /// </summary>
    public partial class DefaultInteractiveLayoutConfiguration
    {
        private DefaultFreeFormLayoutConfiguration _freeForm;
        private DefaultGridLayoutConfiguration _grid;

        /// <summary>
        /// Gets and sets the property FreeForm. 
        /// <para>
        /// The options that determine the default settings of a free-form layout configuration.
        /// </para>
        /// </summary>
        public DefaultFreeFormLayoutConfiguration FreeForm
        {
            get { return this._freeForm; }
            set { this._freeForm = value; }
        }

        // Check to see if FreeForm property is set
        internal bool IsSetFreeForm()
        {
            return this._freeForm != null;
        }

        /// <summary>
        /// Gets and sets the property Grid. 
        /// <para>
        /// The options that determine the default settings for a grid layout configuration.
        /// </para>
        /// </summary>
        public DefaultGridLayoutConfiguration Grid
        {
            get { return this._grid; }
            set { this._grid = value; }
        }

        // Check to see if Grid property is set
        internal bool IsSetGrid()
        {
            return this._grid != null;
        }

    }
}