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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// JMX and Node monitoring for the MSK cluster.
    /// </summary>
    public partial class OpenMonitoringInfo
    {
        private PrometheusInfo _prometheus;

        /// <summary>
        /// Gets and sets the property Prometheus.             
        /// <para>
        /// Prometheus settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrometheusInfo Prometheus
        {
            get { return this._prometheus; }
            set { this._prometheus = value; }
        }

        // Check to see if Prometheus property is set
        internal bool IsSetPrometheus()
        {
            return this._prometheus != null;
        }

    }
}