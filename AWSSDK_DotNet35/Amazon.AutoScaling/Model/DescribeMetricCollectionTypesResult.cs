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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para>The output of the DescribeMetricCollectionTypes action.</para>
    /// </summary>
    public partial class DescribeMetricCollectionTypesResult : AmazonWebServiceResponse
    {
        
        private List<MetricCollectionType> metrics = new List<MetricCollectionType>();
        private List<MetricGranularityType> granularities = new List<MetricGranularityType>();

        /// <summary>
        /// The list of Metrics collected.The following metrics are supported: <ul> <li>GroupMinSize</li> <li>GroupMaxSize</li>
        /// <li>GroupDesiredCapacity</li> <li>GroupInServiceInstances</li> <li>GroupPendingInstances</li> <li>GroupTerminatingInstances</li>
        /// <li>GroupTotalInstances</li> </ul>
        ///  
        /// </summary>
        public List<MetricCollectionType> Metrics
        {
            get { return this.metrics; }
            set { this.metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this.metrics.Count > 0;
        }

        /// <summary>
        /// A list of granularities for the listed Metrics.
        ///  
        /// </summary>
        public List<MetricGranularityType> Granularities
        {
            get { return this.granularities; }
            set { this.granularities = value; }
        }

        // Check to see if Granularities property is set
        internal bool IsSetGranularities()
        {
            return this.granularities.Count > 0;
        }
    }
}
