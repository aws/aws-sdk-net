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
    /// <para> The PolicyAttribute data type. This data type contains a key/value pair that defines properties of a specific policy. </para>
    /// </summary>
    public class PolicyAttribute  
    {
        
        private string attributeName;
        private string attributeValue;
        /// <summary>
        /// Default constructor for a new PolicyAttribute object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public PolicyAttribute() {}
    
        /// <summary>
        /// Constructs a new PolicyAttribute object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="attributeName"> The name of the attribute associated with the policy. </param>
        /// <param name="attributeValue"> The value of the attribute associated with the policy. </param>
        public PolicyAttribute(string attributeName, string attributeValue) 
        {
            this.attributeName = attributeName;
            this.attributeValue = attributeValue;
        }
    

        /// <summary>
        /// The name of the attribute associated with the policy.
        ///  
        /// </summary>
        public string AttributeName
        {
            get { return this.attributeName; }
            set { this.attributeName = value; }
        }

        /// <summary>
        /// Sets the AttributeName property
        /// </summary>
        /// <param name="attributeName">The value to set for the AttributeName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PolicyAttribute WithAttributeName(string attributeName)
        {
            this.attributeName = attributeName;
            return this;
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

        /// <summary>
        /// Sets the AttributeValue property
        /// </summary>
        /// <param name="attributeValue">The value to set for the AttributeValue property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PolicyAttribute WithAttributeValue(string attributeValue)
        {
            this.attributeValue = attributeValue;
            return this;
        }
            

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this.attributeValue != null;       
        }
    }
}
