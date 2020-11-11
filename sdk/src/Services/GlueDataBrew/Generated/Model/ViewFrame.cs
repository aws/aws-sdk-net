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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents the data being being transformed during an AWS Glue DataBrew project session.
    /// </summary>
    public partial class ViewFrame
    {
        private int? _columnRange;
        private List<string> _hiddenColumns = new List<string>();
        private int? _startColumnIndex;

        /// <summary>
        /// Gets and sets the property ColumnRange. 
        /// <para>
        /// The number of columns to include in the view frame, beginning with the <code>StartColumnIndex</code>
        /// value and ignoring any columns in the <code>HiddenColumns</code> list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public int ColumnRange
        {
            get { return this._columnRange.GetValueOrDefault(); }
            set { this._columnRange = value; }
        }

        // Check to see if ColumnRange property is set
        internal bool IsSetColumnRange()
        {
            return this._columnRange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HiddenColumns. 
        /// <para>
        /// A list of columns to hide in the view frame.
        /// </para>
        /// </summary>
        public List<string> HiddenColumns
        {
            get { return this._hiddenColumns; }
            set { this._hiddenColumns = value; }
        }

        // Check to see if HiddenColumns property is set
        internal bool IsSetHiddenColumns()
        {
            return this._hiddenColumns != null && this._hiddenColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartColumnIndex. 
        /// <para>
        /// The starting index for the range of columns to return in the view frame.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int StartColumnIndex
        {
            get { return this._startColumnIndex.GetValueOrDefault(); }
            set { this._startColumnIndex = value; }
        }

        // Check to see if StartColumnIndex property is set
        internal bool IsSetStartColumnIndex()
        {
            return this._startColumnIndex.HasValue; 
        }

    }
}