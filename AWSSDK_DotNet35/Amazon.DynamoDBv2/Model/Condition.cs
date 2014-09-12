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
    /// Represents the selection criteria for a <i>Query</i> or <i>Scan</i> operation:
    /// 
    ///     <ul>      <li>        
    /// <para>
    /// For a <i>Query</i> operation, <i>Condition</i> is used for specifying the        
    ///    <i>KeyConditions</i> to use when querying a table or an index. For <i>KeyConditions</i>,
    ///          only the following comparison operators are supported:
    /// </para>
    ///         
    /// <para>
    ///           <code>EQ | LE | LT | GE | GT | BEGINS_WITH | BETWEEN</code>        
    /// </para>
    ///         
    /// <para>
    /// <i>Condition</i> is also used in a <i>QueryFilter</i>, which evaluates the query results
    ///          and returns only the desired values.
    /// </para>
    ///       </li>      <li>        
    /// <para>
    /// For a <i>Scan</i> operation, <i>Condition</i> is used in a <i>ScanFilter</i>, which
    ///          evaluates the scan results and returns only the desired values.
    /// </para>
    ///       </li>    </ul>
    /// </summary>
    public partial class Condition
    {
        private List<AttributeValue> _attributeValueList = new List<AttributeValue>();
        private ComparisonOperator _comparisonOperator;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Condition() { }

        /// <summary>
        /// Gets and sets the property AttributeValueList. 
        /// <para>
        /// One or more values to evaluate against the supplied attribute. The number of values
        /// in the      list depends on the <i>ComparisonOperator</i> being used.
        /// </para>
        ///     
        /// <para>
        /// For type Number, value comparisons are numeric.
        /// </para>
        ///     
        /// <para>
        /// String value comparisons for greater than, equals, or less than are based on ASCII
        /// character      code values. For example, <code>a</code> is greater than <code>A</code>,
        /// and <code>aa</code>      is greater than <code>B</code>. For a list of code values,
        /// see <a href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>.
        /// </para>
        ///     
        /// <para>
        /// For Binary, DynamoDB treats each byte of the binary data as unsigned when it compares
        /// binary      values, for example when evaluating query expressions.
        /// </para>
        /// </summary>
        public List<AttributeValue> AttributeValueList
        {
            get { return this._attributeValueList; }
            set { this._attributeValueList = value; }
        }

        // Check to see if AttributeValueList property is set
        internal bool IsSetAttributeValueList()
        {
            return this._attributeValueList != null && this._attributeValueList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// A comparator for evaluating attributes. For example, equals, greater than, less than,
        ///      etc.
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
        /// The following are descriptions of each comparison      operator.
        /// </para>
        ///     <ul>      <li>        
        /// <para>
        /// <code>EQ</code> : Equal. 
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        ///          Number, Binary, String Set, Number Set, or Binary Set. If an item contains
        /// an <i>AttributeValue</i> of a different          type than the one specified in the
        /// request, the value does not match. For example,            <code>{"S":"6"}</code>
        /// does not equal <code>{"N":"6"}</code>. Also,            <code>{"N":"6"}</code> does
        /// not equal <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///         <p/></li>      <li>        
        /// <para>
        /// <code>NE</code> : Not equal. 
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        ///          Number, Binary, String Set, Number Set, or Binary Set. If an item contains
        /// an <i>AttributeValue</i> of a different          type than the one specified in the
        /// request, the value does not match. For example,            <code>{"S":"6"}</code>
        /// does not equal <code>{"N":"6"}</code>. Also,            <code>{"N":"6"}</code> does
        /// not equal <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///         <p/></li>      <li>        
        /// <para>
        /// <code>LE</code> : Less than or equal. 
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        ///          Number, or Binary (not a set). If an item contains an <i>AttributeValue</i>
        /// of a different          type than the one specified in the request, the value does
        /// not match. For example,            <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also,            <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2",
        /// "1"]}</code>.
        /// </para>
        ///         <p/></li>      <li>        
        /// <para>
        /// <code>LT</code> : Less than. 
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        ///          Number, or Binary (not a set). If an item contains an <i>AttributeValue</i>
        /// of a different          type than the one specified in the request, the value does
        /// not match. For example,            <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also,            <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2",
        /// "1"]}</code>.
        /// </para>
        ///         <p/></li>      <li>        
        /// <para>
        /// <code>GE</code> : Greater than or equal. 
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        ///          Number, or Binary (not a set). If an item contains an <i>AttributeValue</i>
        /// of a different          type than the one specified in the request, the value does
        /// not match. For example,            <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also,            <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2",
        /// "1"]}</code>.
        /// </para>
        ///         <p/></li>      <li>        
        /// <para>
        /// <code>GT</code> : Greater than. 
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        ///          Number, or Binary (not a set). If an item contains an <i>AttributeValue</i>
        /// of a different          type than the one specified in the request, the value does
        /// not match. For example,            <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also,            <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2",
        /// "1"]}</code>.
        /// </para>
        ///         <p/></li>      <li>        
        /// <para>
        /// <code>NOT_NULL</code> : The attribute exists. 
        /// </para>
        /// </li>      <li>        
        /// <para>
        /// <code>NULL</code> : The attribute does not exist. 
        /// </para>
        /// </li>      <li>        
        /// <para>
        /// <code>CONTAINS</code> : checks for a subsequence, or value in a set.
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        ///          Number, or Binary (not a set). If the target attribute of the comparison
        /// is a String, then          the operation checks for a substring match. If the target
        /// attribute of the comparison is          Binary, then the operation looks for a subsequence
        /// of the target that matches the input.          If the target attribute of the comparison
        /// is a set ("SS", "NS", or "BS"), then the          operation checks for a member of
        /// the set (not as a substring).
        /// </para>
        /// </li>      <li>        
        /// <para>
        /// <code>NOT_CONTAINS</code> : checks for absence of a subsequence, or absence of a value
        /// in          a set.
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        ///          Number, or Binary (not a set). If the target attribute of the comparison
        /// is a String, then          the operation checks for the absence of a substring match.
        /// If the target attribute of the          comparison is Binary, then the operation checks
        /// for the absence of a subsequence of the          target that matches the input. If
        /// the target attribute of the comparison is a set ("SS",          "NS", or "BS"), then
        /// the operation checks for the absence of a member of the set (not as a          substring).
        /// </para>
        /// </li>      <li>        
        /// <para>
        /// <code>BEGINS_WITH</code> : checks for a prefix. 
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String
        /// or          Binary (not a Number or a set). The target attribute of the comparison
        /// must be a String or          Binary (not a Number or a set).
        /// </para>
        ///         <p/></li>      <li>        
        /// <para>
        /// <code>IN</code> : checks for exact matches.
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> can contain more than one <i>AttributeValue</i> of type
        /// String,          Number, or Binary (not a set). The target attribute of the comparison
        /// must be of the same          type and exact value to match. A String never matches
        /// a String set.
        /// </para>
        /// </li>      <li>        
        /// <para>
        /// <code>BETWEEN</code> : Greater than or equal to the first value, and less than or
        /// equal          to the second value. 
        /// </para>
        ///         
        /// <para>
        /// <i>AttributeValueList</i> must contain two <i>AttributeValue</i> elements of the same
        ///          type, either String, Number, or Binary (not a set). A target attribute matches
        /// if the          target value is greater than, or equal to, the first element and less
        /// than, or equal to,          the second element. If an item contains an <i>AttributeValue</i>
        /// of a different type than          the one specified in the request, the value does
        /// not match. For example,            <code>{"S":"6"}</code> does not compare to <code>{"N":"6"}</code>.
        /// Also,            <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2",
        /// "1"]}</code>
        /// </para>
        /// </li>    </ul>    
        /// <para>
        /// For usage examples of <i>AttributeValueList</i> and <i>ComparisonOperator</i>, see
        /// <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html#ConditionalExpressions">Conditional
        /// Expressions</a> in the Amazon DynamoDB Developer Guide.
        /// </para>
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

    }
}