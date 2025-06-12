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
    /// Additional connection options for the connector.
    /// </summary>
    public partial class JDBCConnectorOptions
    {
        private Dictionary<string, string> _dataTypeMapping = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _filterPredicate;
        private List<string> _jobBookmarkKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _jobBookmarkKeysSortOrder;
        private long? _lowerBound;
        private long? _numPartitions;
        private string _partitionColumn;
        private long? _upperBound;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DataTypeMapping
        {
            get { return this._dataTypeMapping; }
            set { this._dataTypeMapping = value; }
        }

        // Check to see if DataTypeMapping property is set
        internal bool IsSetDataTypeMapping()
        {
            return this._dataTypeMapping != null && (this._dataTypeMapping.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public string FilterPredicate
        {
            get { return this._filterPredicate; }
            set { this._filterPredicate = value; }
        }

        // Check to see if FilterPredicate property is set
        internal bool IsSetFilterPredicate()
        {
            return this._filterPredicate != null;
        }

        /// <summary>
        /// Gets and sets the property JobBookmarkKeys. 
        /// <para>
        /// The name of the job bookmark keys on which to sort.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> JobBookmarkKeys
        {
            get { return this._jobBookmarkKeys; }
            set { this._jobBookmarkKeys = value; }
        }

        // Check to see if JobBookmarkKeys property is set
        internal bool IsSetJobBookmarkKeys()
        {
            return this._jobBookmarkKeys != null && (this._jobBookmarkKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobBookmarkKeysSortOrder. 
        /// <para>
        /// Specifies an ascending or descending sort order.
        /// </para>
        /// </summary>
        public string JobBookmarkKeysSortOrder
        {
            get { return this._jobBookmarkKeysSortOrder; }
            set { this._jobBookmarkKeysSortOrder = value; }
        }

        // Check to see if JobBookmarkKeysSortOrder property is set
        internal bool IsSetJobBookmarkKeysSortOrder()
        {
            return this._jobBookmarkKeysSortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property LowerBound. 
        /// <para>
        /// The minimum value of <c>partitionColumn</c> that is used to decide partition stride.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? LowerBound
        {
            get { return this._lowerBound; }
            set { this._lowerBound = value; }
        }

        // Check to see if LowerBound property is set
        internal bool IsSetLowerBound()
        {
            return this._lowerBound.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumPartitions. 
        /// <para>
        /// The number of partitions. This value, along with <c>lowerBound</c> (inclusive) and
        /// <c>upperBound</c> (exclusive), form partition strides for generated <c>WHERE</c> clause
        /// expressions that are used to split the <c>partitionColumn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? NumPartitions
        {
            get { return this._numPartitions; }
            set { this._numPartitions = value; }
        }

        // Check to see if NumPartitions property is set
        internal bool IsSetNumPartitions()
        {
            return this._numPartitions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartitionColumn. 
        /// <para>
        /// The name of an integer column that is used for partitioning. This option works only
        /// when it's included with <c>lowerBound</c>, <c>upperBound</c>, and <c>numPartitions</c>.
        /// This option works the same way as in the Spark SQL JDBC reader.
        /// </para>
        /// </summary>
        public string PartitionColumn
        {
            get { return this._partitionColumn; }
            set { this._partitionColumn = value; }
        }

        // Check to see if PartitionColumn property is set
        internal bool IsSetPartitionColumn()
        {
            return this._partitionColumn != null;
        }

        /// <summary>
        /// Gets and sets the property UpperBound. 
        /// <para>
        /// The maximum value of <c>partitionColumn</c> that is used to decide partition stride.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? UpperBound
        {
            get { return this._upperBound; }
            set { this._upperBound = value; }
        }

        // Check to see if UpperBound property is set
        internal bool IsSetUpperBound()
        {
            return this._upperBound.HasValue; 
        }

    }
}