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
    /// The configuration for a <code>PivotTableVisual</code>.
    /// </summary>
    public partial class PivotTableConfiguration
    {
        private PivotTableFieldOptions _fieldOptions;
        private PivotTableFieldWells _fieldWells;
        private PivotTablePaginatedReportOptions _paginatedReportOptions;
        private PivotTableSortConfiguration _sortConfiguration;
        private PivotTableOptions _tableOptions;
        private PivotTableTotalOptions _totalOptions;

        /// <summary>
        /// Gets and sets the property FieldOptions. 
        /// <para>
        /// The field options for a pivot table visual.
        /// </para>
        /// </summary>
        public PivotTableFieldOptions FieldOptions
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
        public PivotTableFieldWells FieldWells
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
        /// Gets and sets the property PaginatedReportOptions. 
        /// <para>
        /// The paginated report options for a pivot table visual.
        /// </para>
        /// </summary>
        public PivotTablePaginatedReportOptions PaginatedReportOptions
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
        /// The sort configuration for a <code>PivotTableVisual</code>.
        /// </para>
        /// </summary>
        public PivotTableSortConfiguration SortConfiguration
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
        /// Gets and sets the property TableOptions. 
        /// <para>
        /// The table options for a pivot table visual.
        /// </para>
        /// </summary>
        public PivotTableOptions TableOptions
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
        /// The total options for a pivot table visual.
        /// </para>
        /// </summary>
        public PivotTableTotalOptions TotalOptions
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