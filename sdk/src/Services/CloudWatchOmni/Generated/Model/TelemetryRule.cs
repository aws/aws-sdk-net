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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
        private AlertCondition _condition;
        private AlertEvaluation _evaluation;
        private NoData _noData;
        private AlertRuleQuery _query;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The condition that determines when the alert fires.
        /// </para>
        /// </summary>
        public AlertCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property Evaluation. 
        /// <para>
        /// The evaluation cadence and durations.
        /// </para>
        /// </summary>
        public AlertEvaluation Evaluation
        {
            get { return this._evaluation; }
            set { this._evaluation = value; }
        }

        // Check to see if Evaluation property is set
        internal bool IsSetEvaluation()
        {
            return this._evaluation != null;
        }

        /// <summary>
        /// Gets and sets the property NoData. 
        /// <para>
        /// How the alert behaves when a query produces no data.
        /// </para>
        /// </summary>
        public NoData NoData
        {
            get { return this._noData; }
            set { this._noData = value; }
        }

        // Check to see if NoData property is set
        internal bool IsSetNoData()
        {
            return this._noData != null;
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The query expression to evaluate.
        /// </para>
        /// </summary>
        public AlertRuleQuery Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

    }
}