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
    /// An element within a grid layout.
    /// </summary>
    public partial class GridLayoutElement
    {
        /// <summary>
        /// Gets and sets the property BackgroundStyle. 
        /// <para>
        /// The background style configuration of a grid layout element.
        /// </para>
        /// </summary>
        public GridLayoutElementBackgroundStyle BackgroundStyle { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundStyle property is set.
        /// </summary>
        internal bool IsSetBackgroundStyle() => this.BackgroundStyle != null;

        /// <summary>
        /// Gets and sets the property BorderRadius. 
        /// <para>
        /// The border radius of a grid layout element.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string BorderRadius { get; set; }

        /// <summary>
        /// Checks to see if the BorderRadius property is set.
        /// </summary>
        internal bool IsSetBorderRadius() => this.BorderRadius != null;

        /// <summary>
        /// Gets and sets the property BorderStyle. 
        /// <para>
        /// The border style configuration of a grid layout element.
        /// </para>
        /// </summary>
        public GridLayoutElementBorderStyle BorderStyle { get; set; }

        /// <summary>
        /// Checks to see if the BorderStyle property is set.
        /// </summary>
        internal bool IsSetBorderStyle() => this.BorderStyle != null;

        /// <summary>
        /// Gets and sets the property ColumnIndex. 
        /// <para>
        /// The column index for the upper left corner of an element.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 35)]
        public int? ColumnIndex { get; set; }

        /// <summary>
        /// Checks to see if the ColumnIndex property is set.
        /// </summary>
        internal bool IsSetColumnIndex() => this.ColumnIndex.HasValue;

        /// <summary>
        /// Gets and sets the property ColumnSpan. 
        /// <para>
        /// The width of a grid element expressed as a number of grid columns.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public int? ColumnSpan { get; set; }

        /// <summary>
        /// Checks to see if the ColumnSpan property is set.
        /// </summary>
        internal bool IsSetColumnSpan() => this.ColumnSpan.HasValue;

        /// <summary>
        /// Gets and sets the property ElementId. 
        /// <para>
        /// A unique identifier for an element within a grid layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ElementId { get; set; }

        /// <summary>
        /// Checks to see if the ElementId property is set.
        /// </summary>
        internal bool IsSetElementId() => this.ElementId != null;

        /// <summary>
        /// Gets and sets the property ElementType. 
        /// <para>
        /// The type of element.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LayoutElementType ElementType { get; set; }

        /// <summary>
        /// Checks to see if the ElementType property is set.
        /// </summary>
        internal bool IsSetElementType() => this.ElementType != null;

        /// <summary>
        /// Gets and sets the property LoadingAnimation.
        /// </summary>
        public LoadingAnimation LoadingAnimation { get; set; }

        /// <summary>
        /// Checks to see if the LoadingAnimation property is set.
        /// </summary>
        internal bool IsSetLoadingAnimation() => this.LoadingAnimation != null;

        /// <summary>
        /// Gets and sets the property Padding. 
        /// <para>
        /// The padding of a grid layout element.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Padding { get; set; }

        /// <summary>
        /// Checks to see if the Padding property is set.
        /// </summary>
        internal bool IsSetPadding() => this.Padding != null;

        /// <summary>
        /// Gets and sets the property RowIndex. 
        /// <para>
        /// The row index for the upper left corner of an element.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 9009)]
        public int? RowIndex { get; set; }

        /// <summary>
        /// Checks to see if the RowIndex property is set.
        /// </summary>
        internal bool IsSetRowIndex() => this.RowIndex.HasValue;

        /// <summary>
        /// Gets and sets the property RowSpan. 
        /// <para>
        /// The height of a grid element expressed as a number of grid rows.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 21)]
        public int? RowSpan { get; set; }

        /// <summary>
        /// Checks to see if the RowSpan property is set.
        /// </summary>
        internal bool IsSetRowSpan() => this.RowSpan.HasValue;

        /// <summary>
        /// Gets and sets the property SelectedBorderStyle. 
        /// <para>
        /// The border style configuration of a grid layout element. This border style is used
        /// when the element is selected.
        /// </para>
        /// </summary>
        public GridLayoutElementBorderStyle SelectedBorderStyle { get; set; }

        /// <summary>
        /// Checks to see if the SelectedBorderStyle property is set.
        /// </summary>
        internal bool IsSetSelectedBorderStyle() => this.SelectedBorderStyle != null;
    }
}
