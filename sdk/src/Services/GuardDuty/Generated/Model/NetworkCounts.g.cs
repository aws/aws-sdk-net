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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains counts that describe network activity, such as the number of requests or
    /// connection attempts.
    /// </summary>
    public partial class NetworkCounts
    {
        /// <summary>
        /// Gets and sets the property RequestCount. 
        /// <para>
        /// The number of requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? RequestCount { get; set; }

        /// <summary>
        /// Checks to see if the RequestCount property is set.
        /// </summary>
        internal bool IsSetRequestCount() => this.RequestCount.HasValue;

        /// <summary>
        /// Gets and sets the property ResetAttempts. 
        /// <para>
        /// The number of connection attempts that were reset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ResetAttempts { get; set; }

        /// <summary>
        /// Checks to see if the ResetAttempts property is set.
        /// </summary>
        internal bool IsSetResetAttempts() => this.ResetAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property SuspiciousAttempts. 
        /// <para>
        /// The number of connection attempts that were suspicious.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? SuspiciousAttempts { get; set; }

        /// <summary>
        /// Checks to see if the SuspiciousAttempts property is set.
        /// </summary>
        internal bool IsSetSuspiciousAttempts() => this.SuspiciousAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property TotalAttempts. 
        /// <para>
        /// The total number of connection attempts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalAttempts { get; set; }

        /// <summary>
        /// Checks to see if the TotalAttempts property is set.
        /// </summary>
        internal bool IsSetTotalAttempts() => this.TotalAttempts.HasValue;
    }
}
