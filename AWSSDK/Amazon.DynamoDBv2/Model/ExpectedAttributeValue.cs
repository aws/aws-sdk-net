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
    /// <para>An attribute value used with conditional <i>DeleteItem</i> ,
    /// <i>PutItem</i> or <i>UpdateItem</i> operations. Amazon DynamoDB will check to see if the attribute value already
    /// exists; or if the attribute exists and has a particular value before updating it.</para>
    /// </summary>
    public class ExpectedAttributeValue
    {
        
        private AttributeValue value;
        private bool? exists;

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
        public ExpectedAttributeValue WithValue(AttributeValue value)
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
        /// Causes Amazon DynamoDB to evaluate the value before attempting a conditional operation: <ul> <li> If <i>Exists</i> is <c>true</c>, Amazon
        /// DynamoDB will check to see if that attribute value already exists in the table. If it is found, then the operation succeeds. If it is not
        /// found, the operation fails with a <i>ConditionalCheckFailedException</i>. </li> <li> If <i>Exists</i> is <c>false</c>, Amazon DynamoDB
        /// assumes that the attribute value does <i>not</i> exist in the table. If in fact the value does not exist, then the assumption is valid and
        /// the operation succeeds. If the value is found, despite the assumption that it does not exist, the operation fails with a
        /// <i>ConditionalCheckFailedException</i>. </li> </ul> The default setting for <i>Exists</i> is <c>true</c>. If you supply a <i>Value</i> all
        /// by itself, Amazon DynamoDB assumes the attribute exists: You don't have to set <i>Exists</i> to <c>true</c>, because it is implied. Amazon
        /// DynamoDB returns a <i>ValidationException</i> if: <ul> <li> <i>Exists</i> is <c>true</c> but there is no <i>Value</i> to check. (You expect
        /// a value to exist, but don't specify what that value is.) </li> <li> <i>Exists</i> is <c>false</c> but you also specify a <i>Value</i>. (You
        /// cannot expect an attribute to have a value, while also expecting it not to exist.) </li> </ul> If you specify more than one condition for
        /// <i>Exists</i>, then all of the conditions must evaluate to true. (In other words, the conditions are ANDed together.) Otherwise, the
        /// conditional operation will fail.
        ///  
        /// </summary>
        public bool Exists
        {
            get { return this.exists ?? default(bool); }
            set { this.exists = value; }
        }

        /// <summary>
        /// Sets the Exists property
        /// </summary>
        /// <param name="exists">The value to set for the Exists property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ExpectedAttributeValue WithExists(bool exists)
        {
            this.exists = exists;
            return this;
        }
            

        // Check to see if Exists property is set
        internal bool IsSetExists()
        {
            return this.exists.HasValue;
        }
    }
}
