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
    /// Container for the parameters to the PutMetricData operation.
    /// <para> Publishes metric data points to Amazon CloudWatch. Amazon Cloudwatch associates the data points with the specified metric. If the
    /// specified metric does not exist, Amazon CloudWatch creates the metric. </para> <para><b>NOTE:</b> If you create a metric with the
    /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. </para> <para> The size of a
    /// PutMetricData request is limited to 8 KB for HTTP GET requests and 40 KB for HTTP POST requests. </para> <para><b>IMPORTANT:</b> Although
    /// the Value parameter accepts numbers of type Double, Amazon CloudWatch truncates values with very large exponents. Values with base-10
    /// exponents greater than 126 (1 x 10^126) are truncated. Likewise, values with base-10 exponents less than -130 (1 x 10^-130) are also
    /// truncated. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.PutMetricData"/>
    public class PutMetricDataRequest : AmazonWebServiceRequest
    {
        private string namespaceValue;
        private List<MetricDatum> metricData = new List<MetricDatum>();

        /// <summary>
        /// The namespace for the metric data. <note> You cannot specify a namespace that begins with "AWS/". Namespaces that begin with "AWS/" are
        /// reserved for other Amazon Web Services products that send metrics to Amazon CloudWatch. </note>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutMetricDataRequest WithNamespace(string namespaceValue)
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
        /// A list of data describing the metric.
        ///  
        /// </summary>
        public List<MetricDatum> MetricData
        {
            get { return this.metricData; }
            set { this.metricData = value; }
        }
        /// <summary>
        /// Adds elements to the MetricData collection
        /// </summary>
        /// <param name="metricData">The values to add to the MetricData collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutMetricDataRequest WithMetricData(params MetricDatum[] metricData)
        {
            foreach (MetricDatum element in metricData)
            {
                this.metricData.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the MetricData collection
        /// </summary>
        /// <param name="metricData">The values to add to the MetricData collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutMetricDataRequest WithMetricData(IEnumerable<MetricDatum> metricData)
        {
            foreach (MetricDatum element in metricData)
            {
                this.metricData.Add(element);
            }

            return this;
        }

        // Check to see if MetricData property is set
        internal bool IsSetMetricData()
        {
            return this.metricData.Count > 0;       
        }
    }
}
    
