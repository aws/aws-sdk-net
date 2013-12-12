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
    /// <para>Describes the provisioned throughput settings for the table, consisting of read and write capacity units, along with data about
    /// increases and decreases.</para>
    /// </summary>
    public class ProvisionedThroughputDescription
    {
        
        private DateTime? lastIncreaseDateTime;
        private DateTime? lastDecreaseDateTime;
        private long? numberOfDecreasesToday;
        private long? readCapacityUnits;
        private long? writeCapacityUnits;


        /// <summary>
        /// The date and time of the last provisioned throughput increase for this table.
        ///  
        /// </summary>
        public DateTime LastIncreaseDateTime
        {
            get { return this.lastIncreaseDateTime ?? default(DateTime); }
            set { this.lastIncreaseDateTime = value; }
        }

        // Check to see if LastIncreaseDateTime property is set
        internal bool IsSetLastIncreaseDateTime()
        {
            return this.lastIncreaseDateTime.HasValue;
        }

        /// <summary>
        /// The date and time of the last provisioned throughput decrease for this table.
        ///  
        /// </summary>
        public DateTime LastDecreaseDateTime
        {
            get { return this.lastDecreaseDateTime ?? default(DateTime); }
            set { this.lastDecreaseDateTime = value; }
        }

        // Check to see if LastDecreaseDateTime property is set
        internal bool IsSetLastDecreaseDateTime()
        {
            return this.lastDecreaseDateTime.HasValue;
        }

        /// <summary>
        /// The number of provisioned throughput decreases for this table during this UTC calendar day. For current maximums on provisioned throughput
        /// decreases, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Limits</a> in the Amazon DynamoDB
        /// Developer Guide.
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
        public long NumberOfDecreasesToday
        {
            get { return this.numberOfDecreasesToday ?? default(long); }
            set { this.numberOfDecreasesToday = value; }
        }

        // Check to see if NumberOfDecreasesToday property is set
        internal bool IsSetNumberOfDecreasesToday()
        {
            return this.numberOfDecreasesToday.HasValue;
        }

        /// <summary>
        /// The maximum number of strongly consistent reads consumed per second before Amazon DynamoDB returns a <i>ThrottlingException</i>. Eventually
        /// consistent reads require less effort than strongly consistent reads, so a setting of 50 <i>ReadCapacityUnits</i> per second provides 100
        /// eventually consistent <i>ReadCapacityUnits</i> per second.
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

        // Check to see if ReadCapacityUnits property is set
        internal bool IsSetReadCapacityUnits()
        {
            return this.readCapacityUnits.HasValue;
        }

        /// <summary>
        /// The maximum number of writes consumed per second before Amazon DynamoDB returns a <i>ThrottlingException</i>.
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

        // Check to see if WriteCapacityUnits property is set
        internal bool IsSetWriteCapacityUnits()
        {
            return this.writeCapacityUnits.HasValue;
        }
    }
}
