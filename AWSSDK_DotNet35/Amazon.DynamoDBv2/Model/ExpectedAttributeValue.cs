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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents an attribute value used with conditional <i>DeleteItem</i> ,
    /// <i>PutItem</i> or <i>UpdateItem</i> operations. DynamoDB will check to see if the attribute value already exists; or if
    /// the attribute exists and has a particular value before updating it.</para>
    /// </summary>
    public partial class ExpectedAttributeValue
    {
        
        private AttributeValue value;
        private bool? exists;
        private ComparisonOperator comparisonOperator;
        private List<AttributeValue> attributeValueList = new List<AttributeValue>();


        /// <summary>
        /// Represents the data for an attribute. You can set one, and only one, of the elements.
        ///  
        /// </summary>
        public AttributeValue Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;
        }

        /// <summary>
        /// Causes DynamoDB to evaluate the value before attempting a conditional operation: <ul> <li> If <i>Exists</i> is <c>true</c>, DynamoDB will
        /// check to see if that attribute value already exists in the table. If it is found, then the operation succeeds. If it is not found, the
        /// operation fails with a <i>ConditionalCheckFailedException</i>. </li> <li> If <i>Exists</i> is <c>false</c>, DynamoDB assumes that the
        /// attribute value does <i>not</i> exist in the table. If in fact the value does not exist, then the assumption is valid and the operation
        /// succeeds. If the value is found, despite the assumption that it does not exist, the operation fails with a
        /// <i>ConditionalCheckFailedException</i>. </li> </ul> The default setting for <i>Exists</i> is <c>true</c>. If you supply a <i>Value</i> all
        /// by itself, DynamoDB assumes the attribute exists: You don't have to set <i>Exists</i> to <c>true</c>, because it is implied. DynamoDB
        /// returns a <i>ValidationException</i> if: <ul> <li> <i>Exists</i> is <c>true</c> but there is no <i>Value</i> to check. (You expect a value
        /// to exist, but don't specify what that value is.) </li> <li> <i>Exists</i> is <c>false</c> but you also specify a <i>Value</i>. (You cannot
        /// expect an attribute to have a value, while also expecting it not to exist.) </li> </ul>
        ///  
        /// </summary>
        public bool Exists
        {
            get { return this.exists ?? default(bool); }
            set { this.exists = value; }
        }

        // Check to see if Exists property is set
        internal bool IsSetExists()
        {
            return this.exists.HasValue;
        }

        /// <summary>
        /// A comparator for evaluating attributes in the <i>AttributeValueList</i>. For example, equals, greater than, less than, etc. The following
        /// comparison operators are available: <c>EQ | NE | LE | LT | GE | GT | NOT_NULL | NULL | CONTAINS | NOT_CONTAINS | BEGINS_WITH | IN |
        /// BETWEEN</c> <note>You cannot specify <i>ComparisonOperator</i> if <i>Exists</i> or <i>Value</i> are also present.</note> The following are
        /// descriptions of each comparison operator. <ul> <li> <c>EQ</c> : Equal. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i>
        /// of type String, Number, or Binary (not a set). If an item contains an <i>AttributeValue</i> of a different type than the one specified in
        /// the request, the value does not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not equal
        /// <c>{"NS":["6", "2", "1"]}</c>. <p/> </li> <li> <c>NE</c> : Not equal. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i>
        /// of type String, Number, or Binary (not a set). If an item contains an <i>AttributeValue</i> of a different type than the one specified in
        /// the request, the value does not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not equal
        /// <c>{"NS":["6", "2", "1"]}</c>. <p/> </li> <li> <c>LE</c> : Less than or equal. <i>AttributeValueList</i> can contain only one
        /// <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item contains an <i>AttributeValue</i> of a different type than
        /// the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also,
        /// <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. <p/> </li> <li> <c>LT</c> : Less than. <i>AttributeValueList</i> can
        /// contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item contains an <i>AttributeValue</i> of a
        /// different type than the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c> does not equal
        /// <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. <p/> </li> <li> <c>GE</c> : Greater than or
        /// equal. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item
        /// contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For example,
        /// <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. <p/> </li> <li>
        /// <c>GT</c> : Greater than. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a
        /// set). If an item contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For
        /// example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. <p/>
        /// </li> <li> <c>NOT_NULL</c> : The attribute exists. </li> <li> <c>NULL</c> : The attribute does not exist. </li> <li> <c>CONTAINS</c> :
        /// checks for a subsequence, or value in a set. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or
        /// Binary (not a set). If the target attribute of the comparison is a String, then the operation checks for a substring match. If the target
        /// attribute of the comparison is Binary, then the operation looks for a subsequence of the target that matches the input. If the target
        /// attribute of the comparison is a set ("SS", "NS", or "BS"), then the operation checks for a member of the set (not as a substring). </li>
        /// <li> <c>NOT_CONTAINS</c> : checks for absence of a subsequence, or absence of a value in a set. <i>AttributeValueList</i> can contain only
        /// one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If the target attribute of the comparison is a String, then the
        /// operation checks for the absence of a substring match. If the target attribute of the comparison is Binary, then the operation checks for
        /// the absence of a subsequence of the target that matches the input. If the target attribute of the comparison is a set ("SS", "NS", or "BS"),
        /// then the operation checks for the absence of a member of the set (not as a substring). </li> <li> <c>BEGINS_WITH</c> : checks for a prefix.
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String or Binary (not a Number or a set). The target attribute
        /// of the comparison must be a String or Binary (not a Number or a set). <p/> </li> <li> <c>IN</c> : checks for exact matches.
        /// <i>AttributeValueList</i> can contain more than one <i>AttributeValue</i> of type String, Number, or Binary (not a set). The target
        /// attribute of the comparison must be of the same type and exact value to match. A String never matches a String set. </li> <li>
        /// <c>BETWEEN</c> : Greater than or equal to the first value, and less than or equal to the second value. <i>AttributeValueList</i> must
        /// contain two <i>AttributeValue</i> elements of the same type, either String, Number, or Binary (not a set). A target attribute matches if the
        /// target value is greater than, or equal to, the first element and less than, or equal to, the second element. If an item contains an
        /// <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c>
        /// does not compare to <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c> </li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>EQ, NE, IN, LE, LT, GE, GT, BETWEEN, NOT_NULL, NULL, CONTAINS, NOT_CONTAINS, BEGINS_WITH</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator
        {
            get { return this.comparisonOperator; }
            set { this.comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this.comparisonOperator != null;
        }

        /// <summary>
        /// <i>AttributeValueList</i> - One or more values to evaluate against the supplied attribute. The number of values in the list depends on the
        /// <i>ComparisonOperator</i> being used. For type Number, value comparisons are numeric. String value comparisons for greater than, equals, or
        /// less than are based on ASCII character code values. For example, <c>a</c> is greater than <c>A</c>, and <c>aa</c> is greater than <c>B</c>.
        /// For a list of code values, see <a
        /// href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>. For
        /// Binary, DynamoDB treats each byte of the binary data as unsigned when it compares binary values, for example when evaluating query
        /// expressions. For information on specifying data types in JSON, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON Data Format</a> in the Amazon DynamoDB Developer
        /// Guide. <note>You cannot specify <i>AttributeValueList</i> if <i>Exists</i> or <i>Value</i> are also present.</note>
        ///  
        /// </summary>
        public List<AttributeValue> AttributeValueList
        {
            get { return this.attributeValueList; }
            set { this.attributeValueList = value; }
        }

        // Check to see if AttributeValueList property is set
        internal bool IsSetAttributeValueList()
        {
            return this.attributeValueList.Count > 0;
        }
    }
}
