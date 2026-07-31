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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
        private TestRunObservabilityAlarmSummary _observabilityAlarm;
        private TestRunSuccessCriteriaAlarmSummary _successCriteriaAlarm;

        /// <summary>
        /// Gets and sets the property ObservabilityAlarm. 
        /// <para>
        /// An observability alarm snapshot captured for the test run.
        /// </para>
        /// </summary>
        public TestRunObservabilityAlarmSummary ObservabilityAlarm
        {
            get { return this._observabilityAlarm; }
            set { this._observabilityAlarm = value; }
        }

        // Check to see if ObservabilityAlarm property is set
        internal bool IsSetObservabilityAlarm()
        {
            return this._observabilityAlarm != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessCriteriaAlarm. 
        /// <para>
        /// A success criteria alarm snapshot captured for the test run.
        /// </para>
        /// </summary>
        public TestRunSuccessCriteriaAlarmSummary SuccessCriteriaAlarm
        {
            get { return this._successCriteriaAlarm; }
            set { this._successCriteriaAlarm = value; }
        }

        // Check to see if SuccessCriteriaAlarm property is set
        internal bool IsSetSuccessCriteriaAlarm()
        {
            return this._successCriteriaAlarm != null;
        }

    }
}