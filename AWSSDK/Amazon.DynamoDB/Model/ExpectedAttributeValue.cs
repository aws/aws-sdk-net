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
    /// <para>Allows you to provide an attribute name, and whether or not Amazon DynamoDB should check to see if the attribute value already exists;
    /// or if the attribute value exists and has a particular value before changing it.</para>
    /// </summary>
    public class ExpectedAttributeValue  
    {
        
        private AttributeValue value;
        private bool? exists;

        /// <summary>
        /// Specify whether or not a value already exists and has a specific content for the attribute name-value pair.
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
        /// Specify whether or not a value already exists for the attribute name-value pair.
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
