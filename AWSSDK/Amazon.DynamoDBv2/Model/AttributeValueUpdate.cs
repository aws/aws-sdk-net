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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>For the <i>UpdateItem</i> operation, represents the attributes to be modified,the action to perform on each, and the new value for
    /// each.</para> <para><b>NOTE:</b> You cannot use UpdateItem to update any primary key attributes. Instead, you will need to delete the item,
    /// and then use PutItem to create a new item with new attributes. </para> <para>Attribute values cannot be null; string and binary type
    /// attributes must have lengths greater than zero; and set type attributes must not be empty. Requests with empty values will be rejected with
    /// a <i>ValidationException</i> .</para>
    /// </summary>
    public class AttributeValueUpdate
    {
        
        private AttributeValue value;
        private string action;

        /// <summary>
        /// Represents the data for an attribute. You can set one, and only one, of the elements.
        ///  
        /// </summary>
        public AttributeValue Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">The value to set for the Value property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttributeValueUpdate WithValue(AttributeValue value)
        {
            this.value = value;
            return this;
        }
            

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;
        }

        /// <summary>
        /// Specifies how to perform the update. Valid values are <c>PUT</c>, <c>DELETE</c>, and <c>ADD</c>. The behavior depends on whether the
        /// specified primary key already exists in the table. <b>If an item with the specified <i>Key</i> is found in the table:</b> <ul> <li>
        /// <c>PUT</c> - Adds the specified attribute to the item. If the attribute already exists, it is replaced by the new value. </li> <li>
        /// <c>DELETE</c> - If no value is specified, the attribute and its value are removed from the item. The data type of the specified value must
        /// match the existing value's data type. If a <i>set</i> of values is specified, then those values are subtracted from the old set. For
        /// example, if the attribute value was the set <c>[a,b,c]</c> and the <i>DELETE</i> action specified <c>[a,c]</c>, then the final attribute
        /// value would be <c>[b]</c>. Specifying an empty set is an error. </li> <li> <c>ADD</c> - If the attribute does not already exist, then the
        /// attribute and its values are added to the item. If the attribute does exist, then the behavior of <c>ADD</c> depends on the data type of the
        /// attribute: <ul> <li> If the existing attribute is a number, and if <i>Value</i> is also a number, then the <i>Value</i> is mathematically
        /// added to the existing attribute. If <i>Value</i> is a negative number, then it is subtracted from the existing attribute. <note> If you use
        /// <c>ADD</c> to increment or decrement a number value for an item that doesn't exist before the update, Amazon DynamoDB uses 0 as the initial
        /// value. In addition, if you use <c>ADD</c> to update an existing item, and intend to increment or decrement an attribute value which does not
        /// yet exist, Amazon DynamoDB uses <c>0</c> as the initial value. For example, suppose that the item you want to update does not yet have an
        /// attribute named <i>itemcount</i>, but you decide to <c>ADD</c> the number <c>3</c> to this attribute anyway, even though it currently does
        /// not exist. Amazon DynamoDB will create the <i>itemcount</i> attribute, set its initial value to <c>0</c>, and finally add <c>3</c> to it.
        /// The result will be a new <i>itemcount</i> attribute in the item, with a value of <c>3</c>. </note> </li> <li> If the existing data type is a
        /// set, and if the <i>Value</i> is also a set, then the <i>Value</i> is added to the existing set. (This is a <i>set</i> operation, not
        /// mathematical addition.) For example, if the attribute value was the set <c>[1,2]</c>, and the <c>ADD</c> action specified <c>[3]</c>, then
        /// the final attribute value would be <c>[1,2,3]</c>. An error occurs if an Add action is specified for a set attribute and the attribute type
        /// specified does not match the existing set type. Both sets must have the same primitive data type. For example, if the existing data type is
        /// a set of strings, the <i>Value</i> must also be a set of strings. The same holds true for number sets and binary sets. </li> </ul> This
        /// action is only valid for an existing attribute whose data type is number or is a set. Do not use <c>ADD</c> for any other data types. </li>
        /// </ul> <b>If no item with the specified <i>Key</i> is found:</b> <ul> <li> <c>PUT</c> - Amazon DynamoDB creates a new item with the specified
        /// primary key, and then adds the attribute. </li> <li> <c>DELETE</c> - Nothing happens; there is no attribute to delete. </li> <li> <c>ADD</c>
        /// - Amazon DynamoDB creates an item with the supplied primary key and number (or set of numbers) for the attribute value. The only data types
        /// allowed are number and number set; no other data types can be specified. </li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ADD, PUT, DELETE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Action
        {
            get { return this.action; }
            set { this.action = value; }
        }

        /// <summary>
        /// Sets the Action property
        /// </summary>
        /// <param name="action">The value to set for the Action property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttributeValueUpdate WithAction(string action)
        {
            this.action = action;
            return this;
        }
            

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this.action != null;
        }
    }
}
