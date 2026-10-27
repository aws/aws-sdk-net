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
    /// Represents the provisioned throughput settings for the specified global secondary
    /// index. You must use <c>ProvisionedThroughput</c> or <c>OnDemandThroughput</c> based
    /// on your table’s capacity mode.
    /// 
    ///  
    /// <para>
    /// For current minimum and maximum provisioned throughput values, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Service,
    /// Account, and Table Quotas</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ProvisionedThroughput
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ProvisionedThroughput() { }

        /// <summary>
        /// Instantiates ProvisionedThroughput with the parameterized properties
        /// </summary>
        /// <param name="readCapacityUnits">The maximum number of strongly consistent reads consumed per second before DynamoDB   returns a <c>ThrottlingException</c>. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ProvisionedThroughput.html">Specifying    Read and Write Requirements</a> in the <i>Amazon DynamoDB Developer    Guide</i>.   If read/write capacity mode is <c>PAY_PER_REQUEST</c> the value is set to   0.</param>
        /// <param name="writeCapacityUnits">The maximum number of writes consumed per second before DynamoDB returns a    <c>ThrottlingException</c>. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ProvisionedThroughput.html">Specifying    Read and Write Requirements</a> in the <i>Amazon DynamoDB Developer    Guide</i>.   If read/write capacity mode is <c>PAY_PER_REQUEST</c> the value is set to   0.</param>
        public ProvisionedThroughput(long? readCapacityUnits, long? writeCapacityUnits)
        {
            this.ReadCapacityUnits = readCapacityUnits;
            this.WriteCapacityUnits = writeCapacityUnits;
        }

        /// <summary>
        /// Gets and sets the property ReadCapacityUnits. 
        /// <para>
        /// The maximum number of strongly consistent reads consumed per second before DynamoDB
        /// returns a <c>ThrottlingException</c>. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ProvisionedThroughput.html">Specifying
        /// Read and Write Requirements</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If read/write capacity mode is <c>PAY_PER_REQUEST</c> the value is set to 0.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? ReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetReadCapacityUnits() => this.ReadCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property WriteCapacityUnits. 
        /// <para>
        /// The maximum number of writes consumed per second before DynamoDB returns a <c>ThrottlingException</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ProvisionedThroughput.html">Specifying
        /// Read and Write Requirements</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If read/write capacity mode is <c>PAY_PER_REQUEST</c> the value is set to 0.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? WriteCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the WriteCapacityUnits property is set.
        /// </summary>
        internal bool IsSetWriteCapacityUnits() => this.WriteCapacityUnits.HasValue;
    }
}
