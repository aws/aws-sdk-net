/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the provisioned throughput settings for the table, consisting of read and
    /// write capacity units, along with data about increases and decreases.
    /// </summary>
    public partial class ProvisionedThroughputDescription
    {
        /// <summary>
        /// Gets and sets the property LastDecreaseDateTime. 
        /// <para>
        /// The date and time of the last provisioned throughput decrease for this table.
        /// </para>
        /// </summary>
        public DateTime? LastDecreaseDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastDecreaseDateTime property is set.
        /// </summary>
        internal bool IsSetLastDecreaseDateTime() => this.LastDecreaseDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastIncreaseDateTime. 
        /// <para>
        /// The date and time of the last provisioned throughput increase for this table.
        /// </para>
        /// </summary>
        public DateTime? LastIncreaseDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastIncreaseDateTime property is set.
        /// </summary>
        internal bool IsSetLastIncreaseDateTime() => this.LastIncreaseDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfDecreasesToday. 
        /// <para>
        /// The number of provisioned throughput decreases for this table during this UTC calendar
        /// day. For current maximums on provisioned throughput decreases, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Service,
        /// Account, and Table Quotas</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? NumberOfDecreasesToday { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDecreasesToday property is set.
        /// </summary>
        internal bool IsSetNumberOfDecreasesToday() => this.NumberOfDecreasesToday.HasValue;

        /// <summary>
        /// Gets and sets the property ReadCapacityUnits. 
        /// <para>
        /// The maximum number of strongly consistent reads consumed per second before DynamoDB
        /// returns a <c>ThrottlingException</c>. Eventually consistent reads require less effort
        /// than strongly consistent reads, so a setting of 50 <c>ReadCapacityUnits</c> per second
        /// provides 100 eventually consistent <c>ReadCapacityUnits</c> per second.
        /// </para>
        ///  
        /// <para>
        /// For a table or global secondary index that uses on-demand capacity mode (<c>PAY_PER_REQUEST</c>),
        /// this value is <c>0</c>, because on-demand mode does not use provisioned throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetReadCapacityUnits() => this.ReadCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property WriteCapacityUnits. 
        /// <para>
        /// The maximum number of writes consumed per second before DynamoDB returns a <c>ThrottlingException</c>.
        /// </para>
        ///  
        /// <para>
        /// For a table or global secondary index that uses on-demand capacity mode (<c>PAY_PER_REQUEST</c>),
        /// this value is <c>0</c>, because on-demand mode does not use provisioned throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? WriteCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the WriteCapacityUnits property is set.
        /// </summary>
        internal bool IsSetWriteCapacityUnits() => this.WriteCapacityUnits.HasValue;
    }
}
