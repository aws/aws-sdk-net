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
    /// <para>The KeySchema identifies the primary key as a one attribute primary key (hash) or a composite two attribute (hash-and-range) primary
    /// key. Single attribute primary keys have one index value: a <c>HashKeyElement</c> .
    /// A composite hash-and-range primary key contains two attribute values: a <c>HashKeyElement</c> and a <c>RangeKeyElement</c> .</para>
    /// </summary>
    public class KeySchema  
    {
        
        private KeySchemaElement hashKeyElement;
        private KeySchemaElement rangeKeyElement;

        /// <summary>
        /// A hash key element is treated as the primary key, and can be a string or a number. Single attribute primary keys have one index value. The
        /// value can be <c>String</c>, <c>Number</c>, <c>StringSet</c>, <c>NumberSet</c>.
        ///  
        /// </summary>
        public KeySchemaElement HashKeyElement
        {
            get { return this.hashKeyElement; }
            set { this.hashKeyElement = value; }
        }

        /// <summary>
        /// Sets the HashKeyElement property
        /// </summary>
        /// <param name="hashKeyElement">The value to set for the HashKeyElement property </param>
        /// <returns>this instance</returns>
        public KeySchema WithHashKeyElement(KeySchemaElement hashKeyElement)
        {
            this.hashKeyElement = hashKeyElement;
            return this;
        }
            

        // Check to see if HashKeyElement property is set
        internal bool IsSetHashKeyElement()
        {
            return this.hashKeyElement != null;       
        }

        /// <summary>
        /// A range key element is treated as a secondary key (used in conjunction with the primary key), and can be a string or a number, and is only
        /// used for hash-and-range primary keys. The value can be <c>String</c>, <c>Number</c>, <c>StringSet</c>, <c>NumberSet</c>.
        ///  
        /// </summary>
        public KeySchemaElement RangeKeyElement
        {
            get { return this.rangeKeyElement; }
            set { this.rangeKeyElement = value; }
        }

        /// <summary>
        /// Sets the RangeKeyElement property
        /// </summary>
        /// <param name="rangeKeyElement">The value to set for the RangeKeyElement property </param>
        /// <returns>this instance</returns>
        public KeySchema WithRangeKeyElement(KeySchemaElement rangeKeyElement)
        {
            this.rangeKeyElement = rangeKeyElement;
            return this;
        }
            

        // Check to see if RangeKeyElement property is set
        internal bool IsSetRangeKeyElement()
        {
            return this.rangeKeyElement != null;       
        }
    }
}
