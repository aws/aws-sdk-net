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
    /// Additional connection options for the connector.
    /// </summary>
    public partial class JDBCConnectorOptions
    {
        /// <summary>
        /// Gets and sets the property DataTypeMapping. 
        /// <para>
        /// Custom data type mapping that builds a mapping from a JDBC data type to an Glue data
        /// type. For example, the option <c>"dataTypeMapping":{"FLOAT":"STRING"}</c> maps data
        /// fields of JDBC type <c>FLOAT</c> into the Java <c>String</c> type by calling the <c>ResultSet.getString()</c>
        /// method of the driver, and uses it to build the Glue record. The <c>ResultSet</c> object
        /// is implemented by each driver, so the behavior is specific to the driver you use.
        /// Refer to the documentation for your JDBC driver to understand how the driver performs
        /// the conversions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DataTypeMapping { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DataTypeMapping property is set.
        /// </summary>
        internal bool IsSetDataTypeMapping() => this.DataTypeMapping != null && (this.DataTypeMapping.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterPredicate. 
        /// <para>
        /// Extra condition clause to filter data from source. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>BillingCity='Mountain View'</c> 
        /// </para>
        ///  
        /// <para>
        /// When using a query instead of a table name, you should validate that the query works
        /// with the specified <c>filterPredicate</c>.
        /// </para>
        /// </summary>
        public string FilterPredicate { get; set; }

        /// <summary>
        /// Checks to see if the FilterPredicate property is set.
        /// </summary>
        internal bool IsSetFilterPredicate() => this.FilterPredicate != null;

        /// <summary>
        /// Gets and sets the property JobBookmarkKeys. 
        /// <para>
        /// The name of the job bookmark keys on which to sort.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> JobBookmarkKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the JobBookmarkKeys property is set.
        /// </summary>
        internal bool IsSetJobBookmarkKeys() => this.JobBookmarkKeys != null && (this.JobBookmarkKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobBookmarkKeysSortOrder. 
        /// <para>
        /// Specifies an ascending or descending sort order.
        /// </para>
        /// </summary>
        public string JobBookmarkKeysSortOrder { get; set; }

        /// <summary>
        /// Checks to see if the JobBookmarkKeysSortOrder property is set.
        /// </summary>
        internal bool IsSetJobBookmarkKeysSortOrder() => this.JobBookmarkKeysSortOrder != null;

        /// <summary>
        /// Gets and sets the property LowerBound. 
        /// <para>
        /// The minimum value of <c>partitionColumn</c> that is used to decide partition stride.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LowerBound { get; set; }

        /// <summary>
        /// Checks to see if the LowerBound property is set.
        /// </summary>
        internal bool IsSetLowerBound() => this.LowerBound.HasValue;

        /// <summary>
        /// Gets and sets the property NumPartitions. 
        /// <para>
        /// The number of partitions. This value, along with <c>lowerBound</c> (inclusive) and
        /// <c>upperBound</c> (exclusive), form partition strides for generated <c>WHERE</c> clause
        /// expressions that are used to split the <c>partitionColumn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? NumPartitions { get; set; }

        /// <summary>
        /// Checks to see if the NumPartitions property is set.
        /// </summary>
        internal bool IsSetNumPartitions() => this.NumPartitions.HasValue;

        /// <summary>
        /// Gets and sets the property PartitionColumn. 
        /// <para>
        /// The name of an integer column that is used for partitioning. This option works only
        /// when it's included with <c>lowerBound</c>, <c>upperBound</c>, and <c>numPartitions</c>.
        /// This option works the same way as in the Spark SQL JDBC reader.
        /// </para>
        /// </summary>
        public string PartitionColumn { get; set; }

        /// <summary>
        /// Checks to see if the PartitionColumn property is set.
        /// </summary>
        internal bool IsSetPartitionColumn() => this.PartitionColumn != null;

        /// <summary>
        /// Gets and sets the property UpperBound. 
        /// <para>
        /// The maximum value of <c>partitionColumn</c> that is used to decide partition stride.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? UpperBound { get; set; }

        /// <summary>
        /// Checks to see if the UpperBound property is set.
        /// </summary>
        internal bool IsSetUpperBound() => this.UpperBound.HasValue;
    }
}
