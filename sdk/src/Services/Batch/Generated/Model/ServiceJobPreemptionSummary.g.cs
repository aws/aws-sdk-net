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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Summarizes the preemptions of the service job. This field appears on a service job
    /// when it has been preempted.
    /// </summary>
    public partial class ServiceJobPreemptionSummary
    {
        /// <summary>
        /// Gets and sets the property PreemptedAttemptCount. 
        /// <para>
        /// The total number of times the service job has been preempted.
        /// </para>
        /// </summary>
        public int? PreemptedAttemptCount { get; set; }

        /// <summary>
        /// Checks to see if the PreemptedAttemptCount property is set.
        /// </summary>
        internal bool IsSetPreemptedAttemptCount() => this.PreemptedAttemptCount.HasValue;

        /// <summary>
        /// Gets and sets the property RecentPreemptedAttempts. 
        /// <para>
        /// A list of the most recent preemption attempts for the service job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceJobPreemptedAttempt> RecentPreemptedAttempts { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceJobPreemptedAttempt>() : null;

        /// <summary>
        /// Checks to see if the RecentPreemptedAttempts property is set.
        /// </summary>
        internal bool IsSetRecentPreemptedAttempts() => this.RecentPreemptedAttempts != null && (this.RecentPreemptedAttempts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
