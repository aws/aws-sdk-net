/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the Scan operation.
    /// <para>The <i>Scan</i> operation returns one or more items and item attributes by accessing every item in the table. To have DynamoDB return
    /// fewer items, you can provide a <i>ScanFilter</i> .</para> <para>If the total number of scanned items exceeds the maximum data set size limit
    /// of 1 MB, the scan stops and results are returned to the user with a <i>LastEvaluatedKey</i> to continue the scan in a subsequent operation.
    /// The results also include the number of items exceeding the limit. A scan can result in no table data meeting the filter criteria. </para>
    /// <para>The result set is eventually consistent. </para> <para>By default, <i>Scan</i> operations proceed sequentially; however, for faster
    /// performance on large tables, applications can request a parallel <i>Scan</i> by specifying the <i>Segment</i> and <i>TotalSegments</i>
    /// parameters. For more information, see <a
    /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html#QueryAndScanParallelScan" >Parallel Scan</a> in the
    /// Amazon DynamoDB Developer Guide.</para>
    /// </summary>
    public partial class ScanRequest : AmazonDynamoDBv2Request
    {
        private string tableName;
        private List<string> attributesToGet = new List<string>();
        private int? limit;
        private Select select;
        private Dictionary<string,Condition> scanFilter = new Dictionary<string,Condition>();
        private ConditionalOperator conditionalOperator;
        private Dictionary<string,AttributeValue> exclusiveStartKey = new Dictionary<string,AttributeValue>();
        private ReturnConsumedCapacity returnConsumedCapacity;
        private int? totalSegments;
        private int? segment;


        /// <summary>
        /// The name of the table containing the requested items.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this.tableName; }
            set { this.tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this.tableName != null;
        }

        /// <summary>
        /// The names of one or more attributes to retrieve. If no attribute names are specified, then all attributes will be returned. If any of the
        /// requested attributes are not found, they will not appear in the result. Note that <i>AttributesToGet</i> has no effect on provisioned
        /// throughput consumption. DynamoDB determines capacity units consumed based on item size, not on the amount of data that is returned to an
        /// application.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this.attributesToGet; }
            set { this.attributesToGet = value; }
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this.attributesToGet.Count > 0;
        }

        /// <summary>
        /// The maximum number of items to evaluate (not necessarily the number of matching items). If DynamoDB processes the number of items up to the
        /// limit while processing the results, it stops the operation and returns the matching values up to that point, and a <i>LastEvaluatedKey</i>
        /// to apply in a subsequent operation, so that you can pick up where you left off. Also, if the processed data set size exceeds 1 MB before
        /// DynamoDB reaches this limit, it stops the operation and returns the matching values up to the limit, and a <i>LastEvaluatedKey</i> to apply
        /// in a subsequent operation to continue the operation. For more information see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html">Query and Scan</a> in the Amazon DynamoDB Developer
        /// Guide.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;
        }

        /// <summary>
        /// The attributes to be returned in the result. You can retrieve all item attributes, specific item attributes, or the count of matching items.
        /// <ul> <li> <c>ALL_ATTRIBUTES</c>: Returns all of the item attributes. </li> <li> <c>COUNT</c>: Returns the number of matching items, rather
        /// than the matching items themselves. </li> <li> <c>SPECIFIC_ATTRIBUTES</c> : Returns only the attributes listed in <i>AttributesToGet</i>.
        /// This is equivalent to specifying <i>AttributesToGet</i> without specifying any value for <i>Select</i>. </li> </ul> If neither <i>Select</i>
        /// nor <i>AttributesToGet</i> are specified, DynamoDB defaults to <c>ALL_ATTRIBUTES</c>. You cannot use both <i>Select</i> and
        /// <i>AttributesToGet</i> together in a single request, <i>unless</i> the value for <i>Select</i> is <c>SPECIFIC_ATTRIBUTES</c>. (This usage is
        /// equivalent to specifying <i>AttributesToGet</i> without any value for <i>Select</i>.)
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ALL_ATTRIBUTES, ALL_PROJECTED_ATTRIBUTES, SPECIFIC_ATTRIBUTES, COUNT</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Select Select
        {
            get { return this.select; }
            set { this.select = value; }
        }

        // Check to see if Select property is set
        internal bool IsSetSelect()
        {
            return this.select != null;
        }

        /// <summary>
        /// Evaluates the scan results and returns only the desired values. If you specify more than one condition in the <i>ScanFilter</i> map, then by
        /// default all of the conditions must evaluate to true. In other words, the conditions are ANDed together. (You can use the
        /// <i>ConditionalOperator</i> parameter to OR the conditions instead. If you do this, then at least one of the conditions must evaluate to
        /// true, rather than all of them.) Each <i>ScanFilter</i> element consists of an attribute name to compare, along with the following: <ul> <li>
        /// <i>AttributeValueList</i> - One or more values to evaluate against the supplied attribute. The number of values in the list depends on the
        /// <i>ComparisonOperator</i> being used. For type Number, value comparisons are numeric. String value comparisons for greater than, equals, or
        /// less than are based on ASCII character code values. For example, <c>a</c> is greater than <c>A</c>, and <c>aa</c> is greater than <c>B</c>.
        /// For a list of code values, see <a
        /// href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>. For
        /// Binary, DynamoDB treats each byte of the binary data as unsigned when it compares binary values, for example when evaluating query
        /// expressions. For information on specifying data types in JSON, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON Data Format</a> in the Amazon DynamoDB Developer
        /// Guide. </li> <li><i>ComparisonOperator</i> - A comparator for evaluating attributes. For example, equals, greater than, less than, etc. The
        /// following comparison operators are available: <c>EQ | NE | LE | LT | GE | GT | NOT_NULL | NULL | CONTAINS | NOT_CONTAINS | BEGINS_WITH | IN
        /// | BETWEEN</c> For complete descriptions of all comparison operators, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_Condition.html">API_Condition.html</a>. </li> </ul>
        ///  
        /// </summary>
        public Dictionary<string,Condition> ScanFilter
        {
            get { return this.scanFilter; }
            set { this.scanFilter = value; }
        }

        // Check to see if ScanFilter property is set
        internal bool IsSetScanFilter()
        {
            return this.scanFilter != null;
        }

        /// <summary>
        /// A logical operator to apply to the conditions in the <i>ScanFilter</i> map: <ul> <li><c>AND</c> - If <i>all</i> of the conditions evaluate
        /// to true, then the entire map evaluates to true.</li> <li><c>OR</c> - If <i>at least one</i> of the conditions evaluate to true, then the
        /// entire map evaluates to true.</li> </ul> If you omit <i>ConditionalOperator</i>, then <c>AND</c> is used as the default. The operation will
        /// succeed only if the entire map evaluates to true.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>AND, OR</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ConditionalOperator ConditionalOperator
        {
            get { return this.conditionalOperator; }
            set { this.conditionalOperator = value; }
        }

        // Check to see if ConditionalOperator property is set
        internal bool IsSetConditionalOperator()
        {
            return this.conditionalOperator != null;
        }

        /// <summary>
        /// The primary key of the first item that this operation will evaluate. Use the value that was returned for <i>LastEvaluatedKey</i> in the
        /// previous operation. The data type for <i>ExclusiveStartKey</i> must be String, Number or Binary. No set data types are allowed. In a
        /// parallel scan, a <i>Scan</i> request that includes <i>ExclusiveStartKey</i> must specify the same segment whose previous <i>Scan</i>
        /// returned the corresponding value of <i>LastEvaluatedKey</i>.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> ExclusiveStartKey
        {
            get { return this.exclusiveStartKey; }
            set { this.exclusiveStartKey = value; }
        }

        // Check to see if ExclusiveStartKey property is set
        internal bool IsSetExclusiveStartKey()
        {
            return this.exclusiveStartKey != null;
        }

        /// <summary>
        /// If set to <c>TOTAL</c>, the response includes <i>ConsumedCapacity</i> data for tables and indexes. If set to <c>INDEXES</c>, the response
        /// includes <i>ConsumedCapacity</i> for indexes. If set to <c>NONE</c> (the default), <i>ConsumedCapacity</i> is not included in the response.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>INDEXES, TOTAL, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this.returnConsumedCapacity; }
            set { this.returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this.returnConsumedCapacity != null;
        }

        /// <summary>
        /// For a parallel <i>Scan</i> request, <i>TotalSegments</i> represents the total number of segments into which the <i>Scan</i> operation will
        /// be divided. The value of <i>TotalSegments</i> corresponds to the number of application workers that will perform the parallel scan. For
        /// example, if you want to scan a table using four application threads, you would specify a <i>TotalSegments</i> value of 4. The value for
        /// <i>TotalSegments</i> must be greater than or equal to 1, and less than or equal to 4096. If you specify a <i>TotalSegments</i> value of 1,
        /// the <i>Scan</i> will be sequential rather than parallel. If you specify <i>TotalSegments</i>, you must also specify <i>Segment</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 1000000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int TotalSegments
        {
            get { return this.totalSegments ?? default(int); }
            set { this.totalSegments = value; }
        }

        // Check to see if TotalSegments property is set
        internal bool IsSetTotalSegments()
        {
            return this.totalSegments.HasValue;
        }

        /// <summary>
        /// For a parallel <i>Scan</i> request, <i>Segment</i> identifies an individual segment to be scanned by an application worker. Segment IDs are
        /// zero-based, so the first segment is always 0. For example, if you want to scan a table using four application threads, the first thread
        /// would specify a <i>Segment</i> value of 0, the second thread would specify 1, and so on. The value of <i>LastEvaluatedKey</i> returned from
        /// a parallel <i>Scan</i> request must be used as <i>ExclusiveStartKey</i> with the same Segment ID in a subsequent <i>Scan</i> operation. The
        /// value for <i>Segment</i> must be greater than or equal to 0, and less than the value provided for <i>TotalSegments</i>. If you specify
        /// <i>Segment</i>, you must also specify <i>TotalSegments</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 999999</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Segment
        {
            get { return this.segment ?? default(int); }
            set { this.segment = value; }
        }

        // Check to see if Segment property is set
        internal bool IsSetSegment()
        {
            return this.segment.HasValue;
        }

    }
}
    
