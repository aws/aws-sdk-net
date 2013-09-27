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
    /// <summary>Keys And Attributes
    /// </summary>
    public class KeysAndAttributes  
    {
        
        private List<Key> keys = new List<Key>();
        private List<string> attributesToGet = new List<string>();
        private bool? consistentRead;
        public List<Key> Keys
        {
            get { return this.keys; }
            set { this.keys = value; }
        }
        /// <summary>
        /// Adds elements to the Keys collection
        /// </summary>
        /// <param name="keys">The values to add to the Keys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public KeysAndAttributes WithKeys(params Key[] keys)
        {
            foreach (Key element in keys)
            {
                this.keys.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Keys collection
        /// </summary>
        /// <param name="keys">The values to add to the Keys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public KeysAndAttributes WithKeys(IEnumerable<Key> keys)
        {
            foreach (Key element in keys)
            {
                this.keys.Add(element);
            }

            return this;
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this.keys.Count > 0;       
        }

        /// <summary>
        /// List of <c>Attribute</c> names. If attribute names are not specified then all attributes will be returned. If some attributes are not found,
        /// they will not appear in the result.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this.attributesToGet; }
            set { this.attributesToGet = value; }
        }
        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public KeysAndAttributes WithAttributesToGet(params string[] attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public KeysAndAttributes WithAttributesToGet(IEnumerable<string> attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this.attributesToGet.Count > 0;       
        }

        /// <summary>
        /// If set to <c>true</c>, then a consistent read is issued. Otherwise eventually-consistent is used.
        ///  
        /// </summary>
        public bool ConsistentRead
        {
            get { return this.consistentRead ?? default(bool); }
            set { this.consistentRead = value; }
        }

        /// <summary>
        /// Sets the ConsistentRead property
        /// </summary>
        /// <param name="consistentRead">The value to set for the ConsistentRead property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public KeysAndAttributes WithConsistentRead(bool consistentRead)
        {
            this.consistentRead = consistentRead;
            return this;
        }
            

        // Check to see if ConsistentRead property is set
        internal bool IsSetConsistentRead()
        {
            return this.consistentRead.HasValue;       
        }
    }
}
