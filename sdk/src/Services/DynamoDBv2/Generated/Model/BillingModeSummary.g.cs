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
    /// Contains the details for the read/write capacity mode. This page talks about <c>PROVISIONED</c>
    /// and <c>PAY_PER_REQUEST</c> billing modes. For more information about these modes,
    /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadWriteCapacityMode.html">Read/write
    /// capacity mode</a>.
    /// 
    ///  <note> 
    /// <para>
    /// You may need to switch to on-demand mode at least once in order to return a <c>BillingModeSummary</c>
    /// response.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BillingModeSummary
    {
        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// Controls how you are charged for read and write throughput and how you manage capacity.
        /// This setting can be changed later.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONED</c> - Sets the read/write capacity mode to <c>PROVISIONED</c>. We
        /// recommend using <c>PROVISIONED</c> for predictable workloads.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAY_PER_REQUEST</c> - Sets the read/write capacity mode to <c>PAY_PER_REQUEST</c>.
        /// We recommend using <c>PAY_PER_REQUEST</c> for unpredictable workloads. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BillingMode BillingMode { get; set; }

        /// <summary>
        /// Checks to see if the BillingMode property is set.
        /// </summary>
        internal bool IsSetBillingMode() => this.BillingMode != null;

        /// <summary>
        /// Gets and sets the property LastUpdateToPayPerRequestDateTime. 
        /// <para>
        /// Represents the time when <c>PAY_PER_REQUEST</c> was last set as the read/write capacity
        /// mode.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateToPayPerRequestDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateToPayPerRequestDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateToPayPerRequestDateTime() => this.LastUpdateToPayPerRequestDateTime.HasValue;
    }
}
