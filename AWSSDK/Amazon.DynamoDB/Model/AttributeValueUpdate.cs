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

namespace Amazon.DynamoDB.Model
{
    /// <summary>
    /// <para>Specifies the attribute to update and how to perform the update. Possible values: <c>PUT</c> (default), <c>ADD</c> or <c>DELETE</c>
    /// .</para>
    /// </summary>
    public class AttributeValueUpdate  
    {
        
        private AttributeValue value;
        private string action;

        /// <summary>
        /// AttributeValue can be <c>String</c>, <c>Number</c>, <c>Binary</c>, <c>StringSet</c>, <c>NumberSet</c>, <c>BinarySet</c>.
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
        /// The type of action for an item update operation. Only use the add action for numbers or sets; the specified value is added to the existing
        /// value. If a set of values is specified, the values are added to the existing set. Adds the specified attribute. If the attribute exists, it
        /// is replaced by the new value. If no value is specified, this removes the attribute and its value. If a set of values is specified, then the
        /// values in the specified set are removed from the old set.
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
