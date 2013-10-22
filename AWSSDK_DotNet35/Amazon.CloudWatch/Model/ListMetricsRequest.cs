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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the ListMetrics operation.
    /// <para> Returns a list of valid metrics stored for the AWS account owner. Returned metrics can be used with GetMetricStatistics to obtain
    /// statistical data for a given metric. </para> <para><b>NOTE:</b> Up to 500 results are returned for any one call. To retrieve further
    /// results, use returned NextToken values with subsequent ListMetrics operations. </para> <para><b>NOTE:</b> If you create a metric with the
    /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. Statistics about the metric,
    /// however, are available sooner using GetMetricStatistics. </para>
    /// </summary>
    public partial class ListMetricsRequest : AmazonWebServiceRequest
    {
        private string namespaceValue;
        private string metricName;
        private List<DimensionFilter> dimensions = new List<DimensionFilter>();
        private string nextToken;

        /// <summary>
        /// The namespace to filter against.
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
        /// The name of the metric to filter against.
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
        /// A list of dimensions to filter against.
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
        public List<DimensionFilter> Dimensions
        {
            get { return this.dimensions; }
            set { this.dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this.dimensions.Count > 0;
        }

        /// <summary>
        /// The token returned by a previous call to indicate that there is more data available.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

    }
}
    
