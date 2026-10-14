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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Represents the generated column-level statistics for a table or partition.
    /// </summary>
    public partial class ColumnStatistics
    {
        /// <summary>
        /// Gets and sets the property AnalyzedTime. 
        /// <para>
        /// The timestamp of when column statistics were generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AnalyzedTime { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzedTime property is set.
        /// </summary>
        internal bool IsSetAnalyzedTime() => this.AnalyzedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// Name of column which statistics belong to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Checks to see if the ColumnName property is set.
        /// </summary>
        internal bool IsSetColumnName() => this.ColumnName != null;

        /// <summary>
        /// Gets and sets the property ColumnType. 
        /// <para>
        /// The data type of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 20000)]
        public string ColumnType { get; set; }

        /// <summary>
        /// Checks to see if the ColumnType property is set.
        /// </summary>
        internal bool IsSetColumnType() => this.ColumnType != null;

        /// <summary>
        /// Gets and sets the property StatisticsData. 
        /// <para>
        /// A <c>ColumnStatisticData</c> object that contains the statistics data values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnStatisticsData StatisticsData { get; set; }

        /// <summary>
        /// Checks to see if the StatisticsData property is set.
        /// </summary>
        internal bool IsSetStatisticsData() => this.StatisticsData != null;
    }
}
