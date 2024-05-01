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
    /// Container for the parameters to the GetPartitions operation.
    /// Retrieves information about the partitions in a table.
    /// </summary>
    public partial class GetPartitionsRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private bool? _excludeColumnSchema;
        private string _expression;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _queryAsOfTime;
        private Segment _segment;
        private string _tableName;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the partitions in question reside. If none is provided,
        /// the Amazon Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database where the partitions reside.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludeColumnSchema. 
        /// <para>
        /// When true, specifies not returning the partition column schema. Useful when you are
        /// interested only in other partition attributes such as partition values or location.
        /// This approach avoids the problem of a large response by not returning duplicate data.
        /// </para>
        /// </summary>
        public bool? ExcludeColumnSchema
        {
            get { return this._excludeColumnSchema; }
            set { this._excludeColumnSchema = value; }
        }

        // Check to see if ExcludeColumnSchema property is set
        internal bool IsSetExcludeColumnSchema()
        {
            return this._excludeColumnSchema.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// An expression that filters the partitions to be returned.
        /// </para>
        ///  
        /// <para>
        /// The expression uses SQL syntax similar to the SQL <c>WHERE</c> filter clause. The
        /// SQL statement parser <a href="http://jsqlparser.sourceforge.net/home.php">JSQLParser</a>
        /// parses the expression. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Operators</i>: The following are the operators that you can use in the <c>Expression</c>
        /// API call:
        /// </para>
        ///  <dl> <dt>=</dt> <dd> 
        /// <para>
        /// Checks whether the values of the two operands are equal; if yes, then the condition
        /// becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: Assume 'variable a' holds 10 and 'variable b' holds 20. 
        /// </para>
        ///  
        /// <para>
        /// (a = b) is not true.
        /// </para>
        ///  </dd> <dt>&lt; &gt;</dt> <dd> 
        /// <para>
        /// Checks whether the values of two operands are equal; if the values are not equal,
        /// then the condition becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: (a &lt; &gt; b) is true.
        /// </para>
        ///  </dd> <dt>&gt;</dt> <dd> 
        /// <para>
        /// Checks whether the value of the left operand is greater than the value of the right
        /// operand; if yes, then the condition becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: (a &gt; b) is not true.
        /// </para>
        ///  </dd> <dt>&lt;</dt> <dd> 
        /// <para>
        /// Checks whether the value of the left operand is less than the value of the right operand;
        /// if yes, then the condition becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: (a &lt; b) is true.
        /// </para>
        ///  </dd> <dt>&gt;=</dt> <dd> 
        /// <para>
        /// Checks whether the value of the left operand is greater than or equal to the value
        /// of the right operand; if yes, then the condition becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: (a &gt;= b) is not true.
        /// </para>
        ///  </dd> <dt>&lt;=</dt> <dd> 
        /// <para>
        /// Checks whether the value of the left operand is less than or equal to the value of
        /// the right operand; if yes, then the condition becomes true.
        /// </para>
        ///  
        /// <para>
        /// Example: (a &lt;= b) is true.
        /// </para>
        ///  </dd> <dt>AND, OR, IN, BETWEEN, LIKE, NOT, IS NULL</dt> <dd> 
        /// <para>
        /// Logical operators.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        ///  <i>Supported Partition Key Types</i>: The following are the supported partition keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>string</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>date</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>timestamp</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>int</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bigint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>long</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tinyint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>smallint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>decimal</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If an type is encountered that is not valid, an exception is thrown. 
        /// </para>
        ///  
        /// <para>
        /// The following list shows the valid operators on each type. When you define a crawler,
        /// the <c>partitionKey</c> type is created as a <c>STRING</c>, to be compatible with
        /// the catalog partitions. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Sample API Call</i>: 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of partitions to return in a single response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if this is not the first call to retrieve these partitions.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property QueryAsOfTime. 
        /// <para>
        /// The time as of when to read the partition contents. If not set, the most recent transaction
        /// commit time will be used. Cannot be specified along with <c>TransactionId</c>.
        /// </para>
        /// </summary>
        public DateTime? QueryAsOfTime
        {
            get { return this._queryAsOfTime; }
            set { this._queryAsOfTime = value; }
        }

        // Check to see if QueryAsOfTime property is set
        internal bool IsSetQueryAsOfTime()
        {
            return this._queryAsOfTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Segment. 
        /// <para>
        /// The segment of the table's partitions to scan in this request.
        /// </para>
        /// </summary>
        public Segment Segment
        {
            get { return this._segment; }
            set { this._segment = value; }
        }

        // Check to see if Segment property is set
        internal bool IsSetSegment()
        {
            return this._segment != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the partitions' table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID at which to read the partition contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

    }
}