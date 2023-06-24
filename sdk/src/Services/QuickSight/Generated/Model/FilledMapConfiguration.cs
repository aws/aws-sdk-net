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
    /// The configuration for a <code>FilledMapVisual</code>.
    /// </summary>
    public partial class FilledMapConfiguration
    {
        private FilledMapFieldWells _fieldWells;
        private LegendOptions _legend;
        private GeospatialMapStyleOptions _mapStyleOptions;
        private FilledMapSortConfiguration _sortConfiguration;
        private TooltipOptions _tooltip;
        private GeospatialWindowOptions _windowOptions;

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public FilledMapFieldWells FieldWells
        {
            get { return this._fieldWells; }
            set { this._fieldWells = value; }
        }

        // Check to see if FieldWells property is set
        internal bool IsSetFieldWells()
        {
            return this._fieldWells != null;
        }

        /// <summary>
        /// Gets and sets the property Legend. 
        /// <para>
        /// The legend display setup of the visual.
        /// </para>
        /// </summary>
        public LegendOptions Legend
        {
            get { return this._legend; }
            set { this._legend = value; }
        }

        // Check to see if Legend property is set
        internal bool IsSetLegend()
        {
            return this._legend != null;
        }

        /// <summary>
        /// Gets and sets the property MapStyleOptions. 
        /// <para>
        /// The map style options of the filled map visual.
        /// </para>
        /// </summary>
        public GeospatialMapStyleOptions MapStyleOptions
        {
            get { return this._mapStyleOptions; }
            set { this._mapStyleOptions = value; }
        }

        // Check to see if MapStyleOptions property is set
        internal bool IsSetMapStyleOptions()
        {
            return this._mapStyleOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a <code>FilledMapVisual</code>.
        /// </para>
        /// </summary>
        public FilledMapSortConfiguration SortConfiguration
        {
            get { return this._sortConfiguration; }
            set { this._sortConfiguration = value; }
        }

        // Check to see if SortConfiguration property is set
        internal bool IsSetSortConfiguration()
        {
            return this._sortConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The tooltip display setup of the visual.
        /// </para>
        /// </summary>
        public TooltipOptions Tooltip
        {
            get { return this._tooltip; }
            set { this._tooltip = value; }
        }

        // Check to see if Tooltip property is set
        internal bool IsSetTooltip()
        {
            return this._tooltip != null;
        }

        /// <summary>
        /// Gets and sets the property WindowOptions. 
        /// <para>
        /// The window options of the filled map visual.
        /// </para>
        /// </summary>
        public GeospatialWindowOptions WindowOptions
        {
            get { return this._windowOptions; }
            set { this._windowOptions = value; }
        }

        // Check to see if WindowOptions property is set
        internal bool IsSetWindowOptions()
        {
            return this._windowOptions != null;
        }

    }
}