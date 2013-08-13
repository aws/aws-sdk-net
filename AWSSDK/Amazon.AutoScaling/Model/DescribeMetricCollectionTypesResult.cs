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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para>The output of the DescribeMetricCollectionTypes action.</para>
    /// </summary>
    public class DescribeMetricCollectionTypesResult  
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
        /// <summary>
        /// Adds elements to the Metrics collection
        /// </summary>
        /// <param name="metrics">The values to add to the Metrics collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMetricCollectionTypesResult WithMetrics(params MetricCollectionType[] metrics)
        {
            foreach (MetricCollectionType element in metrics)
            {
                this.metrics.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Metrics collection
        /// </summary>
        /// <param name="metrics">The values to add to the Metrics collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMetricCollectionTypesResult WithMetrics(IEnumerable<MetricCollectionType> metrics)
        {
            foreach (MetricCollectionType element in metrics)
            {
                this.metrics.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the Granularities collection
        /// </summary>
        /// <param name="granularities">The values to add to the Granularities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMetricCollectionTypesResult WithGranularities(params MetricGranularityType[] granularities)
        {
            foreach (MetricGranularityType element in granularities)
            {
                this.granularities.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Granularities collection
        /// </summary>
        /// <param name="granularities">The values to add to the Granularities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeMetricCollectionTypesResult WithGranularities(IEnumerable<MetricGranularityType> granularities)
        {
            foreach (MetricGranularityType element in granularities)
            {
                this.granularities.Add(element);
            }

            return this;
        }

        // Check to see if Granularities property is set
        internal bool IsSetGranularities()
        {
            return this.granularities.Count > 0;       
        }
    }
}
