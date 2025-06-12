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
    /// Represents a condition to be compared with an attribute value. This condition can
    /// be used with <c>DeleteItem</c>, <c>PutItem</c>, or <c>UpdateItem</c> operations; if
    /// the comparison evaluates to true, the operation succeeds; if not, the operation fails.
    /// You can use <c>ExpectedAttributeValue</c> in one of two different ways:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Use <c>AttributeValueList</c> to specify one or more values to compare against an
    /// attribute. Use <c>ComparisonOperator</c> to specify how you want to perform the comparison.
    /// If the comparison evaluates to true, then the conditional operation succeeds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>Value</c> to specify a value that DynamoDB will compare against an attribute.
    /// If the values match, then <c>ExpectedAttributeValue</c> evaluates to true and the
    /// conditional operation succeeds. Optionally, you can also set <c>Exists</c> to false,
    /// indicating that you <i>do not</i> expect to find the attribute value in the table.
    /// In this case, the conditional operation succeeds only if the comparison evaluates
    /// to false.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <c>Value</c> and <c>Exists</c> are incompatible with <c>AttributeValueList</c> and
    /// <c>ComparisonOperator</c>. Note that if you use both sets of parameters at once, DynamoDB
    /// will return a <c>ValidationException</c> exception.
    /// </para>
    /// </summary>
    public partial class ExpectedAttributeValue
    {
        private List<AttributeValue> _attributeValueList = AWSConfigs.InitializeCollections ? new List<AttributeValue>() : null;
        private ComparisonOperator _comparisonOperator;
        private bool? _exists;
        private AttributeValue _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ExpectedAttributeValue() { }

        /// <summary>
        /// Instantiates ExpectedAttributeValue with the parameterized properties
        /// </summary>
        /// <param name="value">Represents the data for the expected attribute. Each attribute value is described as a name-value pair. The name is the data type, and the value is the data itself. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.NamingRulesDataTypes.html#HowItWorks.DataTypes">Data Types</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        public ExpectedAttributeValue(AttributeValue value)
        {
            _value = value;
        }

        /// <summary>
        /// Instantiates ExpectedAttributeValue with the parameterized properties
        /// </summary>
        /// <param name="exists">Causes DynamoDB to evaluate the value before attempting a conditional operation: <ul> <li> If <c>Exists</c> is <c>true</c>, DynamoDB will check to see if that attribute value already exists in the table. If it is found, then the operation succeeds. If it is not found, the operation fails with a <c>ConditionCheckFailedException</c>. </li> <li> If <c>Exists</c> is <c>false</c>, DynamoDB assumes that the attribute value does not exist in the table. If in fact the value does not exist, then the assumption is valid and the operation succeeds. If the value is found, despite the assumption that it does not exist, the operation fails with a <c>ConditionCheckFailedException</c>. </li> </ul> The default setting for <c>Exists</c> is <c>true</c>. If you supply a <c>Value</c> all by itself, DynamoDB assumes the attribute exists: You don't have to set <c>Exists</c> to <c>true</c>, because it is implied. DynamoDB returns a <c>ValidationException</c> if: <ul> <li>  <c>Exists</c> is <c>true</c> but there is no <c>Value</c> to check. (You expect a value to exist, but don't specify what that value is.) </li> <li>  <c>Exists</c> is <c>false</c> but you also provide a <c>Value</c>. (You cannot expect an attribute to have a value, while also expecting it not to exist.) </li> </ul></param>
        public ExpectedAttributeValue(bool? exists)
        {
            _exists = exists;
        }

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
        ///  
        /// <para>
        /// For information on specifying data types in JSON, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON
        /// Data Format</a> in the <i>Amazon DynamoDB Developer Guide</i>.
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
        /// A comparator for evaluating attributes in the <c>AttributeValueList</c>. For example,
        /// equals, greater than, less than, etc.
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
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Exists. 
        /// <para>
        /// Causes DynamoDB to evaluate the value before attempting a conditional operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>Exists</c> is <c>true</c>, DynamoDB will check to see if that attribute value
        /// already exists in the table. If it is found, then the operation succeeds. If it is
        /// not found, the operation fails with a <c>ConditionCheckFailedException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>Exists</c> is <c>false</c>, DynamoDB assumes that the attribute value does not
        /// exist in the table. If in fact the value does not exist, then the assumption is valid
        /// and the operation succeeds. If the value is found, despite the assumption that it
        /// does not exist, the operation fails with a <c>ConditionCheckFailedException</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default setting for <c>Exists</c> is <c>true</c>. If you supply a <c>Value</c>
        /// all by itself, DynamoDB assumes the attribute exists: You don't have to set <c>Exists</c>
        /// to <c>true</c>, because it is implied.
        /// </para>
        ///  
        /// <para>
        /// DynamoDB returns a <c>ValidationException</c> if:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Exists</c> is <c>true</c> but there is no <c>Value</c> to check. (You expect a
        /// value to exist, but don't specify what that value is.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Exists</c> is <c>false</c> but you also provide a <c>Value</c>. (You cannot expect
        /// an attribute to have a value, while also expecting it not to exist.)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? Exists
        {
            get { return this._exists; }
            set { this._exists = value; }
        }

        // Check to see if Exists property is set
        internal bool IsSetExists()
        {
            return this._exists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Represents the data for the expected attribute.
        /// </para>
        ///  
        /// <para>
        /// Each attribute value is described as a name-value pair. The name is the data type,
        /// and the value is the data itself.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.NamingRulesDataTypes.html#HowItWorks.DataTypes">Data
        /// Types</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public AttributeValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}