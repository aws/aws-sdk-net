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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
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
namespace Amazon.OAM.Model
{
    /// <summary>
    /// Use this structure to optionally create filters that specify that only some metric
    /// namespaces or log groups are to be shared from the source account to the monitoring
    /// account.
    /// </summary>
    public partial class LinkConfiguration
    {
        private LogGroupConfiguration _logGroupConfiguration;
        private MetricConfiguration _metricConfiguration;

        /// <summary>
        /// Gets and sets the property LogGroupConfiguration. 
        /// <para>
        /// Use this structure to filter which log groups are to send log events from the source
        /// account to the monitoring account.
        /// </para>
        /// </summary>
        public LogGroupConfiguration LogGroupConfiguration
        {
            get { return this._logGroupConfiguration; }
            set { this._logGroupConfiguration = value; }
        }

        // Check to see if LogGroupConfiguration property is set
        internal bool IsSetLogGroupConfiguration()
        {
            return this._logGroupConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MetricConfiguration. 
        /// <para>
        /// Use this structure to filter which metric namespaces are to be shared from the source
        /// account to the monitoring account.
        /// </para>
        /// </summary>
        public MetricConfiguration MetricConfiguration
        {
            get { return this._metricConfiguration; }
            set { this._metricConfiguration = value; }
        }

        // Check to see if MetricConfiguration property is set
        internal bool IsSetMetricConfiguration()
        {
            return this._metricConfiguration != null;
        }

    }
}