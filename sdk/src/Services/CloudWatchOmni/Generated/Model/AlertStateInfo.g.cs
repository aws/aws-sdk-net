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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Live evaluation state for an alert. Read-only, system-managed.
    /// </summary>
    public partial class AlertStateInfo
    {
        /// <summary>
        /// Gets and sets the property ContributorSummary. Counts of contributors currently breaching
        /// each severity threshold. Present only when contributor-level tracking is active; absent
        /// until the first contributor breaches a {@code WARNING} or {@code CRITICAL} threshold.
        /// </summary>
        public ContributorSummary ContributorSummary { get; set; }

        /// <summary>
        /// Checks to see if the ContributorSummary property is set.
        /// </summary>
        internal bool IsSetContributorSummary() => this.ContributorSummary != null;

        /// <summary>
        /// Gets and sets the property Data. Structured detail about why the alert is in its current
        /// state.
        /// </summary>
        public AlertStateData Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property TransitionedAt. When the alert transitioned to its current
        /// state.
        /// </summary>
        public DateTime? TransitionedAt { get; set; }

        /// <summary>
        /// Checks to see if the TransitionedAt property is set.
        /// </summary>
        internal bool IsSetTransitionedAt() => this.TransitionedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Value. Current flat state.
        /// </summary>
        [AWSProperty(Required = true)]
        public AlertState Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
