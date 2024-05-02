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
    /// The lookback window setup of an incremental refresh configuration.
    /// </summary>
    public partial class LookbackWindow
    {
        private string _columnName;
        private long? _size;
        private LookbackWindowSizeUnit _sizeUnit;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the lookback window column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }

        // Check to see if ColumnName property is set
        internal bool IsSetColumnName()
        {
            return this._columnName != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The lookback window column size.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeUnit. 
        /// <para>
        /// The size unit that is used for the lookback window column. Valid values for this structure
        /// are <c>HOUR</c>, <c>DAY</c>, and <c>WEEK</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LookbackWindowSizeUnit SizeUnit
        {
            get { return this._sizeUnit; }
            set { this._sizeUnit = value; }
        }

        // Check to see if SizeUnit property is set
        internal bool IsSetSizeUnit()
        {
            return this._sizeUnit != null;
        }

    }
}