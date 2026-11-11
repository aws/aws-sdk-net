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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Describes the estimated effect of an account-level retention policy change on one
    /// log group.
    /// </summary>
    public partial class LogGroupImpact
    {
        /// <summary>
        /// Gets and sets the property CurrentRetention. 
        /// <para>
        /// The current effective retention period of the log group, in days. A value of <c>NEVER_EXPIRE</c>
        /// indicates that log events in the log group never expire.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 12)]
        public string CurrentRetention { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRetention property is set.
        /// </summary>
        internal bool IsSetCurrentRetention() => this.CurrentRetention != null;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property ProposedRetention. 
        /// <para>
        /// The effective retention period of the log group, in days, after the change. A value
        /// of <c>NEVER_EXPIRE</c> indicates that log events in the log group would never expire.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 12)]
        public string ProposedRetention { get; set; }

        /// <summary>
        /// Checks to see if the ProposedRetention property is set.
        /// </summary>
        internal bool IsSetProposedRetention() => this.ProposedRetention != null;

        /// <summary>
        /// Gets and sets the property StoredBytes. 
        /// <para>
        /// The number of bytes stored in the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? StoredBytes { get; set; }

        /// <summary>
        /// Checks to see if the StoredBytes property is set.
        /// </summary>
        internal bool IsSetStoredBytes() => this.StoredBytes.HasValue;
    }
}
