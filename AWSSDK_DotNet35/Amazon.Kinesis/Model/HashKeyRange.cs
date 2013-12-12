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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// <para>The range of possible hash key values for the shard, which is a set of ordered contiguous positive integers.</para>
    /// </summary>
    public class HashKeyRange
    {
        
        private string startingHashKey;
        private string endingHashKey;


        /// <summary>
        /// The starting hash key of the hash key range.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>0|([1-9]\d{0,38})</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StartingHashKey
        {
            get { return this.startingHashKey; }
            set { this.startingHashKey = value; }
        }

        // Check to see if StartingHashKey property is set
        internal bool IsSetStartingHashKey()
        {
            return this.startingHashKey != null;
        }

        /// <summary>
        /// The ending hash key of the hash key range.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>0|([1-9]\d{0,38})</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EndingHashKey
        {
            get { return this.endingHashKey; }
            set { this.endingHashKey = value; }
        }

        // Check to see if EndingHashKey property is set
        internal bool IsSetEndingHashKey()
        {
            return this.endingHashKey != null;
        }
    }
}
