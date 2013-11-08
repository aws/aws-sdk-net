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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> The <c>PolicyAttributeDescription</c> data type. This data type is used to describe the attributes and values associated with a
    /// policy. </para>
    /// </summary>
    public class PolicyAttributeDescription
    {
        
        private string attributeName;
        private string attributeValue;


        /// <summary>
        /// The name of the attribute associated with the policy.
        ///  
        /// </summary>
        public string AttributeName
        {
            get { return this.attributeName; }
            set { this.attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this.attributeName != null;
        }

        /// <summary>
        /// The value of the attribute associated with the policy.
        ///  
        /// </summary>
        public string AttributeValue
        {
            get { return this.attributeValue; }
            set { this.attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this.attributeValue != null;
        }
    }
}
