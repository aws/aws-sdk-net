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
    /// Container for the parameters to the UpdateItem operation.
    /// Edits an existing item's attributes, or inserts a new item if it does not already
    /// exist. You      can put, delete, or add attribute values. You can also perform a conditional
    /// update (insert a      new attribute name-value pair if it doesn't exist, or replace
    /// an existing name-value pair if      it has certain expected attribute values).
    /// 
    ///     
    /// <para>
    /// In addition to updating an item, you can also return the item's attribute values in
    /// the same      operation, using the <i>ReturnValues</i> parameter.
    /// </para>
    /// </summary>
    public partial class UpdateItemRequest : AmazonDynamoDBRequest
    {
        private Dictionary<string, AttributeValueUpdate> _attributeUpdates = new Dictionary<string, AttributeValueUpdate>();
        private ConditionalOperator _conditionalOperator;
        private Dictionary<string, ExpectedAttributeValue> _expected = new Dictionary<string, ExpectedAttributeValue>();
        private Dictionary<string, AttributeValue> _key = new Dictionary<string, AttributeValue>();
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private ReturnItemCollectionMetrics _returnItemCollectionMetrics;
        private ReturnValue _returnValues;
        private string _tableName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateItemRequest() { }

        /// <summary>
        /// Instantiates UpdateItemRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table containing the item to update. </param>
        /// <param name="key">The primary key of the item to be updated. Each element consists of an attribute name and a   value for that attribute. For the primary key, you must provide <i>all</i> of the attributes. For example, with a hash   type primary key, you only need to specify the hash attribute. For a hash-and-range type   primary key, you must specify <i>both</i> the hash attribute and the range attribute.</param>
        /// <param name="attributeUpdates">The names of attributes to be modified, the action to perform on each, and the new value for   each. If you are updating an attribute that is an index key attribute for any indexes on that   table, the attribute type must match the index key type defined in the  <i>AttributesDefinition</i> of the table description. You can use <i>UpdateItem</i> to   update any non-key attributes. Attribute values cannot be null. String and binary type attributes must have lengths greater   than zero. Set type attributes must not be empty. Requests with empty values will be rejected   with a <i>ValidationException</i>. Each <i>AttributeUpdates</i> element consists of an attribute name to modify, along with the   following: <ul>   <li>  <i>Value</i> - The new value, if applicable, for this attribute.   </li>   <li>  <i>Action</i> - Specifies how to perform the update. Valid values for <i>Action</i> are   <code>PUT</code>, <code>DELETE</code>, and <code>ADD</code>. The behavior depends on    whether the specified primary key already exists in the table.      <b>If an item with the specified <i>Key</i> is found in the table:</b>    <ul>    <li>   <code>PUT</code> - Adds the specified attribute to the item. If the attribute already     exists, it is replaced by the new value.     </li>    <li>   <code>DELETE</code> - If no value is specified, the attribute and its value are     removed from the item. The data type of the specified value must match the existing     value's data type.   If a <i>set</i> of values is specified, then those values are subtracted from the old     set. For example, if the attribute value was the set <code>[a,b,c]</code> and the    <i>DELETE</i> action specified <code>[a,c]</code>, then the final attribute value     would be <code>[b]</code>. Specifying an empty set is an error.    </li>    <li>   <code>ADD</code> - If the attribute does not already exist, then the attribute and     its values are added to the item. If the attribute does exist, then the behavior of    <code>ADD</code> depends on the data type of the attribute:   <ul>     <li>    If the existing attribute is a number, and if <i>Value</i> is also a number, then      the <i>Value</i> is mathematically added to the existing attribute. If     <i>Value</i> is a negative number, then it is subtracted from the existing      attribute.    <note>       If you use <code>ADD</code> to increment or decrement a number value for an     item that doesn't exist before the update, DynamoDB uses 0 as the initial     value.      In addition, if you use <code>ADD</code> to update an existing item, and intend     to increment or decrement an attribute value which does not yet exist, DynamoDB     uses <code>0</code> as the initial value. For example, suppose that the item you     want to update does not yet have an attribute named <i>itemcount</i>, but you     decide to <code>ADD</code> the number <code>3</code> to this attribute anyway,     even though it currently does not exist. DynamoDB will create the <i>itemcount</i>     attribute, set its initial value to <code>0</code>, and finally add       <code>3</code> to it. The result will be a new <i>itemcount</i> attribute in     the item, with a value of <code>3</code>.    </note>     </li>     <li>    If the existing data type is a set, and if the <i>Value</i> is also a set, then      the <i>Value</i> is added to the existing set. (This is a <i>set</i> operation,      not mathematical addition.) For example, if the attribute value was the set     <code>[1,2]</code>, and the <code>ADD</code> action specified <code>[3]</code>,      then the final attribute value would be <code>[1,2,3]</code>. An error occurs if      an Add action is specified for a set attribute and the attribute type specified      does not match the existing set type.     Both sets must have the same primitive data type. For example, if the existing      data type is a set of strings, the <i>Value</i> must also be a set of strings. The      same holds true for number sets and binary sets.     </li>   </ul>   This action is only valid for an existing attribute whose data type is number or is a     set. Do not use <code>ADD</code> for any other data types.    </li>  </ul>      <b>If no item with the specified <i>Key</i> is found:</b>    <ul>    <li>   <code>PUT</code> - DynamoDB creates a new item with the specified primary key, and then     adds the attribute.     </li>    <li>   <code>DELETE</code> - Nothing happens; there is no attribute to delete.    </li>    <li>   <code>ADD</code> - DynamoDB creates an item with the supplied primary key and number (or     set of numbers) for the attribute value. The only data types allowed are number and     number set; no other data types can be specified.    </li>  </ul>   </li> </ul> If you specify any attributes that are part of an index key, then the data types for those   attributes must match those of the schema in the table's attribute definition.</param>
        public UpdateItemRequest(string tableName, Dictionary<string, AttributeValue> key, Dictionary<string, AttributeValueUpdate> attributeUpdates)
        {
            _tableName = tableName;
            _key = key;
            _attributeUpdates = attributeUpdates;
        }

        /// <summary>
        /// Instantiates UpdateItemRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table containing the item to update. </param>
        /// <param name="key">The primary key of the item to be updated. Each element consists of an attribute name and a   value for that attribute. For the primary key, you must provide <i>all</i> of the attributes. For example, with a hash   type primary key, you only need to specify the hash attribute. For a hash-and-range type   primary key, you must specify <i>both</i> the hash attribute and the range attribute.</param>
        /// <param name="attributeUpdates">The names of attributes to be modified, the action to perform on each, and the new value for   each. If you are updating an attribute that is an index key attribute for any indexes on that   table, the attribute type must match the index key type defined in the  <i>AttributesDefinition</i> of the table description. You can use <i>UpdateItem</i> to   update any non-key attributes. Attribute values cannot be null. String and binary type attributes must have lengths greater   than zero. Set type attributes must not be empty. Requests with empty values will be rejected   with a <i>ValidationException</i>. Each <i>AttributeUpdates</i> element consists of an attribute name to modify, along with the   following: <ul>   <li>  <i>Value</i> - The new value, if applicable, for this attribute.   </li>   <li>  <i>Action</i> - Specifies how to perform the update. Valid values for <i>Action</i> are   <code>PUT</code>, <code>DELETE</code>, and <code>ADD</code>. The behavior depends on    whether the specified primary key already exists in the table.      <b>If an item with the specified <i>Key</i> is found in the table:</b>    <ul>    <li>   <code>PUT</code> - Adds the specified attribute to the item. If the attribute already     exists, it is replaced by the new value.     </li>    <li>   <code>DELETE</code> - If no value is specified, the attribute and its value are     removed from the item. The data type of the specified value must match the existing     value's data type.   If a <i>set</i> of values is specified, then those values are subtracted from the old     set. For example, if the attribute value was the set <code>[a,b,c]</code> and the    <i>DELETE</i> action specified <code>[a,c]</code>, then the final attribute value     would be <code>[b]</code>. Specifying an empty set is an error.    </li>    <li>   <code>ADD</code> - If the attribute does not already exist, then the attribute and     its values are added to the item. If the attribute does exist, then the behavior of    <code>ADD</code> depends on the data type of the attribute:   <ul>     <li>    If the existing attribute is a number, and if <i>Value</i> is also a number, then      the <i>Value</i> is mathematically added to the existing attribute. If     <i>Value</i> is a negative number, then it is subtracted from the existing      attribute.    <note>       If you use <code>ADD</code> to increment or decrement a number value for an     item that doesn't exist before the update, DynamoDB uses 0 as the initial     value.      In addition, if you use <code>ADD</code> to update an existing item, and intend     to increment or decrement an attribute value which does not yet exist, DynamoDB     uses <code>0</code> as the initial value. For example, suppose that the item you     want to update does not yet have an attribute named <i>itemcount</i>, but you     decide to <code>ADD</code> the number <code>3</code> to this attribute anyway,     even though it currently does not exist. DynamoDB will create the <i>itemcount</i>     attribute, set its initial value to <code>0</code>, and finally add       <code>3</code> to it. The result will be a new <i>itemcount</i> attribute in     the item, with a value of <code>3</code>.    </note>     </li>     <li>    If the existing data type is a set, and if the <i>Value</i> is also a set, then      the <i>Value</i> is added to the existing set. (This is a <i>set</i> operation,      not mathematical addition.) For example, if the attribute value was the set     <code>[1,2]</code>, and the <code>ADD</code> action specified <code>[3]</code>,      then the final attribute value would be <code>[1,2,3]</code>. An error occurs if      an Add action is specified for a set attribute and the attribute type specified      does not match the existing set type.     Both sets must have the same primitive data type. For example, if the existing      data type is a set of strings, the <i>Value</i> must also be a set of strings. The      same holds true for number sets and binary sets.     </li>   </ul>   This action is only valid for an existing attribute whose data type is number or is a     set. Do not use <code>ADD</code> for any other data types.    </li>  </ul>      <b>If no item with the specified <i>Key</i> is found:</b>    <ul>    <li>   <code>PUT</code> - DynamoDB creates a new item with the specified primary key, and then     adds the attribute.     </li>    <li>   <code>DELETE</code> - Nothing happens; there is no attribute to delete.    </li>    <li>   <code>ADD</code> - DynamoDB creates an item with the supplied primary key and number (or     set of numbers) for the attribute value. The only data types allowed are number and     number set; no other data types can be specified.    </li>  </ul>   </li> </ul> If you specify any attributes that are part of an index key, then the data types for those   attributes must match those of the schema in the table's attribute definition.</param>
        /// <param name="returnValues">Use <i>ReturnValues</i> if you want to get the item attributes as they appeared either before   or after they were updated. For <i>UpdateItem</i>, the valid values are: <ul>   <li>  <code>NONE</code> - If <i>ReturnValues</i> is not specified, or if its value is   <code>NONE</code>, then nothing is returned. (This is the default for   <i>ReturnValues</i>.)   </li>   <li>  <code>ALL_OLD</code> - If <i>UpdateItem</i> overwrote an attribute name-value pair, then    the content of the old item is returned.   </li>   <li>  <code>UPDATED_OLD</code> - The old versions of only the updated attributes are    returned.   </li>   <li>  <code>ALL_NEW</code> - All of the attributes of the new version of the item are    returned.   </li>   <li>  <code>UPDATED_NEW</code> - The new versions of only the updated attributes are    returned.   </li> </ul></param>
        public UpdateItemRequest(string tableName, Dictionary<string, AttributeValue> key, Dictionary<string, AttributeValueUpdate> attributeUpdates, ReturnValue returnValues)
        {
            _tableName = tableName;
            _key = key;
            _attributeUpdates = attributeUpdates;
            _returnValues = returnValues;
        }

        /// <summary>
        /// Gets and sets the property AttributeUpdates. 
        /// <para>
        /// The names of attributes to be modified, the action to perform on each, and the new
        /// value for      each. If you are updating an attribute that is an index key attribute
        /// for any indexes on that      table, the attribute type must match the index key type
        /// defined in the        <i>AttributesDefinition</i> of the table description. You can
        /// use <i>UpdateItem</i> to      update any non-key attributes.
        /// </para>
        ///     
        /// <para>
        /// Attribute values cannot be null. String and binary type attributes must have lengths
        /// greater      than zero. Set type attributes must not be empty. Requests with empty
        /// values will be rejected      with a <i>ValidationException</i>.
        /// </para>
        ///     
        /// <para>
        /// Each <i>AttributeUpdates</i> element consists of an attribute name to modify, along
        /// with the      following:
        /// </para>
        ///     <ul>      <li>        
        /// <para>
        /// <i>Value</i> - The new value, if applicable, for this attribute.
        /// </para>
        ///       </li>      <li>        
        /// <para>
        /// <i>Action</i> - Specifies how to perform the update. Valid values for <i>Action</i>
        /// are            <code>PUT</code>, <code>DELETE</code>, and <code>ADD</code>. The behavior
        /// depends on          whether the specified primary key already exists in the table.
        /// </para>
        ///         
        /// <para>
        ///           <b>If an item with the specified <i>Key</i> is found in the table:</b> 
        ///       
        /// </para>
        ///         <ul>          <li>            
        /// <para>
        /// <code>PUT</code> - Adds the specified attribute to the item. If the attribute already
        ///              exists, it is replaced by the new value. 
        /// </para>
        ///           </li>          <li>            
        /// <para>
        /// <code>DELETE</code> - If no value is specified, the attribute and its value are  
        ///            removed from the item. The data type of the specified value must match
        /// the existing              value's data type.
        /// </para>
        ///             
        /// <para>
        /// If a <i>set</i> of values is specified, then those values are subtracted from the
        /// old              set. For example, if the attribute value was the set <code>[a,b,c]</code>
        /// and the                <i>DELETE</i> action specified <code>[a,c]</code>, then the
        /// final attribute value              would be <code>[b]</code>. Specifying an empty
        /// set is an error.
        /// </para>
        ///           </li>          <li>            
        /// <para>
        /// <code>ADD</code> - If the attribute does not already exist, then the attribute and
        ///              its values are added to the item. If the attribute does exist, then the
        /// behavior of                <code>ADD</code> depends on the data type of the attribute:
        /// </para>
        ///             <ul>              <li>                
        /// <para>
        /// If the existing attribute is a number, and if <i>Value</i> is also a number, then
        ///                  the <i>Value</i> is mathematically added to the existing attribute.
        /// If                    <i>Value</i> is a negative number, then it is subtracted from
        /// the existing                  attribute.
        /// </para>
        ///                 <note>                  
        /// <para>
        ///  If you use <code>ADD</code> to increment or decrement a number value for an     
        ///               item that doesn't exist before the update, DynamoDB uses 0 as the initial
        ///                    value.
        /// </para>
        ///                   
        /// <para>
        /// In addition, if you use <code>ADD</code> to update an existing item, and intend  
        ///                  to increment or decrement an attribute value which does not yet exist,
        /// DynamoDB                    uses <code>0</code> as the initial value. For example,
        /// suppose that the item you                    want to update does not yet have an attribute
        /// named <i>itemcount</i>, but you                    decide to <code>ADD</code> the
        /// number <code>3</code> to this attribute anyway,                    even though it
        /// currently does not exist. DynamoDB will create the <i>itemcount</i>              
        ///      attribute, set its initial value to <code>0</code>, and finally add         
        ///             <code>3</code> to it. The result will be a new <i>itemcount</i> attribute
        /// in                    the item, with a value of <code>3</code>.
        /// </para>
        ///                 </note>              </li>              <li>                
        /// <para>
        /// If the existing data type is a set, and if the <i>Value</i> is also a set, then  
        ///                the <i>Value</i> is added to the existing set. (This is a <i>set</i>
        /// operation,                  not mathematical addition.) For example, if the attribute
        /// value was the set                    <code>[1,2]</code>, and the <code>ADD</code>
        /// action specified <code>[3]</code>,                  then the final attribute value
        /// would be <code>[1,2,3]</code>. An error occurs if                  an Add action is
        /// specified for a set attribute and the attribute type specified                  does
        /// not match the existing set type. 
        /// </para>
        ///                 
        /// <para>
        /// Both sets must have the same primitive data type. For example, if the existing   
        ///               data type is a set of strings, the <i>Value</i> must also be a set of
        /// strings. The                  same holds true for number sets and binary sets.
        /// </para>
        ///               </li>            </ul>            
        /// <para>
        /// This action is only valid for an existing attribute whose data type is number or is
        /// a              set. Do not use <code>ADD</code> for any other data types.
        /// </para>
        ///           </li>        </ul>        
        /// <para>
        ///           <b>If no item with the specified <i>Key</i> is found:</b>        
        /// </para>
        ///         <ul>          <li>            
        /// <para>
        /// <code>PUT</code> - DynamoDB creates a new item with the specified primary key, and
        /// then              adds the attribute. 
        /// </para>
        ///           </li>          <li>            
        /// <para>
        /// <code>DELETE</code> - Nothing happens; there is no attribute to delete.
        /// </para>
        ///           </li>          <li>            
        /// <para>
        /// <code>ADD</code> - DynamoDB creates an item with the supplied primary key and number
        /// (or              set of numbers) for the attribute value. The only data types allowed
        /// are number and              number set; no other data types can be specified.
        /// </para>
        ///           </li>        </ul>      </li>    </ul>    
        /// <para>
        /// If you specify any attributes that are part of an index key, then the data types for
        /// those      attributes must match those of the schema in the table's attribute definition.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValueUpdate> AttributeUpdates
        {
            get { return this._attributeUpdates; }
            set { this._attributeUpdates = value; }
        }

        // Check to see if AttributeUpdates property is set
        internal bool IsSetAttributeUpdates()
        {
            return this._attributeUpdates != null && this._attributeUpdates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConditionalOperator. 
        /// <para>
        /// A logical operator to apply to the conditions in the <i>Expected</i> map:
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
        /// Gets and sets the property Expected. 
        /// <para>
        /// A map of attribute/condition pairs. This is the conditional block for the <i>UpdateItem</i>
        ///      operation.
        /// </para>
        ///          
        /// <para>
        /// Each element of <i>Expected</i> consists of an attribute name, a comparison operator,
        /// and one or more values.  DynamoDB compares the attribute with the value(s) you supplied,
        /// using the comparison operator. For each <i>Expected</i> element, the result of the
        /// evaluation is either true or false.
        /// </para>
        ///     
        /// <para>
        /// If you specify more than one element in the <i>Expected</i> map, then by default all
        /// of the conditions must evaluate to true. In other words, the conditions are ANDed
        /// together. (You can use the <i>ConditionalOperator</i> parameter to OR the conditions
        /// instead. If you do this, then at least one of the conditions must evaluate to true,
        /// rather than all of them.)
        /// </para>
        ///     
        /// <para>
        /// If the <i>Expected</i> map evaluates to true, then the conditional operation succeeds;
        /// otherwise, it fails.
        /// </para>
        ///         
        /// <para>
        /// Each item in <i>Expected</i> represents an attribute name for DynamoDB to check, along
        /// with an <i>AttributeValueList</i> and a <i>ComparisonOperator</i>:
        /// </para>
        ///          <ul>         <li>             
        /// <para>
        /// <i>AttributeValueList</i> - One or more values to evaluate against the supplied  
        ///               attribute. The number of values in the list depends on the <i>ComparisonOperator</i>
        ///                 being used.
        /// </para>
        ///              
        /// <para>
        /// For type Number, value comparisons are numeric.
        /// </para>
        ///              
        /// <para>
        /// String value comparisons for greater than, equals, or less than are based on ASCII
        ///                 character code values. For example, <code>a</code> is greater than
        /// <code>A</code>, and                     <code>aa</code> is greater than <code>B</code>.
        /// For a list of code values, see <a                     href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters"
        ///                     >http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>.
        /// </para>
        ///              
        /// <para>
        /// For Binary, DynamoDB treats each byte of the binary data as unsigned when it compares
        /// binary                 values, for example when evaluating query expressions.
        /// </para>
        ///          </li>         <li>        
        /// <para>
        /// <i>ComparisonOperator</i> - A comparator for evaluating attributes in the        
        ///        <i>AttributeValueList</i>. When performing the comparison, DynamoDB uses strongly
        /// consistent reads.
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
        /// The following are descriptions of each comparison operator.
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
        /// </li>    </ul>    </li>     </ul>    
        /// <para>
        /// For usage examples of <i>AttributeValueList</i> and <i>ComparisonOperator</i>, see
        /// <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html#ConditionalExpressions"
        ///        >Conditional Expressions</a> in the Amazon DynamoDB Developer Guide.
        /// </para>
        ///     <note>      
        /// <para>
        /// For backward compatibility with previous DynamoDB releases, the following parameters
        /// can be        used instead of <i>AttributeValueList</i> and <i>ComparisonOperator</i>:
        /// </para>
        ///       <ul>        <li>          
        /// <para>
        /// <i>Value</i> - A value for DynamoDB to compare with an attribute.
        /// </para>
        ///         </li>        <li>          
        /// <para>
        /// <i>Exists</i> - Causes DynamoDB to evaluate the value before attempting the conditional
        ///            operation:
        /// </para>
        ///           <ul>            <li>              
        /// <para>
        /// If <i>Exists</i> is <code>true</code>, DynamoDB will check to see if that attribute
        ///                value already exists in the table. If it is found, then the condition
        /// evaluates to                true; otherwise the condition evaluate to false.
        /// </para>
        ///             </li>            <li>
        /// <para>
        /// If <i>Exists</i> is <code>false</code>, DynamoDB assumes that the attribute value
        ///                does <i>not</i> exist in the table. If in fact the value does not exist,
        /// then the                assumption is valid and the condition evaluates to true. If
        /// the value is found,                despite the assumption that it does not exist,
        /// the condition evaluates to              false.
        /// </para>
        /// </li>          </ul>        </li>      </ul>      
        /// <para>
        /// Even though DynamoDB continues to accept the <i>Value</i> and <i>Exists</i> parameters,
        /// they        are now deprecated. We recommend that you use <i>AttributeValueList</i>
        /// and          <i>ComparisonOperator</i> instead, since they allow you to construct
        /// a much wider range of        conditions.
        /// </para>
        ///       
        /// <para>
        /// The <i>Value</i> and <i>Exists</i> parameters are incompatible with          <i>AttributeValueList</i>
        /// and <i>ComparisonOperator</i>. If you attempt to use both sets        of parameters
        /// at once, DynamoDB will throw a <i>ValidationException</i>.
        /// </para>
        ///     </note>
        /// </summary>
        public Dictionary<string, ExpectedAttributeValue> Expected
        {
            get { return this._expected; }
            set { this._expected = value; }
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this._expected != null && this._expected.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The primary key of the item to be updated. Each element consists of an attribute name
        /// and a      value for that attribute.
        /// </para>
        ///     
        /// <para>
        /// For the primary key, you must provide <i>all</i> of the attributes. For example, with
        /// a hash      type primary key, you only need to specify the hash attribute. For a hash-and-range
        /// type      primary key, you must specify <i>both</i> the hash attribute and the range
        /// attribute.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null && this._key.Count > 0; 
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
        /// Gets and sets the property ReturnItemCollectionMetrics. 
        /// <para>
        /// If set to <code>SIZE</code>, statistics about item collections, if any, that were
        /// modified during      the operation are returned in the response. If set to <code>NONE</code>
        /// (the default), no statistics are returned.
        /// </para>
        /// </summary>
        public ReturnItemCollectionMetrics ReturnItemCollectionMetrics
        {
            get { return this._returnItemCollectionMetrics; }
            set { this._returnItemCollectionMetrics = value; }
        }

        // Check to see if ReturnItemCollectionMetrics property is set
        internal bool IsSetReturnItemCollectionMetrics()
        {
            return this._returnItemCollectionMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnValues. 
        /// <para>
        /// Use <i>ReturnValues</i> if you want to get the item attributes as they appeared either
        /// before      or after they were updated. For <i>UpdateItem</i>, the valid values are:
        /// </para>
        ///     <ul>      <li>        
        /// <para>
        /// <code>NONE</code> - If <i>ReturnValues</i> is not specified, or if its value is  
        ///          <code>NONE</code>, then nothing is returned. (This is the default for   
        ///         <i>ReturnValues</i>.)
        /// </para>
        ///       </li>      <li>        
        /// <para>
        /// <code>ALL_OLD</code> - If <i>UpdateItem</i> overwrote an attribute name-value pair,
        /// then          the content of the old item is returned.
        /// </para>
        ///       </li>      <li>        
        /// <para>
        /// <code>UPDATED_OLD</code> - The old versions of only the updated attributes are   
        ///       returned.
        /// </para>
        ///       </li>      <li>        
        /// <para>
        /// <code>ALL_NEW</code> - All of the attributes of the new version of the item are  
        ///        returned.
        /// </para>
        ///       </li>      <li>        
        /// <para>
        /// <code>UPDATED_NEW</code> - The new versions of only the updated attributes are   
        ///       returned.
        /// </para>
        ///       </li>    </ul>
        /// </summary>
        public ReturnValue ReturnValues
        {
            get { return this._returnValues; }
            set { this._returnValues = value; }
        }

        // Check to see if ReturnValues property is set
        internal bool IsSetReturnValues()
        {
            return this._returnValues != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table containing the item to update. 
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

    }
}