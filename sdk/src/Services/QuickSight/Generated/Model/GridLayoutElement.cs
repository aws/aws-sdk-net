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
    /// An element within a grid layout.
    /// </summary>
    public partial class GridLayoutElement
    {
        private int? _columnIndex;
        private int? _columnSpan;
        private string _elementId;
        private LayoutElementType _elementType;
        private int? _rowIndex;
        private int? _rowSpan;

        /// <summary>
        /// Gets and sets the property ColumnIndex. 
        /// <para>
        /// The column index for the upper left corner of an element.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=35)]
        public int ColumnIndex
        {
            get { return this._columnIndex.GetValueOrDefault(); }
            set { this._columnIndex = value; }
        }

        // Check to see if ColumnIndex property is set
        internal bool IsSetColumnIndex()
        {
            return this._columnIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColumnSpan. 
        /// <para>
        /// The width of a grid element expressed as a number of grid columns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public int ColumnSpan
        {
            get { return this._columnSpan.GetValueOrDefault(); }
            set { this._columnSpan = value; }
        }

        // Check to see if ColumnSpan property is set
        internal bool IsSetColumnSpan()
        {
            return this._columnSpan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ElementId. 
        /// <para>
        /// A unique identifier for an element within a grid layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ElementId
        {
            get { return this._elementId; }
            set { this._elementId = value; }
        }

        // Check to see if ElementId property is set
        internal bool IsSetElementId()
        {
            return this._elementId != null;
        }

        /// <summary>
        /// Gets and sets the property ElementType. 
        /// <para>
        /// The type of element.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LayoutElementType ElementType
        {
            get { return this._elementType; }
            set { this._elementType = value; }
        }

        // Check to see if ElementType property is set
        internal bool IsSetElementType()
        {
            return this._elementType != null;
        }

        /// <summary>
        /// Gets and sets the property RowIndex. 
        /// <para>
        /// The row index for the upper left corner of an element.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9009)]
        public int RowIndex
        {
            get { return this._rowIndex.GetValueOrDefault(); }
            set { this._rowIndex = value; }
        }

        // Check to see if RowIndex property is set
        internal bool IsSetRowIndex()
        {
            return this._rowIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RowSpan. 
        /// <para>
        /// The height of a grid element expressed as a number of grid rows.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=21)]
        public int RowSpan
        {
            get { return this._rowSpan.GetValueOrDefault(); }
            set { this._rowSpan = value; }
        }

        // Check to see if RowSpan property is set
        internal bool IsSetRowSpan()
        {
            return this._rowSpan.HasValue; 
        }

    }
}