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
    /// Prometheus settings.
    /// </summary>
    public partial class PrometheusInfo
    {
        private JmxExporterInfo _jmxExporter;
        private NodeExporterInfo _nodeExporter;

        /// <summary>
        /// Gets and sets the property JmxExporter.             
        /// <para>
        /// Indicates whether you want to turn on or turn off the JMX Exporter.
        /// </para>
        /// </summary>
        public JmxExporterInfo JmxExporter
        {
            get { return this._jmxExporter; }
            set { this._jmxExporter = value; }
        }

        // Check to see if JmxExporter property is set
        internal bool IsSetJmxExporter()
        {
            return this._jmxExporter != null;
        }

        /// <summary>
        /// Gets and sets the property NodeExporter.             
        /// <para>
        /// Indicates whether you want to turn on or turn off the Node Exporter.
        /// </para>
        /// </summary>
        public NodeExporterInfo NodeExporter
        {
            get { return this._nodeExporter; }
            set { this._nodeExporter = value; }
        }

        // Check to see if NodeExporter property is set
        internal bool IsSetNodeExporter()
        {
            return this._nodeExporter != null;
        }

    }
}