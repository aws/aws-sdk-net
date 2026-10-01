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
    /// A transform operation that converts columns into rows, normalizing the data structure.
    /// </summary>
    public partial class UnpivotOperation
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property ColumnsToUnpivot. 
        /// <para>
        /// The list of columns to unpivot from the source data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public List<ColumnToUnpivot> ColumnsToUnpivot { get; set; } = AWSConfigs.InitializeCollections ? new List<ColumnToUnpivot>() : null;

        /// <summary>
        /// Checks to see if the ColumnsToUnpivot property is set.
        /// </summary>
        internal bool IsSetColumnsToUnpivot() => this.ColumnsToUnpivot != null && (this.ColumnsToUnpivot.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source transform operation that provides input data for unpivoting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformOperationSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property UnpivotedLabelColumnId. 
        /// <para>
        /// A unique identifier for the new column that will contain the unpivoted column names.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UnpivotedLabelColumnId { get; set; }

        /// <summary>
        /// Checks to see if the UnpivotedLabelColumnId property is set.
        /// </summary>
        internal bool IsSetUnpivotedLabelColumnId() => this.UnpivotedLabelColumnId != null;

        /// <summary>
        /// Gets and sets the property UnpivotedLabelColumnName. 
        /// <para>
        /// The name for the new column that will contain the unpivoted column names.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string UnpivotedLabelColumnName { get; set; }

        /// <summary>
        /// Checks to see if the UnpivotedLabelColumnName property is set.
        /// </summary>
        internal bool IsSetUnpivotedLabelColumnName() => this.UnpivotedLabelColumnName != null;

        /// <summary>
        /// Gets and sets the property UnpivotedValueColumnId. 
        /// <para>
        /// A unique identifier for the new column that will contain the unpivoted values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UnpivotedValueColumnId { get; set; }

        /// <summary>
        /// Checks to see if the UnpivotedValueColumnId property is set.
        /// </summary>
        internal bool IsSetUnpivotedValueColumnId() => this.UnpivotedValueColumnId != null;

        /// <summary>
        /// Gets and sets the property UnpivotedValueColumnName. 
        /// <para>
        /// The name for the new column that will contain the unpivoted values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string UnpivotedValueColumnName { get; set; }

        /// <summary>
        /// Checks to see if the UnpivotedValueColumnName property is set.
        /// </summary>
        internal bool IsSetUnpivotedValueColumnName() => this.UnpivotedValueColumnName != null;
    }
}
