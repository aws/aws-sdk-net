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
    /// The configuration for a <c>TableVisual</c>.
    /// </summary>
    public partial class TableConfiguration
    {
        private TableFieldOptions _fieldOptions;
        private TableFieldWells _fieldWells;
        private VisualInteractionOptions _interactions;
        private TablePaginatedReportOptions _paginatedReportOptions;
        private TableSortConfiguration _sortConfiguration;
        private List<TableInlineVisualization> _tableInlineVisualizations = AWSConfigs.InitializeCollections ? new List<TableInlineVisualization>() : null;
        private TableOptions _tableOptions;
        private TotalOptions _totalOptions;

        /// <summary>
        /// Gets and sets the property FieldOptions. 
        /// <para>
        /// The field options for a table visual.
        /// </para>
        /// </summary>
        public TableFieldOptions FieldOptions
        {
            get { return this._fieldOptions; }
            set { this._fieldOptions = value; }
        }

        // Check to see if FieldOptions property is set
        internal bool IsSetFieldOptions()
        {
            return this._fieldOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public TableFieldWells FieldWells
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
        /// Gets and sets the property Interactions. 
        /// <para>
        /// The general visual interactions setup for a visual.
        /// </para>
        /// </summary>
        public VisualInteractionOptions Interactions
        {
            get { return this._interactions; }
            set { this._interactions = value; }
        }

        // Check to see if Interactions property is set
        internal bool IsSetInteractions()
        {
            return this._interactions != null;
        }

        /// <summary>
        /// Gets and sets the property PaginatedReportOptions. 
        /// <para>
        /// The paginated report options for a table visual.
        /// </para>
        /// </summary>
        public TablePaginatedReportOptions PaginatedReportOptions
        {
            get { return this._paginatedReportOptions; }
            set { this._paginatedReportOptions = value; }
        }

        // Check to see if PaginatedReportOptions property is set
        internal bool IsSetPaginatedReportOptions()
        {
            return this._paginatedReportOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration for a <c>TableVisual</c>.
        /// </para>
        /// </summary>
        public TableSortConfiguration SortConfiguration
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
        /// Gets and sets the property TableInlineVisualizations. 
        /// <para>
        /// A collection of inline visualizations to display within a chart.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<TableInlineVisualization> TableInlineVisualizations
        {
            get { return this._tableInlineVisualizations; }
            set { this._tableInlineVisualizations = value; }
        }

        // Check to see if TableInlineVisualizations property is set
        internal bool IsSetTableInlineVisualizations()
        {
            return this._tableInlineVisualizations != null && (this._tableInlineVisualizations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableOptions. 
        /// <para>
        /// The table options for a table visual.
        /// </para>
        /// </summary>
        public TableOptions TableOptions
        {
            get { return this._tableOptions; }
            set { this._tableOptions = value; }
        }

        // Check to see if TableOptions property is set
        internal bool IsSetTableOptions()
        {
            return this._tableOptions != null;
        }

        /// <summary>
        /// Gets and sets the property TotalOptions. 
        /// <para>
        /// The total options for a table visual.
        /// </para>
        /// </summary>
        public TotalOptions TotalOptions
        {
            get { return this._totalOptions; }
            set { this._totalOptions = value; }
        }

        // Check to see if TotalOptions property is set
        internal bool IsSetTotalOptions()
        {
            return this._totalOptions != null;
        }

    }
}