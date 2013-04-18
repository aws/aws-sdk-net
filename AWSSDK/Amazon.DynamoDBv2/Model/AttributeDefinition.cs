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
    /// <para>Specifies an attribute for describing the key schema for the table and indexes.</para>
    /// </summary>
    public class AttributeDefinition
    {
        
        private string attributeName;
        private string attributeType;

        /// <summary>
        /// A name for the attribute.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
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
        public AttributeDefinition WithAttributeName(string attributeName)
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
        /// The data type for the attribute.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>S, N, B</description>
        ///     </item>
        /// </list>
        /// </para>
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
        public AttributeDefinition WithAttributeType(string attributeType)
        {
            this.attributeType = attributeType;
            return this;
        }
            

        // Check to see if AttributeType property is set
        internal bool IsSetAttributeType()
        {
            return this.attributeType != null;
        }
    }
}
