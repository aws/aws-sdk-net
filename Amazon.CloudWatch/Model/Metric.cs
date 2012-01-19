/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> The <c>Metric</c> data type contains information about a
    /// specific metric. If you call ListMetrics, Amazon CloudWatch returns
    /// information contained by this data type. </para>
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

        /// <summary>
        /// Sets the Namespace property
        /// </summary>
        /// <param name="namespaceValue">The value to set for the Namespace property </param>
        /// <returns>this instance</returns>
        public Metric WithNamespace(string namespaceValue)
        {
            this.namespaceValue = namespaceValue;
            return this;
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

        /// <summary>
        /// Sets the MetricName property
        /// </summary>
        /// <param name="metricName">The value to set for the MetricName property </param>
        /// <returns>this instance</returns>
        public Metric WithMetricName(string metricName)
        {
            this.metricName = metricName;
            return this;
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
        /// <summary>
        /// Adds elements to the Dimensions collection
        /// </summary>
        /// <param name="dimensions">The values to add to the Dimensions collection </param>
        /// <returns>this instance</returns>
        public Metric WithDimensions(params Dimension[] dimensions)
        {
            foreach (Dimension element in dimensions)
            {
                this.dimensions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Dimensions collection
        /// </summary>
        /// <param name="dimensions">The values to add to the Dimensions collection </param>
        /// <returns>this instance</returns>
        public Metric WithDimensions(IEnumerable<Dimension> dimensions)
        {
            foreach (Dimension element in dimensions)
            {
                this.dimensions.Add(element);
            }

            return this;
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this.dimensions.Count > 0;       
        }
    }
}
