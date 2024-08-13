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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Represents the generated column-level statistics for a table or partition.
    /// </summary>
    public partial class ColumnStatistics
    {
        private DateTime? _analyzedTime;
        private string _columnName;
        private string _columnType;
        private ColumnStatisticsData _statisticsData;

        /// <summary>
        /// Gets and sets the property AnalyzedTime. 
        /// <para>
        /// The timestamp of when column statistics were generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AnalyzedTime
        {
            get { return this._analyzedTime; }
            set { this._analyzedTime = value; }
        }

        // Check to see if AnalyzedTime property is set
        internal bool IsSetAnalyzedTime()
        {
            return this._analyzedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// Name of column which statistics belong to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property ColumnType. 
        /// <para>
        /// The data type of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20000)]
        public string ColumnType
        {
            get { return this._columnType; }
            set { this._columnType = value; }
        }

        // Check to see if ColumnType property is set
        internal bool IsSetColumnType()
        {
            return this._columnType != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticsData. 
        /// <para>
        /// A <c>ColumnStatisticData</c> object that contains the statistics data values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnStatisticsData StatisticsData
        {
            get { return this._statisticsData; }
            set { this._statisticsData = value; }
        }

        // Check to see if StatisticsData property is set
        internal bool IsSetStatisticsData()
        {
            return this._statisticsData != null;
        }

    }
}