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
    /// An element within a grid layout.
    /// </summary>
    public partial class GridLayoutElement
    {
        private GridLayoutElementBackgroundStyle _backgroundStyle;
        private string _borderRadius;
        private GridLayoutElementBorderStyle _borderStyle;
        private int? _columnIndex;
        private int? _columnSpan;
        private string _elementId;
        private LayoutElementType _elementType;
        private LoadingAnimation _loadingAnimation;
        private string _padding;
        private int? _rowIndex;
        private int? _rowSpan;
        private GridLayoutElementBorderStyle _selectedBorderStyle;

        /// <summary>
        /// Gets and sets the property BackgroundStyle. 
        /// <para>
        /// The background style configuration of a grid layout element.
        /// </para>
        /// </summary>
        public GridLayoutElementBackgroundStyle BackgroundStyle
        {
            get { return this._backgroundStyle; }
            set { this._backgroundStyle = value; }
        }

        // Check to see if BackgroundStyle property is set
        internal bool IsSetBackgroundStyle()
        {
            return this._backgroundStyle != null;
        }

        /// <summary>
        /// Gets and sets the property BorderRadius. 
        /// <para>
        /// The border radius of a grid layout element.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string BorderRadius
        {
            get { return this._borderRadius; }
            set { this._borderRadius = value; }
        }

        // Check to see if BorderRadius property is set
        internal bool IsSetBorderRadius()
        {
            return this._borderRadius != null;
        }

        /// <summary>
        /// Gets and sets the property BorderStyle. 
        /// <para>
        /// The border style configuration of a grid layout element.
        /// </para>
        /// </summary>
        public GridLayoutElementBorderStyle BorderStyle
        {
            get { return this._borderStyle; }
            set { this._borderStyle = value; }
        }

        // Check to see if BorderStyle property is set
        internal bool IsSetBorderStyle()
        {
            return this._borderStyle != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnIndex. 
        /// <para>
        /// The column index for the upper left corner of an element.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=35)]
        public int? ColumnIndex
        {
            get { return this._columnIndex; }
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
        public int? ColumnSpan
        {
            get { return this._columnSpan; }
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
        /// Gets and sets the property LoadingAnimation.
        /// </summary>
        public LoadingAnimation LoadingAnimation
        {
            get { return this._loadingAnimation; }
            set { this._loadingAnimation = value; }
        }

        // Check to see if LoadingAnimation property is set
        internal bool IsSetLoadingAnimation()
        {
            return this._loadingAnimation != null;
        }

        /// <summary>
        /// Gets and sets the property Padding. 
        /// <para>
        /// The padding of a grid layout element.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string Padding
        {
            get { return this._padding; }
            set { this._padding = value; }
        }

        // Check to see if Padding property is set
        internal bool IsSetPadding()
        {
            return this._padding != null;
        }

        /// <summary>
        /// Gets and sets the property RowIndex. 
        /// <para>
        /// The row index for the upper left corner of an element.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9009)]
        public int? RowIndex
        {
            get { return this._rowIndex; }
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
        public int? RowSpan
        {
            get { return this._rowSpan; }
            set { this._rowSpan = value; }
        }

        // Check to see if RowSpan property is set
        internal bool IsSetRowSpan()
        {
            return this._rowSpan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelectedBorderStyle. 
        /// <para>
        /// The border style configuration of a grid layout element. This border style is used
        /// when the element is selected.
        /// </para>
        /// </summary>
        public GridLayoutElementBorderStyle SelectedBorderStyle
        {
            get { return this._selectedBorderStyle; }
            set { this._selectedBorderStyle = value; }
        }

        // Check to see if SelectedBorderStyle property is set
        internal bool IsSetSelectedBorderStyle()
        {
            return this._selectedBorderStyle != null;
        }

    }
}