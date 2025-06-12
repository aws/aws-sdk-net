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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the selection criteria for a <c>Query</c> or <c>Scan</c> operation:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For a <c>Query</c> operation, <c>Condition</c> is used for specifying the <c>KeyConditions</c>
    /// to use when querying a table or an index. For <c>KeyConditions</c>, only the following
    /// comparison operators are supported:
    /// </para>
    ///  
    /// <para>
    ///  <c>EQ | LE | LT | GE | GT | BEGINS_WITH | BETWEEN</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>Condition</c> is also used in a <c>QueryFilter</c>, which evaluates the query
    /// results and returns only the desired values.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a <c>Scan</c> operation, <c>Condition</c> is used in a <c>ScanFilter</c>, which
    /// evaluates the scan results and returns only the desired values.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Condition
    {
        private List<AttributeValue> _attributeValueList = AWSConfigs.InitializeCollections ? new List<AttributeValue>() : null;
        private ComparisonOperator _comparisonOperator;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Condition() { }

        /// <summary>
        /// Gets and sets the property AttributeValueList. 
        /// <para>
        /// One or more values to evaluate against the supplied attribute. The number of values
        /// in the list depends on the <c>ComparisonOperator</c> being used.
        /// </para>
        ///  
        /// <para>
        /// For type Number, value comparisons are numeric.
        /// </para>
        ///  
        /// <para>
        /// String value comparisons for greater than, equals, or less than are based on ASCII
        /// character code values. For example, <c>a</c> is greater than <c>A</c>, and <c>a</c>
        /// is greater than <c>B</c>. For a list of code values, see <a href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>.
        /// </para>
        ///  
        /// <para>
        /// For Binary, DynamoDB treats each byte of the binary data as unsigned when it compares
        /// binary values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeValue> AttributeValueList
        {
            get { return this._attributeValueList; }
            set { this._attributeValueList = value; }
        }

        // Check to see if AttributeValueList property is set
        internal bool IsSetAttributeValueList()
        {
            return this._attributeValueList != null && (this._attributeValueList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// A comparator for evaluating attributes. For example, equals, greater than, less than,
        /// etc.
        /// </para>
        ///  
        /// <para>
        /// The following comparison operators are available:
        /// </para>
        ///  
        /// <para>
        ///  <c>EQ | NE | LE | LT | GE | GT | NOT_NULL | NULL | CONTAINS | NOT_CONTAINS | BEGINS_WITH
        /// | IN | BETWEEN</c> 
        /// </para>
        ///  
        /// <para>
        /// The following are descriptions of each comparison operator.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EQ</c> : Equal. <c>EQ</c> is supported for all data types, including lists and
        /// maps.
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> can contain only one <c>AttributeValue</c> element of type
        /// String, Number, Binary, String Set, Number Set, or Binary Set. If an item contains
        /// an <c>AttributeValue</c> element of a different type than the one provided in the
        /// request, the value does not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>.
        /// Also, <c>{"N":"6"}</c> does not equal <c>{"NS":["6", "2", "1"]}</c>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <c>NE</c> : Not equal. <c>NE</c> is supported for all data types, including lists
        /// and maps.
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> can contain only one <c>AttributeValue</c> of type String,
        /// Number, Binary, String Set, Number Set, or Binary Set. If an item contains an <c>AttributeValue</c>
        /// of a different type than the one provided in the request, the value does not match.
        /// For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c>
        /// does not equal <c>{"NS":["6", "2", "1"]}</c>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <c>LE</c> : Less than or equal. 
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> can contain only one <c>AttributeValue</c> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <c>AttributeValue</c>
        /// element of a different type than the one provided in the request, the value does not
        /// match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c>
        /// does not compare to <c>{"NS":["6", "2", "1"]}</c>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <c>LT</c> : Less than. 
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> can contain only one <c>AttributeValue</c> of type String,
        /// Number, or Binary (not a set type). If an item contains an <c>AttributeValue</c> element
        /// of a different type than the one provided in the request, the value does not match.
        /// For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c>
        /// does not compare to <c>{"NS":["6", "2", "1"]}</c>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <c>GE</c> : Greater than or equal. 
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> can contain only one <c>AttributeValue</c> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <c>AttributeValue</c>
        /// element of a different type than the one provided in the request, the value does not
        /// match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c>
        /// does not compare to <c>{"NS":["6", "2", "1"]}</c>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <c>GT</c> : Greater than. 
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> can contain only one <c>AttributeValue</c> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <c>AttributeValue</c>
        /// element of a different type than the one provided in the request, the value does not
        /// match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c>
        /// does not compare to <c>{"NS":["6", "2", "1"]}</c>.
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <c>NOT_NULL</c> : The attribute exists. <c>NOT_NULL</c> is supported for all data
        /// types, including lists and maps.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operator tests for the existence of an attribute, not its data type. If the data
        /// type of attribute "<c>a</c>" is null, and you evaluate it using <c>NOT_NULL</c>, the
        /// result is a Boolean <c>true</c>. This result is because the attribute "<c>a</c>" exists;
        /// its data type is not relevant to the <c>NOT_NULL</c> comparison operator.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>NULL</c> : The attribute does not exist. <c>NULL</c> is supported for all data
        /// types, including lists and maps.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operator tests for the nonexistence of an attribute, not its data type. If the
        /// data type of attribute "<c>a</c>" is null, and you evaluate it using <c>NULL</c>,
        /// the result is a Boolean <c>false</c>. This is because the attribute "<c>a</c>" exists;
        /// its data type is not relevant to the <c>NULL</c> comparison operator.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>CONTAINS</c> : Checks for a subsequence, or value in a set.
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> can contain only one <c>AttributeValue</c> element of type
        /// String, Number, or Binary (not a set type). If the target attribute of the comparison
        /// is of type String, then the operator checks for a substring match. If the target attribute
        /// of the comparison is of type Binary, then the operator looks for a subsequence of
        /// the target that matches the input. If the target attribute of the comparison is a
        /// set ("<c>SS</c>", "<c>NS</c>", or "<c>BS</c>"), then the operator evaluates to true
        /// if it finds an exact match with any member of the set.
        /// </para>
        ///  
        /// <para>
        /// CONTAINS is supported for lists: When evaluating "<c>a CONTAINS b</c>", "<c>a</c>"
        /// can be a list; however, "<c>b</c>" cannot be a set, a map, or a list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CONTAINS</c> : Checks for absence of a subsequence, or absence of a value
        /// in a set.
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> can contain only one <c>AttributeValue</c> element of type
        /// String, Number, or Binary (not a set type). If the target attribute of the comparison
        /// is a String, then the operator checks for the absence of a substring match. If the
        /// target attribute of the comparison is Binary, then the operator checks for the absence
        /// of a subsequence of the target that matches the input. If the target attribute of
        /// the comparison is a set ("<c>SS</c>", "<c>NS</c>", or "<c>BS</c>"), then the operator
        /// evaluates to true if it <i>does not</i> find an exact match with any member of the
        /// set.
        /// </para>
        ///  
        /// <para>
        /// NOT_CONTAINS is supported for lists: When evaluating "<c>a NOT CONTAINS b</c>", "<c>a</c>"
        /// can be a list; however, "<c>b</c>" cannot be a set, a map, or a list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BEGINS_WITH</c> : Checks for a prefix. 
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> can contain only one <c>AttributeValue</c> of type String
        /// or Binary (not a Number or a set type). The target attribute of the comparison must
        /// be of type String or Binary (not a Number or a set type).
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <c>IN</c> : Checks for matching elements in a list.
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> can contain one or more <c>AttributeValue</c> elements
        /// of type String, Number, or Binary. These attributes are compared against an existing
        /// attribute of an item. If any elements of the input are equal to the item attribute,
        /// the expression evaluates to true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BETWEEN</c> : Greater than or equal to the first value, and less than or equal
        /// to the second value. 
        /// </para>
        ///  
        /// <para>
        ///  <c>AttributeValueList</c> must contain two <c>AttributeValue</c> elements of the
        /// same type, either String, Number, or Binary (not a set type). A target attribute matches
        /// if the target value is greater than, or equal to, the first element and less than,
        /// or equal to, the second element. If an item contains an <c>AttributeValue</c> element
        /// of a different type than the one provided in the request, the value does not match.
        /// For example, <c>{"S":"6"}</c> does not compare to <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c>
        /// does not compare to <c>{"NS":["6", "2", "1"]}</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For usage examples of <c>AttributeValueList</c> and <c>ComparisonOperator</c>, see
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.html">Legacy
        /// Conditional Parameters</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

    }
}