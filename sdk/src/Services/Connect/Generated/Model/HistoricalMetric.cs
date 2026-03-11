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
    /// Contains information about a historical metric.
    /// </summary>
    public partial class HistoricalMetric
    {
        private HistoricalMetricName _name;
        private Statistic _statistic;
        private Threshold _threshold;
        private Unit _unit;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric. Following is a list of each supported metric mapped to the
        /// UI name, linked to a detailed description in the <i>Amazon Connect Administrator Guide</i>.
        /// 
        /// </para>
        ///  <dl> <dt>ABANDON_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#average-queue-abandon-time">Average
        /// queue abandon time</a> 
        /// </para>
        ///  </dd> <dt>AFTER_CONTACT_WORK_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#after-contact-work-time">After
        /// contact work time</a> 
        /// </para>
        ///  </dd> <dt>API_CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#api-contacts-handled">API
        /// contacts handled</a> 
        /// </para>
        ///  </dd> <dt>AVG_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#average-customer-hold-time">Average
        /// customer hold time</a> 
        /// </para>
        ///  </dd> <dt>CALLBACK_CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#callback-contacts-handled">Callback
        /// contacts handled</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_ABANDONED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-abandoned">Contacts
        /// abandoned</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_AGENT_HUNG_UP_FIRST</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-agent-hung-up-first">Contacts
        /// agent hung up first</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_CONSULTED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-consulted">Contacts
        /// consulted</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-handled">Contacts
        /// handled</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED_INCOMING</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-handled-incoming">Contacts
        /// handled incoming</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED_OUTBOUND</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-handled-outbound">Contacts
        /// handled outbound</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_HOLD_ABANDONS</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-hold-disconnect">Contacts
        /// hold disconnect</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_MISSED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#agent-non-response">AGENT_NON_RESPONSE</a>
        /// 
        /// </para>
        ///  </dd> <dt>CONTACTS_QUEUED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-queued">Contacts
        /// queued</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_IN</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-transferred-in">Contacts
        /// transferred in</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_IN_FROM_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-transferred-out-queue">Contacts
        /// transferred out queue</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-transferred-out">Contacts
        /// transferred out</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_FROM_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-transferred-out-queue">Contacts
        /// transferred out queue</a> 
        /// </para>
        ///  </dd> <dt>HANDLE_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#average-handle-time">Average
        /// handle time</a> 
        /// </para>
        ///  </dd> <dt>INTERACTION_AND_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#average-agent-interaction-and-customer-hold-time">Average
        /// agent interaction and customer hold time</a> 
        /// </para>
        ///  </dd> <dt>INTERACTION_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#aaverage-agent-interaction-time">Average
        /// agent interaction time</a> 
        /// </para>
        ///  </dd> <dt>OCCUPANCY</dt> <dd> 
        /// <para>
        /// Unit: PERCENT
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#occupancy">Occupancy</a>
        /// 
        /// </para>
        ///  </dd> <dt>QUEUE_ANSWER_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html##average-queue-answer-time">Average
        /// queue answer time</a> 
        /// </para>
        ///  </dd> <dt>QUEUED_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: MAX
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#minimum-flow-time">Minimum
        /// flow time</a> 
        /// </para>
        ///  </dd> <dt>SERVICE_LEVEL</dt> <dd> 
        /// <para>
        /// You can include up to 20 SERVICE_LEVEL metrics in a request.
        /// </para>
        ///  
        /// <para>
        /// Unit: PERCENT
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// Threshold: For <c>ThresholdValue</c>, enter any whole number from 1 to 604800 (inclusive),
        /// in seconds. For <c>Comparison</c>, you must enter <c>LT</c> (for "Less than"). 
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#service-level">Service
        /// level X</a> 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public HistoricalMetricName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic for the metric.
        /// </para>
        /// </summary>
        public Statistic Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The threshold for the metric, used with service level metrics.
        /// </para>
        /// </summary>
        public Threshold Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for the metric.
        /// </para>
        /// </summary>
        public Unit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}