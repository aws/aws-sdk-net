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
    /// <para>Represents the output of a <c>GetRecords</c> operation.</para>
    /// </summary>
    public partial class GetRecordsResult
    {
        
        private List<Record> records = new List<Record>();
        private string nextShardIterator;

        /// <summary>
        /// <P>The data records retrieved from the shard.</P>
        ///  
        /// </summary>
        public List<Record> Records
        {
            get { return this.records; }
            set { this.records = value; }
        }
        /// <summary>
        /// Adds elements to the Records collection
        /// </summary>
        /// <param name="records">The values to add to the Records collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetRecordsResult WithRecords(params Record[] records)
        {
            foreach (Record element in records)
            {
                this.records.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Records collection
        /// </summary>
        /// <param name="records">The values to add to the Records collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetRecordsResult WithRecords(IEnumerable<Record> records)
        {
            foreach (Record element in records)
            {
                this.records.Add(element);
            }

            return this;
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this.records.Count > 0;
        }

        /// <summary>
        /// The next position in the shard from which to start sequentially reading data records. If set to <c>null</c>, the shard has been closed and
        /// the requested iterator will not return any more data.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 512</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextShardIterator
        {
            get { return this.nextShardIterator; }
            set { this.nextShardIterator = value; }
        }

        /// <summary>
        /// Sets the NextShardIterator property
        /// </summary>
        /// <param name="nextShardIterator">The value to set for the NextShardIterator property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetRecordsResult WithNextShardIterator(string nextShardIterator)
        {
            this.nextShardIterator = nextShardIterator;
            return this;
        }
            

        // Check to see if NextShardIterator property is set
        internal bool IsSetNextShardIterator()
        {
            return this.nextShardIterator != null;
        }
    }
}
