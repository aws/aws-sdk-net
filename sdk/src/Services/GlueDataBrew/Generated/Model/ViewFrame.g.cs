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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents the data being transformed during an action.
    /// </summary>
    public partial class ViewFrame
    {
        /// <summary>
        /// Gets and sets the property Analytics. 
        /// <para>
        /// Controls if analytics computation is enabled or disabled. Enabled by default.
        /// </para>
        /// </summary>
        public AnalyticsMode Analytics { get; set; }

        /// <summary>
        /// Checks to see if the Analytics property is set.
        /// </summary>
        internal bool IsSetAnalytics() => this.Analytics != null;

        /// <summary>
        /// Gets and sets the property ColumnRange. 
        /// <para>
        /// The number of columns to include in the view frame, beginning with the <c>StartColumnIndex</c>
        /// value and ignoring any columns in the <c>HiddenColumns</c> list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public int? ColumnRange { get; set; }

        /// <summary>
        /// Checks to see if the ColumnRange property is set.
        /// </summary>
        internal bool IsSetColumnRange() => this.ColumnRange.HasValue;

        /// <summary>
        /// Gets and sets the property HiddenColumns. 
        /// <para>
        /// A list of columns to hide in the view frame.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HiddenColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HiddenColumns property is set.
        /// </summary>
        internal bool IsSetHiddenColumns() => this.HiddenColumns != null && (this.HiddenColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RowRange. 
        /// <para>
        /// The number of rows to include in the view frame, beginning with the <c>StartRowIndex</c>
        /// value.
        /// </para>
        /// </summary>
        public int? RowRange { get; set; }

        /// <summary>
        /// Checks to see if the RowRange property is set.
        /// </summary>
        internal bool IsSetRowRange() => this.RowRange.HasValue;

        /// <summary>
        /// Gets and sets the property StartColumnIndex. 
        /// <para>
        /// The starting index for the range of columns to return in the view frame.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? StartColumnIndex { get; set; }

        /// <summary>
        /// Checks to see if the StartColumnIndex property is set.
        /// </summary>
        internal bool IsSetStartColumnIndex() => this.StartColumnIndex.HasValue;

        /// <summary>
        /// Gets and sets the property StartRowIndex. 
        /// <para>
        /// The starting index for the range of rows to return in the view frame.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? StartRowIndex { get; set; }

        /// <summary>
        /// Checks to see if the StartRowIndex property is set.
        /// </summary>
        internal bool IsSetStartRowIndex() => this.StartRowIndex.HasValue;
    }
}
