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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The metrics configuration for your event source. Use this configuration object to
    /// define which metrics you want your event source mapping to produce.
    /// </summary>
    public partial class EventSourceMappingMetricsConfig
    {
        private List<string> _metrics = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        ///  The metrics you want your event source mapping to produce, including <c>EventCount</c>,
        /// <c>ErrorCount</c>, <c>KafkaMetrics</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EventCount</c> to receive metrics related to the number of events processed by
        /// your event source mapping.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ErrorCount</c> (Amazon MSK and self-managed Apache Kafka) to receive metrics related
        /// to the number of errors in your event source mapping processing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KafkaMetrics</c> (Amazon MSK and self-managed Apache Kafka) to receive metrics
        /// related to the Kafka consumers from your event source mapping.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about these metrics, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/monitoring-metrics-types.html#event-source-mapping-metrics">
        /// Event source mapping metrics</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}