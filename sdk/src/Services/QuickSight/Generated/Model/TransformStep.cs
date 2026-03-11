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
    /// A step in data preparation that performs a specific operation on the data.
    /// </summary>
    public partial class TransformStep
    {
        private AggregateOperation _aggregateStep;
        private AppendOperation _appendStep;
        private CastColumnTypesOperation _castColumnTypesStep;
        private CreateColumnsOperation _createColumnsStep;
        private FiltersOperation _filtersStep;
        private ImportTableOperation _importTableStep;
        private JoinOperation _joinStep;
        private PivotOperation _pivotStep;
        private ProjectOperation _projectStep;
        private RenameColumnsOperation _renameColumnsStep;
        private UnpivotOperation _unpivotStep;

        /// <summary>
        /// Gets and sets the property AggregateStep. 
        /// <para>
        /// A transform step that groups data and applies aggregation functions to calculate summary
        /// values.
        /// </para>
        /// </summary>
        public AggregateOperation AggregateStep
        {
            get { return this._aggregateStep; }
            set { this._aggregateStep = value; }
        }

        // Check to see if AggregateStep property is set
        internal bool IsSetAggregateStep()
        {
            return this._aggregateStep != null;
        }

        /// <summary>
        /// Gets and sets the property AppendStep. 
        /// <para>
        /// A transform step that combines rows from multiple sources by stacking them vertically.
        /// </para>
        /// </summary>
        public AppendOperation AppendStep
        {
            get { return this._appendStep; }
            set { this._appendStep = value; }
        }

        // Check to see if AppendStep property is set
        internal bool IsSetAppendStep()
        {
            return this._appendStep != null;
        }

        /// <summary>
        /// Gets and sets the property CastColumnTypesStep. 
        /// <para>
        /// A transform step that changes the data types of one or more columns.
        /// </para>
        /// </summary>
        public CastColumnTypesOperation CastColumnTypesStep
        {
            get { return this._castColumnTypesStep; }
            set { this._castColumnTypesStep = value; }
        }

        // Check to see if CastColumnTypesStep property is set
        internal bool IsSetCastColumnTypesStep()
        {
            return this._castColumnTypesStep != null;
        }

        /// <summary>
        /// Gets and sets the property CreateColumnsStep.
        /// </summary>
        public CreateColumnsOperation CreateColumnsStep
        {
            get { return this._createColumnsStep; }
            set { this._createColumnsStep = value; }
        }

        // Check to see if CreateColumnsStep property is set
        internal bool IsSetCreateColumnsStep()
        {
            return this._createColumnsStep != null;
        }

        /// <summary>
        /// Gets and sets the property FiltersStep. 
        /// <para>
        /// A transform step that applies filter conditions.
        /// </para>
        /// </summary>
        public FiltersOperation FiltersStep
        {
            get { return this._filtersStep; }
            set { this._filtersStep = value; }
        }

        // Check to see if FiltersStep property is set
        internal bool IsSetFiltersStep()
        {
            return this._filtersStep != null;
        }

        /// <summary>
        /// Gets and sets the property ImportTableStep. 
        /// <para>
        /// A transform step that brings data from a source table.
        /// </para>
        /// </summary>
        public ImportTableOperation ImportTableStep
        {
            get { return this._importTableStep; }
            set { this._importTableStep = value; }
        }

        // Check to see if ImportTableStep property is set
        internal bool IsSetImportTableStep()
        {
            return this._importTableStep != null;
        }

        /// <summary>
        /// Gets and sets the property JoinStep. 
        /// <para>
        /// A transform step that combines data from two sources based on specified join conditions.
        /// </para>
        /// </summary>
        public JoinOperation JoinStep
        {
            get { return this._joinStep; }
            set { this._joinStep = value; }
        }

        // Check to see if JoinStep property is set
        internal bool IsSetJoinStep()
        {
            return this._joinStep != null;
        }

        /// <summary>
        /// Gets and sets the property PivotStep. 
        /// <para>
        /// A transform step that converts row values into columns to reshape the data structure.
        /// </para>
        /// </summary>
        public PivotOperation PivotStep
        {
            get { return this._pivotStep; }
            set { this._pivotStep = value; }
        }

        // Check to see if PivotStep property is set
        internal bool IsSetPivotStep()
        {
            return this._pivotStep != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectStep.
        /// </summary>
        public ProjectOperation ProjectStep
        {
            get { return this._projectStep; }
            set { this._projectStep = value; }
        }

        // Check to see if ProjectStep property is set
        internal bool IsSetProjectStep()
        {
            return this._projectStep != null;
        }

        /// <summary>
        /// Gets and sets the property RenameColumnsStep. 
        /// <para>
        /// A transform step that changes the names of one or more columns.
        /// </para>
        /// </summary>
        public RenameColumnsOperation RenameColumnsStep
        {
            get { return this._renameColumnsStep; }
            set { this._renameColumnsStep = value; }
        }

        // Check to see if RenameColumnsStep property is set
        internal bool IsSetRenameColumnsStep()
        {
            return this._renameColumnsStep != null;
        }

        /// <summary>
        /// Gets and sets the property UnpivotStep. 
        /// <para>
        /// A transform step that converts columns into rows to normalize the data structure.
        /// </para>
        /// </summary>
        public UnpivotOperation UnpivotStep
        {
            get { return this._unpivotStep; }
            set { this._unpivotStep = value; }
        }

        // Check to see if UnpivotStep property is set
        internal bool IsSetUnpivotStep()
        {
            return this._unpivotStep != null;
        }

    }
}