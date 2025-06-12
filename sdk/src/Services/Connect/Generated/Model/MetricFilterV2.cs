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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the filter used when retrieving metrics. <c>MetricFiltersV2</c>
    /// can be used on the following metrics: <c>AVG_AGENT_CONNECTING_TIME</c>, <c>CONTACTS_CREATED</c>,
    /// <c>CONTACTS_HANDLED</c>, <c>SUM_CONTACTS_DISCONNECTED</c>.
    /// </summary>
    public partial class MetricFilterV2
    {
        private string _metricFilterKey;
        private List<string> _metricFilterValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _negate;

        /// <summary>
        /// Gets and sets the property MetricFilterKey. 
        /// <para>
        /// The key to use for filtering data. 
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter keys: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ANSWERING_MACHINE_DETECTION_STATUS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CASE_STATUS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DISCONNECT_REASON
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLOWS_ACTION_IDENTIFIER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLOWS_NEXT_ACTION_IDENTIFIER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLOWS_OUTCOME_TYPE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLOWS_RESOURCE_TYPE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INITIATION_METHOD
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string MetricFilterKey
        {
            get { return this._metricFilterKey; }
            set { this._metricFilterKey = value; }
        }

        // Check to see if MetricFilterKey property is set
        internal bool IsSetMetricFilterKey()
        {
            return this._metricFilterKey != null;
        }

        /// <summary>
        /// Gets and sets the property MetricFilterValues. 
        /// <para>
        /// The values to use for filtering data. Values for metric-level filters can be either
        /// a fixed set of values or a customized list, depending on the use case.
        /// </para>
        ///  
        /// <para>
        /// For valid values of metric-level filters <c>INITIATION_METHOD</c>, <c>DISCONNECT_REASON</c>,
        /// and <c>ANSWERING_MACHINE_DETECTION_STATUS</c>, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/ctr-data-model.html#ctr-ContactTraceRecord">ContactTraceRecord</a>
        /// in the <i>Amazon Connect Administrator Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For valid values of the metric-level filter <c>FLOWS_OUTCOME_TYPE</c>, see the description
        /// for the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#flows-outcome">Flow
        /// outcome</a> metric in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For valid values of the metric-level filter <c>BOT_CONVERSATION_OUTCOME_TYPE</c>,
        /// see the description for the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/bot-metrics.html#bot-conversations-completed-metric">Bot
        /// conversations completed</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For valid values of the metric-level filter <c>BOT_INTENT_OUTCOME_TYPE</c>, see the
        /// description for the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/bot-metrics.html#bot-intents-completed-metric">Bot
        /// intents completed</a> metric in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> MetricFilterValues
        {
            get { return this._metricFilterValues; }
            set { this._metricFilterValues = value; }
        }

        // Check to see if MetricFilterValues property is set
        internal bool IsSetMetricFilterValues()
        {
            return this._metricFilterValues != null && (this._metricFilterValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Negate. 
        /// <para>
        /// If set to <c>true</c>, the API response contains results that filter out the results
        /// matched by the metric-level filters condition. By default, <c>Negate</c> is set to
        /// <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? Negate
        {
            get { return this._negate; }
            set { this._negate = value; }
        }

        // Check to see if Negate property is set
        internal bool IsSetNegate()
        {
            return this._negate.HasValue; 
        }

    }
}