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
    /// <para>Represents a key schema. Specifies the attributes that make up the primary key of a table, or the key attributes of a secondary
    /// index.</para>
    /// </summary>
    public class KeySchemaElement
    {
        
        private string attributeName;
        private string keyType;

        /// <summary>
        /// Represents the name of a key attribute.
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
        public KeySchemaElement WithAttributeName(string attributeName)
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
        /// Represents the attribute data, consisting of the data type and the attribute value itself.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>HASH, RANGE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string KeyType
        {
            get { return this.keyType; }
            set { this.keyType = value; }
        }

        /// <summary>
        /// Sets the KeyType property
        /// </summary>
        /// <param name="keyType">The value to set for the KeyType property </param>
        /// <returns>this instance</returns>
        public KeySchemaElement WithKeyType(string keyType)
        {
            this.keyType = keyType;
            return this;
        }
            

        // Check to see if KeyType property is set
        internal bool IsSetKeyType()
        {
            return this.keyType != null;
        }
    }
}
