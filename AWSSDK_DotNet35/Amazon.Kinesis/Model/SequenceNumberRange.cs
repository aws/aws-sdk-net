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
    /// <para>The range of possible sequence numbers for the shard.</para>
    /// </summary>
    public class SequenceNumberRange
    {
        
        private string startingSequenceNumber;
        private string endingSequenceNumber;


        /// <summary>
        /// The starting sequence number for the range.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>0|([1-9]\d{0,128})</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StartingSequenceNumber
        {
            get { return this.startingSequenceNumber; }
            set { this.startingSequenceNumber = value; }
        }

        // Check to see if StartingSequenceNumber property is set
        internal bool IsSetStartingSequenceNumber()
        {
            return this.startingSequenceNumber != null;
        }

        /// <summary>
        /// The ending sequence number for the range. Shards that are in the OPEN state have an ending sequence number of <c>null</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>0|([1-9]\d{0,128})</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EndingSequenceNumber
        {
            get { return this.endingSequenceNumber; }
            set { this.endingSequenceNumber = value; }
        }

        // Check to see if EndingSequenceNumber property is set
        internal bool IsSetEndingSequenceNumber()
        {
            return this.endingSequenceNumber != null;
        }
    }
}
