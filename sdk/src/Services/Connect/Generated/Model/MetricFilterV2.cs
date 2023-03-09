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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the filter used when retrieving metrics. <code>MetricFiltersV2</code>
    /// can be used on the following metrics: <code>AVG_AGENT_CONNECTING_TIME</code>, <code>CONTACTS_CREATED</code>,
    /// <code>CONTACTS_HANDLED</code>, <code>SUM_CONTACTS_DISCONNECTED</code>.
    /// </summary>
    public partial class MetricFilterV2
    {
        private string _metricFilterKey;
        private List<string> _metricFilterValues = new List<string>();

        /// <summary>
        /// Gets and sets the property MetricFilterKey. 
        /// <para>
        /// The key to use for filtering data. 
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter keys: <code>INITIATION_METHOD</code>, <code>DISCONNECT_REASON</code>
        /// 
        /// </para>
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
        /// The values to use for filtering data. 
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter values for <code>INITIATION_METHOD</code>: <code>INBOUND</code>
        /// | <code>OUTBOUND</code> | <code>TRANSFER</code> | <code>QUEUE_TRANSFER</code> | <code>CALLBACK</code>
        /// | <code>API</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter values for <code>DISCONNECT_REASON</code>: <code>CUSTOMER_DISCONNECT</code>
        /// | <code>AGENT_DISCONNECT</code> | <code>THIRD_PARTY_DISCONNECT</code> | <code>TELECOM_PROBLEM</code>
        /// | <code>BARGED</code> | <code>CONTACT_FLOW_DISCONNECT</code> | <code>OTHER</code>
        /// | <code>EXPIRED</code> | <code>API</code> 
        /// </para>
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
            return this._metricFilterValues != null && this._metricFilterValues.Count > 0; 
        }

    }
}