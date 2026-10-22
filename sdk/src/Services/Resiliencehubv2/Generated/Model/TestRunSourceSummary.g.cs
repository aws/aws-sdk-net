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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// A monitoring-source snapshot captured for a test run. Exactly one member is set.
    /// </summary>
    public partial class TestRunSourceSummary
    {
        /// <summary>
        /// Gets and sets the property ObservabilityAlarm. 
        /// <para>
        /// An observability alarm snapshot captured for the test run.
        /// </para>
        /// </summary>
        public TestRunObservabilityAlarmSummary ObservabilityAlarm { get; set; }

        /// <summary>
        /// Checks to see if the ObservabilityAlarm property is set.
        /// </summary>
        internal bool IsSetObservabilityAlarm() => this.ObservabilityAlarm != null;

        /// <summary>
        /// Gets and sets the property SuccessCriteriaAlarm. 
        /// <para>
        /// A success criteria alarm snapshot captured for the test run.
        /// </para>
        /// </summary>
        public TestRunSuccessCriteriaAlarmSummary SuccessCriteriaAlarm { get; set; }

        /// <summary>
        /// Checks to see if the SuccessCriteriaAlarm property is set.
        /// </summary>
        internal bool IsSetSuccessCriteriaAlarm() => this.SuccessCriteriaAlarm != null;
    }
}
