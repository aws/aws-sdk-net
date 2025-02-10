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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Determines how the plugin visual sorts the data during query.
    /// </summary>
    public partial class PluginVisualSortConfiguration
    {
        private PluginVisualTableQuerySort _pluginVisualTableQuerySort;

        /// <summary>
        /// Gets and sets the property PluginVisualTableQuerySort. 
        /// <para>
        /// The table query sorting options for the plugin visual.
        /// </para>
        /// </summary>
        public PluginVisualTableQuerySort PluginVisualTableQuerySort
        {
            get { return this._pluginVisualTableQuerySort; }
            set { this._pluginVisualTableQuerySort = value; }
        }

        // Check to see if PluginVisualTableQuerySort property is set
        internal bool IsSetPluginVisualTableQuerySort()
        {
            return this._pluginVisualTableQuerySort != null;
        }

    }
}