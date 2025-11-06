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
    /// A transform operation that converts columns into rows, normalizing the data structure.
    /// </summary>
    public partial class UnpivotOperation
    {
        private string _alias;
        private List<ColumnToUnpivot> _columnsToUnpivot = AWSConfigs.InitializeCollections ? new List<ColumnToUnpivot>() : null;
        private TransformOperationSource _source;
        private string _unpivotedLabelColumnId;
        private string _unpivotedLabelColumnName;
        private string _unpivotedValueColumnId;
        private string _unpivotedValueColumnName;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnsToUnpivot. 
        /// <para>
        /// The list of columns to unpivot from the source data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<ColumnToUnpivot> ColumnsToUnpivot
        {
            get { return this._columnsToUnpivot; }
            set { this._columnsToUnpivot = value; }
        }

        // Check to see if ColumnsToUnpivot property is set
        internal bool IsSetColumnsToUnpivot()
        {
            return this._columnsToUnpivot != null && (this._columnsToUnpivot.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source transform operation that provides input data for unpivoting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformOperationSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property UnpivotedLabelColumnId. 
        /// <para>
        /// A unique identifier for the new column that will contain the unpivoted column names.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string UnpivotedLabelColumnId
        {
            get { return this._unpivotedLabelColumnId; }
            set { this._unpivotedLabelColumnId = value; }
        }

        // Check to see if UnpivotedLabelColumnId property is set
        internal bool IsSetUnpivotedLabelColumnId()
        {
            return this._unpivotedLabelColumnId != null;
        }

        /// <summary>
        /// Gets and sets the property UnpivotedLabelColumnName. 
        /// <para>
        /// The name for the new column that will contain the unpivoted column names.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string UnpivotedLabelColumnName
        {
            get { return this._unpivotedLabelColumnName; }
            set { this._unpivotedLabelColumnName = value; }
        }

        // Check to see if UnpivotedLabelColumnName property is set
        internal bool IsSetUnpivotedLabelColumnName()
        {
            return this._unpivotedLabelColumnName != null;
        }

        /// <summary>
        /// Gets and sets the property UnpivotedValueColumnId. 
        /// <para>
        /// A unique identifier for the new column that will contain the unpivoted values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string UnpivotedValueColumnId
        {
            get { return this._unpivotedValueColumnId; }
            set { this._unpivotedValueColumnId = value; }
        }

        // Check to see if UnpivotedValueColumnId property is set
        internal bool IsSetUnpivotedValueColumnId()
        {
            return this._unpivotedValueColumnId != null;
        }

        /// <summary>
        /// Gets and sets the property UnpivotedValueColumnName. 
        /// <para>
        /// The name for the new column that will contain the unpivoted values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string UnpivotedValueColumnName
        {
            get { return this._unpivotedValueColumnName; }
            set { this._unpivotedValueColumnName = value; }
        }

        // Check to see if UnpivotedValueColumnName property is set
        internal bool IsSetUnpivotedValueColumnName()
        {
            return this._unpivotedValueColumnName != null;
        }

    }
}