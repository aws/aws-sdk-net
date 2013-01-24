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
    /// <para>Provisioned throughput reserves the required read and write resources for your table in terms of <c>ReadCapacityUnits</c> and
    /// <c>WriteCapacityUnits</c> . Values for provisioned throughput depend upon your expected read/write rates, item size, and consistency.
    /// Provide the expected number of read and write operations, assuming an item size of 1k and strictly consistent reads. For 2k item size,
    /// double the value. For 3k, triple the value, etc. Eventually-consistent reads consume half the resources of strictly consistent reads.</para>
    /// </summary>
    public class ProvisionedThroughput  
    {
        
        private long? readCapacityUnits;
        private long? writeCapacityUnits;

        /// <summary>
        /// <c>ReadCapacityUnits</c> are in terms of strictly consistent reads, assuming items of 1k. 2k items require twice the
        /// <c>ReadCapacityUnits</c>. Eventually-consistent reads only require half the <c>ReadCapacityUnits</c> of stirctly consistent reads.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long ReadCapacityUnits
        {
            get { return this.readCapacityUnits ?? default(long); }
            set { this.readCapacityUnits = value; }
        }

        /// <summary>
        /// Sets the ReadCapacityUnits property
        /// </summary>
        /// <param name="readCapacityUnits">The value to set for the ReadCapacityUnits property </param>
        /// <returns>this instance</returns>
        public ProvisionedThroughput WithReadCapacityUnits(long readCapacityUnits)
        {
            this.readCapacityUnits = readCapacityUnits;
            return this;
        }
            

        // Check to see if ReadCapacityUnits property is set
        internal bool IsSetReadCapacityUnits()
        {
            return this.readCapacityUnits.HasValue;       
        }

        /// <summary>
        /// <c>WriteCapacityUnits</c> are in terms of strictly consistent reads, assuming items of 1k. 2k items require twice the
        /// <c>WriteCapacityUnits</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long WriteCapacityUnits
        {
            get { return this.writeCapacityUnits ?? default(long); }
            set { this.writeCapacityUnits = value; }
        }

        /// <summary>
        /// Sets the WriteCapacityUnits property
        /// </summary>
        /// <param name="writeCapacityUnits">The value to set for the WriteCapacityUnits property </param>
        /// <returns>this instance</returns>
        public ProvisionedThroughput WithWriteCapacityUnits(long writeCapacityUnits)
        {
            this.writeCapacityUnits = writeCapacityUnits;
            return this;
        }
            

        // Check to see if WriteCapacityUnits property is set
        internal bool IsSetWriteCapacityUnits()
        {
            return this.writeCapacityUnits.HasValue;       
        }
    }
}
