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
        /// Valid metric filter keys: <c>INITIATION_METHOD</c>, <c>DISCONNECT_REASON</c>. These
        /// are the same values as the <c>InitiationMethod</c> and <c>DisconnectReason</c> in
        /// the contact record. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/ctr-data-model.html#ctr-ContactTraceRecord">ContactTraceRecord</a>
        /// in the <i>Amazon Connect Administrator Guide</i>. 
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
        /// Valid metric filter values for <c>INITIATION_METHOD</c>: <c>INBOUND</c> | <c>OUTBOUND</c>
        /// | <c>TRANSFER</c> | <c>QUEUE_TRANSFER</c> | <c>CALLBACK</c> | <c>API</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter values for <c>DISCONNECT_REASON</c>: <c>CUSTOMER_DISCONNECT</c>
        /// | <c>AGENT_DISCONNECT</c> | <c>THIRD_PARTY_DISCONNECT</c> | <c>TELECOM_PROBLEM</c>
        /// | <c>BARGED</c> | <c>CONTACT_FLOW_DISCONNECT</c> | <c>OTHER</c> | <c>EXPIRED</c> |
        /// <c>API</c> 
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
            return this._metricFilterValues != null && (this._metricFilterValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Negate. 
        /// <para>
        /// The flag to use to filter on requested metric filter values or to not filter on requested
        /// metric filter values. By default the negate is <c>false</c>, which indicates to filter
        /// on the requested metric filter. 
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