/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// <para> The <c>Metric</c> data type contains information about a specific metric. If you call ListMetrics, Amazon CloudWatch returns
    /// information contained by this data type. </para> <para> The example in the Examples section publishes two metrics named buffers and latency.
    /// Both metrics are in the examples namespace. Both metrics have two dimensions, InstanceID and InstanceType. </para>
    /// </summary>
    public class Metric
    {
        
        private string namespaceValue;
        private string metricName;
        private List<Dimension> dimensions = new List<Dimension>();

        /// <summary>
        /// The namespace of the metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[^:].*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this.namespaceValue; }
            set { this.namespaceValue = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this.namespaceValue != null;
        }

        /// <summary>
        /// The name of the metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this.metricName; }
            set { this.metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this.metricName != null;
        }

        /// <summary>
        /// A list of dimensions associated with the metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<Dimension> Dimensions
        {
            get { return this.dimensions; }
            set { this.dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this.dimensions.Count > 0;
        }
    }
}
