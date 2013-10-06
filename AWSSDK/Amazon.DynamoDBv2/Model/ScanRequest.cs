/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>The <i>Scan</i> operation returns one or more items and item attributes by accessing every item in the table. To have Amazon DynamoDB
    /// return fewer items, you can provide a <i>ScanFilter</i> .</para> <para>If the total number of scanned items exceeds the maximum data set
    /// size limit of 1 MB, the scan stops and results are returned to the user with a <i>LastEvaluatedKey</i> to continue the scan in a subsequent
    /// operation. The results also include the number of items exceeding the limit. A scan can result in no table data meeting the filter criteria.
    /// </para> <para>The result set is eventually consistent. </para> <para>By default, <i>Scan</i> operations proceed sequentially; however, for
    /// faster performance on large tables, applications can perform a parallel <i>Scan</i> by specifying the <i>Segment</i> and
    /// <i>TotalSegments</i> parameters. For more information, see Parallel Scan in the <i>Amazon DynamoDB Developer Guide</i> .</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.Scan"/>
    public class ScanRequest : AmazonWebServiceRequest
    {
        private string tableName;
        private List<string> attributesToGet = new List<string>();
        private int? limit;
        private string select;
        private Dictionary<string,Condition> scanFilter = new Dictionary<string,Condition>();
        private Dictionary<string,AttributeValue> exclusiveStartKey = new Dictionary<string,AttributeValue>();
        private string returnConsumedCapacity;
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

        /// <summary>
        /// Sets the TableName property
        /// </summary>
        /// <param name="tableName">The value to set for the TableName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScanRequest WithTableName(string tableName)
        {
            this.tableName = tableName;
            return this;
        }
            

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this.tableName != null;
        }

        /// <summary>
        /// The names of one or more attributes to retrieve. If no attribute names are specified, then all attributes will be returned. If any of the
        /// requested attributes are not found, they will not appear in the result.
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
        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScanRequest WithAttributesToGet(params string[] attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScanRequest WithAttributesToGet(IEnumerable<string> attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this.attributesToGet.Count > 0;
        }

        /// <summary>
        /// The maximum number of items to evaluate (not necessarily the number of matching items). If Amazon DynamoDB processes the number of items up
        /// to the limit while processing the results, it stops the operation and returns the matching values up to that point, and a
        /// <i>LastEvaluatedKey</i> to apply in a subsequent operation, so that you can pick up where you left off. Also, if the processed data set size
        /// exceeds 1 MB before Amazon DynamoDB reaches this limit, it stops the operation and returns the matching values up to the limit, and a
        /// <i>LastEvaluatedKey</i> to apply in a subsequent operation to continue the operation. For more information see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html">Query and Scan</a> in the <i>Amazon DynamoDB
        /// Developer Guide</i>.
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

        /// <summary>
        /// Sets the Limit property
        /// </summary>
        /// <param name="limit">The value to set for the Limit property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScanRequest WithLimit(int limit)
        {
            this.limit = limit;
            return this;
        }
            

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;
        }

        /// <summary>
        /// The attributes to be returned in the result. You can retrieve all item attributes, specific item attributes, the count of matching items, or
        /// in the case of an index, some or all of the attributes projected into the index. <ul> <li> <c>ALL_ATTRIBUTES</c>: Returns all of the item
        /// attributes. For a table, this is the default. For an index, this mode causes Amazon DynamoDB to fetch the full item from the table for each
        /// matching item in the index. If the index is configured to project all item attributes, the matching items will not be fetched from the
        /// table. Fetching items from the table incurs additional throughput cost and latency. </li> <li> <c>ALL_PROJECTED_ATTRIBUTES</c>: Retrieves
        /// all attributes which have been projected into the index. If the index is configured to project all attributes, this is equivalent to
        /// specifying <i>ALL_ATTRIBUTES</i>. </li> <li> <c>COUNT</c>: Returns the number of matching items, rather than the matching items themselves.
        /// </li> <li> <c>SPECIFIC_ATTRIBUTES</c> : Returns only the attributes listed in <i>AttributesToGet</i>. This is equivalent to specifying
        /// <i>AttributesToGet</i> without specifying any value for <i>Select</i>. If you are querying an index and request only attributes that are
        /// projected into that index, the operation will read only the index and not the table. If any of the requested attributes are not projected
        /// into the index, Amazon DynamoDB will need to fetch each matching item from the table. This extra fetching incurs additional throughput cost
        /// and latency. </li> </ul> When neither <i>Select</i> nor <i>AttributesToGet</i> are specified, Amazon DynamoDB defaults to
        /// <c>ALL_ATTRIBUTES</c> when accessing a table, and <c>ALL_PROJECTED_ATTRIBUTES</c> when accessing an index. You cannot use both <i>Select</i>
        /// and <i>AttributesToGet</i> together in a single request, <i>unless</i> the value for <i>Select</i> is <c>SPECIFIC_ATTRIBUTES</c>. (This
        /// usage is equivalent to specifying <i>AttributesToGet</i> without any value for <i>Select</i>.)
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
        public string Select
        {
            get { return this.select; }
            set { this.select = value; }
        }

        /// <summary>
        /// Sets the Select property
        /// </summary>
        /// <param name="select">The value to set for the Select property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScanRequest WithSelect(string select)
        {
            this.select = select;
            return this;
        }
            

        // Check to see if Select property is set
        internal bool IsSetSelect()
        {
            return this.select != null;
        }

        /// <summary>
        /// Evaluates the scan results and returns only the desired values. Multiple conditions are treated as "AND" operations: all conditions must be
        /// met to be included in the results. Each <i>ScanConditions</i> element consists of an attribute name to compare, along with the following:
        /// <ul> <li><i>AttributeValueList</i> - One or more values to evaluate against the supplied attribute. This list contains exactly one value,
        /// except for a <c>BETWEEN</c> or <c>IN</c> comparison, in which case the list contains two values. <note> For type Number, value comparisons
        /// are numeric. String value comparisons for greater than, equals, or less than are based on ASCII character code values. For example, <c>a</c>
        /// is greater than <c>A</c>, and <c>aa</c> is greater than <c>B</c>. For a list of code values, see <a
        /// href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>. For
        /// Binary, Amazon DynamoDB treats each byte of the binary data as unsigned when it compares binary values, for example when evaluating query
        /// expressions. </note> </li> <li><i>ComparisonOperator</i> - A comparator for evaluating attributes. For example, equals, greater than, less
        /// than, etc. Valid comparison operators for Scan: <c>EQ | NE | LE | LT | GE | GT | NOT_NULL | NULL | CONTAINS | NOT_CONTAINS | BEGINS_WITH |
        /// IN | BETWEEN</c> For information on specifying data types in JSON, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON Data Format</a> in the <i>Amazon DynamoDB
        /// Developer Guide</i>. The following are descriptions of each comparison operator. <ul> <li> <c>EQ</c> : Equal. <i>AttributeValueList</i> can
        /// contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item contains an <i>AttributeValue</i> of a
        /// different type than the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c> does not equal
        /// <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not equal <c>{"NS":["6", "2", "1"]}</c>. </li> <li> <c>NE</c> : Not equal.
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item contains an
        /// <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c>
        /// does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not equal <c>{"NS":["6", "2", "1"]}</c>. </li> <li> <c>LE</c> : Less than or
        /// equal. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item
        /// contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For example,
        /// <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. </li> <li>
        /// <c>LT</c> : Less than. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set).
        /// If an item contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For
        /// example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. </li>
        /// <li> <c>GE</c> : Greater than or equal. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or
        /// Binary (not a set). If an item contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value does
        /// not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2",
        /// "1"]}</c>. </li> <li> <c>GT</c> : Greater than. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number,
        /// or Binary (not a set). If an item contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value
        /// does not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6",
        /// "2", "1"]}</c>. </li> <li> <c>NOT_NULL</c> : The attribute exists. </li> <li> <c>NULL</c> : The attribute does not exist. </li> <li>
        /// <c>CONTAINS</c> : checks for a subsequence, or value in a set. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type
        /// String, Number, or Binary (not a set). If the target attribute of the comparison is a String, then the operation checks for a substring
        /// match. If the target attribute of the comparison is Binary, then the operation looks for a subsequence of the target that matches the input.
        /// If the target attribute of the comparison is a set ("SS", "NS", or "BS"), then the operation checks for a member of the set (not as a
        /// substring). </li> <li> <c>NOT_CONTAINS</c> : checks for absence of a subsequence, or absence of a value in a set. <i>AttributeValueList</i>
        /// can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If the target attribute of the comparison is a
        /// String, then the operation checks for the absence of a substring match. If the target attribute of the comparison is Binary, then the
        /// operation checks for the absence of a subsequence of the target that matches the input. If the target attribute of the comparison is a set
        /// ("SS", "NS", or "BS"), then the operation checks for the absence of a member of the set (not as a substring). </li> <li> <c>BEGINS_WITH</c>
        /// : checks for a prefix. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String or Binary (not a Number or a
        /// set). The target attribute of the comparison must be a String or Binary (not a Number or a set). </li> <li> <c>IN</c> : checks for exact
        /// matches. <i>AttributeValueList</i> can contain more than one <i>AttributeValue</i> of type String, Number, or Binary (not a set). The target
        /// attribute of the comparison must be of the same type and exact value to match. A String never matches a String set. </li> <li>
        /// <c>BETWEEN</c> : Greater than or equal to the first value, and less than or equal to the second value. <i>AttributeValueList</i> must
        /// contain two <i>AttributeValue</i> elements of the same type, either String, Number, or Binary (not a set). A target attribute matches if the
        /// target value is greater than, or equal to, the first element and less than, or equal to, the second element. If an item contains an
        /// <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c>
        /// does not compare to <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c> </li> </ul> </li> </ul>
        ///  
        /// </summary>
        public Dictionary<string,Condition> ScanFilter
        {
            get { return this.scanFilter; }
            set { this.scanFilter = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the ScanFilter dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the ScanFilter dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScanRequest WithScanFilter(params KeyValuePair<string, Condition>[] pairs)
        {
            foreach (KeyValuePair<string, Condition> pair in pairs)
            {
                this.ScanFilter[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if ScanFilter property is set
        internal bool IsSetScanFilter()
        {
            return this.scanFilter != null;
        }

        /// <summary>
        /// The primary key of the item from which to continue an earlier operation. An earlier operation might provide this value as the
        /// <i>LastEvaluatedKey</i> if that operation was interrupted before completion; either because of the result set size or because of the setting
        /// for <i>Limit</i>. The <i>LastEvaluatedKey</i> can be passed back in a new request to continue the operation from that point. The data type
        /// for <i>ExclusiveStartKey</i> must be String, Number or Binary. No set data types are allowed. If you are performing a parallel scan, the
        /// value of <i>ExclusiveStartKey</i> must fall into the key space of the <i>Segment</i> being scanned. For example, suppose that there are two
        /// application threads scanning a table using the following <i>Scan</i> parameters <ul> <li> Thread 0: <i>Segment</i>=0; <i>TotalSegments</i>=2
        /// </li> <li> Thread 1: <i>Segment</i>=1; <i>TotalSegments</i>=2 </li> </ul> Now suppose that the <i>Scan</i> request for Thread 0 completed
        /// and returned a <i>LastEvaluatedKey</i> of "X". Because "X" is part of <i>Segment</i> 0's key space, it cannot be used anywhere else in the
        /// table. If Thread 1 were to issue another <i>Scan</i> request with an <i>ExclusiveStartKey</i> of "X", Amazon DynamoDB would throw an
        /// <i>InputValidationError</i> because hash key "X" cannot be in <i>Segment</i> 1.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> ExclusiveStartKey
        {
            get { return this.exclusiveStartKey; }
            set { this.exclusiveStartKey = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the ExclusiveStartKey dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the ExclusiveStartKey dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScanRequest WithExclusiveStartKey(params KeyValuePair<string, AttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, AttributeValue> pair in pairs)
            {
                this.ExclusiveStartKey[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if ExclusiveStartKey property is set
        internal bool IsSetExclusiveStartKey()
        {
            return this.exclusiveStartKey != null;
        }

        /// <summary>
        /// If set to <c>TOTAL</c>, <i>ConsumedCapacity</i> is included in the response; if set to <c>NONE</c> (the default), <i>ConsumedCapacity</i> is
        /// not included.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>TOTAL, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ReturnConsumedCapacity
        {
            get { return this.returnConsumedCapacity; }
            set { this.returnConsumedCapacity = value; }
        }

        /// <summary>
        /// Sets the ReturnConsumedCapacity property
        /// </summary>
        /// <param name="returnConsumedCapacity">The value to set for the ReturnConsumedCapacity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScanRequest WithReturnConsumedCapacity(string returnConsumedCapacity)
        {
            this.returnConsumedCapacity = returnConsumedCapacity;
            return this;
        }
            

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this.returnConsumedCapacity != null;
        }

        /// <summary>
        /// For parallel <i>Scan</i> requests, <i>TotalSegments</i>represents the total number of segments for a table that is being scanned. Segments
        /// are a way to logically divide a table into equally sized portions, for the duration of the <i>Scan</i> request. The value of
        /// <i>TotalSegments</i> corresponds to the number of application "workers" (such as threads or processes) that will perform the parallel
        /// <i>Scan</i>. For example, if you want to scan a table using four application threads, you would specify a <i>TotalSegments</i> value of 4.
        /// The value for <i>TotalSegments</i> must be greater than or equal to 1, and less than or equal to 4096. If you specify a <i>TotalSegments</i>
        /// value of 1, the <i>Scan</i> will be sequential rather than parallel. If you specify <i>TotalSegments</i>, you must also specify
        /// <i>Segment</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 4096</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int TotalSegments
        {
            get { return this.totalSegments ?? default(int); }
            set { this.totalSegments = value; }
        }

        /// <summary>
        /// Sets the TotalSegments property
        /// </summary>
        /// <param name="totalSegments">The value to set for the TotalSegments property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScanRequest WithTotalSegments(int totalSegments)
        {
            this.totalSegments = totalSegments;
            return this;
        }
            

        // Check to see if TotalSegments property is set
        internal bool IsSetTotalSegments()
        {
            return this.totalSegments.HasValue;
        }

        /// <summary>
        /// For parallel <i>Scan</i> requests, <i>Segment</i> identifies an individual segment to be scanned by an application "worker" (such as a
        /// thread or a process). Each worker issues a <i>Scan</i> request with a distinct value for the segment it will scan. Segment IDs are
        /// zero-based, so the first segment is always 0. For example, if you want to scan a table using four application threads, the first thread
        /// would specify a <i>Segment</i> value of 0, the second thread would specify 1, and so on. LastEvaluatedKey returned from a parallel scan
        /// request must be used with same Segment id in a subsequent operation. The value for <i>Segment</i> must be less than or equal to 0, and less
        /// than the value provided for <i>TotalSegments</i>. If you specify <i>Segment</i>, you must also specify <i>TotalSegments</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 4095</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Segment
        {
            get { return this.segment ?? default(int); }
            set { this.segment = value; }
        }

        /// <summary>
        /// Sets the Segment property
        /// </summary>
        /// <param name="segment">The value to set for the Segment property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScanRequest WithSegment(int segment)
        {
            this.segment = segment;
            return this;
        }
            

        // Check to see if Segment property is set
        internal bool IsSetSegment()
        {
            return this.segment.HasValue;
        }
    }
}
    
