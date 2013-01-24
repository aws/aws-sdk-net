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
    /// <para> The <c>PolicyAttributeTypeDescription</c> data type. This data type is used to describe values that are acceptable for the policy
    /// attribute. </para>
    /// </summary>
    public class PolicyAttributeTypeDescription  
    {
        
        private string attributeName;
        private string attributeType;
        private string description;
        private string defaultValue;
        private string cardinality;

        /// <summary>
        /// The name of the attribute associated with the policy type.
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
        public PolicyAttributeTypeDescription WithAttributeName(string attributeName)
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
        /// The type of attribute. For example, Boolean, Integer, etc.
        ///  
        /// </summary>
        public string AttributeType
        {
            get { return this.attributeType; }
            set { this.attributeType = value; }
        }

        /// <summary>
        /// Sets the AttributeType property
        /// </summary>
        /// <param name="attributeType">The value to set for the AttributeType property </param>
        /// <returns>this instance</returns>
        public PolicyAttributeTypeDescription WithAttributeType(string attributeType)
        {
            this.attributeType = attributeType;
            return this;
        }
            

        // Check to see if AttributeType property is set
        internal bool IsSetAttributeType()
        {
            return this.attributeType != null;       
        }

        /// <summary>
        /// A human-readable description of the attribute.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public PolicyAttributeTypeDescription WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;       
        }

        /// <summary>
        /// The default value of the attribute, if applicable.
        ///  
        /// </summary>
        public string DefaultValue
        {
            get { return this.defaultValue; }
            set { this.defaultValue = value; }
        }

        /// <summary>
        /// Sets the DefaultValue property
        /// </summary>
        /// <param name="defaultValue">The value to set for the DefaultValue property </param>
        /// <returns>this instance</returns>
        public PolicyAttributeTypeDescription WithDefaultValue(string defaultValue)
        {
            this.defaultValue = defaultValue;
            return this;
        }
            

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue != null;       
        }

        /// <summary>
        /// The cardinality of the attribute. Valid Values: <ul> <li>ONE(1) : Single value required</li> <li>ZERO_OR_ONE(0..1) : Up to one value can be
        /// supplied</li> <li>ZERO_OR_MORE(0..*) : Optional. Multiple values are allowed</li> <li>ONE_OR_MORE(1..*0) : Required. Multiple values are
        /// allowed</li> </ul>
        ///  
        /// </summary>
        public string Cardinality
        {
            get { return this.cardinality; }
            set { this.cardinality = value; }
        }

        /// <summary>
        /// Sets the Cardinality property
        /// </summary>
        /// <param name="cardinality">The value to set for the Cardinality property </param>
        /// <returns>this instance</returns>
        public PolicyAttributeTypeDescription WithCardinality(string cardinality)
        {
            this.cardinality = cardinality;
            return this;
        }
            

        // Check to see if Cardinality property is set
        internal bool IsSetCardinality()
        {
            return this.cardinality != null;       
        }
    }
}
