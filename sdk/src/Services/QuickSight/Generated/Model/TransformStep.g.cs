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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A step in data preparation that performs a specific operation on the data.
    /// </summary>
    public partial class TransformStep
    {
        /// <summary>
        /// Gets and sets the property AggregateStep. 
        /// <para>
        /// A transform step that groups data and applies aggregation functions to calculate summary
        /// values.
        /// </para>
        /// </summary>
        public AggregateOperation AggregateStep { get; set; }

        /// <summary>
        /// Checks to see if the AggregateStep property is set.
        /// </summary>
        internal bool IsSetAggregateStep() => this.AggregateStep != null;

        /// <summary>
        /// Gets and sets the property AppendStep. 
        /// <para>
        /// A transform step that combines rows from multiple sources by stacking them vertically.
        /// </para>
        /// </summary>
        public AppendOperation AppendStep { get; set; }

        /// <summary>
        /// Checks to see if the AppendStep property is set.
        /// </summary>
        internal bool IsSetAppendStep() => this.AppendStep != null;

        /// <summary>
        /// Gets and sets the property CastColumnTypesStep. 
        /// <para>
        /// A transform step that changes the data types of one or more columns.
        /// </para>
        /// </summary>
        public CastColumnTypesOperation CastColumnTypesStep { get; set; }

        /// <summary>
        /// Checks to see if the CastColumnTypesStep property is set.
        /// </summary>
        internal bool IsSetCastColumnTypesStep() => this.CastColumnTypesStep != null;

        /// <summary>
        /// Gets and sets the property CreateColumnsStep.
        /// </summary>
        public CreateColumnsOperation CreateColumnsStep { get; set; }

        /// <summary>
        /// Checks to see if the CreateColumnsStep property is set.
        /// </summary>
        internal bool IsSetCreateColumnsStep() => this.CreateColumnsStep != null;

        /// <summary>
        /// Gets and sets the property FiltersStep. 
        /// <para>
        /// A transform step that applies filter conditions.
        /// </para>
        /// </summary>
        public FiltersOperation FiltersStep { get; set; }

        /// <summary>
        /// Checks to see if the FiltersStep property is set.
        /// </summary>
        internal bool IsSetFiltersStep() => this.FiltersStep != null;

        /// <summary>
        /// Gets and sets the property ImportTableStep. 
        /// <para>
        /// A transform step that brings data from a source table.
        /// </para>
        /// </summary>
        public ImportTableOperation ImportTableStep { get; set; }

        /// <summary>
        /// Checks to see if the ImportTableStep property is set.
        /// </summary>
        internal bool IsSetImportTableStep() => this.ImportTableStep != null;

        /// <summary>
        /// Gets and sets the property JoinStep. 
        /// <para>
        /// A transform step that combines data from two sources based on specified join conditions.
        /// </para>
        /// </summary>
        public JoinOperation JoinStep { get; set; }

        /// <summary>
        /// Checks to see if the JoinStep property is set.
        /// </summary>
        internal bool IsSetJoinStep() => this.JoinStep != null;

        /// <summary>
        /// Gets and sets the property PivotStep. 
        /// <para>
        /// A transform step that converts row values into columns to reshape the data structure.
        /// </para>
        /// </summary>
        public PivotOperation PivotStep { get; set; }

        /// <summary>
        /// Checks to see if the PivotStep property is set.
        /// </summary>
        internal bool IsSetPivotStep() => this.PivotStep != null;

        /// <summary>
        /// Gets and sets the property ProjectStep.
        /// </summary>
        public ProjectOperation ProjectStep { get; set; }

        /// <summary>
        /// Checks to see if the ProjectStep property is set.
        /// </summary>
        internal bool IsSetProjectStep() => this.ProjectStep != null;

        /// <summary>
        /// Gets and sets the property RenameColumnsStep. 
        /// <para>
        /// A transform step that changes the names of one or more columns.
        /// </para>
        /// </summary>
        public RenameColumnsOperation RenameColumnsStep { get; set; }

        /// <summary>
        /// Checks to see if the RenameColumnsStep property is set.
        /// </summary>
        internal bool IsSetRenameColumnsStep() => this.RenameColumnsStep != null;

        /// <summary>
        /// Gets and sets the property UnpivotStep. 
        /// <para>
        /// A transform step that converts columns into rows to normalize the data structure.
        /// </para>
        /// </summary>
        public UnpivotOperation UnpivotStep { get; set; }

        /// <summary>
        /// Checks to see if the UnpivotStep property is set.
        /// </summary>
        internal bool IsSetUnpivotStep() => this.UnpivotStep != null;
    }
}
