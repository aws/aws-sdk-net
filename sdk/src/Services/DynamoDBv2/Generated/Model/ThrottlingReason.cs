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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
    /// Represents the specific reason why a DynamoDB request was throttled and the ARN of
    /// the impacted resource. This helps identify exactly what resource is being throttled,
    /// what type of operation caused it, and why the throttling occurred.
    /// </summary>
    public partial class ThrottlingReason
    {
        private string _reason;
        private string _resource;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for throttling. The throttling reason follows a specific format: <c>ResourceType+OperationType+LimitType</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Resource Type (What is being throttled): Table or Index
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Operation Type (What kind of operation): Read or Write
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Limit Type (Why the throttling occurred):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ProvisionedThroughputExceeded</c>: The request rate is exceeding the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/provisioned-capacity-mode.html">provisioned
        /// throughput capacity</a> (read or write capacity units) configured for a table or a
        /// global secondary index (GSI) in provisioned capacity mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccountLimitExceeded</c>: The request rate has caused a table or global secondary
        /// index (GSI) in on-demand mode to exceed the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ServiceQuotas.html#default-limits-throughput">per-table
        /// account-level service quotas</a> for read/write throughput in the current Amazon Web
        /// Services Region. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeyRangeThroughputExceeded</c>: The request rate directed at a specific partition
        /// key value has exceeded the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/bp-partition-key-design.html">internal
        /// partition-level throughput limits</a>, indicating uneven access patterns across the
        /// table's or GSI's key space.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaxOnDemandThroughputExceeded</c>: The request rate has exceeded the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/on-demand-capacity-mode-max-throughput.html">configured
        /// maximum throughput limits</a> set for a table or index in on-demand capacity mode.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// Examples of complete throttling reasons:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TableReadProvisionedThroughputExceeded
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IndexWriteAccountLimitExceeded
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This helps identify exactly what resource is being throttled, what type of operation
        /// caused it, and why the throttling occurred.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DynamoDB table or index that experienced the
        /// throttling event.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}