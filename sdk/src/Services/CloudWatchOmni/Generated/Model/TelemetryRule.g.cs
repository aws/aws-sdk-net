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
    /// Telemetry-based rule: what to query, how to evaluate the result, what condition makes
    /// it fire, and what to do on missing data.
    /// </summary>
    public partial class TelemetryRule
    {
        /// <summary>
        /// Gets and sets the property Condition. The condition that determines when the alert
        /// fires.
        /// </summary>
        public AlertCondition Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property Evaluation. The evaluation cadence and durations.
        /// </summary>
        public AlertEvaluation Evaluation { get; set; }

        /// <summary>
        /// Checks to see if the Evaluation property is set.
        /// </summary>
        internal bool IsSetEvaluation() => this.Evaluation != null;

        /// <summary>
        /// Gets and sets the property NoData. How the alert behaves when a query produces no
        /// data.
        /// </summary>
        public NoData NoData { get; set; }

        /// <summary>
        /// Checks to see if the NoData property is set.
        /// </summary>
        internal bool IsSetNoData() => this.NoData != null;

        /// <summary>
        /// Gets and sets the property Query. The query expression to evaluate.
        /// </summary>
        public AlertRuleQuery Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;
    }
}
