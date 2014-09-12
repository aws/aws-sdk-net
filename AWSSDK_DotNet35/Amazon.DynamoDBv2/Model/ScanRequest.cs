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

/*
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
    /// The <i>Scan</i> operation returns one or more items and item attributes by accessing
    /// every      item in the table. To have DynamoDB return fewer items, you can provide
    /// a <i>ScanFilter</i>.
    /// 
    ///     
    /// <para>
    /// If the total number of scanned items exceeds the maximum data set size limit of  
    ///    1 MB, the scan stops and results are returned to the user with a        <i>LastEvaluatedKey</i>
    /// to continue the scan in a subsequent operation. The results also      include the
    /// number of items exceeding the limit. A scan can result in no table data meeting  
    ///    the filter criteria. 
    /// </para>
    ///     
    /// <para>
    /// The result set is eventually consistent. 
    /// </para>
    ///     
    /// <para>
    /// By default, <i>Scan</i> operations proceed sequentially; however, for faster performance
    /// on      large tables, applications can request a parallel <i>Scan</i> by specifying
    /// the <i>Segment</i>      and <i>TotalSegments</i> parameters. For more information,
    /// see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html#QueryAndScanParallelScan">Parallel
    /// Scan</a> in the      Amazon DynamoDB Developer Guide.
    /// </para>
    /// </summary>
    public partial class ScanRequest : AmazonDynamoDBRequest
    {
        private List<string> _attributesToGet = new List<string>();
        private ConditionalOperator _conditionalOperator;
        private Dictionary<string, AttributeValue> _exclusiveStartKey = new Dictionary<string, AttributeValue>();
        private int? _limit;
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private Dictionary<string, Condition> _scanFilter = new Dictionary<string, Condition>();
        private int? _segment;
        private Select _select;
        private string _tableName;
        private int? _totalSegments;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ScanRequest() { }

        /// <summary>
        /// Instantiates ScanRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested items.</param>
        public ScanRequest(string tableName)
        {
            _tableName = tableName;
        }

        /// <summary>
        /// Gets and sets the property AttributesToGet. 
        /// <para>
        /// The names of one or more attributes to retrieve.  If no attribute      names are specified,
        /// then all attributes will be returned. If      any of the requested attributes are
        /// not found, they will not      appear in the result.
        /// </para>
        ///       
        /// <para>
        /// Note that <i>AttributesToGet</i> has no effect on provisioned throughput consumption.
        ///       DynamoDB determines capacity units consumed based on item size, not on the amount
        /// of data that is returned to an application.
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this._attributesToGet; }
            set { this._attributesToGet = value; }
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this._attributesToGet != null && this._attributesToGet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConditionalOperator. 
        /// <para>
        /// A logical operator to apply to the conditions in the <i>ScanFilter</i> map:
        /// </para>
        ///               <ul>               <li>
        /// <para>
        /// <code>AND</code> - If <i>all</i> of the conditions evaluate to true, then the entire
        /// map  evaluates to true.
        /// </para>
        /// </li>               <li>
        /// <para>
        /// <code>OR</code> - If <i>at least one</i> of the conditions evaluate to true, then
        /// the entire map evaluates to true.
        /// </para>
        /// </li>           </ul>           
        /// <para>
        /// If you omit <i>ConditionalOperator</i>, then <code>AND</code> is the default.
        /// </para>
        ///            
        /// <para>
        /// The operation will succeed only if the entire map evaluates to true.
        /// </para>
        /// </summary>
        public ConditionalOperator ConditionalOperator
        {
            get { return this._conditionalOperator; }
            set { this._conditionalOperator = value; }
        }

        // Check to see if ConditionalOperator property is set
        internal bool IsSetConditionalOperator()
        {
            return this._conditionalOperator != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusiveStartKey. 
        /// <para>
        /// The primary key of the first item that this operation will evaluate. Use the value
        /// that was returned for <i>LastEvaluatedKey</i> in the previous operation.
        /// </para>
        ///        
        /// <para>
        /// The data type for <i>ExclusiveStartKey</i> must be String, Number or Binary. No set
        /// data types are allowed.
        /// </para>
        ///   
        /// <para>
        /// In a parallel scan, a        <i>Scan</i> request that includes <i>ExclusiveStartKey</i>
        /// must specify the same segment      whose previous <i>Scan</i> returned the corresponding
        /// value of <i>LastEvaluatedKey</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> ExclusiveStartKey
        {
            get { return this._exclusiveStartKey; }
            set { this._exclusiveStartKey = value; }
        }

        // Check to see if ExclusiveStartKey property is set
        internal bool IsSetExclusiveStartKey()
        {
            return this._exclusiveStartKey != null && this._exclusiveStartKey.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to evaluate (not necessarily the number of matching items).
        /// If      DynamoDB processes the number of items up to the limit while processing the
        /// results, it stops the      operation and returns the matching values up to that point,
        /// and a <i>LastEvaluatedKey</i> to       apply in      a subsequent operation, so that
        /// you can pick up where you left off. Also, if the processed data set size      exceeds
        /// 1 MB before DynamoDB reaches this limit, it stops the operation and returns the matching
        /// values      up to the limit, and a <i>LastEvaluatedKey</i> to apply in a subsequent
        /// operation to      continue the operation. For more information, see <a        href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html"
        ///        >Query and Scan</a> in the Amazon DynamoDB Developer Guide.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReturnConsumedCapacity.
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this._returnConsumedCapacity; }
            set { this._returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this._returnConsumedCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property ScanFilter. 
        /// <para>
        /// Evaluates the scan results and returns only the desired values.
        /// </para>
        ///     
        /// <para>
        /// If you specify more than one condition in the <i>ScanFilter</i> map, then by default
        /// all of      the conditions must evaluate to true. In other words, the conditions are
        /// ANDed together. (You      can use the <i>ConditionalOperator</i> parameter to OR the
        /// conditions instead. If you do this,      then at least one of the conditions must
        /// evaluate to true, rather than all of them.)
        /// </para>
        ///     
        /// <para>
        /// Each <i>ScanFilter</i> element consists of an attribute name to compare, along with
        /// the      following:
        /// </para>
        ///     <ul>      <li>        
        /// <para>
        /// <i>AttributeValueList</i> - One or more values to evaluate against the supplied  
        ///        attribute. The number of values in the list depends on the <i>ComparisonOperator</i>
        /// being          used.
        /// </para>
        ///         
        /// <para>
        /// For type Number, value comparisons are numeric.
        /// </para>
        ///         
        /// <para>
        /// String value comparisons for greater than, equals, or less than are based on ASCII
        ///          character code values. For example, <code>a</code> is greater than <code>A</code>,
        /// and            <code>aa</code> is greater than <code>B</code>. For a list of code
        /// values, see <a href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>.
        /// </para>
        ///         
        /// <para>
        /// For Binary, DynamoDB treats each byte of the binary data as unsigned when it compares
        /// binary          values, for example when evaluating query expressions.
        /// </para>
        ///         
        /// <para>
        /// For information on specifying data types in JSON, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON
        /// Data Format</a> in the Amazon DynamoDB Developer Guide.
        /// </para>
        ///       </li>      <li>
        /// <para>
        /// <i>ComparisonOperator</i> - A comparator for evaluating attributes. For example, 
        ///         equals, greater than, less than, etc.
        /// </para>
        ///  
        /// <para>
        /// The following comparison operators are available:
        /// </para>
        ///       
        /// <para>
        /// <code>EQ | NE | LE | LT | GE | GT | NOT_NULL | NULL | CONTAINS | NOT_CONTAINS | BEGINS_WITH
        /// | IN | BETWEEN</code>
        /// </para>
        ///  
        /// <para>
        /// For complete          descriptions of all comparison operators, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_Condition.html">Condition</a>.
        /// </para>
        ///       </li>    </ul>
        /// </summary>
        public Dictionary<string, Condition> ScanFilter
        {
            get { return this._scanFilter; }
            set { this._scanFilter = value; }
        }

        // Check to see if ScanFilter property is set
        internal bool IsSetScanFilter()
        {
            return this._scanFilter != null && this._scanFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Segment. 
        /// <para>
        /// For a parallel <i>Scan</i> request, <i>Segment</i> identifies an individual segment
        /// to be      scanned by an application worker.
        /// </para>
        ///     
        /// <para>
        /// Segment IDs are zero-based, so the first segment is always 0. For example, if you
        /// want to      scan a table using four application threads, the first thread would specify
        /// a <i>Segment</i>      value of 0, the second thread would specify 1, and so on.
        /// </para>
        ///     
        /// <para>
        /// The value of <i>LastEvaluatedKey</i> returned from a parallel <i>Scan</i> request
        /// must be      used as <i>ExclusiveStartKey</i> with the same Segment ID in a subsequent
        /// <i>Scan</i>      operation.
        /// </para>
        ///     
        /// <para>
        /// The value for <i>Segment</i> must be greater than or equal to 0, and less than the
        /// value      provided for <i>TotalSegments</i>.
        /// </para>
        ///     
        /// <para>
        /// If you specify <i>Segment</i>, you must also specify <i>TotalSegments</i>.
        /// </para>
        /// </summary>
        public int Segment
        {
            get { return this._segment.GetValueOrDefault(); }
            set { this._segment = value; }
        }

        // Check to see if Segment property is set
        internal bool IsSetSegment()
        {
            return this._segment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Select. 
        /// <para>
        /// The attributes to be returned in the result. You can retrieve all item attributes,
        /// specific      item attributes, or the count of matching items.
        /// </para>
        ///     <ul>      <li>        
        /// <para>
        /// <code>ALL_ATTRIBUTES</code>: Returns all of the item attributes.
        /// </para>
        ///       </li>      <li>        
        /// <para>
        /// <code>COUNT</code>: Returns the number of matching items, rather than the matching
        /// items          themselves.
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           <code>SPECIFIC_ATTRIBUTES</code> : Returns only the attributes listed in
        ///            <i>AttributesToGet</i>. This is equivalent to specifying <i>AttributesToGet</i>
        /// without          specifying any value for <i>Select</i>.
        /// </para>
        ///       </li>    </ul>    
        /// <para>
        /// If neither <i>Select</i> nor <i>AttributesToGet</i> are specified, DynamoDB defaults
        /// to        <code>ALL_ATTRIBUTES</code>. You cannot use both <i>Select</i> and <i>AttributesToGet</i>
        ///      together in a single request, <i>unless</i> the value for <i>Select</i> is  
        ///      <code>SPECIFIC_ATTRIBUTES</code>. (This usage is equivalent to specifying   
        ///     <i>AttributesToGet</i> without any value for <i>Select</i>.)
        /// </para>
        /// </summary>
        public Select Select
        {
            get { return this._select; }
            set { this._select = value; }
        }

        // Check to see if Select property is set
        internal bool IsSetSelect()
        {
            return this._select != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table containing the requested items.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TotalSegments. 
        /// <para>
        /// For a parallel <i>Scan</i> request, <i>TotalSegments</i> represents the total number
        /// of      segments into which the <i>Scan</i> operation will be divided. The value of
        ///        <i>TotalSegments</i> corresponds to the number of application workers that
        /// will perform the      parallel scan. For example, if you want to scan a table using
        /// four application threads, you      would specify a <i>TotalSegments</i> value of 4.
        /// </para>
        ///     
        /// <para>
        /// The value for <i>TotalSegments</i> must be greater than or equal to 1, and less than
        /// or equal      to 4096. If you specify a <i>TotalSegments</i> value of 1, the <i>Scan</i>
        /// will be sequential      rather than parallel.
        /// </para>
        ///     
        /// <para>
        /// If you specify <i>TotalSegments</i>, you must also specify <i>Segment</i>.
        /// </para>
        /// </summary>
        public int TotalSegments
        {
            get { return this._totalSegments.GetValueOrDefault(); }
            set { this._totalSegments = value; }
        }

        // Check to see if TotalSegments property is set
        internal bool IsSetTotalSegments()
        {
            return this._totalSegments.HasValue; 
        }

    }
}